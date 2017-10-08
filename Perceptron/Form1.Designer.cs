namespace Perceptron
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
            this.RecognizeBtn = new System.Windows.Forms.Button();
            this.TeachBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecognizeBtn
            // 
            this.RecognizeBtn.Location = new System.Drawing.Point(12, 410);
            this.RecognizeBtn.Name = "RecognizeBtn";
            this.RecognizeBtn.Size = new System.Drawing.Size(92, 36);
            this.RecognizeBtn.TabIndex = 0;
            this.RecognizeBtn.Text = "Распознать";
            this.RecognizeBtn.UseVisualStyleBackColor = true;
            // 
            // TeachBtn
            // 
            this.TeachBtn.Location = new System.Drawing.Point(306, 410);
            this.TeachBtn.Name = "TeachBtn";
            this.TeachBtn.Size = new System.Drawing.Size(83, 36);
            this.TeachBtn.TabIndex = 1;
            this.TeachBtn.Text = "Обучить";
            this.TeachBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 452);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(92, 31);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 499);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TeachBtn);
            this.Controls.Add(this.RecognizeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RecognizeBtn;
        private System.Windows.Forms.Button TeachBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}

