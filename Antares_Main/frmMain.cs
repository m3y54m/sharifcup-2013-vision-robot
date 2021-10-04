using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

using System.IO.Ports;
using System.Threading;

namespace Antares_Main
{
    public partial class frmMain : Form
    {
        //declaring global variables

        // rtsp://admin:abcdefg@192.168.0.20:554/live1.sdp // works in VLC
		// http://admin:asdfgh@192.168.0.20:80/video1.mjpg
        // http://admin:abcdefg@192.168.0.20/dms?nowprofileid=1 //JPEG
        // http://admin:abcdefg@192.168.0.20/image/jpeg.cgi //JPEG
        // http://admin:abcdefg@192.168.0.20/dms.jpg //JPEG
        // http://admin:abcdefg@192.168.0.20/ipcam/stream.cgi?nowprofileid=1 //	MJPEG

        private static string inputStream = "rtsp://admin:ozrais4me@172.18.17.94:554/live1.sdp";

        private Capture capture = new Capture(0);       //takes images from camera as image frames
        private bool captureInProgress = false; // checks if capture is executing
        private bool previewInProgress = false;
        private bool enableToGetColors = true;

        public class commonColors
        {
                public Bgr Red = new Bgr();
                public Bgr Blue = new Bgr();
                public Bgr Green = new Bgr();
                public Bgr Yellow = new Bgr();
                public Bgr Purple = new Bgr();
                public Bgr Cyan = new Bgr();

                public Hsv hsvRed = new Hsv();
                public Hsv hsvBlue = new Hsv();
                public Hsv hsvGreen = new Hsv();
                public Hsv hsvYellow = new Hsv();
                public Hsv hsvPurple = new Hsv();
                public Hsv hsvCyan = new Hsv();
        }

        private commonColors colorsList = new commonColors();

        //[FlagsAttribute]

        Image<Bgr, byte> imgCam = new Image<Bgr, byte>("20130923089.jpg");

        public frmMain()
        {
            InitializeComponent();
            ibCam.Image = imgCam;
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> img = capture.QueryFrame();
            if (previewInProgress)
            {
                ibResult.Image = img;
            }
        }

        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }


        public void aRotate()
        {
        
        }

