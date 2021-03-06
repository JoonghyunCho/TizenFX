﻿
using global::System;
using Tizen.NUI.BaseComponents;

namespace Tizen.NUI.Samples
{
    using tlog = Tizen.Log;

    public class VideoViewTest : IExample
    {
        // Make derieved class from Tizen.Multimedia.Player because protected Player(IntPtr handle, Action<int, string> errorHandler)
        // this constructor's access modifyer is protected, so there is no other way.
        public class myPlayer : Tizen.Multimedia.Player
        {
            public myPlayer() : base()
            {
                //Initialize();
            }

            public myPlayer(IntPtr p) : base(p, null)
            {
                //Initialize();
            }
        }

        Window win;
        myPlayer player;
        string resourcePath;
        const string tag = "NUITEST";
        public void Activate()
        {
            win = NUIApplication.GetDefaultWindow();
            win.BackgroundColor = Color.Green;
            win.KeyEvent += Win_KeyEvent;
            win.TouchEvent += Win_TouchEvent;

            var dummy = new View();
            dummy.Size = new Size(200, 200);
            dummy.BackgroundColor = new Color(0.0f, 0.0f, 0.0f, 0.2f);
            win.Add(dummy);

            resourcePath = Tizen.Applications.Application.Current.DirectoryInfo.Resource + "v.mp4";
            tlog.Fatal(tag, $"resourcePath: {resourcePath}");

            NUIVideoViewTest();
            //PlayerTest();
        }
        public void Deactivate()
        {
            win.KeyEvent -= Win_KeyEvent;
            win.TouchEvent -= Win_TouchEvent;
            videoView?.Unparent();
            player?.Dispose();
            player = null;
        }

        int cnt;
        private void Win_TouchEvent(object sender, Window.TouchEventArgs e)
        {
            if (e.Touch.GetState(0) == PointStateType.Down)
            {
                if (++cnt % 2 == 1)
                {
                    if (player != null)
                    {
                        player.Pause();
                        tlog.Fatal(tag, $"player pause!");
                    }
                }
                else
                {
                    if (player != null)
                    {
                        player.Start();
                        tlog.Fatal(tag, $"player start!");
                    }
                }
            }
        }

        public async void PlayerTest()
        {
            player = new myPlayer();

            player.SetSource(new Tizen.Multimedia.MediaUriSource(resourcePath));

            player.Display = new Tizen.Multimedia.Display(win);

            await player.PrepareAsync();
            tlog.Fatal(tag, $"await player.PrepareAsync();");

            player.Start();
            tlog.Fatal(tag, $"player.Start();");

            if (player.DisplaySettings.IsVisible == false)
            {
                player.DisplaySettings.IsVisible = true;
            }
            tlog.Fatal(tag, $"Display visible = {player.DisplaySettings.IsVisible}");

            player.DisplaySettings.Mode = Tizen.Multimedia.PlayerDisplayMode.FullScreen;
        }

        VideoView videoView;
        public void NUIVideoViewTest()
        {
            videoView = new VideoView();
            videoView.ResourceUrl = resourcePath;
            videoView.Looping = true;
            videoView.Size = new Size(300, 300);
            videoView.PositionUsesPivotPoint = true;
            videoView.ParentOrigin = ParentOrigin.Center;
            videoView.PivotPoint = PivotPoint.Center;
            win.Add(videoView);

            var playerHandle = new SafeNativePlayerHandler(videoView);
            player = new myPlayer(playerHandle.DangerousGetHandle());
            if (player != null)
            {
                player.Start();
            }
        }

        private void Win_KeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down)
            {
                tlog.Fatal(tag, $"key pressed name={e.Key.KeyPressedName}");
                if (e.Key.KeyPressedName == "XF86Back")
                {
                    Deactivate();
                }
            }
        }

    }
}
