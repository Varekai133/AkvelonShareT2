namespace Task1
{
    partial class MainForm
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
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSpeedBTN = new System.Windows.Forms.Button();
            this.MatDispBTN = new System.Windows.Forms.Button();
            this.DynamicBTN = new System.Windows.Forms.Button();
            this.ImpositionBTN = new System.Windows.Forms.Button();
            this.PressTimeBTN = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ComplexityBTN = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.DBPBtn = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ClearBDBtn = new System.Windows.Forms.Button();
            this.VectorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.VerifButton = new System.Windows.Forms.Button();
            this.IdentButton = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(13, 76);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(231, 22);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // PasswordSpeedBTN
            // 
            this.PasswordSpeedBTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordSpeedBTN.Location = new System.Drawing.Point(12, 203);
            this.PasswordSpeedBTN.Name = "PasswordSpeedBTN";
            this.PasswordSpeedBTN.Size = new System.Drawing.Size(232, 27);
            this.PasswordSpeedBTN.TabIndex = 1;
            this.PasswordSpeedBTN.Text = "Гистограмма скорости ввода";
            this.PasswordSpeedBTN.UseVisualStyleBackColor = false;
            this.PasswordSpeedBTN.Click += new System.EventHandler(this.PasswordSpeedBTN_Click);
            // 
            // MatDispBTN
            // 
            this.MatDispBTN.Location = new System.Drawing.Point(12, 269);
            this.MatDispBTN.Name = "MatDispBTN";
            this.MatDispBTN.Size = new System.Drawing.Size(231, 27);
            this.MatDispBTN.TabIndex = 2;
            this.MatDispBTN.Text = "Мат. ожидание и дисперсия";
            this.MatDispBTN.UseVisualStyleBackColor = true;
            this.MatDispBTN.Click += new System.EventHandler(this.MatDispBTN_Click);
            // 
            // DynamicBTN
            // 
            this.DynamicBTN.Location = new System.Drawing.Point(12, 236);
            this.DynamicBTN.Name = "DynamicBTN";
            this.DynamicBTN.Size = new System.Drawing.Size(232, 27);
            this.DynamicBTN.TabIndex = 3;
            this.DynamicBTN.Text = "Динамика ввода";
            this.DynamicBTN.UseVisualStyleBackColor = true;
            this.DynamicBTN.Click += new System.EventHandler(this.DynamicBTN_Click);
            // 
            // ImpositionBTN
            // 
            this.ImpositionBTN.Location = new System.Drawing.Point(12, 170);
            this.ImpositionBTN.Name = "ImpositionBTN";
            this.ImpositionBTN.Size = new System.Drawing.Size(232, 27);
            this.ImpositionBTN.TabIndex = 4;
            this.ImpositionBTN.Text = "Число наложений";
            this.ImpositionBTN.UseVisualStyleBackColor = true;
            this.ImpositionBTN.Click += new System.EventHandler(this.ImpositionBTN_Click);
            // 
            // PressTimeBTN
            // 
            this.PressTimeBTN.Location = new System.Drawing.Point(12, 137);
            this.PressTimeBTN.Name = "PressTimeBTN";
            this.PressTimeBTN.Size = new System.Drawing.Size(231, 27);
            this.PressTimeBTN.TabIndex = 5;
            this.PressTimeBTN.Text = "Время удержания";
            this.PressTimeBTN.UseVisualStyleBackColor = true;
            this.PressTimeBTN.Click += new System.EventHandler(this.PressTimeBTN_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(271, 13);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(332, 349);
            this.TextBox.TabIndex = 6;
            // 
            // ComplexityBTN
            // 
            this.ComplexityBTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ComplexityBTN.Location = new System.Drawing.Point(12, 104);
            this.ComplexityBTN.Name = "ComplexityBTN";
            this.ComplexityBTN.Size = new System.Drawing.Size(232, 27);
            this.ComplexityBTN.TabIndex = 7;
            this.ComplexityBTN.Text = "Сложность";
            this.ComplexityBTN.UseVisualStyleBackColor = false;
            this.ComplexityBTN.Click += new System.EventHandler(this.ComplexityBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(12, 302);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(231, 27);
            this.ResetBTN.TabIndex = 8;
            this.ResetBTN.Text = "Сбросить пароль";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // DBPBtn
            // 
            this.DBPBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DBPBtn.Location = new System.Drawing.Point(12, 368);
            this.DBPBtn.Name = "DBPBtn";
            this.DBPBtn.Size = new System.Drawing.Size(231, 27);
            this.DBPBtn.TabIndex = 9;
            this.DBPBtn.Text = "Просмотр БД\r\n";
            this.DBPBtn.UseVisualStyleBackColor = false;
            this.DBPBtn.Click += new System.EventHandler(this.DBBtn_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(13, 28);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(231, 22);
            this.LoginTextBox.TabIndex = 11;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(13, 8);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(47, 17);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(13, 56);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 17);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Пароль";
            // 
            // ClearBDBtn
            // 
            this.ClearBDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearBDBtn.Location = new System.Drawing.Point(271, 368);
            this.ClearBDBtn.Name = "ClearBDBtn";
            this.ClearBDBtn.Size = new System.Drawing.Size(332, 30);
            this.ClearBDBtn.TabIndex = 14;
            this.ClearBDBtn.Text = "Очистить БД";
            this.ClearBDBtn.UseVisualStyleBackColor = false;
            this.ClearBDBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // VectorBtn
            // 
            this.VectorBtn.Location = new System.Drawing.Point(12, 335);
            this.VectorBtn.Name = "VectorBtn";
            this.VectorBtn.Size = new System.Drawing.Size(231, 27);
            this.VectorBtn.TabIndex = 15;
            this.VectorBtn.Text = "БХЧ";
            this.VectorBtn.UseVisualStyleBackColor = true;
            this.VectorBtn.Click += new System.EventHandler(this.VectorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(618, 28);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(192, 22);
            this.IDTextBox.TabIndex = 17;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteButton.Location = new System.Drawing.Point(618, 56);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(192, 27);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditButton.Location = new System.Drawing.Point(618, 89);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(192, 27);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // VerifButton
            // 
            this.VerifButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.VerifButton.Location = new System.Drawing.Point(618, 371);
            this.VerifButton.Name = "VerifButton";
            this.VerifButton.Size = new System.Drawing.Size(192, 27);
            this.VerifButton.TabIndex = 20;
            this.VerifButton.Text = "Верификация";
            this.VerifButton.UseVisualStyleBackColor = false;
            this.VerifButton.Click += new System.EventHandler(this.VerifButton_Click);
            // 
            // IdentButton
            // 
            this.IdentButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IdentButton.Location = new System.Drawing.Point(618, 338);
            this.IdentButton.Name = "IdentButton";
            this.IdentButton.Size = new System.Drawing.Size(192, 27);
            this.IdentButton.TabIndex = 21;
            this.IdentButton.Text = "Идентификация";
            this.IdentButton.UseVisualStyleBackColor = false;
            this.IdentButton.Click += new System.EventHandler(this.IdentButton_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RegisterBTN.Location = new System.Drawing.Point(618, 305);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(192, 27);
            this.RegisterBTN.TabIndex = 22;
            this.RegisterBTN.Text = "Регистрация";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 399);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.IdentButton);
            this.Controls.Add(this.VerifButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VectorBtn);
            this.Controls.Add(this.ClearBDBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.DBPBtn);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.ComplexityBTN);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PressTimeBTN);
            this.Controls.Add(this.ImpositionBTN);
            this.Controls.Add(this.DynamicBTN);
            this.Controls.Add(this.MatDispBTN);
            this.Controls.Add(this.PasswordSpeedBTN);
            this.Controls.Add(this.PasswordTextBox);
            this.Name = "MainForm";
            this.Text = "Почерк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button PasswordSpeedBTN;
        private System.Windows.Forms.Button MatDispBTN;
        private System.Windows.Forms.Button DynamicBTN;
        private System.Windows.Forms.Button ImpositionBTN;
        private System.Windows.Forms.Button PressTimeBTN;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ComplexityBTN;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Button DBPBtn;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button ClearBDBtn;
        private System.Windows.Forms.Button VectorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button VerifButton;
        private System.Windows.Forms.Button IdentButton;
        private System.Windows.Forms.Button RegisterBTN;
    }
}

