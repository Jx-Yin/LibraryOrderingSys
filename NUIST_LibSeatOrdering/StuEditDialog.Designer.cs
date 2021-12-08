namespace NUIST_LibSeatOrdering
{
    partial class StuEditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuEditDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.orderedCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blocked_check = new System.Windows.Forms.CheckBox();
            this.blocked = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(110, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(80, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "预约情况";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountField
            // 
            this.accountField.Location = new System.Drawing.Point(194, 32);
            this.accountField.Name = "accountField";
            this.accountField.Size = new System.Drawing.Size(144, 25);
            this.accountField.TabIndex = 4;
            this.accountField.TextChanged += new System.EventHandler(this.accountField_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(194, 94);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(144, 25);
            this.passwordField.TabIndex = 5;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(396, 265);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(93, 41);
            this.OKbutton.TabIndex = 7;
            this.OKbutton.Text = "保存";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(65, 265);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(93, 41);
            this.Cancelbutton.TabIndex = 8;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // orderedCheck
            // 
            this.orderedCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderedCheck.Location = new System.Drawing.Point(194, 156);
            this.orderedCheck.Name = "orderedCheck";
            this.orderedCheck.Size = new System.Drawing.Size(79, 25);
            this.orderedCheck.TabIndex = 9;
            this.orderedCheck.Text = "是";
            this.orderedCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderedCheck.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Violet;
            this.pictureBox1.Image = global::NUIST_LibSeatOrdering.Properties.Resources._9ec6b93eb13533fab0c443cba5d3fd1f40345b87;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // blocked_check
            // 
            this.blocked_check.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blocked_check.Location = new System.Drawing.Point(194, 208);
            this.blocked_check.Name = "blocked_check";
            this.blocked_check.Size = new System.Drawing.Size(79, 25);
            this.blocked_check.TabIndex = 11;
            this.blocked_check.Text = "是";
            this.blocked_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blocked_check.UseVisualStyleBackColor = false;
            // 
            // blocked
            // 
            this.blocked.BackColor = System.Drawing.Color.Violet;
            this.blocked.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.blocked.Location = new System.Drawing.Point(80, 208);
            this.blocked.Name = "blocked";
            this.blocked.Size = new System.Drawing.Size(77, 25);
            this.blocked.TabIndex = 10;
            this.blocked.Text = "惩罚情况";
            this.blocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StuEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 364);
            this.Controls.Add(this.blocked_check);
            this.Controls.Add(this.blocked);
            this.Controls.Add(this.orderedCheck);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.accountField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StuEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账户编辑界面( ゜- ゜)つロ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.CheckBox orderedCheck;
        private System.Windows.Forms.CheckBox blocked_check;
        private System.Windows.Forms.Label blocked;
    }
}