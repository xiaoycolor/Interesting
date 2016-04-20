﻿using Emgu.CV.Structure;
using System.Windows.Media.Imaging;
using Emgu.CV;
using System.Windows.Controls;

namespace ImageProcessing
{
    class Processing_Erode : Processing
    {
        public Processing_Erode()
        {
            _Control = new Ui_Slider(this); //加入滑动条
            Level = 50;
        }

        public override string Name { get { return "Erode"; } } //函数名
        public override UserControl Control { get { return _Control; } }
        private Ui_Slider _Control;
        public double Level { get; set; }

        public override BitmapSource GetResultImage(BitmapImage aSourceImage)
        {
            Image<Bgr, byte> img = new Image<Bgr, byte>(Method_BitmapChange.BitmapImage2Bitmap(aSourceImage));
            Image<Bgr, byte> img1 = img.Erode((int)Level/20);
            return Method_BitmapChange.Bitmap2BitmapImage(img1.ToBitmap());
        }

        protected override byte[] ProcessImage(byte[] aSourceRawData, ref int aPixelWidth, ref int aPixelHeight, int aBytesPerPixel, ref int aStride)
        {
            return aSourceRawData;
        }

    }
}



