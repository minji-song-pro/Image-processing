namespace 영상처리소프트웨어
{
    partial class Sub_Input2
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
            this.btn_ok2 = new System.Windows.Forms.Button();
            this.btn_cancel2 = new System.Windows.Forms.Button();
            this.numeric_start = new System.Windows.Forms.NumericUpDown();
            this.numeric_end = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok2
            // 
            this.btn_ok2.Location = new System.Drawing.Point(376, 28);
            this.btn_ok2.Name = "btn_ok2";
            this.btn_ok2.Size = new System.Drawing.Size(108, 46);
            this.btn_ok2.TabIndex = 0;
            this.btn_ok2.Text = "OK";
            this.btn_ok2.UseVisualStyleBackColor = true;
            this.btn_ok2.Click += new System.EventHandler(this.btn_ok2_Click);
            // 
            // btn_cancel2
            // 
            this.btn_cancel2.Location = new System.Drawing.Point(376, 80);
            this.btn_cancel2.Name = "btn_cancel2";
            this.btn_cancel2.Size = new System.Drawing.Size(108, 46);
            this.btn_cancel2.TabIndex = 0;
            this.btn_cancel2.Text = "Cancel";
            this.btn_cancel2.UseVisualStyleBackColor = true;
            this.btn_cancel2.Click += new System.EventHandler(this.btn_cancel2_Click);
            // 
            // numeric_start
            // 
            this.numeric_start.DecimalPlaces = 1;
            this.numeric_start.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_start.Location = new System.Drawing.Point(47, 65);
            this.numeric_start.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_start.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numeric_start.Name = "numeric_start";
            this.numeric_start.Size = new System.Drawing.Size(120, 25);
            this.numeric_start.TabIndex = 1;
            // 
            // numeric_end
            // 
            this.numeric_end.DecimalPlaces = 1;
            this.numeric_end.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_end.Location = new System.Drawing.Point(217, 65);
            this.numeric_end.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_end.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numeric_end.Name = "numeric_end";
            this.numeric_end.Size = new System.Drawing.Size(120, 25);
            this.numeric_end.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "범위를 지정하세요.";
            // 
            // Sub_Input2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_end);
            this.Controls.Add(this.numeric_start);
            this.Controls.Add(this.btn_cancel2);
            this.Controls.Add(this.btn_ok2);
            this.Name = "Sub_Input2";
            this.Text = "Sub_Input2";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok2;
        private System.Windows.Forms.Button btn_cancel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numeric_start;
        public System.Windows.Forms.NumericUpDown numeric_end;
    }
}