namespace QLSV
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
            txtName = new TextBox();
            btn = new Button();
            txtDate = new DateTimePicker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtMaSV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cboGender = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // btn
            // 
            btn.Location = new Point(298, 248);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 1;
            btn.Text = "Lưu";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(214, 131);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(259, 23);
            txtDate.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(214, 80);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(259, 23);
            txtMaSV.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 43);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 88);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 8;
            label2.Text = "Mã sinh viên";
            label2.Click += Form1_Load;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 137);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 9;
            label3.Text = "Ngày, tháng, năm sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 173);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(214, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(259, 23);
            txtPhone.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 208);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 12;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 177);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 13;
            label6.Text = "Giói tinh";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(214, 173);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 23);
            cboGender.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboGender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaSV);
            Controls.Add(txtDate);
            Controls.Add(btn);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btn;
        private DateTimePicker txtDate;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMaSV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private Label label6;
        private ComboBox cboGender;
    }
}
