namespace TP_MOD3_1302213108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            label1.Text = "HALO " + text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}