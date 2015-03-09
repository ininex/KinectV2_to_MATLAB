// Taking reference from : http://pterneas.com/2014/02/20/kinect-for-windows-version-2-color-depth-and-infrared-streams/
// Improved by Guanjiu Zhang (ininex)

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
/*NOTE: if it warns you that Microsoft.Kinect does not exist, 
 * add :C:\Program Files\Microsoft SDKs\Kinect\v2.0_1409\Assemblies\Microsoft.Kinect.dll
 as the reference*/

namespace KinectV2_to_MATLAB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region initializer
        // set mode default value
        Mode _mode = Mode.Color;
        // initialize the sensor-related objects
        KinectSensor _sensor;
        MultiSourceFrameReader _reader;
        IList<Body> _bodies;
        String lines = "";
        bool _displayBody = true;

        #endregion

        #region TEST REGION

        #endregion

        #region MainWindow()
        public MainWindow()
        {
            InitializeComponent();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\iNineX\Documents\MATLAB\KINECT V2 TEST\Joints_Locs.txt", true))
            {
                file.WriteLine("Working...");
            }
        }

        #endregion

        #region Streamoperator()

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _sensor = KinectSensor.GetDefault(); //Connect sensor

            if (_sensor != null)
            {
                _sensor.Open();//start up sensor

                _reader = _sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Body);
                _reader.MultiSourceFrameArrived += Reader_MultiSourceFrameArrived;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (_reader != null)
            {
                _reader.Dispose();
            }

            if (_sensor != null)
            {
                _sensor.Close();
            }
        }

        void Reader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            //Color
            var reference = e.FrameReference.AcquireFrame();
            using (var frame = reference.ColorFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    if (_mode == Mode.Color)
                    {
                        camera.Source = frame.ToBitmap();
                    }
                }
            }
            // Body
            using (var frame = reference.BodyFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    canvas.Children.Clear();

                    _bodies = new Body[frame.BodyFrameSource.BodyCount];

                    frame.GetAndRefreshBodyData(_bodies);

                    foreach (var body in _bodies)
                    {
                        if (body != null)
                        {
                            if (body.IsTracked)
                            {
                                foreach (Joint joint in body.Joints.Values)
                                {
                                    String lines_temp = String.Format("{0}, {1}, {2}" + Environment.NewLine, joint.Position.X.ToString(), joint.Position.Y.ToString(), joint.Position.Z.ToString());
                                    lines = lines + lines_temp;
                                }

                                if (_displayBody)
                                {
                                    canvas.DrawSkeleton(body);
                                }
                            }
                        }
                    }
                }
                if (lines != "") { txtCreator(lines); }
            }
        }

        #endregion

        #region TXT FILE GENERATION
        void txtCreator(String line)
        {
            System.IO.File.WriteAllText(@"C:\Users\iNineX\Documents\MATLAB\KINECT V2 TEST\Joints_Locs.txt", String.Empty);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\iNineX\Documents\MATLAB\KINECT V2 TEST\Joints_Locs.txt", true))
            {
                file.WriteLine(line);
            }
        }
        #endregion
    }
    public enum Mode
    {
        Color
    }
}
