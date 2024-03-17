using Lab1;

namespace Lab1_GUI
{
    public partial class Form1 : Form
    {
        private int n;
        private int seed;
        private int capacity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KnapsackProblem knapsackProblem = new KnapsackProblem(n, seed);
            instance_text_box.Text = knapsackProblem.ToString();
            res_text_box.Text = knapsackProblem.Solve(capacity).ToString();

        }

        private void result_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void instance_text_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void noi_text_box_TextChanged(object sender, EventArgs e)
        {   
            noi_text_box.BackColor = Color.White;
            try
            {
                n = Convert.ToInt32(noi_text_box.Text);
            } catch {
                noi_text_box.BackColor = Color.Red;
                n = 0;
            }
        }

        private void cap_text_box_TextChanged(object sender, EventArgs e)
        {
            cap_text_box.BackColor = Color.White;
            try
            {
                capacity = Convert.ToInt32(noi_text_box.Text);
            }
            catch
            {
                capacity = 0;
                cap_text_box.BackColor = Color.Red;
            }
        }

        private void seed_text_box_TextChanged(object sender, EventArgs e)
        {
            seed_text_box.BackColor = Color.White;
            try
            {
                seed = Convert.ToInt32(noi_text_box.Text);
            }
            catch
            {
                seed = 0;
                seed_text_box.BackColor = Color.Red;
            }
        }
    }
}