        public static Hsv RGBtoHSV(Bgr myRGB)
        {
            /***************************************************************** 
             * written by Meysam Parvizi 
             * using www.rapidtables.com/convert/color/rgb-to-hsv.htm
             *****************************************************************/
            double r = myRGB.Red / 255;    // 0 <= r <= 1
            double g = myRGB.Green / 255;  // 0 <= g <= 1
            double b = myRGB.Blue / 255;   // 0 <= b <= 1

            double h;
            double s;
            double v;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));	
            double delta = max - min;

            if (delta != 0)
            {
                if (r == max)
                    h = ((g - b) / delta) % 6;
                else if (g == max)
                    h = ((b - r) / delta) + 2;
                else // if (b == max)
                    h = ((r - g) / delta) + 4;
                h *= 60;
                if (h < 0)
                    h += 360;
                s = delta / max;
            }
            else
            {
                h = 0;
                s = 0;
            }

            v = max;
            
            return new Hsv(h / 2, s * 255, v * 255);
        }

        public static Bgr HSVtoRGB(Hsv myHSV)
        {
            /***************************************************************** 
             * written by Meysam Parvizi 
             * using www.rapidtables.com/convert/color/hsv-to-rgb.htm
             *****************************************************************/
            double h = myHSV.Hue * 2;           // 0 <= h < 360
            double s = myHSV.Satuation / 255;   // 0 <= s <= 1
            double v = myHSV.Value / 255;       // 0 <= v <= 1

            double r;
            double g;
            double b;

            double c = v * s;
            double d = h / 60;
            double x = c * (1 - Math.Abs(d % 2 - 1));
            double m = v - c;

            int n = (int)Math.Floor(d);

            switch (n)
            {
                case 0:
                    r = c + m;
                    g = x + m;
                    b = m;
                    break;
                case 1:
                    r = x + m;
                    g = c + m;
                    b = m;
                    break;
                case 2:
                    r = m;
                    g = c + m;
                    b = x + m;
                    break;
                case 3:
                    r = m;
                    g = x + m;
                    b = c + m;
                    break;
                case 4:
                    r = x + m;
                    g = m;
                    b = c + m;
                    break;
                default:    // case 5:
                    r = c + m;
                    g = m;
                    b = x + m;
                    break;
            }

            return new Bgr(b * 255, g * 255, r * 255);
        }

        private void ibCam_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (enableToGetColors)
            {
                int x = (int)(e.X * ((float)ibCam.Image.Bitmap.Width / ibCam.Width));
                int y = (int)(e.Y * ((float)ibCam.Image.Bitmap.Height / ibCam.Height));
                Bitmap bmpImage = ibCam.Image.Bitmap;
                Color clr = bmpImage.GetPixel(x, y);
                Bgr mycolor = new Bgr(clr.B, clr.G, clr.R);
                String strColor = Convert.ToString(clr.R) + ", " + Convert.ToString(clr.G) + ", " + Convert.ToString(clr.B);

                if (rbRed.Checked)
                {
                    colorsList.Red = mycolor;
                    colorsList.hsvRed = RGBtoHSV(mycolor);
                    label3.Text = colorsList.hsvRed.ToString();
                    lblRed.Text = strColor;
                    lblRed.BackColor = Color.FromArgb(clr.R, clr.G, clr.B);
                    lblRed.ForeColor = Color.White;
                }
                else if (rbBlue.Checked)
                {
                    colorsList.Blue = mycolor;
                    colorsList.hsvBlue = RGBtoHSV(mycolor);
                    lblBlue.Text = strColor;
                    label3.Text = colorsList.hsvBlue.ToString();
                    lblBlue.BackColor = Color.FromArgb(clr.R, clr.G, clr.B);
                    lblBlue.ForeColor = Color.White;
                }
                else if (rbGreen.Checked)
                {
                    colorsList.Green = mycolor;
                    colorsList.hsvGreen = RGBtoHSV(mycolor);
                    lblGreen.Text = strColor;
                    label3.Text = colorsList.hsvGreen.ToString();
                    lblGreen.BackColor = Color.FromArgb(clr.R, clr.G, clr.B);
                    lblGreen.ForeColor = Color.White;
                }
                else if (rbYellow.Checked)
                {
                    colorsList.Yellow = mycolor;
                    colorsList.hsvYellow = RGBtoHSV(mycolor);
                    lblYellow.Text = strColor;
                    lblYellow.BackColor = Color.FromArgb(clr.R, clr.G, clr.B);
                    lblYellow.ForeColor = Color.White;
                }
                else if (rbPurple.Checked)
                {
                    colorsList.Purple = mycolor;
                    colorsList.hsvPurple = RGBtoHSV(mycolor);
                    lblPurple.Text = strColor;
                    lblPurple.BackColor = Color.FromArgb(clr.R, clr.G, clr.B);
                    lblPurple.ForeColor = Color.White;
                }
                else if (rbCyan.Checked)
                {
                    colorsList.Cyan = mycolor;
                    colorsList.hsvCyan = RGBtoHSV(mycolor);
                    lblCyan.Text = strColor;
                    lblCyan.BackColor = Color.FromArgb(clr.R, clr.G, clr.B);
                    lblCyan.ForeColor = Color.White;
                }
            }
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            // if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    //capture = new Capture(inputStream);
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            if (capture != null)
            {
                if (captureInProgress)
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture
                    btnStream.Text = "Start Streaming"; //
                    Application.Idle -= ProcessFrame;
                    captureInProgress = false;
                    previewInProgress = false;
                    btnFreeze.Enabled = false;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
                    btnStream.Text = "Stop Streaming";
                    Application.Idle += ProcessFrame;
                    captureInProgress = true;
                    previewInProgress = true;
                    btnFreeze.Enabled = true;
                }
            }
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (previewInProgress)
                {
                    btnFreeze.Text = "Play";
                    previewInProgress = false;
                    ibResult.Image = capture.QueryFrame();
                }
                else
                {
                    btnFreeze.Text = "Freeze";
                    previewInProgress = true;
                }
            }
        }

        private void btnGetColors_Click(object sender, EventArgs e)
        {
            if (!enableToGetColors)
            {
                gbGetColors.Enabled = true;
                btnGetColors.Text = "Disable Getting Colors";
            }
            else
            {
                gbGetColors.Enabled = false;
                btnGetColors.Text = "Enable Getting Colors";
            }

            enableToGetColors = !enableToGetColors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image<Hsv, byte> imgHsv= imgCam.Convert<Hsv, byte>();
            Image<Gray, byte> imgGray= imgCam.Convert<Gray, byte>().PyrDown().PyrUp();
            
            if (lblRed.Text == "" || lblBlue.Text == "" || lblGreen.Text == "" || lblYellow.Text == "" || lblPurple.Text == "" || lblCyan.Text == "")
            {
                MessageBox.Show("You haven't entered all colors!");
            }
            else
            {
                byte saturationMin = 100;
                byte valueMin = 100;
                byte saturationMax = 255;
                byte valueMax = 255;
                int ImageSize = 550;
                int FieldRealSize = int.Parse(txtFieldRealSize.Text);
                double dif = 10;
                double k = (double)ImageSize / FieldRealSize;
                double minArea = Math.Pow(10 * k, 2) * Math.PI;
                double maxArea = Math.Pow(350 * k, 2);

                Image<Gray, byte> grayRed;
                Image<Gray, byte> grayRed2;

                if (colorsList.hsvRed.Hue < 90)
                {
                    grayRed = imgHsv.InRange(new Hsv(colorsList.hsvRed.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvRed.Hue + dif, saturationMax, valueMax));
                    grayRed2 = imgHsv.InRange(new Hsv(180 - dif, saturationMin, valueMin), new Hsv(180, saturationMax, valueMax));
                }
                else
                {
                    grayRed = imgHsv.InRange(new Hsv(colorsList.hsvRed.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvRed.Hue + dif, saturationMax, valueMax));
                    grayRed2 = imgHsv.InRange(new Hsv(0, saturationMin, valueMin), new Hsv(dif, saturationMax, valueMax));
                }

                grayRed = grayRed | grayRed2;

                Image<Gray, byte> grayBlue = imgHsv.InRange(new Hsv(colorsList.hsvBlue.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvBlue.Hue + dif, saturationMax, valueMax));
                Image<Gray, byte> grayGreen = imgHsv.InRange(new Hsv(colorsList.hsvGreen.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvGreen.Hue + dif, saturationMax, valueMax));
                Image<Gray, byte> grayYellow = imgHsv.InRange(new Hsv(colorsList.hsvYellow.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvYellow.Hue + dif, saturationMax, valueMax));
                Image<Gray, byte> grayPurple = imgHsv.InRange(new Hsv(colorsList.hsvPurple.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvPurple.Hue + dif, saturationMax, valueMax));
                Image<Gray, byte> grayCyan = imgHsv.InRange(new Hsv(colorsList.hsvCyan.Hue - dif, saturationMin, valueMin), new Hsv(colorsList.hsvCyan.Hue + dif, saturationMax, valueMax));
                
                //Image<Gray, byte> grayBlack = imgGray.ThresholdBinary(new Gray(200), new Gray(255));
                Image<Gray, byte> OrColors = grayRed | grayBlue | grayGreen | grayYellow | grayPurple | grayCyan;

                /*
                if (serialPort1.IsOpen == false)
                    serialPort1.Open();
                byte[] command = { Convert.ToByte(txtFieldRealSize.Text) };
                serialPort1.Write(command, 0, 1);

                /*
                if (serialPort2.IsOpen == false)
                    serialPort2.Open();
                int bytes = serialPort2.BytesToRead;
                byte[] byte_buffer = new byte[bytes];
                serialPort2.Read(byte_buffer, 0, bytes);
                label1.Text = "";
                for (int t = 0; t < bytes; t++)
                    label1.Text += byte_buffer[t].ToString();*/


                Image<Bgr, byte> BgrOrColors = imgCam.CopyBlank();

                //--------------------------------------------------------------//
                Contour<Point> contoursRed = grayRed.FindContours();

                while (contoursRed != null)
                {
                    MCvMoments moment = contoursRed.GetMoments();
                    float x = (float)moment.GravityCenter.x;
                    float y = (float)moment.GravityCenter.y;

                    if (contoursRed.Area > 0.8 * minArea)
                    {
                        BgrOrColors.Draw(contoursRed, new Bgr(Color.Red), -1);
                        label1.Text = label1.Text + Convert.ToString(contoursRed.Area) + ",";
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }
                    else if (contoursRed.Area > 0.05 * minArea && contoursRed.Area < 0.15 * minArea)
                    {
                        BgrOrColors.Draw(contoursRed, new Bgr(Color.Orange), -1);
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }

                    contoursRed = contoursRed.HNext;
                }
                //--------------------------------------------------------------//

                //--------------------------------------------------------------//
                Contour<Point> contoursBlue = grayBlue.FindContours();

                while (contoursBlue != null)
                {
                    MCvMoments moment = contoursBlue.GetMoments();
                    float x = (float)moment.GravityCenter.x;
                    float y = (float)moment.GravityCenter.y;

                    if (contoursBlue.Area > 0.8 * minArea)
                    {
                        BgrOrColors.Draw(contoursBlue, new Bgr(Color.Blue), -1);
                        label1.Text = label1.Text + Convert.ToString(contoursBlue.Area) + ",";
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }

                    contoursBlue = contoursBlue.HNext;
                }
                //--------------------------------------------------------------//

                //--------------------------------------------------------------//
                Contour<Point> contoursGreen = grayGreen.FindContours();

                while (contoursGreen != null)
                {
                    MCvMoments moment = contoursGreen.GetMoments();
                    float x = (float)moment.GravityCenter.x;
                    float y = (float)moment.GravityCenter.y;

                    if (contoursGreen.Area > 0.8 * minArea)
                    {
                        BgrOrColors.Draw(contoursGreen, new Bgr(Color.Green), -1);
                        label1.Text = label1.Text + Convert.ToString(contoursGreen.Area) + ",";
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }

                    contoursGreen = contoursGreen.HNext;
                }
                //--------------------------------------------------------------//

                //--------------------------------------------------------------//
                Contour<Point> contoursYellow = grayYellow.FindContours();

                while (contoursYellow != null)
                {
                    MCvMoments moment = contoursYellow.GetMoments();
                    float x = (float)moment.GravityCenter.x;
                    float y = (float)moment.GravityCenter.y;

                    if (contoursYellow.Area > 0.8 * minArea)
                    {
                        BgrOrColors.Draw(contoursYellow, new Bgr(Color.Yellow), -1);
                        label1.Text = label1.Text + Convert.ToString(contoursYellow.Area) + ",";
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }
                    else if (contoursYellow.Area > 0.05 * minArea && contoursYellow.Area < 0.15 * minArea)
                    {
                        BgrOrColors.Draw(contoursYellow, new Bgr(Color.White), -1);
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }

                    contoursYellow = contoursYellow.HNext;
                }
                //--------------------------------------------------------------//

                //--------------------------------------------------------------//
                Contour<Point> contoursPurple = grayPurple.FindContours();

                while (contoursPurple != null)
                {
                    MCvMoments moment = contoursPurple.GetMoments();
                    float x = (float)moment.GravityCenter.x;
                    float y = (float)moment.GravityCenter.y;

                    if (contoursPurple.Area > 0.5 * minArea)
                    {
                        BgrOrColors.Draw(contoursPurple, new Bgr(Color.Purple), -1);
                        label1.Text = label1.Text + Convert.ToString(contoursPurple.Area) + ",";
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }

                    contoursPurple = contoursPurple.HNext;
                }
                //--------------------------------------------------------------//

                //--------------------------------------------------------------//
                Contour<Point> contoursCyan = grayCyan.FindContours();

                while (contoursCyan != null)
                {
                    MCvMoments moment = contoursCyan.GetMoments();
                    float x = (float)moment.GravityCenter.x;
                    float y = (float)moment.GravityCenter.y;

                    if (contoursCyan.Area > 0.5 * minArea)
                    {
                        BgrOrColors.Draw(contoursCyan, new Bgr(Color.Cyan), -1);
                        label1.Text = label1.Text + Convert.ToString(contoursCyan.Area) + ",";
                        CircleF dot = new CircleF(new PointF(x, y), 2);
                        BgrOrColors.Draw(dot, new Bgr(Color.Black), -1);
                    }

                    contoursCyan = contoursCyan.HNext;
                }
                //--------------------------------------------------------------//

                Image<Gray, Byte> imgThresholdTemp = imgGray.InRange(new Gray(0), new Gray(130));
                Image<Gray, Byte> imgThreshold = imgThresholdTemp.CopyBlank();
                
                Contour<Point> contoursThT = imgThresholdTemp.FindContours();

                while (contoursThT != null)
                {
                    if (contoursThT.Area > 0.5 * maxArea)
                    {
                        imgThreshold.Draw(contoursThT, new Gray(255), -1);
                    }

                    contoursThT = contoursThT.HNext;
                }

                Contour<Point> contoursTh = imgThreshold.FindContours();

                List<MCvBox2D> lstRectangles = new List<MCvBox2D>(); // Declare list of rectangles

                using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                    while (contoursTh != null)
                    {
                        Contour<Point> contour = contoursTh.ApproxPoly(contoursTh.Perimeter * 0.025, storage); // Approximates one or more curves and returns the approximation results
                        if (contour.Area > 250.0)
                        {
                            if (contour.Total == 4) // If 4, 5, or 6 points, could be a rectangle or a polygon
                            {
                                Point[] ptPoints = contour.ToArray(); // Get contour points
                                bool blnIsRectangle = true; // To start with, let's suppose it's a rectangle

                                LineSegment2D[] ls2dEdges = PointCollection.PolyLine(ptPoints, true); // Get edges between points
                                for (int i = 0; i <= ls2dEdges.Length - 1; i++) // Step through edges
                                {
                                    double dblAngle = Math.Abs(ls2dEdges[(i + 1) % ls2dEdges.Length].GetExteriorAngleDegree(ls2dEdges[i]));
                                    if (dblAngle < 80.0 || dblAngle > 100.0) // If not about 90 degrees angle between edges
                                    {
                                        blnIsRectangle = false; // Then it's not a rectangle
                                        break;
                                    }
                                }

                                if (blnIsRectangle) // If a rectangle
                                {
                                    lstRectangles.Add(contour.GetMinAreaRect()); // Add to list of rectangles
                                    BgrOrColors.Draw(contour.GetMinAreaRect(), new Bgr(Color.Red), 2);
                                    int dotX = (ptPoints[0].X + ptPoints[1].X + ptPoints[2].X + ptPoints[3].X) / 4;
                                    int dotY = (ptPoints[0].Y + ptPoints[1].Y + ptPoints[2].Y + ptPoints[3].Y) / 4;
                                    CircleF dot = new CircleF(new PointF(dotX, dotY), 3);
                                    BgrOrColors.Draw(dot, new Bgr(Color.Red), -1);
                                }
                            }
                        }
                        contoursTh = contoursTh.HNext;
                    }

                ibResult.Image = BgrOrColors;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
