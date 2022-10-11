
namespace foroshgahlebas
{
    partial class newcustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newcustomer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpostalcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edite = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.sabt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.phonenumber,
            this.address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 712);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "نام مشتری";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "شماره تلفن";
            this.phonenumber.MinimumWidth = 6;
            this.phonenumber.Name = "phonenumber";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "آدرس";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtpname.Location = new System.Drawing.Point(879, 23);
            this.txtpname.Multiline = true;
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(220, 30);
            this.txtpname.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(1133, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 54;
            this.label4.Text = "نام مشتری";
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtnumber.Location = new System.Drawing.Point(879, 73);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(220, 30);
            this.txtnumber.TabIndex = 57;
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(1133, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "شماره تلفن";
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcity.Location = new System.Drawing.Point(879, 181);
            this.txtcity.Multiline = true;
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(256, 37);
            this.txtcity.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(1155, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "شهر";
            // 
            // txtstreet
            // 
            this.txtstreet.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtstreet.Location = new System.Drawing.Point(879, 224);
            this.txtstreet.Multiline = true;
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(256, 37);
            this.txtstreet.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(1155, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 27);
            this.label3.TabIndex = 60;
            this.label3.Text = "خیابان";
            // 
            // txtpostalcode
            // 
            this.txtpostalcode.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtpostalcode.Location = new System.Drawing.Point(879, 267);
            this.txtpostalcode.Multiline = true;
            this.txtpostalcode.Name = "txtpostalcode";
            this.txtpostalcode.Size = new System.Drawing.Size(256, 39);
            this.txtpostalcode.TabIndex = 63;
            this.txtpostalcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpostalcode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(1145, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 62;
            this.label5.Text = "کد پستی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(1163, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 64;
            this.label6.Text = "آدرس:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // edite
            // 
            this.edite.BackColor = System.Drawing.Color.Orange;
            this.edite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edite.FlatAppearance.BorderSize = 0;
            this.edite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edite.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.edite.ForeColor = System.Drawing.Color.White;
            this.edite.Location = new System.Drawing.Point(912, 455);
            this.edite.Name = "edite";
            this.edite.Size = new System.Drawing.Size(187, 57);
            this.edite.TabIndex = 67;
            this.edite.Text = "ویرایش";
            this.edite.UseVisualStyleBackColor = false;
            this.edite.Click += new System.EventHandler(this.edite_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightSalmon;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(912, 529);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(187, 57);
            this.delete.TabIndex = 66;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // sabt
            // 
            this.sabt.BackColor = System.Drawing.Color.OrangeRed;
            this.sabt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sabt.FlatAppearance.BorderSize = 0;
            this.sabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sabt.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.sabt.ForeColor = System.Drawing.Color.White;
            this.sabt.Location = new System.Drawing.Point(912, 381);
            this.sabt.Name = "sabt";
            this.sabt.Size = new System.Drawing.Size(187, 57);
            this.sabt.TabIndex = 65;
            this.sabt.Text = "ثبت";
            this.sabt.UseVisualStyleBackColor = false;
            this.sabt.Click += new System.EventHandler(this.sabt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(912, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 56);
            this.button3.TabIndex = 68;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 712);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edite);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.sabt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpostalcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newcustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newcustomer";
            this.Load += new System.EventHandler(this.newcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpostalcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edite;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button sabt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}