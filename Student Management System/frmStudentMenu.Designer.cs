namespace Student_Management_System
{
    partial class frmStudentMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStuView = new System.Windows.Forms.Button();
            this.btnStuAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStuView);
            this.panel1.Controls.Add(this.btnStuAdd);
            this.panel1.Location = new System.Drawing.Point(10, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 516);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(285, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 504);
            this.panel2.TabIndex = 2;
            // 
            // btnStuView
            // 
            this.btnStuView.Location = new System.Drawing.Point(9, 86);
            this.btnStuView.Name = "btnStuView";
            this.btnStuView.Size = new System.Drawing.Size(253, 71);
            this.btnStuView.TabIndex = 1;
            this.btnStuView.Text = "button2";
            this.btnStuView.UseVisualStyleBackColor = true;
            this.btnStuView.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStuAdd
            // 
            this.btnStuAdd.Location = new System.Drawing.Point(9, 9);
            this.btnStuAdd.Name = "btnStuAdd";
            this.btnStuAdd.Size = new System.Drawing.Size(253, 71);
            this.btnStuAdd.TabIndex = 0;
            this.btnStuAdd.Text = "button1";
            this.btnStuAdd.UseVisualStyleBackColor = true;
            this.btnStuAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 529);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentMenu";
            this.Text = "frmStudentMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStuView;
        private System.Windows.Forms.Button btnStuAdd;
        private System.Windows.Forms.Panel panel2;
    }
}