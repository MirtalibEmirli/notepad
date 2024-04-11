namespace notepad
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            fontbox = new ComboBox();
            sizebox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            loadbox = new TextBox();
            savebox = new TextBox();
            loadbutton = new Button();
            savebutton = new Button();
            bold = new Button();
            italic = new Button();
            simple = new Button();
            colorDialog1 = new ColorDialog();
            button6 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1305, 601);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // fontbox
            // 
            fontbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            fontbox.FormattingEnabled = true;
            fontbox.Location = new Point(14, 35);
            fontbox.Name = "fontbox";
            fontbox.Size = new Size(151, 31);
            fontbox.TabIndex = 1;
            fontbox.SelectedIndexChanged += fontchanged;
            // 
            // sizebox
            // 
            sizebox.FormattingEnabled = true;
            sizebox.Location = new Point(190, 35);
            sizebox.Name = "sizebox";
            sizebox.Size = new Size(101, 28);
            sizebox.TabIndex = 2;
            sizebox.SelectedIndexChanged += sizechanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Font        ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 4;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Fontstyle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 9);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Size";
            // 
            // loadbox
            // 
            loadbox.Location = new Point(886, 12);
            loadbox.Name = "loadbox";
            loadbox.Size = new Size(286, 27);
            loadbox.TabIndex = 7;
            // 
            // savebox
            // 
            savebox.Location = new Point(886, 51);
            savebox.Name = "savebox";
            savebox.Size = new Size(286, 27);
            savebox.TabIndex = 8;
            // 
            // loadbutton
            // 
            loadbutton.Location = new Point(1202, 7);
            loadbutton.Name = "loadbutton";
            loadbutton.Size = new Size(94, 29);
            loadbutton.TabIndex = 10;
            loadbutton.Text = "Load";
            loadbutton.UseVisualStyleBackColor = true;
            loadbutton.Click += loadbutton_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(1202, 49);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(94, 29);
            savebutton.TabIndex = 11;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // bold
            // 
            bold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bold.Location = new Point(323, 32);
            bold.Name = "bold";
            bold.Size = new Size(28, 29);
            bold.TabIndex = 12;
            bold.Text = "B";
            bold.UseVisualStyleBackColor = true;
            bold.Click += bold_Click;
            // 
            // italic
            // 
            italic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            italic.Location = new Point(366, 32);
            italic.Name = "italic";
            italic.Size = new Size(28, 29);
            italic.TabIndex = 13;
            italic.Text = "I";
            italic.UseVisualStyleBackColor = true;
            italic.Click += italic_Click;
            // 
            // simple
            // 
            simple.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            simple.Location = new Point(415, 32);
            simple.Name = "simple";
            simple.Size = new Size(28, 29);
            simple.TabIndex = 14;
            simple.Text = "R";
            simple.UseVisualStyleBackColor = true;
            simple.Click += simple_Click;
            // 
            // button6
            // 
            button6.Location = new Point(491, 36);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 15;
            button6.Text = "select";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 688);
            Controls.Add(button6);
            Controls.Add(simple);
            Controls.Add(italic);
            Controls.Add(bold);
            Controls.Add(savebutton);
            Controls.Add(loadbutton);
            Controls.Add(savebox);
            Controls.Add(loadbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sizebox);
            Controls.Add(fontbox);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox fontbox;
        private ComboBox sizebox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox loadbox;
        private TextBox savebox;
        private Button loadbutton;
        private Button savebutton;
        private Button bold;
        private Button italic;
        private Button simple;
        private ColorDialog colorDialog1;
        private Button button6;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
