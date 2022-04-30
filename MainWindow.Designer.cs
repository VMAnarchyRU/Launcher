namespace VMALauncher_V3._0
{
    partial class MainWin
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
            this.smach = new System.Windows.Forms.Button();
            this.pmach = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // smach
            // 
            this.smach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.smach.Location = new System.Drawing.Point(165, 245);
            this.smach.Name = "smach";
            this.smach.Size = new System.Drawing.Size(152, 78);
            this.smach.TabIndex = 0;
            this.smach.Text = "Стандартные Машины";
            this.smach.UseVisualStyleBackColor = true;
            this.smach.Click += new System.EventHandler(this.smach_Click);
            // 
            // pmach
            // 
            this.pmach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pmach.Location = new System.Drawing.Point(481, 245);
            this.pmach.Name = "pmach";
            this.pmach.Size = new System.Drawing.Size(152, 78);
            this.pmach.TabIndex = 1;
            this.pmach.Text = "Премиум Машины";
            this.pmach.UseVisualStyleBackColor = true;
            this.pmach.Click += new System.EventHandler(this.pmach_Click);
            // 
            // about
            // 
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.about.Location = new System.Drawing.Point(323, 245);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(152, 78);
            this.about.TabIndex = 2;
            this.about.Text = "О Лаунчере";
            this.about.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(165, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 107);
            this.panel1.TabIndex = 3;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VMALauncher_V3._0.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.pmach);
            this.Controls.Add(this.smach);
            this.Name = "MainWin";
            this.Text = "VMALauncher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button smach;
        private System.Windows.Forms.Button pmach;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel panel1;
    }
}

