using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

// 이 파일은 Tizen 타겟 기기에서 실행할 독립된 콘솔/UI 프레임워크 앱에 붙여넣고
// RunBenchmark() 메서드를 호출하여 성능을 직접 측정해볼 수 있는 순수 C# 테스트 코드입니다.
namespace LibraryImportTest
{
    public static partial class PerformanceTest
    {
        // 타겟 라이브러리 (Tizen 디바이스에 존재하는 기본 libc 사용)
        // strlen: 문자열 마샬링 테스트용 (UTF-8 변환)
        private const string NativeLib = "libc.so.6";

        // =========================================================
        // 1. DllImport 정의 (기존 방식)
        // =========================================================
        [DllImport(NativeLib, EntryPoint = "strlen", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong Old_StringTest([MarshalAs(UnmanagedType.LPStr)] string text);

        [DllImport(NativeLib, EntryPoint = "abs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Old_BoolTest([MarshalAs(UnmanagedType.U1)] bool value);

        [DllImport(NativeLib, EntryPoint = "abs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Old_IntTest(int value);

        [DllImport("libm.so.6", EntryPoint = "cosf", CallingConvention = CallingConvention.Cdecl)]
        public static extern float Old_FloatTest(float value);

        // =========================================================
        // 2. LibraryImport 정의 (신규 방식 - 소스 제너레이터)
        // =========================================================
        [LibraryImport(NativeLib, EntryPoint = "strlen", StringMarshalling = StringMarshalling.Utf8)]
        public static partial ulong New_StringTest(string text);

        [LibraryImport(NativeLib, EntryPoint = "abs")]
        public static partial int New_BoolTest([MarshalAs(UnmanagedType.U1)] bool value);

        [LibraryImport(NativeLib, EntryPoint = "abs")]
        public static partial int New_IntTest(int value);

        [LibraryImport("libm.so.6", EntryPoint = "cosf")]
        public static partial float New_FloatTest(float value);

        // =========================================================
        // 실행 메서드
        // =========================================================
        public static void RunBenchmark()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("    [Interop Performance Benchmark Start]    ");
            Console.WriteLine("=============================================");

            int iterations = 1_000_000; // 100만 번 호출 (가혹 조건)
            string testString = "Tizen.NUI.Performance.Optimization.Test.String.1234567890";
            Stopwatch sw = new Stopwatch();

            // JIT 예열 (Warming up) - 첫 실행의 지연 속도를 제외하기 위함
            Old_StringTest(testString);
            New_StringTest(testString);
            Old_BoolTest(true);
            New_BoolTest(true);
            Old_IntTest(100);
            New_IntTest(100);
            Old_FloatTest(1.0f);
            New_FloatTest(1.0f);

            // -----------------------------------------------------------------
            // 테스터 1: String 마샬링 (UTF-8 변환 + Heap 할당 속도 비교)
            // -----------------------------------------------------------------
            Console.WriteLine($"\n[Test 1] String Marshalling ({iterations:N0} 회)");
            
            // GC 수거 후 메모리(할당량) 베이스라인
            GC.Collect();
            GC.WaitForPendingFinalizers();
            long initialMemory = GC.GetTotalMemory(true);

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                Old_StringTest(testString);
            }
            sw.Stop();
            long oldMemoryAllocated = GC.GetTotalMemory(false) - initialMemory;
            Console.WriteLine($"  -> [DllImport]     Time: {sw.ElapsedMilliseconds} ms, Appx. GC Alloc: {oldMemoryAllocated / 1024.0:F2} KB");

            // GC 수거 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            initialMemory = GC.GetTotalMemory(true);

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                New_StringTest(testString);
            }
            sw.Stop();
            long newMemoryAllocated = GC.GetTotalMemory(false) - initialMemory;
            Console.WriteLine($"  -> [LibraryImport] Time: {sw.ElapsedMilliseconds} ms, Appx. GC Alloc: {newMemoryAllocated / 1024.0:F2} KB");

            // -----------------------------------------------------------------
            // 테스터 2: 단순 Boolean/값 마샬링 (변환 엔진 오버헤드 징검다리 속도)
            // -----------------------------------------------------------------
            Console.WriteLine($"\n[Test 2] Boolean/Value Marshalling Overhead ({iterations:N0} 회)");

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                Old_BoolTest(true);
            }
            sw.Stop();
            Console.WriteLine($"  -> [DllImport]     Time: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                New_BoolTest(true);
            }
            sw.Stop();
            Console.WriteLine($"  -> [LibraryImport] Time: {sw.ElapsedMilliseconds} ms");

            // -----------------------------------------------------------------
            // 테스터 3: 단순 Integer 테스트 (Blittable Type 마샬링 오버헤드)
            // -----------------------------------------------------------------
            Console.WriteLine($"\n[Test 3] Integer (Blittable) Marshalling Overhead ({iterations:N0} 회)");

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                Old_IntTest(100);
            }
            sw.Stop();
            Console.WriteLine($"  -> [DllImport]     Time: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                New_IntTest(100);
            }
            sw.Stop();
            Console.WriteLine($"  -> [LibraryImport] Time: {sw.ElapsedMilliseconds} ms");

            // -----------------------------------------------------------------
            // 테스터 4: 단순 Float 테스트 (Blittable Type 마샬링 오버헤드)
            // -----------------------------------------------------------------
            Console.WriteLine($"\n[Test 4] Float (Blittable) Marshalling Overhead ({iterations:N0} 회)");

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                Old_FloatTest(1.0f);
            }
            sw.Stop();
            Console.WriteLine($"  -> [DllImport]     Time: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                New_FloatTest(1.0f);
            }
            sw.Stop();
            Console.WriteLine($"  -> [LibraryImport] Time: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine("=============================================");
            Console.WriteLine("                 [Test End]                  ");
            Console.WriteLine("=============================================");
        }
    }
}
