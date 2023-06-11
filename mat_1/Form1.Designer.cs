namespace mat_1
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
            cueTextBox1 = new YOUR_NAMESPACE_HERE.CueTextBox();
            Go_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cueTextBox1
            // 
            cueTextBox1.AutoCompleteMode = AutoCompleteMode.Append;
            cueTextBox1.Cue = "Enter number";
            cueTextBox1.Location = new Point(300, 230);
            cueTextBox1.Name = "cueTextBox1";
            cueTextBox1.Size = new Size(400, 27);
            cueTextBox1.TabIndex = 0;
            // 
            // Go_button
            // 
            Go_button.Location = new Point(450, 280);
            Go_button.Name = "Go_button";
            Go_button.Size = new Size(100, 29);
            Go_button.TabIndex = 1;
            Go_button.Text = "Go";
            Go_button.UseVisualStyleBackColor = true;
            Go_button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 330);
            label1.MaximumSize = new Size(400, 100);
            label1.MinimumSize = new Size(400, 100);
            label1.Name = "label1";
            label1.Size = new Size(400, 100);
            label1.TabIndex = 2;
            label1.Text = " ";
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(label1);
            Controls.Add(Go_button);
            Controls.Add(cueTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "Form1";
            Text = "Matematyka dyskretna";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private YOUR_NAMESPACE_HERE.CueTextBox cueTextBox1;
        private Button Go_button;
        private Label label1;
    }
}