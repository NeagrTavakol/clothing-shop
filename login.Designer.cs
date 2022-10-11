
namespace foroshgahlebas
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.closss = new System.Windows.Forms.Button();
            this.textpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_Show_Hide = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // closss
            // 
            this.closss.BackColor = System.Drawing.Color.Maroon;
            this.closss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closss.FlatAppearance.BorderSize = 0;
            this.closss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closss.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.closss.ForeColor = System.Drawing.Color.Transparent;
            this.closss.Location = new System.Drawing.Point(21, 148);
            this.closss.Name = "closss";
            this.closss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.closss.Size = new System.Drawing.Size(236, 43);
            this.closss.TabIndex = 22;
            this.closss.Text = "خروج";
            this.closss.UseVisualStyleBackColor = false;
            this.closss.Click += new System.EventHandler(this.closss_Click);
            // 
            // textpass
            // 
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpass.Location = new System.Drawing.Point(109, 55);
            this.textpass.Multiline = true;
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '•';
            this.textpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textpass.Size = new System.Drawing.Size(116, 22);
            this.textpass.TabIndex = 19;
            this.textpass.TextChanged += new System.EventHandler(this.textpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(231, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "رمز عبور";
            // 
            // textuser
            // 
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textuser.Location = new System.Drawing.Point(109, 19);
            this.textuser.Multiline = true;
            this.textuser.Name = "textuser";
            this.textuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textuser.Size = new System.Drawing.Size(116, 22);
            this.textuser.TabIndex = 17;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(231, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام کاربری";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(21, 99);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(236, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.BackColor = System.Drawing.Color.Linen;
            this.checkBox_Show_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox_Show_Hide.ImageKey = "images.png";
            this.checkBox_Show_Hide.ImageList = this.imageList1;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(37, 58);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(44, 20);
            this.checkBox_Show_Hide.TabIndex = 23;
            this.checkBox_Show_Hide.UseVisualStyleBackColor = false;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye-icon.png");
            this.imageList1.Images.SetKeyName(1, "images.png");
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(309, 228);
            this.Controls.Add(this.checkBox_Show_Hide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closss);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closss;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide;
        private System.Windows.Forms.ImageList imageList1;
    }
}