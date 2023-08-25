namespace _01Basic
{
    partial class winform
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
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.led01On = new System.Windows.Forms.Button();
            this.led02On = new System.Windows.Forms.Button();
            this.led02Off = new System.Windows.Forms.Button();
            this.led01Off = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.PortNumber.Location = new System.Drawing.Point(27, 33);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(136, 23);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged);
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(192, 23);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 40);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // led01On
            // 
            this.led01On.Location = new System.Drawing.Point(27, 104);
            this.led01On.Name = "led01On";
            this.led01On.Size = new System.Drawing.Size(102, 36);
            this.led01On.TabIndex = 2;
            this.led01On.Text = "LED_01 ON";
            this.led01On.UseVisualStyleBackColor = true;
            this.led01On.Click += new System.EventHandler(this.led01On_Click);
            // 
            // led02On
            // 
            this.led02On.Location = new System.Drawing.Point(27, 161);
            this.led02On.Name = "led02On";
            this.led02On.Size = new System.Drawing.Size(105, 36);
            this.led02On.TabIndex = 3;
            this.led02On.Text = "LED_02 ON";
            this.led02On.UseVisualStyleBackColor = true;
            this.led02On.Click += new System.EventHandler(this.led02On_Click);
            // 
            // led02Off
            // 
            this.led02Off.Location = new System.Drawing.Point(165, 161);
            this.led02Off.Name = "led02Off";
            this.led02Off.Size = new System.Drawing.Size(102, 36);
            this.led02Off.TabIndex = 4;
            this.led02Off.Text = "LED_02 OFF";
            this.led02Off.UseVisualStyleBackColor = true;
            this.led02Off.Click += new System.EventHandler(this.led02Off_Click);
            // 
            // led01Off
            // 
            this.led01Off.Location = new System.Drawing.Point(165, 104);
            this.led01Off.Name = "led01Off";
            this.led01Off.Size = new System.Drawing.Size(102, 36);
            this.led01Off.TabIndex = 5;
            this.led01Off.Text = "LED_01 OFF";
            this.led01Off.UseVisualStyleBackColor = true;
            this.led01Off.Click += new System.EventHandler(this.led01Off_Click);
            // 
            // textArea
            // 
            this.textArea.Enabled = false;
            this.textArea.Location = new System.Drawing.Point(27, 244);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(240, 25);
            this.textArea.TabIndex = 6;
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.Location = new System.Drawing.Point(27, 223);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(81, 15);
            this.msgBox.TabIndex = 7;
            this.msgBox.Text = "message : ";
            // 
            // winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 281);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.led01Off);
            this.Controls.Add(this.led02Off);
            this.Controls.Add(this.led02On);
            this.Controls.Add(this.led01On);
            this.Controls.Add(this.conn_btn);
            this.Controls.Add(this.PortNumber);
            this.Name = "winform";
            this.Text = "WINFORMTEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.Button led01On;
        private System.Windows.Forms.Button led02On;
        private System.Windows.Forms.Button led02Off;
        private System.Windows.Forms.Button led01Off;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Label msgBox;
    }
}

