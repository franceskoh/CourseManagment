using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagmentSystem
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public string Name { get; set; }
        public double Fee { get; set; }
        public string TimeDuration { get; set; }
        public string Title { get; set; }
        public string TopicsDescription { get; set; }
        public string Lecturer { get; set; }
        public string Location { get; set; }
        public Form3(string Name, double Fee, string TimeDuration, string Title, string TopicsDescription, string Lecturer, string Location)
        {
            InitializeComponent();
            instance = this;

            this.Name = Name;
            this.Fee = Fee;
            this.TimeDuration = TimeDuration;
            this.Title = Title;
            this.TopicsDescription = TopicsDescription;
            this.Location = Location;
            this.Lecturer = Lecturer;

            UpdateUI();
        }
        private void UpdateUI()
        {
            label1.Text = "Name: " + Name;
            label2.Text = $"Fee Amount: {Fee.ToString("C2", new System.Globalization.CultureInfo("en-GB"))}"; // Assumes FeeAmount is in currency format
            label3.Text = "Time Duration: " +TimeDuration;

            label4.Text = "Title: " +Title;
            label5.Text = "Topics Description: " +TopicsDescription;
            label6.Text = "Lecturer: " +Lecturer;
            label7.Text = "Location: " +Location;
        }

    }
}
