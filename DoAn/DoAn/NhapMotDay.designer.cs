namespace DoAn
{
    partial class NhapMotDay
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
            this.dayCanNhapTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.luuDayCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dayCanNhapTextBox
            // 
            this.dayCanNhapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCanNhapTextBox.Location = new System.Drawing.Point(122, 33);
            this.dayCanNhapTextBox.Name = "dayCanNhapTextBox";
            this.dayCanNhapTextBox.Size = new System.Drawing.Size(291, 26);
            this.dayCanNhapTextBox.TabIndex = 122;
            this.dayCanNhapTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayCanNhapTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 121;
            this.label6.Text = "Dãy cần nhập";
            // 
            // capNhatButton
            // 
            this.capNhatButton.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.capNhatButton.Location = new System.Drawing.Point(135, 87);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(75, 33);
            this.capNhatButton.TabIndex = 123;
            this.capNhatButton.Text = "Tạo";
            this.capNhatButton.UseVisualStyleBackColor = true;
            this.capNhatButton.Click += new System.EventHandler(this.TaoButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.button1.Location = new System.Drawing.Point(216, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 124;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // luuDayCheckBox
            // 
            this.luuDayCheckBox.AutoSize = true;
            this.luuDayCheckBox.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuDayCheckBox.Location = new System.Drawing.Point(336, 65);
            this.luuDayCheckBox.Name = "luuDayCheckBox";
            this.luuDayCheckBox.Size = new System.Drawing.Size(77, 22);
            this.luuDayCheckBox.TabIndex = 125;
            this.luuDayCheckBox.Text = "Lưu dãy";
            this.luuDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // NhapMotDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 131);
            this.Controls.Add(this.luuDayCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capNhatButton);
            this.Controls.Add(this.dayCanNhapTextBox);
            this.Controls.Add(this.label6);
            this.MinimizeBox = false;
            this.Name = "NhapMotDay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo dãy các phần tử";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhapTay_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayCanNhapTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox luuDayCheckBox;
    }
}