namespace iw4x_Playlist_Generator
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
            this.mapCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.generatedText = new System.Windows.Forms.TextBox();
            this.randomToggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mapCheckedListBox
            // 
            this.mapCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapCheckedListBox.CheckOnClick = true;
            this.mapCheckedListBox.FormattingEnabled = true;
            this.mapCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.mapCheckedListBox.Name = "mapCheckedListBox";
            this.mapCheckedListBox.Size = new System.Drawing.Size(394, 832);
            this.mapCheckedListBox.TabIndex = 0;
            this.mapCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // generatedText
            // 
            this.generatedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatedText.Location = new System.Drawing.Point(12, 877);
            this.generatedText.Multiline = true;
            this.generatedText.Name = "generatedText";
            this.generatedText.Size = new System.Drawing.Size(394, 23);
            this.generatedText.TabIndex = 1;
            // 
            // randomToggle
            // 
            this.randomToggle.AutoSize = true;
            this.randomToggle.Location = new System.Drawing.Point(12, 852);
            this.randomToggle.Name = "randomToggle";
            this.randomToggle.Size = new System.Drawing.Size(135, 19);
            this.randomToggle.TabIndex = 2;
            this.randomToggle.Text = "Randomize selection";
            this.randomToggle.UseVisualStyleBackColor = false;
            this.randomToggle.CheckedChanged += new System.EventHandler(this.RandomToggle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 913);
            this.Controls.Add(this.randomToggle);
            this.Controls.Add(this.generatedText);
            this.Controls.Add(this.mapCheckedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox generatedText;
        public CheckedListBox mapCheckedListBox;
        public CheckBox randomToggle;
    }
}