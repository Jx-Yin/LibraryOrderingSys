namespace NUIST_LibSeatOrdering
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.welcome = new System.Windows.Forms.Label();
            this.title_box = new System.Windows.Forms.Label();
            this.Password_change_button = new System.Windows.Forms.Button();
            this.Call_admin_button = new System.Windows.Forms.Button();
            this.Message_button = new System.Windows.Forms.Button();
            this.Blocked_check_button = new System.Windows.Forms.Button();
            this.Seat_info_button = new System.Windows.Forms.Button();
            this.Order_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(200, 74);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(0, 15);
            this.welcome.TabIndex = 1;
            // 
            // title_box
            // 
            this.title_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_box.BackColor = System.Drawing.Color.Transparent;
            this.title_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_box.Font = new System.Drawing.Font("幼圆", 26.01681F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_box.Location = new System.Drawing.Point(224, 63);
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(560, 45);
            this.title_box.TabIndex = 12;
            this.title_box.Text = "图书馆座位预约系统客户端";
            this.title_box.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Password_change_button
            // 
            this.Password_change_button.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password_change_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password_change_button.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.Password_change_button.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Password_change_button.Location = new System.Drawing.Point(553, 453);
            this.Password_change_button.Name = "Password_change_button";
            this.Password_change_button.Size = new System.Drawing.Size(167, 78);
            this.Password_change_button.TabIndex = 18;
            this.Password_change_button.Text = "修改密码";
            this.Password_change_button.UseVisualStyleBackColor = true;
            this.Password_change_button.Click += new System.EventHandler(this.Password_change_button_Click);
            // 
            // Call_admin_button
            // 
            this.Call_admin_button.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Call_admin_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Call_admin_button.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.Call_admin_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Call_admin_button.Location = new System.Drawing.Point(167, 582);
            this.Call_admin_button.Name = "Call_admin_button";
            this.Call_admin_button.Size = new System.Drawing.Size(167, 78);
            this.Call_admin_button.TabIndex = 17;
            this.Call_admin_button.Text = "联系管理员";
            this.Call_admin_button.UseVisualStyleBackColor = true;
            this.Call_admin_button.Click += new System.EventHandler(this.Call_admin_button_Click);
            // 
            // Message_button
            // 
            this.Message_button.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Message_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Message_button.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.Message_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Message_button.Location = new System.Drawing.Point(553, 582);
            this.Message_button.Name = "Message_button";
            this.Message_button.Size = new System.Drawing.Size(167, 78);
            this.Message_button.TabIndex = 16;
            this.Message_button.Text = "退出登录";
            this.Message_button.UseVisualStyleBackColor = true;
            this.Message_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Blocked_check_button
            // 
            this.Blocked_check_button.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Blocked_check_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Blocked_check_button.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.Blocked_check_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blocked_check_button.Location = new System.Drawing.Point(167, 453);
            this.Blocked_check_button.Name = "Blocked_check_button";
            this.Blocked_check_button.Size = new System.Drawing.Size(167, 78);
            this.Blocked_check_button.TabIndex = 15;
            this.Blocked_check_button.Text = "违规记录  查询";
            this.Blocked_check_button.UseVisualStyleBackColor = true;
            this.Blocked_check_button.Click += new System.EventHandler(this.Blocked_check_button_Click);
            // 
            // Seat_info_button
            // 
            this.Seat_info_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seat_info_button.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Seat_info_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Seat_info_button.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.Seat_info_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Seat_info_button.Location = new System.Drawing.Point(553, 330);
            this.Seat_info_button.Name = "Seat_info_button";
            this.Seat_info_button.Size = new System.Drawing.Size(167, 78);
            this.Seat_info_button.TabIndex = 14;
            this.Seat_info_button.Text = "图书馆官网";
            this.Seat_info_button.UseVisualStyleBackColor = true;
            this.Seat_info_button.Click += new System.EventHandler(this.Seat_info_button_Click);
            // 
            // Order_button
            // 
            this.Order_button.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Order_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_button.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.Order_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Order_button.Location = new System.Drawing.Point(167, 330);
            this.Order_button.Name = "Order_button";
            this.Order_button.Size = new System.Drawing.Size(167, 78);
            this.Order_button.TabIndex = 13;
            this.Order_button.Text = "座位预约";
            this.Order_button.UseVisualStyleBackColor = true;
            this.Order_button.Click += new System.EventHandler(this.Order_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NUIST_LibSeatOrdering.Properties.Resources.mmexporta5775139953304614faa9367f9bb7b46;
            this.pictureBox1.Location = new System.Drawing.Point(-62, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.button1.Location = new System.Drawing.Point(553, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 78);
            this.button1.TabIndex = 19;
            this.button1.Text = "预约须知";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("幼圆", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::NUIST_LibSeatOrdering.Properties.Resources._1573718974_IMG_20210404_105737_1617505057000_xg_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(167, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 78);
            this.button2.TabIndex = 20;
            this.button2.Text = "预约情况";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 737);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password_change_button);
            this.Controls.Add(this.Call_admin_button);
            this.Controls.Add(this.Message_button);
            this.Controls.Add(this.Blocked_check_button);
            this.Controls.Add(this.Seat_info_button);
            this.Controls.Add(this.Order_button);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label title_box;
        private System.Windows.Forms.Button Order_button;
        private System.Windows.Forms.Button Seat_info_button;
        private System.Windows.Forms.Button Blocked_check_button;
        private System.Windows.Forms.Button Message_button;
        private System.Windows.Forms.Button Call_admin_button;
        private System.Windows.Forms.Button Password_change_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}