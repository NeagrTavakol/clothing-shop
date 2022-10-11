
namespace foroshgahlebas
{
    partial class Formdress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formdress));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboproducer = new System.Windows.Forms.ComboBox();
            this.btnregisterdress = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnedite = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Lotus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.size,
            this.color,
            this.producername,
            this.number,
            this.payment,
            this.typename});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 747);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "مدل پوشاک";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "سایز";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "رنگ";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // producername
            // 
            this.producername.DataPropertyName = "producername";
            this.producername.HeaderText = "نام تولید کننده";
            this.producername.MinimumWidth = 6;
            this.producername.Name = "producername";
            this.producername.ReadOnly = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "تعداد";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // payment
            // 
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "قیمت";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            // 
            // typename
            // 
            this.typename.DataPropertyName = "typename";
            this.typename.HeaderText = "نوع";
            this.typename.MinimumWidth = 6;
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1096, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "مدل:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmodel.Location = new System.Drawing.Point(879, 44);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(230, 28);
            this.txtmodel.TabIndex = 2;
            // 
            // txtsize
            // 
            this.txtsize.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsize.Location = new System.Drawing.Point(879, 116);
            this.txtsize.Multiline = true;
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(230, 28);
            this.txtsize.TabIndex = 4;
            this.txtsize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsize_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1096, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "سایز:";
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcolor.Location = new System.Drawing.Point(879, 182);
            this.txtcolor.Multiline = true;
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(230, 28);
            this.txtcolor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(1096, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "رنگ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(1069, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "شرکت تولیدی:";
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnumber.Location = new System.Drawing.Point(879, 314);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(230, 28);
            this.txtnumber.TabIndex = 10;
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(1089, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "تعداد:";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("B Lotus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtprice.Location = new System.Drawing.Point(879, 383);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(230, 28);
            this.txtprice.TabIndex = 12;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(1089, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "قیمت:";
            // 
            // comboproducer
            // 
            this.comboproducer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboproducer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboproducer.FormattingEnabled = true;
            this.comboproducer.Location = new System.Drawing.Point(988, 252);
            this.comboproducer.Name = "comboproducer";
            this.comboproducer.Size = new System.Drawing.Size(121, 24);
            this.comboproducer.TabIndex = 13;
            // 
            // btnregisterdress
            // 
            this.btnregisterdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnregisterdress.FlatAppearance.BorderSize = 0;
            this.btnregisterdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregisterdress.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnregisterdress.ForeColor = System.Drawing.Color.White;
            this.btnregisterdress.Location = new System.Drawing.Point(1073, 569);
            this.btnregisterdress.Name = "btnregisterdress";
            this.btnregisterdress.Size = new System.Drawing.Size(99, 48);
            this.btnregisterdress.TabIndex = 16;
            this.btnregisterdress.Text = "ثبت";
            this.btnregisterdress.UseVisualStyleBackColor = false;
            this.btnregisterdress.Click += new System.EventHandler(this.btnregisterdress_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(827, 640);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(369, 60);
            this.button4.TabIndex = 17;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnedite
            // 
            this.btnedite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnedite.FlatAppearance.BorderSize = 0;
            this.btnedite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedite.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedite.ForeColor = System.Drawing.Color.White;
            this.btnedite.Location = new System.Drawing.Point(959, 569);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(108, 48);
            this.btnedite.TabIndex = 18;
            this.btnedite.Text = "ویرایش";
            this.btnedite.UseVisualStyleBackColor = false;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Red;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(842, 569);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(111, 48);
            this.btnremove.TabIndex = 19;
            this.btnremove.Text = "حذف";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(860, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 33);
            this.button5.TabIndex = 20;
            this.button5.Text = "ثبت تولیدی";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // combotype
            // 
            this.combotype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combotype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combotype.FormattingEnabled = true;
            this.combotype.Location = new System.Drawing.Point(879, 422);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(211, 24);
            this.combotype.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("B Lotus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(1099, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "نوع:";
            // 
            // Formdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 712);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedite);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnregisterdress);
            this.Controls.Add(this.comboproducer);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formdress";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formdress";
            this.Load += new System.EventHandler(this.Formdress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboproducer;
        private System.Windows.Forms.Button btnregisterdress;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnedite;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn producername;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
    }
}