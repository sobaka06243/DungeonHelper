namespace DungeonHelper
{
    partial class ucMagic
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
            this.textMagic = new System.Windows.Forms.TextBox();
            this.listMagic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textMagic
            // 
            this.textMagic.Location = new System.Drawing.Point(244, 3);
            this.textMagic.Multiline = true;
            this.textMagic.Name = "textMagic";
            this.textMagic.Size = new System.Drawing.Size(402, 277);
            this.textMagic.TabIndex = 6;
            // 
            // listMagic
            // 
            this.listMagic.FormattingEnabled = true;
            this.listMagic.Items.AddRange(new object[] {
            "MagicMissile",
            "FireBall",
            "IceKnife"});
            this.listMagic.Location = new System.Drawing.Point(0, 3);
            this.listMagic.Name = "listMagic";
            this.listMagic.Size = new System.Drawing.Size(190, 277);
            this.listMagic.TabIndex = 5;
            this.listMagic.SelectedIndexChanged += new System.EventHandler(this.ListMagic_SelectedIndexChanged);
            // 
            // ucMagic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textMagic);
            this.Controls.Add(this.listMagic);
            this.Name = "ucMagic";
            this.Size = new System.Drawing.Size(666, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMagic;
        private System.Windows.Forms.ListBox listMagic;
    }
}
