namespace CurrencyConversionApp
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
            this.cb_currenyType1 = new System.Windows.Forms.ComboBox();
            this.lb_previousConversions = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pb_conversionProgressMeter = new System.Windows.Forms.ProgressBar();
            this.btn_logConversion = new System.Windows.Forms.Button();
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.cb_currenyType2 = new System.Windows.Forms.ComboBox();
            this.lbl_ConversionResult = new System.Windows.Forms.Label();
            this.btn_SaveLog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_clearLog = new System.Windows.Forms.Button();
            this.btn_queryLog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_currenyType1
            // 
            this.cb_currenyType1.FormattingEnabled = true;
            this.cb_currenyType1.Location = new System.Drawing.Point(15, 131);
            this.cb_currenyType1.Name = "cb_currenyType1";
            this.cb_currenyType1.Size = new System.Drawing.Size(121, 23);
            this.cb_currenyType1.TabIndex = 0;
            this.cb_currenyType1.SelectedIndexChanged += new System.EventHandler(this.cb_currenyType1_SelectedIndexChanged);
            // 
            // lb_previousConversions
            // 
            this.lb_previousConversions.FormattingEnabled = true;
            this.lb_previousConversions.HorizontalScrollbar = true;
            this.lb_previousConversions.ItemHeight = 15;
            this.lb_previousConversions.Location = new System.Drawing.Point(12, 208);
            this.lb_previousConversions.Name = "lb_previousConversions";
            this.lb_previousConversions.Size = new System.Drawing.Size(120, 94);
            this.lb_previousConversions.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(142, 131);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pb_conversionProgressMeter
            // 
            this.pb_conversionProgressMeter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_conversionProgressMeter.Location = new System.Drawing.Point(0, 427);
            this.pb_conversionProgressMeter.Name = "pb_conversionProgressMeter";
            this.pb_conversionProgressMeter.Size = new System.Drawing.Size(800, 23);
            this.pb_conversionProgressMeter.TabIndex = 3;
            // 
            // btn_logConversion
            // 
            this.btn_logConversion.Location = new System.Drawing.Point(15, 179);
            this.btn_logConversion.Name = "btn_logConversion";
            this.btn_logConversion.Size = new System.Drawing.Size(75, 23);
            this.btn_logConversion.TabIndex = 4;
            this.btn_logConversion.Text = "Log";
            this.btn_logConversion.UseVisualStyleBackColor = true;
            this.btn_logConversion.Click += new System.EventHandler(this.btn_logConversion_Click);
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_AppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AppTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(800, 69);
            this.lbl_AppTitle.TabIndex = 5;
            this.lbl_AppTitle.Text = "Currency Convertion App";
            this.lbl_AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_currenyType2
            // 
            this.cb_currenyType2.FormattingEnabled = true;
            this.cb_currenyType2.Location = new System.Drawing.Point(268, 131);
            this.cb_currenyType2.Name = "cb_currenyType2";
            this.cb_currenyType2.Size = new System.Drawing.Size(121, 23);
            this.cb_currenyType2.TabIndex = 6;
            this.cb_currenyType2.SelectedIndexChanged += new System.EventHandler(this.cb_currenyType2_SelectedIndexChanged);
            // 
            // lbl_ConversionResult
            // 
            this.lbl_ConversionResult.AutoSize = true;
            this.lbl_ConversionResult.Location = new System.Drawing.Point(395, 134);
            this.lbl_ConversionResult.Name = "lbl_ConversionResult";
            this.lbl_ConversionResult.Size = new System.Drawing.Size(13, 15);
            this.lbl_ConversionResult.TabIndex = 7;
            this.lbl_ConversionResult.Text = "0";
            // 
            // btn_SaveLog
            // 
            this.btn_SaveLog.Location = new System.Drawing.Point(12, 308);
            this.btn_SaveLog.Name = "btn_SaveLog";
            this.btn_SaveLog.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveLog.TabIndex = 8;
            this.btn_SaveLog.Text = "Save";
            this.btn_SaveLog.UseVisualStyleBackColor = true;
            this.btn_SaveLog.Click += new System.EventHandler(this.btn_SaveLog_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "CurrencyConversionHistory";
            this.saveFileDialog1.Filter = "Text File |*.txt";
            // 
            // btn_clearLog
            // 
            this.btn_clearLog.Location = new System.Drawing.Point(96, 179);
            this.btn_clearLog.Name = "btn_clearLog";
            this.btn_clearLog.Size = new System.Drawing.Size(75, 23);
            this.btn_clearLog.TabIndex = 9;
            this.btn_clearLog.Text = "Clear";
            this.btn_clearLog.UseVisualStyleBackColor = true;
            this.btn_clearLog.Click += new System.EventHandler(this.btn_clearLog_Click);
            // 
            // btn_queryLog
            // 
            this.btn_queryLog.Location = new System.Drawing.Point(96, 308);
            this.btn_queryLog.Name = "btn_queryLog";
            this.btn_queryLog.Size = new System.Drawing.Size(75, 23);
            this.btn_queryLog.TabIndex = 10;
            this.btn_queryLog.Text = "Query";
            this.btn_queryLog.UseVisualStyleBackColor = true;
            this.btn_queryLog.Click += new System.EventHandler(this.btn_queryLog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "CurrencyConversionHistory";
            this.openFileDialog1.Filter = "Text File |*.txt";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_queryLog);
            this.Controls.Add(this.btn_clearLog);
            this.Controls.Add(this.btn_SaveLog);
            this.Controls.Add(this.lbl_ConversionResult);
            this.Controls.Add(this.cb_currenyType2);
            this.Controls.Add(this.lbl_AppTitle);
            this.Controls.Add(this.btn_logConversion);
            this.Controls.Add(this.pb_conversionProgressMeter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lb_previousConversions);
            this.Controls.Add(this.cb_currenyType1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_currenyType1;
        private ListBox lb_previousConversions;
        private NumericUpDown numericUpDown1;
        private ProgressBar pb_conversionProgressMeter;
        private Button btn_logConversion;
        private Label lbl_AppTitle;
        private ComboBox cb_currenyType2;
        private Label lbl_ConversionResult;
        private Button btn_SaveLog;
        private SaveFileDialog saveFileDialog1;
        private Button btn_clearLog;
        private Button btn_queryLog;
        private OpenFileDialog openFileDialog1;
    }
}