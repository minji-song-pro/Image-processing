namespace 영상처리소프트웨어
{
    partial class Sub_Input1
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
            this.numeric_double1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_double1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_double1
            // 
            this.numeric_double1.DecimalPlaces = 1;
            this.numeric_double1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_double1.Location = new System.Drawing.Point(175, 42);
            this.numeric_double1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numeric_double1.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numeric_double1.Name = "numeric_double1";
            this.numeric_double1.Size = new System.Drawing.Size(120, 25);
            this.numeric_double1.TabIndex = 0;
            this.numeric_double1.ValueChanged += new System.EventHandler(this.numeric_double1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "숫자";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(66, 114);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(104, 41);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(202, 114);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 41);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Sub_Input1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 197);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_double1);
            this.Name = "Sub_Input1";
            this.Text = "숫자1개입력";
            this.Load += new System.EventHandler(this.숫자1개입력_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_double1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.NumericUpDown numeric_double1;
    }
}