namespace Practica_6__Do_while_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ri, Rs, sum = 0;

            Ri = int.Parse(textBox1.Text);
            Rs = int.Parse(textBox2.Text);
            for (int i = Ri; i <= Rs; i++)
            {
                listBox1.Items.Add(i);
                sum = sum + i;
            }
            textBox3.Text = sum.ToString();
        }
    }
}