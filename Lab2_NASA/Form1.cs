using System.Globalization;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab2_NASA
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "T25TDN0vYdXGIvsUaVBSeoGQ1qnuKWZVwdWaLFWP"; // Replace with your NASA API key
        private const string ApodApiUrl = "https://api.nasa.gov/planetary/apod?api_key={0}&date={1}&thumbs=true";

        public Form1()
        {
            InitializeComponent();

        }
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            string dateString = txtDate.Text; // Get the date from the textbox

            // Validate date format
            if (!DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Invalid date format. Please use YYYY-MM-DD format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await LoadImage(dateString);
        }

        private async Task LoadImage(string dateString)
        {
            using (var context = new APODsDB())
            {
                DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var apod = context.APODs.FirstOrDefault(a => a.date == date);
                if (apod == null)
                {
                    string url = string.Format(ApodApiUrl, ApiKey, date);

                    using (HttpClient client = new HttpClient())
                    {
                        string json = await client.GetStringAsync(url);
                        apod = JsonSerializer.Deserialize<APOD>(json);
                        pictureBox.LoadAsync(apod.url);
                        urlBox.Text = apod.url;
                        titleBox.Text = apod.title;
                        explanationBox.Text = apod.explanation;
                    }
                }
                else
                {
                    pictureBox.ImageLocation = apod.url;
                    titleBox.Text = apod.title;
                    explanationBox.Text = apod.explanation;
                }
            }
        }
    }
}

