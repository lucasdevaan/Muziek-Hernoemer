namespace Music_Renamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            folderButton = new Button();
            folderTextBox = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            outputTextBox = new RichTextBox();
            label1 = new Label();
            startButton = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 368);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(625, 29);
            progressBar1.TabIndex = 0;
            // 
            // folderButton
            // 
            folderButton.DialogResult = DialogResult.OK;
            folderButton.Location = new Point(546, 39);
            folderButton.Margin = new Padding(3, 2, 3, 2);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(91, 28);
            folderButton.TabIndex = 1;
            folderButton.Text = "Bladeren...";
            folderButton.UseVisualStyleBackColor = true;
            folderButton.Click += button1_Click;
            // 
            // folderTextBox
            // 
            folderTextBox.Location = new Point(12, 39);
            folderTextBox.Margin = new Padding(3, 2, 3, 2);
            folderTextBox.Name = "folderTextBox";
            folderTextBox.Size = new Size(528, 27);
            folderTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(12, 72);
            outputTextBox.Margin = new Padding(3, 2, 3, 2);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(625, 290);
            outputTextBox.TabIndex = 3;
            outputTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 4;
            label1.Text = "Kies een muziekmap:";
            label1.Click += label1_Click;
            // 
            // startButton
            // 
            startButton.Enabled = false;
            startButton.Font = new Font("Cabazon", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startButton.Location = new Point(546, 402);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(91, 29);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(12, 412);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 6;
            label2.Text = "versie 1.0 - snufjes 2024";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(449, 404);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(91, 29);
            button2.TabIndex = 7;
            button2.Text = "Reset\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 444);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(startButton);
            Controls.Add(label1);
            Controls.Add(outputTextBox);
            Controls.Add(folderTextBox);
            Controls.Add(folderButton);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Muziek Hernoemer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button folderButton;
        private TextBox folderTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private RichTextBox outputTextBox;
        private Label label1;
        private Button startButton;
        private Label label2;
        private Button button2;
    }
}
