﻿namespace StudentManagmentSystem
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 42);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 71);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Fee :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 103);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Time Duration :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 136);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 166);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 4;
            label5.Text = "Topics Description :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 197);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Lecturer :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 226);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 6;
            label7.Text = "Location :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(71, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 296);
            panel1.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(256, 28);
            label8.Name = "label8";
            label8.Size = new Size(310, 49);
            label8.TabIndex = 8;
            label8.Text = "Course Data";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "CourseData";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label8;
    }
}