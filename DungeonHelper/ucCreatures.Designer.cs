namespace DungeonHelper
{
    partial class ucCreatures
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
            this.listCreatures = new System.Windows.Forms.ListBox();
            this.textCreatures = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCreatures
            // 
            this.listCreatures.FormattingEnabled = true;
            this.listCreatures.Items.AddRange(new object[] {
            "Goblin",
            "Owlbear",
            "Bugbear"});
            this.listCreatures.Location = new System.Drawing.Point(14, 43);
            this.listCreatures.Name = "listCreatures";
            this.listCreatures.Size = new System.Drawing.Size(190, 277);
            this.listCreatures.TabIndex = 3;
            this.listCreatures.SelectedIndexChanged += new System.EventHandler(this.ListCreatures_SelectedIndexChanged);
            // 
            // textCreatures
            // 
            this.textCreatures.Location = new System.Drawing.Point(255, 43);
            this.textCreatures.Multiline = true;
            this.textCreatures.Name = "textCreatures";
            this.textCreatures.Size = new System.Drawing.Size(402, 277);
            this.textCreatures.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 14);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить в бой";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ucCreatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textCreatures);
            this.Controls.Add(this.listCreatures);
            this.Name = "ucCreatures";
            this.Size = new System.Drawing.Size(870, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listCreatures;
        private System.Windows.Forms.TextBox textCreatures;
        private System.Windows.Forms.Button buttonAdd;
    }
}
