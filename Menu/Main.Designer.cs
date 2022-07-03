namespace Menu
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.EmptyControl_ = new Menu.EmptyControl();
            this.PlayControl_ = new Menu.PlayControl();
            this.SettingsControl_ = new Menu.SettingsControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Black;
            this.SidePanel.Location = new System.Drawing.Point(4, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 75);
            this.SidePanel.TabIndex = 3;
            this.SidePanel.Visible = false;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BackColor = System.Drawing.Color.Black;
            this.MiddlePanel.Location = new System.Drawing.Point(289, 4);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(10, 374);
            this.MiddlePanel.TabIndex = 5;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.White;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.ForeColor = System.Drawing.Color.Black;
            this.ButtonClose.Image = global::Menu.Properties.Resources.close;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(14, 154);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(275, 75);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "     Закрыть";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.White;
            this.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSettings.ForeColor = System.Drawing.Color.Black;
            this.ButtonSettings.Image = global::Menu.Properties.Resources.settings;
            this.ButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSettings.Location = new System.Drawing.Point(14, 79);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(275, 75);
            this.ButtonSettings.TabIndex = 4;
            this.ButtonSettings.Text = "     Настройки";
            this.ButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.White;
            this.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ButtonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlay.ForeColor = System.Drawing.Color.Black;
            this.ButtonPlay.Image = global::Menu.Properties.Resources.play;
            this.ButtonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPlay.Location = new System.Drawing.Point(14, 4);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(275, 75);
            this.ButtonPlay.TabIndex = 0;
            this.ButtonPlay.Text = "     Играть";
            this.ButtonPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // EmptyControl_
            // 
            this.EmptyControl_.BackColor = System.Drawing.Color.White;
            this.EmptyControl_.Location = new System.Drawing.Point(299, 4);
            this.EmptyControl_.Name = "EmptyControl_";
            this.EmptyControl_.Size = new System.Drawing.Size(576, 375);
            this.EmptyControl_.TabIndex = 9;
            // 
            // PlayControl_
            // 
            this.PlayControl_.BackColor = System.Drawing.Color.White;
            this.PlayControl_.Location = new System.Drawing.Point(299, 4);
            this.PlayControl_.Name = "PlayControl_";
            this.PlayControl_.Size = new System.Drawing.Size(576, 375);
            this.PlayControl_.TabIndex = 8;
            // 
            // SettingsControl_
            // 
            this.SettingsControl_.BackColor = System.Drawing.Color.White;
            this.SettingsControl_.Location = new System.Drawing.Point(303, 4);
            this.SettingsControl_.Name = "SettingsControl_";
            this.SettingsControl_.Size = new System.Drawing.Size(576, 375);
            this.SettingsControl_.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 382);
            this.Controls.Add(this.EmptyControl_);
            this.Controls.Add(this.PlayControl_);
            this.Controls.Add(this.SettingsControl_);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SettingsControl SettingsControl_;
        private PlayControl PlayControl_;
        private EmptyControl EmptyControl_;
    }
}

