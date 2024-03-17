namespace Lab1_GUI
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
            noi_text_box = new TextBox();
            seed_text_box = new TextBox();
            cap_text_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            res_text_box = new TextBox();
            label4 = new Label();
            instance_text_box = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // noi_text_box
            // 
            noi_text_box.Location = new Point(82, 59);
            noi_text_box.Margin = new Padding(2);
            noi_text_box.Name = "noi_text_box";
            noi_text_box.Size = new Size(106, 23);
            noi_text_box.TabIndex = 0;
            noi_text_box.TextChanged += noi_text_box_TextChanged;
            // 
            // seed_text_box
            // 
            seed_text_box.Location = new Point(82, 99);
            seed_text_box.Margin = new Padding(2);
            seed_text_box.Name = "seed_text_box";
            seed_text_box.Size = new Size(106, 23);
            seed_text_box.TabIndex = 1;
            seed_text_box.TextChanged += seed_text_box_TextChanged;
            // 
            // cap_text_box
            // 
            cap_text_box.Location = new Point(82, 138);
            cap_text_box.Margin = new Padding(2);
            cap_text_box.Name = "cap_text_box";
            cap_text_box.Size = new Size(106, 23);
            cap_text_box.TabIndex = 2;
            cap_text_box.TextChanged += cap_text_box_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "number of items:\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 121);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "capacity";
            label3.Click += label3_Click;
            // 
            // res_text_box
            // 
            res_text_box.Location = new Point(8, 231);
            res_text_box.Margin = new Padding(2);
            res_text_box.Multiline = true;
            res_text_box.Name = "res_text_box";
            res_text_box.ReadOnly = true;
            res_text_box.ScrollBars = ScrollBars.Vertical;
            res_text_box.Size = new Size(260, 304);
            res_text_box.TabIndex = 6;
            res_text_box.TextChanged += result_text_box_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 214);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "result\r\n";
            // 
            // instance_text_box
            // 
            instance_text_box.Location = new Point(279, 56);
            instance_text_box.Margin = new Padding(2);
            instance_text_box.Multiline = true;
            instance_text_box.Name = "instance_text_box";
            instance_text_box.ReadOnly = true;
            instance_text_box.ScrollBars = ScrollBars.Vertical;
            instance_text_box.Size = new Size(274, 479);
            instance_text_box.TabIndex = 8;
            instance_text_box.TextChanged += instance_text_box_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 40);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "instance";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(66, 176);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(134, 38);
            button1.TabIndex = 10;
            button1.Text = "SOLVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(559, 540);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(instance_text_box);
            Controls.Add(label4);
            Controls.Add(res_text_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cap_text_box);
            Controls.Add(seed_text_box);
            Controls.Add(noi_text_box);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Knapsack";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox noi_text_box;
        private TextBox seed_text_box;
        private TextBox cap_text_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox res_text_box;
        private Label label4;
        private TextBox instance_text_box;
        private Label label5;
        private Button button1;
    }
}
