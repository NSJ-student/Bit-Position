
namespace CanTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartBit = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnConvertArray = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResPosition = new System.Windows.Forms.TextBox();
            this.txtResValue = new System.Windows.Forms.TextBox();
            this.rtbResultArray = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlign = new System.Windows.Forms.TextBox();
            this.btnConvertValue = new System.Windows.Forms.Button();
            this.txtRefArray = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Bit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // txtStartBit
            // 
            this.txtStartBit.Location = new System.Drawing.Point(91, 12);
            this.txtStartBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStartBit.Name = "txtStartBit";
            this.txtStartBit.Size = new System.Drawing.Size(114, 25);
            this.txtStartBit.TabIndex = 0;
            this.txtStartBit.Click += new System.EventHandler(this.txtStartBit_Click);
            this.txtStartBit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStartBit_KeyUp);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(91, 46);
            this.txtLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(114, 25);
            this.txtLength.TabIndex = 1;
            this.txtLength.Click += new System.EventHandler(this.txtLength_Click);
            this.txtLength.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLength_KeyUp);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(91, 80);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(114, 25);
            this.txtValue.TabIndex = 2;
            this.txtValue.Click += new System.EventHandler(this.txtValue_Click);
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            // 
            // btnConvertArray
            // 
            this.btnConvertArray.Location = new System.Drawing.Point(223, 12);
            this.btnConvertArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertArray.Name = "btnConvertArray";
            this.btnConvertArray.Size = new System.Drawing.Size(86, 93);
            this.btnConvertArray.TabIndex = 4;
            this.btnConvertArray.Text = "Convert to Array";
            this.btnConvertArray.UseVisualStyleBackColor = true;
            this.btnConvertArray.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Value";
            // 
            // txtResPosition
            // 
            this.txtResPosition.Location = new System.Drawing.Point(417, 12);
            this.txtResPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResPosition.Name = "txtResPosition";
            this.txtResPosition.ReadOnly = true;
            this.txtResPosition.Size = new System.Drawing.Size(114, 25);
            this.txtResPosition.TabIndex = 5;
            // 
            // txtResValue
            // 
            this.txtResValue.Location = new System.Drawing.Point(417, 46);
            this.txtResValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResValue.Name = "txtResValue";
            this.txtResValue.ReadOnly = true;
            this.txtResValue.Size = new System.Drawing.Size(114, 25);
            this.txtResValue.TabIndex = 6;
            // 
            // rtbResultArray
            // 
            this.rtbResultArray.Location = new System.Drawing.Point(14, 135);
            this.rtbResultArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbResultArray.Name = "rtbResultArray";
            this.rtbResultArray.ReadOnly = true;
            this.rtbResultArray.Size = new System.Drawing.Size(525, 144);
            this.rtbResultArray.TabIndex = 8;
            this.rtbResultArray.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Align";
            // 
            // txtAlign
            // 
            this.txtAlign.Location = new System.Drawing.Point(493, 101);
            this.txtAlign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlign.Name = "txtAlign";
            this.txtAlign.Size = new System.Drawing.Size(38, 25);
            this.txtAlign.TabIndex = 7;
            this.txtAlign.Text = "8";
            this.txtAlign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertValue
            // 
            this.btnConvertValue.Location = new System.Drawing.Point(352, 295);
            this.btnConvertValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertValue.Name = "btnConvertValue";
            this.btnConvertValue.Size = new System.Drawing.Size(179, 25);
            this.btnConvertValue.TabIndex = 4;
            this.btnConvertValue.Text = "Convert to Value";
            this.btnConvertValue.UseVisualStyleBackColor = true;
            this.btnConvertValue.Click += new System.EventHandler(this.btnConvertValue_Click);
            // 
            // txtRefArray
            // 
            this.txtRefArray.Location = new System.Drawing.Point(91, 295);
            this.txtRefArray.Name = "txtRefArray";
            this.txtRefArray.Size = new System.Drawing.Size(244, 25);
            this.txtRefArray.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "ref. Array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 340);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRefArray);
            this.Controls.Add(this.rtbResultArray);
            this.Controls.Add(this.btnConvertValue);
            this.Controls.Add(this.btnConvertArray);
            this.Controls.Add(this.txtAlign);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtResValue);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtResPosition);
            this.Controls.Add(this.txtStartBit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartBit;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnConvertArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResPosition;
        private System.Windows.Forms.TextBox txtResValue;
        private System.Windows.Forms.RichTextBox rtbResultArray;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlign;
        private System.Windows.Forms.Button btnConvertValue;
        private System.Windows.Forms.TextBox txtRefArray;
        private System.Windows.Forms.Label label7;
    }
}

