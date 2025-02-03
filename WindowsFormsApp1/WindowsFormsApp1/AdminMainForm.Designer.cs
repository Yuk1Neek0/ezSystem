namespace WindowsFormsApp1
{
    partial class AdminMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.student_Sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_Program = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.student_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.student_ID = new System.Windows.Forms.TextBox();
            this.student_Data = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.student_Sex);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.student_Program);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.student_LastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.student_FirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.student_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 661);
            this.panel1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(180, 539);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 46);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(32, 539);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 46);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(180, 436);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 46);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(32, 436);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 46);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // student_Sex
            // 
            this.student_Sex.FormattingEnabled = true;
            this.student_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.student_Sex.Location = new System.Drawing.Point(65, 242);
            this.student_Sex.Name = "student_Sex";
            this.student_Sex.Size = new System.Drawing.Size(178, 21);
            this.student_Sex.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Program";
            // 
            // student_Program
            // 
            this.student_Program.Location = new System.Drawing.Point(65, 296);
            this.student_Program.Name = "student_Program";
            this.student_Program.Size = new System.Drawing.Size(178, 20);
            this.student_Program.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // student_LastName
            // 
            this.student_LastName.Location = new System.Drawing.Point(65, 189);
            this.student_LastName.Name = "student_LastName";
            this.student_LastName.Size = new System.Drawing.Size(178, 20);
            this.student_LastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // student_FirstName
            // 
            this.student_FirstName.Location = new System.Drawing.Point(65, 139);
            this.student_FirstName.Name = "student_FirstName";
            this.student_FirstName.Size = new System.Drawing.Size(178, 20);
            this.student_FirstName.TabIndex = 2;
            this.student_FirstName.TextChanged += new System.EventHandler(this.student_FirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student\'s ID";
            // 
            // student_ID
            // 
            this.student_ID.Location = new System.Drawing.Point(65, 86);
            this.student_ID.Name = "student_ID";
            this.student_ID.Size = new System.Drawing.Size(178, 20);
            this.student_ID.TabIndex = 0;
            // 
            // student_Data
            // 
            this.student_Data.AllowUserToAddRows = false;
            this.student_Data.AllowUserToDeleteRows = false;
            this.student_Data.AllowUserToResizeColumns = false;
            this.student_Data.AllowUserToResizeRows = false;
            this.student_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_Data.Dock = System.Windows.Forms.DockStyle.Right;
            this.student_Data.Location = new System.Drawing.Point(316, 0);
            this.student_Data.Name = "student_Data";
            this.student_Data.Size = new System.Drawing.Size(889, 661);
            this.student_Data.TabIndex = 2;
            this.student_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(1179, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(14, 13);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(48, 359);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(211, 47);
            this.showBtn.TabIndex = 17;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // AdminMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 661);
            this.Controls.Add(this.close);
            this.Controls.Add(this.student_Data);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox student_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_Program;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox student_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox student_Sex;
        private System.Windows.Forms.DataGridView student_Data;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button showBtn;
    }
}