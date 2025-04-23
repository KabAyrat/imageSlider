using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImageSlider
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>
        {
            "https://world-devices.ru/image/cache/catalog/01032017/111/2411/ps3-500x400.jpg",
            "https://ir.ozone.ru/s3/multimedia-h/c1000/6371708513.jpg",
            "https://world-devices.ru/image/cache/catalog/01032017/111/2411/ps3-500x400.jpg"  //здесь хранятся пути к фоткам
        };

        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            ShowImage(); // показываем первую фотку
        }

        private void ShowImage()
        {
            pictureBox1.ImageLocation = imagePaths[currentIndex];
            UpdateLabel(); //счётчик фоток
         
        }

        private void UpdateLabel()
        {
            labelStatus.Text = $"Котик {currentIndex + 1} из {imagePaths.Count}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            ShowImage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Count) % imagePaths.Count;
            ShowImage();
        }
    }
}