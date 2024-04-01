namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.lblWithoutDigitsResult = new System.Windows.Forms.Label();
            this.lblReplaceResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(125, 63);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(158, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // butOk
            // 
            this.butOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butOk.Location = new System.Drawing.Point(125, 271);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(128, 59);
            this.butOk.TabIndex = 1;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = false;
            this.butOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWithoutDigitsResult
            // 
            this.lblWithoutDigitsResult.AutoSize = true;
            this.lblWithoutDigitsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWithoutDigitsResult.Location = new System.Drawing.Point(122, 167);
            this.lblWithoutDigitsResult.Name = "lblWithoutDigitsResult";
            this.lblWithoutDigitsResult.Size = new System.Drawing.Size(0, 15);
            this.lblWithoutDigitsResult.TabIndex = 2;
            this.lblWithoutDigitsResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReplaceResult
            // 
            this.lblReplaceResult.AutoSize = true;
            this.lblReplaceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReplaceResult.Location = new System.Drawing.Point(122, 203);
            this.lblReplaceResult.Name = "lblReplaceResult";
            this.lblReplaceResult.Size = new System.Drawing.Size(0, 15);
            this.lblReplaceResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Results:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(125, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReplaceResult);
            this.Controls.Add(this.lblWithoutDigitsResult);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblWithoutDigitsResult;
        private System.Windows.Forms.Label lblReplaceResult;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

