namespace ERPProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel62 = new System.Windows.Forms.Panel();
            this.button36 = new System.Windows.Forms.Button();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.panel62.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 122);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel62
            // 
            this.panel62.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel62.Controls.Add(this.button36);
            this.panel62.Controls.Add(this.textBox150);
            this.panel62.Location = new System.Drawing.Point(80, 50);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(292, 93);
            this.panel62.TabIndex = 21;
            this.panel62.Visible = false;
            this.panel62.Paint += new System.Windows.Forms.PaintEventHandler(this.panel62_Paint);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button36.Location = new System.Drawing.Point(100, 50);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(96, 29);
            this.button36.TabIndex = 1;
            this.button36.Text = "확 인";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // textBox150
            // 
            this.textBox150.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox150.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox150.Location = new System.Drawing.Point(50, 7);
            this.textBox150.Name = "textBox150";
            this.textBox150.Size = new System.Drawing.Size(214, 25);
            this.textBox150.TabIndex = 0;
            this.textBox150.Text = "잘못입력 하셨습니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ERPProject.Properties.Resources.화면_캡처_2022_12_22_144930;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel62);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel62.ResumeLayout(false);
            this.panel62.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel62;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.TextBox textBox150;
    }
}

