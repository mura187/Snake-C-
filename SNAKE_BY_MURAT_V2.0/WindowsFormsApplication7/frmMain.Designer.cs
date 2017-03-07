namespace WindowsFormsApplication7
{
    partial class lbl
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbl));
            this.labelMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Century Gothic", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMenu.Location = new System.Drawing.Point(396, 332);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(447, 40);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Нажми Enter чтобы начать";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Score is:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 716);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Level is:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1348, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 800);
            this.MinimumSize = new System.Drawing.Size(1366, 800);
            this.Name = "lbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Начали?";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.labelMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.labelMenu_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelMenu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

