
namespace HW4SimCardRegistration
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumBox2 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FemaleBtn = new System.Windows.Forms.RadioButton();
            this.MaleBtn = new System.Windows.Forms.RadioButton();
            this.Fname2 = new System.Windows.Forms.TextBox();
            this.Lname2 = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.MobileNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumBox2
            // 
            this.NumBox2.Location = new System.Drawing.Point(263, 149);
            this.NumBox2.Mask = "0000-000-0000";
            this.NumBox2.Name = "NumBox2";
            this.NumBox2.Size = new System.Drawing.Size(100, 20);
            this.NumBox2.TabIndex = 53;
            this.NumBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NumBox2_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(495, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(259, 328);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 49;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Location";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(259, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Birthday";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.StatusBox.Location = new System.Drawing.Point(474, 251);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 21);
            this.StatusBox.TabIndex = 45;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Sex";
            // 
            // FemaleBtn
            // 
            this.FemaleBtn.AutoSize = true;
            this.FemaleBtn.Location = new System.Drawing.Point(309, 251);
            this.FemaleBtn.Name = "FemaleBtn";
            this.FemaleBtn.Size = new System.Drawing.Size(59, 17);
            this.FemaleBtn.TabIndex = 42;
            this.FemaleBtn.TabStop = true;
            this.FemaleBtn.Text = "Female";
            this.FemaleBtn.UseVisualStyleBackColor = true;
            this.FemaleBtn.CheckedChanged += new System.EventHandler(this.FemaleBtn_CheckedChanged);
            // 
            // MaleBtn
            // 
            this.MaleBtn.AutoSize = true;
            this.MaleBtn.Location = new System.Drawing.Point(255, 251);
            this.MaleBtn.Name = "MaleBtn";
            this.MaleBtn.Size = new System.Drawing.Size(48, 17);
            this.MaleBtn.TabIndex = 41;
            this.MaleBtn.TabStop = true;
            this.MaleBtn.Text = "Male";
            this.MaleBtn.UseVisualStyleBackColor = true;
            this.MaleBtn.CheckedChanged += new System.EventHandler(this.MaleBtn_CheckedChanged);
            // 
            // Fname2
            // 
            this.Fname2.Location = new System.Drawing.Point(263, 192);
            this.Fname2.Name = "Fname2";
            this.Fname2.Size = new System.Drawing.Size(100, 20);
            this.Fname2.TabIndex = 40;
            this.Fname2.TextChanged += new System.EventHandler(this.Fname2_TextChanged);
            // 
            // Lname2
            // 
            this.Lname2.Location = new System.Drawing.Point(434, 192);
            this.Lname2.Name = "Lname2";
            this.Lname2.Size = new System.Drawing.Size(100, 20);
            this.Lname2.TabIndex = 39;
            this.Lname2.TextChanged += new System.EventHandler(this.Lname2_TextChanged);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(375, 195);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(53, 13);
            this.Lname.TabIndex = 38;
            this.Lname.Text = "Lastname";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(205, 195);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(52, 13);
            this.Fname.TabIndex = 37;
            this.Fname.Text = "Firstname";
            // 
            // MobileNum
            // 
            this.MobileNum.AutoSize = true;
            this.MobileNum.Location = new System.Drawing.Point(205, 152);
            this.MobileNum.Name = "MobileNum";
            this.MobileNum.Size = new System.Drawing.Size(38, 13);
            this.MobileNum.TabIndex = 36;
            this.MobileNum.Text = "Mobile";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FemaleBtn);
            this.Controls.Add(this.MaleBtn);
            this.Controls.Add(this.Fname2);
            this.Controls.Add(this.Lname2);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.MobileNum);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox NumBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FemaleBtn;
        private System.Windows.Forms.RadioButton MaleBtn;
        private System.Windows.Forms.TextBox Fname2;
        private System.Windows.Forms.TextBox Lname2;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label MobileNum;
    }
}