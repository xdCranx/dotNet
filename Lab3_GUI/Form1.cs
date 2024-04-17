namespace Lab3_GUI
{
    using System.Threading.Tasks;
    using System.Drawing;
    public partial class Form1 : Form
    {
        private Bitmap? img;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = img;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("load an image.");
                return;
            }
            var imgCopy = new Bitmap[4];
            for (int i = 0; i < 4; i++)
            {
                imgCopy[i] = new Bitmap(img);
            }
            Bitmap[] filteredImages = ApplyFilters(imgCopy);

            pictureBox2.Image = filteredImages[0];
            pictureBox3.Image = filteredImages[1];
            pictureBox4.Image = filteredImages[2];
            pictureBox5.Image = filteredImages[3];
        }

        public Bitmap[] ApplyFilters(Bitmap[] originalImage)
        {
            Bitmap[] filteredImages = new Bitmap[4];

            Func<Bitmap, Bitmap>[] filters = new Func<Bitmap, Bitmap>[]
            {
                GrayscaleFilter,
                InvertFilter,
                ThresholdFilter,
                ColorFilter
            };

            Parallel.For(0, 4, i =>
            {
                filteredImages[i] = filters[i](new Bitmap(originalImage[i]));
            });

            return filteredImages;
        }

        private Bitmap GrayscaleFilter(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayScale = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    image.SetPixel(x, y, Color.FromArgb(grayScale, grayScale, grayScale));
                }
            }

            return image;
        }

        private Bitmap InvertFilter(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    image.SetPixel(x, y, Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B));
                }
            }

            return image;
        }

        private Bitmap ThresholdFilter(Bitmap image)
        {
            int threshold = 90;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayscale = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    if (grayscale > threshold)
                    {
                        image.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        image.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return image;
        }

        private Bitmap ColorFilter(Bitmap image)
        {
            double redMultiplier = 1;
            double greenMultiplier = 0;
            double blueMultiplier = 0;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int r = (int)(pixelColor.R * redMultiplier);
                    int g = (int)(pixelColor.G * greenMultiplier);
                    int b = (int)(pixelColor.B * blueMultiplier);

                    r = (r > 255) ? 255 : (r < 0) ? 0 : r;
                    g = (g > 255) ? 255 : (g < 0) ? 0 : g;
                    b = (b > 255) ? 255 : (b < 0) ? 0 : b;

                    image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return image;
        }
    }
}
