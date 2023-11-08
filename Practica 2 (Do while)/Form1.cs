namespace Practica_2__Do_while_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0, limite,
            b = int.Parse(textBox1.Text);
            limite = int.Parse(textBox2.Text);

            do
            {
                listBox1.Items.Add(b + " * " + count + " = " + b * count);
                count++;
            }

            while (count <= limite);
        }
    }
}