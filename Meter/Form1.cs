namespace Meter
{
    using Meter.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private int val = -1;
        private IContainer components;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;

        public Form1()
        {
            this.InitializeComponent();
            this.radioButton1.Checked = true;
            this.radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form2(this.val).ShowDialog();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.label1 = new Label();
            this.button1 = new Button();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            base.SuspendLayout();
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.radioButton1.ForeColor = Color.DarkOrchid;
            this.radioButton1.Location = new Point(0x12a, 0xc5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(0xad, 0x21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Guided Rkts";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.radioButton2.ForeColor = Color.DarkOrchid;
            this.radioButton2.Location = new Point(0x12a, 0x153);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(200, 0x21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Unguided Rkts";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 22.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Tomato;
            this.label1.Location = new Point(260, 0x23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x141, 0x2c);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rocket Selection";
            this.button1.Image = Resources.go;
            this.button1.Location = new Point(0x30b, 410);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4d, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.pictureBox2.Image = Resources.unguided1;
            this.pictureBox2.Location = new Point(0x10c, 0x111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x139, 50);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox1.Image = Resources.guided1;
            this.pictureBox1.Location = new Point(0x10c, 0x80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x139, 50);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x39a, 0x1f5);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.radioButton2);
            base.Controls.Add(this.radioButton1);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form1";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Rocket Testing-MLRSWS22";
            ((ISupportInitialize) this.pictureBox2).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.val = 1;
                this.radioButton2.Checked = false;
                this.radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.val = 2;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = true;
            }
        }
    }
}

