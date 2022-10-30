namespace Calculator_WindowForms
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
            this.displaybox = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bClr = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bEql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displaybox
            // 
            this.displaybox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.displaybox.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.displaybox.Location = new System.Drawing.Point(3, 3);
            this.displaybox.Name = "displaybox";
            this.displaybox.ReadOnly = true;
            this.displaybox.Size = new System.Drawing.Size(261, 34);
            this.displaybox.TabIndex = 0;
            this.displaybox.Text = "0";
            this.displaybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n1.Location = new System.Drawing.Point(3, 40);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(76, 60);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n2.Location = new System.Drawing.Point(85, 40);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(81, 60);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n3.Location = new System.Drawing.Point(172, 40);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(84, 60);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n4.Location = new System.Drawing.Point(3, 106);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(76, 59);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n5.Location = new System.Drawing.Point(85, 106);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(81, 59);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n6.Location = new System.Drawing.Point(172, 106);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(84, 59);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n7.Location = new System.Drawing.Point(3, 171);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(76, 56);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n8.Location = new System.Drawing.Point(85, 171);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(81, 56);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n9.Location = new System.Drawing.Point(172, 171);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(84, 56);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.n0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n0.Location = new System.Drawing.Point(85, 233);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(79, 53);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bAdd.Location = new System.Drawing.Point(262, 40);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(84, 60);
            this.bAdd.TabIndex = 11;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSub
            // 
            this.bSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSub.Location = new System.Drawing.Point(262, 106);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(84, 59);
            this.bSub.TabIndex = 12;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = false;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bMul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bMul.Location = new System.Drawing.Point(262, 171);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(84, 56);
            this.bMul.TabIndex = 13;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDot.Location = new System.Drawing.Point(3, 230);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(76, 56);
            this.bDot.TabIndex = 14;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // bClr
            // 
            this.bClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bClr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bClr.Location = new System.Drawing.Point(172, 230);
            this.bClr.Name = "bClr";
            this.bClr.Size = new System.Drawing.Size(84, 56);
            this.bClr.TabIndex = 15;
            this.bClr.Text = "C";
            this.bClr.UseVisualStyleBackColor = false;
            this.bClr.Click += new System.EventHandler(this.bClr_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDiv.Location = new System.Drawing.Point(262, 230);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(84, 56);
            this.bDiv.TabIndex = 16;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bEql
            // 
            this.bEql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bEql.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bEql.Location = new System.Drawing.Point(129, 292);
            this.bEql.Name = "bEql";
            this.bEql.Size = new System.Drawing.Size(84, 56);
            this.bEql.TabIndex = 17;
            this.bEql.Text = "=";
            this.bEql.UseVisualStyleBackColor = false;
            this.bEql.Click += new System.EventHandler(this.bEql_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 368);
            this.Controls.Add(this.bEql);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bClr);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.displaybox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox displaybox;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button bAdd;
        private Button bSub;
        private Button bMul;
        private Button bDot;
        private Button bClr;
        private Button bDiv;
        private Button bEql;
    }
}