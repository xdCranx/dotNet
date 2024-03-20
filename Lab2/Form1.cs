namespace Lab2
{
    public partial class Form1 : Form
    {
        private string xyz = "abc";
        ApiClass api = new ApiClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = await api.GetData();
        }
    }
}
