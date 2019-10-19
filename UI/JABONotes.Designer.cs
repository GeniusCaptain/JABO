namespace JABO
{
    partial class JABONotes
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
			this.btnMessage = new System.Windows.Forms.Button();
			this.txtTodoMessage = new System.Windows.Forms.TextBox();
			this.lstTodoMessages = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnMessage
			// 
			this.btnMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMessage.Location = new System.Drawing.Point(270, 392);
			this.btnMessage.Name = "btnMessage";
			this.btnMessage.Size = new System.Drawing.Size(150, 46);
			this.btnMessage.TabIndex = 0;
			this.btnMessage.Text = "Добавить";
			this.btnMessage.UseVisualStyleBackColor = true;
			// 
			// txtTodoMessage
			// 
			this.txtTodoMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTodoMessage.Location = new System.Drawing.Point(13, 392);
			this.txtTodoMessage.Multiline = true;
			this.txtTodoMessage.Name = "txtTodoMessage";
			this.txtTodoMessage.Size = new System.Drawing.Size(251, 46);
			this.txtTodoMessage.TabIndex = 1;
			// 
			// lstTodoMessages
			// 
			this.lstTodoMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstTodoMessages.FormattingEnabled = true;
			this.lstTodoMessages.Location = new System.Drawing.Point(13, 18);
			this.lstTodoMessages.Name = "lstTodoMessages";
			this.lstTodoMessages.Size = new System.Drawing.Size(407, 368);
			this.lstTodoMessages.TabIndex = 2;
			// 
			// JABONotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 450);
			this.Controls.Add(this.lstTodoMessages);
			this.Controls.Add(this.txtTodoMessage);
			this.Controls.Add(this.btnMessage);
			this.MaximumSize = new System.Drawing.Size(1024, 1024);
			this.MinimumSize = new System.Drawing.Size(448, 489);
			this.Name = "JABONotes";
			this.Text = "JABONotes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JABONotes_FormClosing);
			this.Load += new System.EventHandler(this.JABONotes_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnMessage;
		private System.Windows.Forms.TextBox txtTodoMessage;
		private System.Windows.Forms.ListBox lstTodoMessages;
	}
}