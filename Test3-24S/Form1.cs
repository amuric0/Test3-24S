namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Make Windwos Form Aplacation That have a button when it clicked the value in the 1st text box is add to the sum in second text box
        int sum = 0;
        int Count = 0;
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);

            sum += x;
            Count++;
            textBox2.Text = sum.ToString();
            textBox3.Text = Count.ToString();
            double average = double.Parse(textBox2.Text) / double.Parse(textBox3.Text);

            textBox4.Text = average.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            textBox4.Text = 0.ToString();
            sum = 0;
            //averager = 0;
            Count = 0;
        }
    }
}
