using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FishTank
{
    public class Program
    {
        private static FormImageBox m_imageBox;

        private static void Main(string[] args)
        {
            InitializeImageBox();
        }

        private static void InitializeImageBox()
        {
            m_imageBox = new FormImageBox();
            m_imageBox.Show();
        }

        private static void SetDisplayedImage(Bitmap bmp)
        {
            m_imageBox.pictureBoxImage.Image = bmp;
        }
    }
}