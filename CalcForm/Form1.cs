namespace CalcForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double value = 0;
        string op = "";
        bool op_pressed = false;



        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || op_pressed == true)
            {
                textBox1.Clear();
            }
            op_pressed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
               
        }

        private void ce_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void c_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button op_button = (Button)sender;
            op = op_button.Text;
            value = Convert.ToDouble(textBox1.Text);
            op_pressed = true;
            label1.Text = value + " " + op;
        }
        private void equal_button_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (op)
            {
                case "+":
                    textBox1.Text = (value + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }

        }
    }
}