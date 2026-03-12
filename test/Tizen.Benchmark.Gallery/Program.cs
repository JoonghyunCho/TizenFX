using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using Tizen;

namespace Tizen.Benchmark.Gallery
{
    [Config(typeof(Config))]
    [MemoryDiagnoser]
    public class ZlogAllocationBenchmark
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                AddJob(Job.Default.WithToolchain(InProcessEmitToolchain.Instance));
            }
        }

        private const string Tag = "ZlogBenchmark";
        private int _iteration = 0;
        private string _dynamicString1 = "Value1";
        private string _dynamicString2 = "Value2";

        [GlobalSetup]
        public void Setup()
        {
        }

        [Benchmark(Baseline = true, Description = "Legacy: String Concatenation")]
        public void Legacy_StringConcatenation()
        {
            _iteration++;
            try
            {
                Log.Info(Tag, "Legacy concat: a=" + _iteration.ToString() + ", b=" + _dynamicString1 + ", c=" + _dynamicString2);
            }
            catch (DllNotFoundException)
            {
            }
        }

        [Benchmark(Description = "Legacy: String.Format")]
        public void Legacy_StringFormat()
        {
            _iteration++;
            try
            {
                Log.Info(Tag, string.Format("Legacy format: a={0}, b={1}, c={2}", _iteration, _dynamicString1, _dynamicString2));
            }
            catch (DllNotFoundException)
            {
            }
        }

        [Benchmark(Description = "Zlog: Interpolated (Zero-Allocation)")]
        public void Zlog_InterpolatedString()
        {
            _iteration++;
            try
            {
                Log.Info(Tag, $"Zlog: a={_iteration}, b={_dynamicString1}, c={_dynamicString2}");
            }
            catch (DllNotFoundException)
            {
            }
        }
    }

    class Program : NUIApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();

            Window.Default.BackgroundColor = Color.White;
            var text = new TextLabel("Running Benchmarks...\nPlease wait and check dlog.");
            text.ParentOrigin = ParentOrigin.Center;
            text.PivotPoint = PivotPoint.Center;
            text.PositionUsesPivotPoint = true;
            text.HorizontalAlignment = HorizontalAlignment.Center;
            Window.Default.Add(text);

            var syncContext = global::System.Threading.SynchronizationContext.Current;

            global::System.Threading.Tasks.Task.Run(() => {
                Console.WriteLine("Starting Zlog Memory Allocation Benchmarks...");
                try
                {
                    BenchmarkRunner.Run<ZlogAllocationBenchmark>();
                    Console.WriteLine("Benchmark Finished!");
                    syncContext?.Post((o) => {
                        text.Text = "Benchmark Finished!\nPlease check dlog output.";
                    }, null);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    syncContext?.Post((o) => {
                        text.Text = "Exception:\n" + e.Message;
                    }, null);
                }
            });
        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
