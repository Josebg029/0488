namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x, y;
        private void suma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(num1.Text);
            y = Convert.ToDouble(num2.Text);
            res.Text = string.Format("{0:f2}", x + y);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(num1.Text);
            y = Convert.ToDouble(num2.Text);
            res.Text = string.Format("{0:f2}", x - y);
        }

        private void multi_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(num1.Text);
            y = Convert.ToDouble(num2.Text);
            res.Text = string.Format("{0:f2}", x * y);
        }

        private void division_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(num1.Text);
            y = Convert.ToDouble(num2.Text);
            res.Text = string.Format("{0:f2}", x / y);
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(num1.Text);
            double result = Math.Sqrt(x);
            res.Text = result.ToString();
        }

        private void poten_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(num1.Text);
            y = Convert.ToDouble(num2.Text);
            double result = Math.Pow(x, y);
            res.Text = string.Format("{0:f2}", result);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            res.Text = "";
        }
    }
}
