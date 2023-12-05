using Microsoft.VisualBasic.Devices;

namespace StudentManagmentSystem
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        public TextBox TextBox1
        {
            get { return textBox1; }
        }

        public TextBox TextBox2
        {
            get { return textBox2; }
        }

        public ComboBox ComboBox1
        {
            get { return comboBox1; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            double Fee = Convert.ToDouble(textBox2.Text);
            string TimeDuration = comboBox1.Text;


            Form2 form2 = new Form2(Name, Fee, TimeDuration);
            form2.Show();
        }
        

    }


}
