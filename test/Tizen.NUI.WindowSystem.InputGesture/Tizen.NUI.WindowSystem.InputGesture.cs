using System;
using Tizen;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.WindowSystem;
using WS = Tizen.WindowSystem;
using System.Collections.Generic;

namespace Tizen.NUI.WindowSystem
{
    class Program : NUIApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        void Initialize()
        {
            Window win = Window.Instance;
            inputGesture = new InputGesture();

            win.WindowSize = new Size2D(500, 500);
            win.KeyEvent += OnKeyEvent;
            win.BackgroundColor = Color.White;

            View windowView = new View();
            windowView.Size2D = new Size2D(500, 500);
            windowView.BackgroundColor = Color.White;
            windowView.TouchEvent += OnTouchEvent;
            win.Add(windowView);

            centerLabel = new TextLabel("InputGesture Sample, Click to generate Return Key.");
            centerLabel.HorizontalAlignment = HorizontalAlignment.Center;
            centerLabel.VerticalAlignment = VerticalAlignment.Center;
            centerLabel.TextColor = Color.Black;
            centerLabel.PointSize = 12.0f;
            centerLabel.HeightResizePolicy = ResizePolicyType.FillToParent;
            centerLabel.WidthResizePolicy = ResizePolicyType.FillToParent;
            windowView.Add(centerLabel);

            repeatCounter = 0;
        }

