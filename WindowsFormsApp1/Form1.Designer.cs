namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.numbutton1 = new System.Windows.Forms.Button();
            this.numbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numPlus = new System.Windows.Forms.Button();
            this.numbutton3 = new System.Windows.Forms.Button();
            this.numbutton6 = new System.Windows.Forms.Button();
            this.numbutton5 = new System.Windows.Forms.Button();
            this.numbutton4 = new System.Windows.Forms.Button();
            this.numbutton9 = new System.Windows.Forms.Button();
            this.numbutton8 = new System.Windows.Forms.Button();
            this.numbutton7 = new System.Windows.Forms.Button();
            this.numMinus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.numbutton0 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbutton1
            // 
            this.numbutton1.Location = new System.Drawing.Point(46, 170);
            this.numbutton1.Name = "numbutton1";
            this.numbutton1.Size = new System.Drawing.Size(87, 84);
            this.numbutton1.TabIndex = 0;
            this.numbutton1.Text = "1";
            this.numbutton1.UseVisualStyleBackColor = true;
            this.numbutton1.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton2
            // 
            this.numbutton2.Location = new System.Drawing.Point(172, 170);
            this.numbutton2.Name = "numbutton2";
            this.numbutton2.Size = new System.Drawing.Size(92, 84);
            this.numbutton2.TabIndex = 1;
            this.numbutton2.Text = "2";
            this.numbutton2.UseVisualStyleBackColor = true;
            this.numbutton2.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 111);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numPlus
            // 
            this.numPlus.Font = new System.Drawing.Font("굴림", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numPlus.Location = new System.Drawing.Point(476, 170);
            this.numPlus.Name = "numPlus";
            this.numPlus.Size = new System.Drawing.Size(79, 84);
            this.numPlus.TabIndex = 3;
            this.numPlus.Text = "+";
            this.numPlus.UseVisualStyleBackColor = true;
            this.numPlus.Click += new System.EventHandler(this.numPlus_Click);
            // 
            // numbutton3
            // 
            this.numbutton3.Location = new System.Drawing.Point(313, 170);
            this.numbutton3.Name = "numbutton3";
            this.numbutton3.Size = new System.Drawing.Size(86, 84);
            this.numbutton3.TabIndex = 4;
            this.numbutton3.Text = "3";
            this.numbutton3.UseVisualStyleBackColor = true;
            this.numbutton3.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton6
            // 
            this.numbutton6.Location = new System.Drawing.Point(313, 296);
            this.numbutton6.Name = "numbutton6";
            this.numbutton6.Size = new System.Drawing.Size(86, 84);
            this.numbutton6.TabIndex = 7;
            this.numbutton6.Text = "6";
            this.numbutton6.UseVisualStyleBackColor = true;
            this.numbutton6.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton5
            // 
            this.numbutton5.Location = new System.Drawing.Point(172, 296);
            this.numbutton5.Name = "numbutton5";
            this.numbutton5.Size = new System.Drawing.Size(92, 84);
            this.numbutton5.TabIndex = 6;
            this.numbutton5.Text = "5";
            this.numbutton5.UseVisualStyleBackColor = true;
            this.numbutton5.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton4
            // 
            this.numbutton4.Location = new System.Drawing.Point(46, 296);
            this.numbutton4.Name = "numbutton4";
            this.numbutton4.Size = new System.Drawing.Size(87, 84);
            this.numbutton4.TabIndex = 5;
            this.numbutton4.Text = "4";
            this.numbutton4.UseVisualStyleBackColor = true;
            this.numbutton4.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton9
            // 
            this.numbutton9.Location = new System.Drawing.Point(313, 416);
            this.numbutton9.Name = "numbutton9";
            this.numbutton9.Size = new System.Drawing.Size(86, 83);
            this.numbutton9.TabIndex = 10;
            this.numbutton9.Text = "9";
            this.numbutton9.UseVisualStyleBackColor = true;
            this.numbutton9.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton8
            // 
            this.numbutton8.Location = new System.Drawing.Point(172, 416);
            this.numbutton8.Name = "numbutton8";
            this.numbutton8.Size = new System.Drawing.Size(92, 83);
            this.numbutton8.TabIndex = 9;
            this.numbutton8.Text = "8";
            this.numbutton8.UseVisualStyleBackColor = true;
            this.numbutton8.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numbutton7
            // 
            this.numbutton7.Location = new System.Drawing.Point(46, 416);
            this.numbutton7.Name = "numbutton7";
            this.numbutton7.Size = new System.Drawing.Size(87, 83);
            this.numbutton7.TabIndex = 8;
            this.numbutton7.Text = "7";
            this.numbutton7.UseVisualStyleBackColor = true;
            this.numbutton7.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // numMinus
            // 
            this.numMinus.Font = new System.Drawing.Font("굴림", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numMinus.Location = new System.Drawing.Point(600, 170);
            this.numMinus.Name = "numMinus";
            this.numMinus.Size = new System.Drawing.Size(70, 84);
            this.numMinus.TabIndex = 11;
            this.numMinus.Text = "-";
            this.numMinus.UseVisualStyleBackColor = true;
            this.numMinus.Click += new System.EventHandler(this.numPlus_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("굴림", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(600, 296);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 84);
            this.button9.TabIndex = 13;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numPlus_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("굴림", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(476, 296);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(79, 84);
            this.button10.TabIndex = 12;
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.numPlus_Click);
            // 
            // numbutton0
            // 
            this.numbutton0.Location = new System.Drawing.Point(46, 524);
            this.numbutton0.Name = "numbutton0";
            this.numbutton0.Size = new System.Drawing.Size(218, 64);
            this.numbutton0.TabIndex = 14;
            this.numbutton0.Text = "0";
            this.numbutton0.UseVisualStyleBackColor = true;
            this.numbutton0.Click += new System.EventHandler(this.numbutton1_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("굴림", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clear.Location = new System.Drawing.Point(476, 524);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(194, 64);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 83);
            this.button1.TabIndex = 16;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.numbutton0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.numMinus);
            this.Controls.Add(this.numbutton9);
            this.Controls.Add(this.numbutton8);
            this.Controls.Add(this.numbutton7);
            this.Controls.Add(this.numbutton6);
            this.Controls.Add(this.numbutton5);
            this.Controls.Add(this.numbutton4);
            this.Controls.Add(this.numbutton3);
            this.Controls.Add(this.numPlus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbutton2);
            this.Controls.Add(this.numbutton1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button numbutton1;
        private System.Windows.Forms.Button numbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button numPlus;
        private System.Windows.Forms.Button numbutton3;
        private System.Windows.Forms.Button numbutton6;
        private System.Windows.Forms.Button numbutton5;
        private System.Windows.Forms.Button numbutton4;
        private System.Windows.Forms.Button numbutton9;
        private System.Windows.Forms.Button numbutton8;
        private System.Windows.Forms.Button numbutton7;
        private System.Windows.Forms.Button numMinus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button numbutton0;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
    }
}

