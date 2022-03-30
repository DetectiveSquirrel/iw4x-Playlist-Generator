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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.generatedText = new System.Windows.Forms.TextBox();
            this.randomToggle = new System.Windows.Forms.CheckBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.importTextBbox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.mapCheckedListBox.Size = new System.Drawing.Size(394, 814);
            this.mapCheckedListBox.TabIndex = 0;
            this.mapCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // generatedText
            // 
            this.generatedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatedText.Location = new System.Drawing.Point(12, 904);
            this.generatedText.Name = "generatedText";
            this.generatedText.Size = new System.Drawing.Size(302, 23);
            this.generatedText.TabIndex = 1;
            // 
            // randomToggle
            // 
            this.randomToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.randomToggle.AutoSize = true;
            this.randomToggle.Location = new System.Drawing.Point(12, 879);
            this.randomToggle.Name = "randomToggle";
            this.randomToggle.Size = new System.Drawing.Size(135, 19);
            this.randomToggle.TabIndex = 2;
            this.randomToggle.Text = "Randomize selection";
            this.randomToggle.UseVisualStyleBackColor = false;
            this.randomToggle.CheckedChanged += new System.EventHandler(this.RandomToggle_CheckedChanged);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(320, 903);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(86, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy!";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // importTextBbox
            // 
            this.importTextBbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importTextBbox.Location = new System.Drawing.Point(12, 833);
            this.importTextBbox.Name = "importTextBbox";
            this.importTextBbox.Size = new System.Drawing.Size(302, 23);
            this.importTextBbox.TabIndex = 4;
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Location = new System.Drawing.Point(320, 833);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(86, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 867);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 2);
            this.label1.TabIndex = 6;
            this.label1.Text = "DividerLabel";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(320, 875);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Uncheck All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UncheckAllButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 939);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.importTextBbox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.randomToggle);
            this.Controls.Add(this.generatedText);
            this.Controls.Add(this.mapCheckedListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "iw4x Playlist Generator";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox generatedText;
        public CheckedListBox mapCheckedListBox;
        public CheckBox randomToggle;
        private Button copyButton;
        private TextBox importTextBbox;
        private Button importButton;
        private BindingSource bindingSource1;
        private Label label1;
        private Button button1;
    }
}