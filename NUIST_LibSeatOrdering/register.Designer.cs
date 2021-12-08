namespace NUIST_LibSeatOrdering
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.password_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.account_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_repeat_field = new System.Windows.Forms.TextBox();
            this.register_in = new System.Windows.Forms.Button();
            this.register_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(213, 69);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '❤';
            this.password_field.Size = new System.Drawing.Size(144, 25);
            this.password_field.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(130, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "学号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // account_field
            // 
            this.account_field.Location = new System.Drawing.Point(213, 22);
            this.account_field.Name = "account_field";
            this.account_field.Size = new System.Drawing.Size(144, 25);
            this.account_field.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(63, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "复读你的密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_repeat_field
            // 
            this.password_repeat_field.Location = new System.Drawing.Point(213, 118);
            this.password_repeat_field.Name = "password_repeat_field";
            this.password_repeat_field.PasswordChar = '❤';
            this.password_repeat_field.Size = new System.Drawing.Size(144, 25);
            this.password_repeat_field.TabIndex = 18;
            // 
            // register_in
            // 
            this.register_in.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.register_in.Location = new System.Drawing.Point(213, 194);
            this.register_in.Name = "register_in";
            this.register_in.Size = new System.Drawing.Size(180, 60);
            this.register_in.TabIndex = 19;
            this.register_in.Text = "成为图书馆大家庭的一员";
            this.register_in.UseVisualStyleBackColor = true;
            this.register_in.Click += new System.EventHandler(this.register_in_Click);
            // 
            // register_cancel
            // 
            this.register_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.register_cancel.Location = new System.Drawing.Point(66, 194);
            this.register_cancel.Name = "register_cancel";
            this.register_cancel.Size = new System.Drawing.Size(108, 60);
            this.register_cancel.TabIndex = 20;
            this.register_cancel.Text = "反悔(处分)";
            this.register_cancel.UseVisualStyleBackColor = true;
            this.register_cancel.Click += new System.EventHandler(this.register_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NUIST_LibSeatOrdering.Properties.Resources._849589_20171015224719590_1433219824;
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 10.28571F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "冒泡也好，选择也罢，结果都是无尽的排序……";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(473, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_cancel);
            this.Controls.Add(this.register_in);
            this.Controls.Add(this.password_repeat_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.account_field);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册就现在(｡･ω･｡)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox account_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_repeat_field;
        private System.Windows.Forms.Button register_in;
        private System.Windows.Forms.Button register_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}