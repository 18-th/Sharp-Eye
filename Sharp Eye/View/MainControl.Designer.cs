namespace View
{
    partial class MainControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.logBox = new System.Windows.Forms.GroupBox();
            this.logView = new System.Windows.Forms.ListBox();
            this.logBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.SystemColors.Control;
            this.logBox.Controls.Add(this.logView);
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(3, 279);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(760, 109);
            this.logBox.TabIndex = 0;
            this.logBox.TabStop = false;
            this.logBox.Text = "Журнал";
            this.logBox.Paint += new System.Windows.Forms.PaintEventHandler(this.logBox_Paint);
            // 
            // logView
            // 
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.FormattingEnabled = true;
            this.logView.ItemHeight = 20;
            this.logView.Location = new System.Drawing.Point(3, 22);
            this.logView.Margin = new System.Windows.Forms.Padding(5);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(754, 84);
            this.logView.TabIndex = 0;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logBox);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(766, 391);
            this.logBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logBox;
        private System.Windows.Forms.ListBox logView;
    }
}
