namespace JABO
{
    partial class JABO
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
            this.notesOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesOpenButton
            // 
            this.notesOpenButton.FlatAppearance.BorderSize = 0;
            this.notesOpenButton.Location = new System.Drawing.Point(13, 13);
            this.notesOpenButton.Name = "notesOpenButton";
            this.notesOpenButton.Size = new System.Drawing.Size(80, 45);
            this.notesOpenButton.TabIndex = 0;
            this.notesOpenButton.Text = "Open Notes";
            this.notesOpenButton.UseVisualStyleBackColor = true;
            this.notesOpenButton.Click += new System.EventHandler(this.NotesOpenButton_Click);
            // 
            // JABO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.notesOpenButton);
            this.MaximumSize = new System.Drawing.Size(512, 512);
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "JABO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JABO";
            this.Load += new System.EventHandler(this.JABO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notesOpenButton;
    }
}

