namespace RandomNumber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(38, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Axtarılan ədəd";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(38, 139);
            button1.Name = "button1";
            button1.Size = new Size(216, 38);
            button1.TabIndex = 2;
            button1.Text = "Yoxla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 228);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ədəd axtarışı";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(357, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(234, 166);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(357, 209);
            button2.Name = "button2";
            button2.Size = new Size(234, 38);
            button2.TabIndex = 5;
            button2.Text = "Yeni oyun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(610, 271);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random number";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}
