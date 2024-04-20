namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a, b;
            int a1, b1;
            double a2;
            a = int.TryParse(textBox1.Text, out a1);
            b = int.TryParse(textBox2.Text, out b1);
            if (a & b)
            {
                a2 = Math.Atan2(b1, a1) * 180.0 / Math.PI;
                label4.Text = Convert.ToString(a2);
            }
            else
            {
                label4.Text = "Неверный формат";
            }
        }
    }
}
