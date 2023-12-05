using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2(string Name, double Fee, string TimeDuration)
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Title = textBox1.Text;
            string TopicsDescription = richTextBox1.Text;
            string Lecturer = textBox3.Text;
            string Location = comboBox1.Text;

            Form3 form3 = new Form3(
                Form1.instance.TextBox1.Text,
                Convert.ToDouble(Form1.instance.TextBox2.Text),
                Form1.instance.ComboBox1.Text,
                Title,
                TopicsDescription,
                Lecturer,
                Location
            );
            form3.Show();
        }
    }
}
