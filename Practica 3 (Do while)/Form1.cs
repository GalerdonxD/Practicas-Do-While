namespace Practica_3__Do_while_
{
    public partial class Form1 : Form
    {
        float fnum, total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

            fnum = float.Parse(textBox1.Text);
            total += fnum;
            textBox1.Text = " ";
            textBox1.Focus();
        }
    }
}