        private void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
            if (e.Key.State == Key.StateType.Down && e.Key.KeyPressedName == "Return")
            {
                repeatCounter++;
                centerLabel.Text = "Return Key Pressed, counter: " + repeatCounter.ToString();
            }

            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "S" || e.Key.KeyPressedName == "s"))
            {
                if (edgeSwipeGesture == null)
                    edgeSwipeGesture = inputGesture.CreateEdgeSwipe(2, GestureEdge.Left);

                if (edgeSwipeGesture == null)
                {
                    centerLabel.Text = "'S' Key Pressed. edgeSwipeGesture NULL!!";
                    return;
                }

                if (!edgeSwipeGrabbed)
                {
                    edgeSwipeGesture.Grab();
                    centerLabel.Text = "'S' Key Pressed. edgeSwipe Grabbed";

                    edgeSwipeGesture.Detected += _edgeSwipeEventHandler;
                    edgeSwipeGrabbed = true;
                }
                else
                {
                    edgeSwipeGesture.Ungrab();
                    edgeSwipeGesture.Detected -= _edgeSwipeEventHandler;
                    centerLabel.Text = "'S' Key Pressed. edgeSwipe Ungrabbed";
                    edgeSwipeGrabbed = false;
                }
            }
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "D" || e.Key.KeyPressedName == "d"))
            {
                if (edgeDragGesture == null)
                    edgeDragGesture = inputGesture.CreateEdgeDrag(2, GestureEdge.Right);

                if (edgeDragGesture == null)
                {
                    centerLabel.Text = "'D' Key Pressed. edgeDrag NULL!!!";
                    return;
                }

                if (!edgeDragGrabbed)
                {
                    edgeDragGesture.Grab();
                    centerLabel.Text = "'D' Key Pressed. edgeDrag Grabbed";

                    edgeDragGesture.Detected += _edgeDragEventHandler;
                    edgeDragGrabbed = true;
                }
                else
                {
                    edgeDragGesture.Ungrab();
                    edgeDragGesture.Detected -= _edgeDragEventHandler;
                    centerLabel.Text = "'D' Key Pressed. edgeDrag Ungrabbed";
                    edgeDragGrabbed = false;
                }
            }
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "T" || e.Key.KeyPressedName == "t"))
            {
                if (tapGesture == null)
                    tapGesture = inputGesture.CreateTap(3, 2);

                if (tapGesture == null)
                {
                    centerLabel.Text = "'T' Key Pressed. Tap NULL!!!";
                    return;
                }

                if (!tapGrabbed)
                {
                    tapGesture.Grab();
                    centerLabel.Text = "'T' Key Pressed. Tap Grabbed";

                    tapGesture.Detected += _tapEventHandler;
                    tapGrabbed = true;
                }
                else
                {
                    tapGesture.Ungrab();
                    tapGesture.Detected -= _tapEventHandler;
                    centerLabel.Text = "'T' Key Pressed. Tap Ungrabbed";
                    tapGrabbed = false;
                }
            }
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "P" || e.Key.KeyPressedName == "p"))
            {
                if (palmGesture == null)
                    palmGesture = inputGesture.CreatePalmCover();

                if (palmGesture == null)
                {
                    centerLabel.Text = "'P' Key Pressed. PalmCover NULL!!!";
                    return;
                }

                if (!palmCoverGrabbed)
                {
                    palmGesture.Grab();
                    centerLabel.Text = "'P' Key Pressed. PalmCover Grabbed";

                    palmGesture.Detected += _palmCoverEventHandler;
                    palmCoverGrabbed = true;
                }
                else
                {
                    palmGesture.Ungrab();
                    palmGesture.Detected -= _palmCoverEventHandler;
                    centerLabel.Text = "'P' Key Pressed. PalmCover Ungrabbed";
                    palmCoverGrabbed = false;
                }
            }
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "G" || e.Key.KeyPressedName == "g"))
            {
                if (edgeSwipeGesture == null)
                    edgeSwipeGesture = inputGesture.CreateEdgeSwipe(1, GestureEdge.Left);

                if (edgeSwipeGesture == null)
                {
                    centerLabel.Text = "'G' Key Pressed. edgeSwipeGesture NULL!!";
                    return;
                }

                if (!edgeSwipeGrabbed)
                {
                    edgeSwipeGesture.SetGrabMode(GestureGrabMode.Shared);
                    edgeSwipeGesture.Grab();
                    centerLabel.Text = "'G' Key Pressed. edgeSwipe Shared Grabbed";

                    edgeSwipeGesture.Detected += _edgeSwipeEventHandler;
                    edgeSwipeGrabbed = true;
                }
                else
                {
                    edgeSwipeGesture.Ungrab();
                    edgeSwipeGesture.Detected -= _edgeSwipeEventHandler;
                    centerLabel.Text = "'G' Key Pressed. edgeSwipe Ungrabbed";
                    edgeSwipeGrabbed = false;
                }
            }
        }

        private bool OnTouchEvent(object sender, View.TouchEventArgs e)
        {
            touchCounter++;
            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"> The sender object. </param>
        /// <param name="e"> Argument of Event. </param>
        private static void _edgeSwipeEventHandler(object sender, EdgeSwipeEventArgs e)
        {
            Log.Debug("GestureSample", "Mode: " + (GestureMode)e.Mode + ", Fingers: " + e.Fingers + ", Sx: " + e.Sx + ", Sy: " + e.Sy + ", Edge: " + (GestureEdge)e.Edge);
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"> The sender object. </param>
        /// <param name="e"> Argument of Event. </param>
        private static void _edgeDragEventHandler(object sender, EdgeDragEventArgs e)
        {
            Log.Debug("GestureSample", "Mode: " + (GestureMode)e.Mode + ", Fingers: " + e.Fingers + ", Cx: " + e.Cx + ", Cy: " + e.Cy + ", Edge: " + (GestureEdge)e.Edge);
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"> The sender object. </param>
        /// <param name="e"> Argument of Event. </param>
        private static void _tapEventHandler(object sender, TapEventArgs e)
        {
            Log.Debug("GestureSample", "Mode: " + (GestureMode)e.Mode + ", Fingers: " + e.Fingers + ", Repeats: " + e.Fingers);
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"> The sender object. </param>
        /// <param name="e"> Argument of Event. </param>
        private static void _palmCoverEventHandler(object sender, PalmCoverEventArgs e)
        {
            Log.Debug("GestureSample", "Mode: " + (GestureMode)e.Mode + ", Duration: " + e.Duration + ", Cx: " + e.Cx + ", Cy: " + e.Cy + ", Size: " + e.Size + ", Pressure: " + e.Pressure);
        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }

        private InputGesture inputGesture;
        WS.EdgeSwipeGesture edgeSwipeGesture;
        WS.EdgeDragGesture edgeDragGesture;
        WS.TapGesture tapGesture;
        WS.PalmCoverGesture palmGesture;
        private TextLabel centerLabel;
        int repeatCounter = 0;
        int touchCounter = 0;

        bool edgeSwipeGrabbed;
        bool edgeDragGrabbed;
        bool tapGrabbed;
        bool palmCoverGrabbed;
    }
}
