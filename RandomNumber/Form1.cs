namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num,s=0;
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "Ədəd daxil edin");

            if (textBox1.Text != "")
            {
                errorProvider1.Clear();

                int a = Convert.ToInt32(textBox1.Text);
                if (num == a)
                {
                    s++;
                    richTextBox1.Text= "Siz doğru tapdınız!\n"+ "Cəhd sayı: " + s;
                    textBox1.Enabled=false;
                    button1.Enabled = false;
                    textBox1.Clear();
                }
                else
                {
                    richTextBox1.Text = "Siz yalnış tapdınız!\n";
                    s++;
                    richTextBox1.Text += "Cəhd sayı: " + s + "\n";
                    if (num > a)
                    {
                        textBox1.Clear();
                        richTextBox1.Text += "Daxil etdiyiniz ədəd gizli ədəddən kiçikdir.\n";
                    }
                    else
                    {
                        textBox1.Clear();
                        richTextBox1.Text += "Daxil etdiyiniz ədəd gizli ədəddən böyükdür.\n";
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r= new Random();
            num = r.Next(1, 100);
            button1.Enabled=true;
            textBox1.Enabled = true;
        }
    }
}
