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
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(17, 20);
            pictureBox.Margin = new Padding(2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(757, 433);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(884, 20);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 15);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(884, 41);
            txtDate.Margin = new Padding(2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(106, 23);
            txtDate.TabIndex = 2;
            // 
            // getPicButton
            // 
            getPicButton.Location = new Point(884, 92);
            getPicButton.Margin = new Padding(2);
            getPicButton.Name = "getPicButton";
            getPicButton.Size = new Size(105, 41);
            getPicButton.TabIndex = 3;
            getPicButton.Text = "Get Pic!";
            getPicButton.UseVisualStyleBackColor = true;
            getPicButton.Click += btnLoad_Click;
            // 
            // urlBox
            // 
            urlBox.Location = new Point(845, 70);
            urlBox.Margin = new Padding(2);
            urlBox.Name = "urlBox";
            urlBox.ReadOnly = true;
            urlBox.Size = new Size(180, 23);
            urlBox.TabIndex = 4;
            urlBox.Visible = false;
            // 
            // explanationBox
            // 
            explanationBox.Location = new Point(485, 165);
            explanationBox.Margin = new Padding(2);
            explanationBox.Multiline = true;
            explanationBox.Name = "explanationBox";
            explanationBox.ReadOnly = true;
            explanationBox.ScrollBars = ScrollBars.Vertical;
            explanationBox.Size = new Size(316, 288);
            explanationBox.TabIndex = 5;
            // 
            // titleBox
            // 
            titleBox.BorderStyle = BorderStyle.FixedSingle;
            titleBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleBox.Location = new Point(17, 457);
            titleBox.Margin = new Padding(2);
            titleBox.Name = "titleBox";
            titleBox.ReadOnly = true;
            titleBox.Size = new Size(757, 39);
            titleBox.TabIndex = 6;
            titleBox.TextAlign = HorizontalAlignment.Center;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(831, 144);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 516);
            Controls.Add(monthCalendar1);
            Controls.Add(titleBox);
            Controls.Add(explanationBox);
            Controls.Add(urlBox);
            Controls.Add(getPicButton);
            Controls.Add(txtDate);
            Controls.Add(dateLabel);
            Controls.Add(pictureBox);
            Margin = new Padding(2);
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
        private MonthCalendar monthCalendar1;
    }
}
