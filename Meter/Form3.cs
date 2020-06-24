namespace Meter
{
    using Meter.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO.Ports;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class Form3 : Form
    {
        private string[] sPorts;
        private SerialPort Port;
        private bool isConnected;
        private int val = -1;
        private int flag;
        private IContainer components;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripProgressBar toolStripProgressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ToolStripComboBox toolStripComboBox1;

        public Form3(int rad)
        {
            this.InitializeComponent();
            this.val = rad;
            this.getPortName();
            this.button1.BackColor = Color.Gray;
            this.button2.BackColor = Color.Gray;
            this.button3.BackColor = Color.Gray;
            this.button4.BackColor = Color.Gray;
            this.button6.Enabled = false;
            this.textBox1.GotFocus += new EventHandler(this.textBox1_GotFocus);
            this.textBox2.GotFocus += new EventHandler(this.textBox1_GotFocus);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!this.isConnected)
            {
                base.Hide();
                new Form2(this.val).ShowDialog();
                base.Close();
            }
            else
            {
                this.disconnectFromArduino();
                base.Hide();
                new Form2(this.val).ShowDialog();
                base.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.disconnectFromArduino();
            base.Hide();
            new Form4(this.val, this.flag).ShowDialog();
            base.Close();
        }

        private void connectToArduino()
        {
            string portName = this.toolStripComboBox1.SelectedItem.ToString();
            try
            {
                this.isConnected = true;
                this.Port = new SerialPort(portName, 0x2580, Parity.None, 8, StopBits.One);
                this.toolStripButton1.Image = Resources.connected;
                this.toolStripButton1.Text = "Connected";
                this.toolStripButton2.Enabled = true;
            }
            catch (Exception)
            {
                this.isConnected = false;
                MessageBox.Show("COM Port is not selected");
                this.toolStripButton2.Enabled = false;
            }
        }

        private void disconnectFromArduino()
        {
            this.isConnected = false;
            this.Port.Close();
            this.toolStripButton1.Image = Resources.disconnected;
            this.toolStripButton1.Text = "Disconnected";
            this.toolStripButton2.Enabled = false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void getPortName()
        {
            this.sPorts = SerialPort.GetPortNames();
            foreach (string str in this.sPorts)
            {
                this.toolStripComboBox1.Items.Add(str);
                if (this.sPorts[0] != null)
                {
                    this.toolStripComboBox1.SelectedItem = this.sPorts[0];
                }
            }
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form3));
            this.toolStrip1 = new ToolStrip();
            this.toolStripComboBox1 = new ToolStripComboBox();
            this.toolStripProgressBar1 = new ToolStripProgressBar();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.backgroundWorker1 = new BackgroundWorker();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button6 = new Button();
            this.button5 = new Button();
            this.toolStripButton1 = new ToolStripButton();
            this.toolStripButton2 = new ToolStripButton();
            this.toolStrip1.SuspendLayout();
            base.SuspendLayout();
            this.toolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripComboBox1, this.toolStripButton1, this.toolStripButton2, this.toolStripProgressBar1 };
            this.toolStrip1.Items.AddRange(toolStripItems);
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(0x39a, 0x1c);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new Size(0x79, 0x1c);
            this.toolStripComboBox1.Text = "PORTS";
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new Size(100, 0x19);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Algerian", 19.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = SystemColors.HotTrack;
            this.label1.Location = new Point(0x16e, 80);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x90, 0x24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testing";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.DarkOrchid;
            this.label2.Location = new Point(0xc3, 0xb0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0xaf, 0x1f);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guided Rkts";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.DarkOrchid;
            this.label3.Location = new Point(0xc3, 0x115);
            this.label3.Name = "label3";
            this.label3.Size = new Size(190, 0x1f);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unuided Rkts";
            this.textBox1.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = Color.Red;
            this.textBox1.Location = new Point(420, 0xb0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(100, 0x22);
            this.textBox1.TabIndex = 2;
            this.textBox2.Cursor = Cursors.Default;
            this.textBox2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.Red;
            this.textBox2.Location = new Point(420, 0x112);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(100, 0x22);
            this.textBox2.TabIndex = 2;
            this.button1.BackColor = SystemColors.Control;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.ForeColor = SystemColors.ControlText;
            this.button1.Location = new Point(0x248, 0xaf);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x3f, 0x23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Location = new Point(0x2ae, 0xaf);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x3f, 0x23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Location = new Point(0x248, 0x110);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x3f, 0x23);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.Location = new Point(0x2ae, 0x110);
            this.button4.Name = "button4";
            this.button4.Size = new Size(0x3f, 0x23);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button6.Image = Resources.go;
            this.button6.Location = new Point(0x30b, 410);
            this.button6.Name = "button6";
            this.button6.Size = new Size(0x3f, 0x24);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.button5.Image = Resources.back;
            this.button5.Location = new Point(60, 410);
            this.button5.Name = "button5";
            this.button5.Size = new Size(0x4d, 40);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = Resources.disconnected;
            this.toolStripButton1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new Size(0x18, 0x19);
            this.toolStripButton1.Text = "Disconnected";
            this.toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
            this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = Resources.go;
            this.toolStripButton2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new Size(0x18, 0x19);
            this.toolStripButton2.Text = "Show";
            this.toolStripButton2.Click += new EventHandler(this.toolStripButton2_Click);
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x39a, 0x1f5);
            base.Controls.Add(this.button6);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.toolStrip1);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form3";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Testing";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void Read()
        {
            double data = 0.0;
            int count = 1;
            while (this.Port.IsOpen)
            {
                try
                {
                    string s = this.Port.ReadLine();
                    data += double.Parse(s);
                    count++;
                    Console.Out.WriteLine(s);
                    if (count > 20)
                    {
                        this.SetText(data, count);
                        break;
                    }
                }
                catch (Exception exception)
                {
                    Console.Out.WriteLine(exception);
                }
            }
        }

        private void SetText(double data, int count)
        {
            double num = data / ((double) count);
            decimal num2 = Convert.ToDecimal($"{num:F2}");
            Console.Out.WriteLine(num2);
            if (this.val == 1)
            {
                this.button6.Enabled = true;
                if ((num >= 0.4) && (num <= 2.6))
                {
                    this.textBox1.Text = "0.6 ohm";
                    this.button1.BackColor = Color.Green;
                    this.button2.BackColor = Color.Gray;
                    this.flag = 1;
                }
                else
                {
                    this.textBox1.Text = "4.8 ohm";
                    this.button1.BackColor = Color.Gray;
                    this.button2.BackColor = Color.Red;
                    this.flag = 0;
                }
            }
            else if (this.val == 2)
            {
                this.button6.Enabled = true;
                if ((num >= 2.6) && (num <= 6.0))
                {
                    this.textBox2.Text = "2.2 ohm";
                    this.button3.BackColor = Color.Green;
                    this.button4.BackColor = Color.Gray;
                    this.flag = 1;
                }
                else
                {
                    this.textBox2.Text = "4.9 ohm";
                    this.button3.BackColor = Color.Gray;
                    this.button4.BackColor = Color.Red;
                    this.flag = 0;
                }
            }
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            ((TextBox) sender).Parent.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!this.isConnected)
            {
                this.connectToArduino();
            }
            else
            {
                this.disconnectFromArduino();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Port.Open();
            this.Read();
        }

        private delegate void SetTextCallback(string text);
    }
}

