namespace Menu
{
    partial class SettingsControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDebugEnabled = new System.Windows.Forms.Button();
            this.ButtonDebugDisabled = new System.Windows.Forms.Button();
            this.TextBoxLenght = new System.Windows.Forms.TextBox();
            this.LabelLenght = new System.Windows.Forms.Label();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.LabelDelay = new System.Windows.Forms.Label();
            this.TextBoxDelay = new System.Windows.Forms.TextBox();
            this.ButtonChanceDisabled = new System.Windows.Forms.Button();
            this.ButtonChanceEnabled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = global::Menu.Properties.Resources.vert;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 75);
            this.label2.TabIndex = 15;
            this.label2.Text = "     Высота игрового поля";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = global::Menu.Properties.Resources.debug;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 75);
            this.label5.TabIndex = 14;
            this.label5.Text = "     Режим отладки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = global::Menu.Properties.Resources.chance;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 75);
            this.label4.TabIndex = 13;
            this.label4.Text = "     Шанс появления врагов";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = global::Menu.Properties.Resources.delay;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 75);
            this.label3.TabIndex = 12;
            this.label3.Text = "     Задержка между кадрами";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::Menu.Properties.Resources.horiz;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 75);
            this.label1.TabIndex = 10;
            this.label1.Text = "     Длина игрового поля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonDebugEnabled
            // 
            this.ButtonDebugEnabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDebugEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDebugEnabled.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDebugEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDebugEnabled.Image = global::Menu.Properties.Resources.check;
            this.ButtonDebugEnabled.Location = new System.Drawing.Point(492, 317);
            this.ButtonDebugEnabled.Name = "ButtonDebugEnabled";
            this.ButtonDebugEnabled.Size = new System.Drawing.Size(41, 41);
            this.ButtonDebugEnabled.TabIndex = 20;
            this.ButtonDebugEnabled.UseVisualStyleBackColor = true;
            this.ButtonDebugEnabled.Click += new System.EventHandler(this.ButtonDebugEnabled_Click);
            // 
            // ButtonDebugDisabled
            // 
            this.ButtonDebugDisabled.BackColor = System.Drawing.Color.White;
            this.ButtonDebugDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDebugDisabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDebugDisabled.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonDebugDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDebugDisabled.Location = new System.Drawing.Point(492, 317);
            this.ButtonDebugDisabled.Name = "ButtonDebugDisabled";
            this.ButtonDebugDisabled.Size = new System.Drawing.Size(41, 41);
            this.ButtonDebugDisabled.TabIndex = 21;
            this.ButtonDebugDisabled.UseVisualStyleBackColor = false;
            this.ButtonDebugDisabled.Click += new System.EventHandler(this.ButtonDebugDisabled_Click);
            // 
            // TextBoxLenght
            // 
            this.TextBoxLenght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLenght.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLenght.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxLenght.Location = new System.Drawing.Point(460, 17);
            this.TextBoxLenght.MaxLength = 4;
            this.TextBoxLenght.Name = "TextBoxLenght";
            this.TextBoxLenght.Size = new System.Drawing.Size(100, 41);
            this.TextBoxLenght.TabIndex = 24;
            this.TextBoxLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxLenght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLenght_KeyPress);
            this.TextBoxLenght.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBoxLenght_MouseDown);
            this.TextBoxLenght.MouseLeave += new System.EventHandler(this.TextBoxLenght_MouseLeave);
            this.TextBoxLenght.MouseHover += new System.EventHandler(this.TextBoxLenght_MouseHover);
            // 
            // LabelLenght
            // 
            this.LabelLenght.AutoSize = true;
            this.LabelLenght.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLenght.Location = new System.Drawing.Point(457, 61);
            this.LabelLenght.Name = "LabelLenght";
            this.LabelLenght.Size = new System.Drawing.Size(0, 17);
            this.LabelLenght.TabIndex = 25;
            this.LabelLenght.Visible = false;
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHeight.Location = new System.Drawing.Point(457, 136);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(0, 17);
            this.LabelHeight.TabIndex = 27;
            this.LabelHeight.Visible = false;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxHeight.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxHeight.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxHeight.Location = new System.Drawing.Point(460, 92);
            this.TextBoxHeight.MaxLength = 4;
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 41);
            this.TextBoxHeight.TabIndex = 26;
            this.TextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHeight_KeyPress);
            this.TextBoxHeight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBoxHeight_MouseDown);
            this.TextBoxHeight.MouseLeave += new System.EventHandler(this.TextBoxHeight_MouseLeave);
            this.TextBoxHeight.MouseHover += new System.EventHandler(this.TextBoxHeight_MouseHover);
            // 
            // LabelDelay
            // 
            this.LabelDelay.AutoSize = true;
            this.LabelDelay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDelay.Location = new System.Drawing.Point(457, 211);
            this.LabelDelay.Name = "LabelDelay";
            this.LabelDelay.Size = new System.Drawing.Size(0, 17);
            this.LabelDelay.TabIndex = 29;
            this.LabelDelay.Visible = false;
            // 
            // TextBoxDelay
            // 
            this.TextBoxDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDelay.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDelay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxDelay.Location = new System.Drawing.Point(460, 167);
            this.TextBoxDelay.MaxLength = 4;
            this.TextBoxDelay.Name = "TextBoxDelay";
            this.TextBoxDelay.Size = new System.Drawing.Size(100, 41);
            this.TextBoxDelay.TabIndex = 28;
            this.TextBoxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDelay_KeyPress);
            this.TextBoxDelay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBoxDelay_MouseDown);
            this.TextBoxDelay.MouseLeave += new System.EventHandler(this.TextBoxDelay_MouseLeave);
            this.TextBoxDelay.MouseHover += new System.EventHandler(this.TextBoxDelay_MouseHover);
            // 
            // ButtonChanceDisabled
            // 
            this.ButtonChanceDisabled.BackColor = System.Drawing.Color.White;
            this.ButtonChanceDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonChanceDisabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChanceDisabled.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonChanceDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChanceDisabled.Location = new System.Drawing.Point(492, 242);
            this.ButtonChanceDisabled.Name = "ButtonChanceDisabled";
            this.ButtonChanceDisabled.Size = new System.Drawing.Size(41, 41);
            this.ButtonChanceDisabled.TabIndex = 31;
            this.ButtonChanceDisabled.UseVisualStyleBackColor = false;
            this.ButtonChanceDisabled.Click += new System.EventHandler(this.ButtonChanceDisabled_Click);
            // 
            // ButtonChanceEnabled
            // 
            this.ButtonChanceEnabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonChanceEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChanceEnabled.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonChanceEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChanceEnabled.Image = global::Menu.Properties.Resources.check;
            this.ButtonChanceEnabled.Location = new System.Drawing.Point(492, 242);
            this.ButtonChanceEnabled.Name = "ButtonChanceEnabled";
            this.ButtonChanceEnabled.Size = new System.Drawing.Size(41, 41);
            this.ButtonChanceEnabled.TabIndex = 30;
            this.ButtonChanceEnabled.UseVisualStyleBackColor = true;
            this.ButtonChanceEnabled.Click += new System.EventHandler(this.ButtonChanceEnabled_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonChanceDisabled);
            this.Controls.Add(this.ButtonChanceEnabled);
            this.Controls.Add(this.LabelDelay);
            this.Controls.Add(this.TextBoxDelay);
            this.Controls.Add(this.LabelHeight);
            this.Controls.Add(this.TextBoxHeight);
            this.Controls.Add(this.LabelLenght);
            this.Controls.Add(this.TextBoxLenght);
            this.Controls.Add(this.ButtonDebugDisabled);
            this.Controls.Add(this.ButtonDebugEnabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(620, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDebugEnabled;
        private System.Windows.Forms.Button ButtonDebugDisabled;
        private System.Windows.Forms.TextBox TextBoxLenght;
        private System.Windows.Forms.Label LabelLenght;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.Label LabelDelay;
        private System.Windows.Forms.TextBox TextBoxDelay;
        private System.Windows.Forms.Button ButtonChanceDisabled;
        private System.Windows.Forms.Button ButtonChanceEnabled;
    }
}
