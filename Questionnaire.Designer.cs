namespace Questionnaire
{
    partial class Questionnaire
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
            this.panelEnter = new System.Windows.Forms.Panel();
            this.textBoxWelcome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnter
            // 
            this.panelEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelEnter.Controls.Add(this.button1);
            this.panelEnter.Controls.Add(this.textBoxWelcome);
            this.panelEnter.Location = new System.Drawing.Point(1, -2);
            this.panelEnter.Name = "panelEnter";
            this.panelEnter.Size = new System.Drawing.Size(802, 452);
            this.panelEnter.TabIndex = 0;
            // 
            // textBoxWelcome
            // 
            this.textBoxWelcome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWelcome.Location = new System.Drawing.Point(241, 158);
            this.textBoxWelcome.Multiline = true;
            this.textBoxWelcome.Name = "textBoxWelcome";
            this.textBoxWelcome.Size = new System.Drawing.Size(321, 90);
            this.textBoxWelcome.TabIndex = 0;
            this.textBoxWelcome.Text = "Welcome";
            this.textBoxWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Перейти к анкете";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEnter);
            this.Name = "Questionnaire";
            this.Text = "Анкета";
            this.panelEnter.ResumeLayout(false);
            this.panelEnter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnter;
        private System.Windows.Forms.TextBox textBoxWelcome;
        private System.Windows.Forms.Button button1;
    }
}

