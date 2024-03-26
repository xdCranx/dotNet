namespace Lab2_NASA
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
            pictureBox = new PictureBox();
            dateLabel = new Label();
            txtDate = new TextBox();
            getPicButton = new Button();
            urlBox = new TextBox();
            explanationBox = new TextBox();
            titleBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(24, 33);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1080, 720);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1263, 33);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(49, 25);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(1263, 69);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(150, 31);
            txtDate.TabIndex = 2;
            // 
            // getPicButton
            // 
            getPicButton.Location = new Point(1263, 154);
            getPicButton.Name = "getPicButton";
            getPicButton.Size = new Size(150, 68);
            getPicButton.TabIndex = 3;
            getPicButton.Text = "Get Pic!";
            getPicButton.UseVisualStyleBackColor = true;
            getPicButton.Click += btnLoad_Click;
            // 
            // urlBox
            // 
            urlBox.Location = new Point(1207, 117);
            urlBox.Name = "urlBox";
            urlBox.ReadOnly = true;
            urlBox.Size = new Size(255, 31);
            urlBox.TabIndex = 4;
            urlBox.Visible = false;
            // 
            // explanationBox
            // 
            explanationBox.Location = new Point(1110, 275);
            explanationBox.Multiline = true;
            explanationBox.Name = "explanationBox";
            explanationBox.ReadOnly = true;
            explanationBox.ScrollBars = ScrollBars.Vertical;
            explanationBox.Size = new Size(449, 478);
            explanationBox.TabIndex = 5;
            // 
            // titleBox
            // 
            titleBox.BorderStyle = BorderStyle.FixedSingle;
            titleBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleBox.Location = new Point(229, 759);
            titleBox.Name = "titleBox";
            titleBox.ReadOnly = true;
            titleBox.Size = new Size(653, 55);
            titleBox.TabIndex = 6;
            titleBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 860);
            Controls.Add(titleBox);
            Controls.Add(explanationBox);
            Controls.Add(urlBox);
            Controls.Add(getPicButton);
            Controls.Add(txtDate);
            Controls.Add(dateLabel);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label dateLabel;
        private TextBox txtDate;
        private Button getPicButton;
        private TextBox urlBox;
        private TextBox explanationBox;
        private TextBox titleBox;
    }
}
