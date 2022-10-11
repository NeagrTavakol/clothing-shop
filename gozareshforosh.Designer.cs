
namespace foroshgahlebas
{
    partial class gozareshforosh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gozareshforosh));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cusname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfacktor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePickerX2 = new BehComponents.DateTimePickerX();
            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Zar", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.date,
            this.payment});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 622);
            this.dataGridView1.TabIndex = 41;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "شماره فاکتور";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "نام مشتری";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // payment
            // 
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "مبلغ";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(660, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "تا تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(965, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "تاریخ فاکتور از";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(691, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "مشتری";
            // 
            // cusname
            // 
            this.cusname.Location = new System.Drawing.Point(510, 21);
            this.cusname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(164, 28);
            this.cusname.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(962, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "شماره فاکتور";
            // 
            // txtfacktor
            // 
            this.txtfacktor.Location = new System.Drawing.Point(791, 21);
            this.txtfacktor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfacktor.Name = "txtfacktor";
            this.txtfacktor.Size = new System.Drawing.Size(164, 28);
            this.txtfacktor.TabIndex = 34;
            this.txtfacktor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namemarket_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(14, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 52);
            this.button2.TabIndex = 32;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(158, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 31;
            this.button1.Text = "چاپ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(302, 8);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 52);
            this.button4.TabIndex = 30;
            this.button4.Text = "جستجو";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePickerX2
            // 
            this.dateTimePickerX2.AnchorSize = new System.Drawing.Size(225, 28);
            this.dateTimePickerX2.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerX2.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerX2.CalendarDayRectTickness = 2F;
            this.dateTimePickerX2.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerX2.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePickerX2.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerX2.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX2.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX2.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarShowToday = true;
            this.dateTimePickerX2.CalendarShowTodayRect = true;
            this.dateTimePickerX2.CalendarShowToolTips = false;
            this.dateTimePickerX2.CalendarShowTrailing = true;
            this.dateTimePickerX2.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX2.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX2.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX2.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarTitleFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.dateTimePickerX2.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarTodayFont = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX2.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerX2.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX2.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerX2.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX2.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.dateTimePickerX2.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerX2.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX2.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX2.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX2.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX2.ClearButtonImage")));
            this.dateTimePickerX2.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX2.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX2.ClearButtonText = "";
            this.dateTimePickerX2.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.ClearButtonToolTip = "";
            this.dateTimePickerX2.ClearButtonWidth = 17;
            this.dateTimePickerX2.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX2.CustomFormat = "";
            this.dateTimePickerX2.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX2.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX2.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX2.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dateTimePickerX2.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX2.Location = new System.Drawing.Point(426, 94);
            this.dateTimePickerX2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimePickerX2.Name = "dateTimePickerX2";
            this.dateTimePickerX2.RightToLeftLayout = true;
            this.dateTimePickerX2.ShowClearButton = false;
            this.dateTimePickerX2.Size = new System.Drawing.Size(225, 28);
            this.dateTimePickerX2.TabIndex = 38;
            this.dateTimePickerX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX2.TextWhenClearButtonClicked = "";
            // 
            // dateTimePickerX1
            // 
            this.dateTimePickerX1.AnchorSize = new System.Drawing.Size(225, 28);
            this.dateTimePickerX1.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerX1.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerX1.CalendarDayRectTickness = 2F;
            this.dateTimePickerX1.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerX1.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePickerX1.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerX1.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX1.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX1.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarShowToday = true;
            this.dateTimePickerX1.CalendarShowTodayRect = true;
            this.dateTimePickerX1.CalendarShowToolTips = false;
            this.dateTimePickerX1.CalendarShowTrailing = true;
            this.dateTimePickerX1.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX1.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarTitleFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.dateTimePickerX1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarTodayFont = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX1.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerX1.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX1.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerX1.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX1.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.dateTimePickerX1.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerX1.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX1.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX1.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX1.ClearButtonImage")));
            this.dateTimePickerX1.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX1.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX1.ClearButtonText = "";
            this.dateTimePickerX1.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonToolTip = "";
            this.dateTimePickerX1.ClearButtonWidth = 17;
            this.dateTimePickerX1.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX1.CustomFormat = "";
            this.dateTimePickerX1.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX1.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX1.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dateTimePickerX1.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX1.Location = new System.Drawing.Point(730, 94);
            this.dateTimePickerX1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimePickerX1.Name = "dateTimePickerX1";
            this.dateTimePickerX1.RightToLeftLayout = true;
            this.dateTimePickerX1.ShowClearButton = false;
            this.dateTimePickerX1.Size = new System.Drawing.Size(225, 28);
            this.dateTimePickerX1.TabIndex = 37;
            this.dateTimePickerX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX1.TextWhenClearButtonClicked = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Zar", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(158, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 53);
            this.button3.TabIndex = 42;
            this.button3.Text = "پیشنهاد دادن";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // gozareshforosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 780);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerX2);
            this.Controls.Add(this.dateTimePickerX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cusname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfacktor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("B Zar", 7.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "gozareshforosh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gozareshforosh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BehComponents.DateTimePickerX dateTimePickerX2;
        private BehComponents.DateTimePickerX dateTimePickerX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cusname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfacktor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
    }
}