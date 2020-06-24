namespace Meter
{
    using Meter.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form4 : Form
    {
        private int rkts = -1;
        private int select = -1;
        private IContainer components;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;

        public Form4(int a, int b)
        {
            this.InitializeComponent();
            this.rkts = a;
            this.select = b;
            this.showLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form3(this.rkts).ShowDialog();
            base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form4));
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.button2 = new Button();
            this.button1 = new Button();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Algerian", 25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = SystemColors.HotTrack;
            this.label1.Location = new Point(0x15d, 0x30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0xa9, 0x2e);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.DarkOrchid;
            this.label2.Location = new Point(0x11a, 0xa4);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x14c, 0x27);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Testing completed";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.DarkOrchid;
            this.label3.Location = new Point(0x11a, 0xe3);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0, 0x27);
            this.label3.TabIndex = 2;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.DarkOrchid;
            this.label4.Location = new Point(0x11a, 0x121);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0, 0x27);
            this.label4.TabIndex = 3;
            this.button2.Image = Resources.close;
            this.button2.Location = new Point(0x30b, 410);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x48, 0x26);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Image = Resources.back;
            this.button1.Location = new Point(60, 410);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4d, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x39a, 0x1f5);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form4";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Result";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void showLabel()
        {
            if ((this.rkts == 1) && (this.select == 1))
            {
                this.label3.Text = "2. Guided rocket is QC Passed";
                this.label4.Text = "3. Rkts is ready to fire";
                this.label3.BackColor = Color.Green;
                this.label4.BackColor = Color.Green;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
            }
            else if ((this.rkts == 1) && (this.select == 0))
            {
                this.label3.Text = "2. Guided rocket is not QC Passed";
                this.label4.Text = "3. Rkts is not ready to fire";
                this.label3.BackColor = Color.Red;
                this.label4.BackColor = Color.Red;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
            }
            else if ((this.rkts == 2) && (this.select == 1))
            {
                this.label3.Text = "2. Unguided rocket is QC Passed";
                this.label4.Text = "3. Rkts is ready to fire";
                this.label3.BackColor = Color.Green;
                this.label4.BackColor = Color.Green;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
            }
            else if ((this.rkts == 2) && (this.select == 0))
            {
                this.label3.Text = "2. Unuided rocket is not QC Passed";
                this.label4.Text = "3. Rkts is not ready to fire";
                this.label3.BackColor = Color.Red;
                this.label4.BackColor = Color.Red;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
            }
        }
    }
}

