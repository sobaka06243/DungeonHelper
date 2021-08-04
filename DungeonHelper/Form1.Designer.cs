namespace DungeonHelper
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
            this.buttonCreatures = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreatures
            // 
            this.buttonCreatures.Location = new System.Drawing.Point(1, 1);
            this.buttonCreatures.Name = "buttonCreatures";
            this.buttonCreatures.Size = new System.Drawing.Size(86, 50);
            this.buttonCreatures.TabIndex = 0;
            this.buttonCreatures.Text = "Существа";
            this.buttonCreatures.UseVisualStyleBackColor = true;
            this.buttonCreatures.Click += new System.EventHandler(this.ButtonCreatures_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Заклинания";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 964);
            this.panel1.TabIndex = 2;
            // 
            // buttonBattle
            // 
            this.buttonBattle.Location = new System.Drawing.Point(180, 1);
            this.buttonBattle.Name = "buttonBattle";
            this.buttonBattle.Size = new System.Drawing.Size(99, 50);
            this.buttonBattle.TabIndex = 4;
            this.buttonBattle.Text = "Битва";
            this.buttonBattle.UseVisualStyleBackColor = true;
            this.buttonBattle.Click += new System.EventHandler(this.ButtonBattle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1290, 1033);
            this.Controls.Add(this.buttonBattle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCreatures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreatures;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBattle;
    }
}

