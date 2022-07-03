namespace Menu
{
    partial class PlayControl
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
            this.ButtonEndless = new System.Windows.Forms.Button();
            this.ButtonPlayWithBoss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEndless
            // 
            this.ButtonEndless.BackColor = System.Drawing.Color.White;
            this.ButtonEndless.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonEndless.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEndless.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonEndless.FlatAppearance.BorderSize = 0;
            this.ButtonEndless.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonEndless.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ButtonEndless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEndless.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEndless.ForeColor = System.Drawing.Color.Black;
            this.ButtonEndless.Image = global::Menu.Properties.Resources.eternity;
            this.ButtonEndless.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEndless.Location = new System.Drawing.Point(0, 75);
            this.ButtonEndless.Name = "ButtonEndless";
            this.ButtonEndless.Size = new System.Drawing.Size(275, 75);
            this.ButtonEndless.TabIndex = 2;
            this.ButtonEndless.Text = "     Бесконечно";
            this.ButtonEndless.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEndless.UseVisualStyleBackColor = false;
            this.ButtonEndless.Click += new System.EventHandler(this.ButtonEndless_Click);
            // 
            // ButtonPlayWithBoss
            // 
            this.ButtonPlayWithBoss.BackColor = System.Drawing.Color.White;
            this.ButtonPlayWithBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPlayWithBoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlayWithBoss.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonPlayWithBoss.FlatAppearance.BorderSize = 0;
            this.ButtonPlayWithBoss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonPlayWithBoss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ButtonPlayWithBoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlayWithBoss.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlayWithBoss.ForeColor = System.Drawing.Color.Black;
            this.ButtonPlayWithBoss.Image = global::Menu.Properties.Resources.boss;
            this.ButtonPlayWithBoss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPlayWithBoss.Location = new System.Drawing.Point(0, 0);
            this.ButtonPlayWithBoss.Name = "ButtonPlayWithBoss";
            this.ButtonPlayWithBoss.Size = new System.Drawing.Size(275, 75);
            this.ButtonPlayWithBoss.TabIndex = 1;
            this.ButtonPlayWithBoss.Text = "     С боссом";
            this.ButtonPlayWithBoss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPlayWithBoss.UseVisualStyleBackColor = false;
            this.ButtonPlayWithBoss.Click += new System.EventHandler(this.ButtonPlayWithBoss_Click);
            // 
            // PlayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonEndless);
            this.Controls.Add(this.ButtonPlayWithBoss);
            this.Name = "PlayControl";
            this.Size = new System.Drawing.Size(620, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlayWithBoss;
        private System.Windows.Forms.Button ButtonEndless;
    }
}
