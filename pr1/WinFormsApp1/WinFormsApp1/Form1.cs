namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
