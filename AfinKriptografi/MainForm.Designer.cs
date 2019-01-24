namespace AfinKriptografi
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
            this.bntGenerateKeys = new System.Windows.Forms.Button();
            this.tKey1 = new System.Windows.Forms.TextBox();
            this.tKey2 = new System.Windows.Forms.TextBox();
            this.tMessageIn = new System.Windows.Forms.TextBox();
            this.tMessageOut = new System.Windows.Forms.TextBox();
            this.btnEncript = new System.Windows.Forms.Button();
            this.btnDecript = new System.Windows.Forms.Button();
            this.lText = new System.Windows.Forms.Label();
            this.lMessageOut = new System.Windows.Forms.Label();
            this.lKey1 = new System.Windows.Forms.Label();
            this.lKey2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntGenerateKeys
            // 
            this.bntGenerateKeys.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntGenerateKeys.Location = new System.Drawing.Point(30, 81);
            this.bntGenerateKeys.Name = "bntGenerateKeys";
            this.bntGenerateKeys.Size = new System.Drawing.Size(148, 31);
            this.bntGenerateKeys.TabIndex = 0;
            this.bntGenerateKeys.Text = "Сгенерировать ключи";
            this.bntGenerateKeys.UseVisualStyleBackColor = true;
            this.bntGenerateKeys.Click += new System.EventHandler(this.bntGenerateKeys_Click);
            // 
            // tKey1
            // 
            this.tKey1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tKey1.Location = new System.Drawing.Point(75, 31);
            this.tKey1.Name = "tKey1";
            this.tKey1.Size = new System.Drawing.Size(103, 20);
            this.tKey1.TabIndex = 1;
            // 
            // tKey2
            // 
            this.tKey2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tKey2.Location = new System.Drawing.Point(75, 55);
            this.tKey2.Name = "tKey2";
            this.tKey2.Size = new System.Drawing.Size(103, 20);
            this.tKey2.TabIndex = 2;
            // 
            // tMessageIn
            // 
            this.tMessageIn.Location = new System.Drawing.Point(73, 29);
            this.tMessageIn.Multiline = true;
            this.tMessageIn.Name = "tMessageIn";
            this.tMessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tMessageIn.Size = new System.Drawing.Size(311, 34);
            this.tMessageIn.TabIndex = 6;
            // 
            // tMessageOut
            // 
            this.tMessageOut.Location = new System.Drawing.Point(73, 70);
            this.tMessageOut.Multiline = true;
            this.tMessageOut.Name = "tMessageOut";
            this.tMessageOut.ReadOnly = true;
            this.tMessageOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tMessageOut.Size = new System.Drawing.Size(311, 36);
            this.tMessageOut.TabIndex = 7;
            // 
            // btnEncript
            // 
            this.btnEncript.Location = new System.Drawing.Point(73, 114);
            this.btnEncript.Name = "btnEncript";
            this.btnEncript.Size = new System.Drawing.Size(94, 30);
            this.btnEncript.TabIndex = 8;
            this.btnEncript.Text = "Зашифровать";
            this.btnEncript.UseVisualStyleBackColor = true;
            this.btnEncript.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // btnDecript
            // 
            this.btnDecript.Location = new System.Drawing.Point(189, 114);
            this.btnDecript.Name = "btnDecript";
            this.btnDecript.Size = new System.Drawing.Size(97, 30);
            this.btnDecript.TabIndex = 9;
            this.btnDecript.Text = "Расшифровать";
            this.btnDecript.UseVisualStyleBackColor = true;
            this.btnDecript.Click += new System.EventHandler(this.btnDecript_Click);
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Location = new System.Drawing.Point(5, 32);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(68, 13);
            this.lText.TabIndex = 10;
            this.lText.Text = "Сообщение:";
            // 
            // lMessageOut
            // 
            this.lMessageOut.AutoSize = true;
            this.lMessageOut.Location = new System.Drawing.Point(5, 71);
            this.lMessageOut.Name = "lMessageOut";
            this.lMessageOut.Size = new System.Drawing.Size(62, 13);
            this.lMessageOut.TabIndex = 11;
            this.lMessageOut.Text = "Результат:";
            // 
            // lKey1
            // 
            this.lKey1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lKey1.AutoSize = true;
            this.lKey1.Location = new System.Drawing.Point(27, 34);
            this.lKey1.Name = "lKey1";
            this.lKey1.Size = new System.Drawing.Size(45, 13);
            this.lKey1.TabIndex = 14;
            this.lKey1.Text = "Ключ 1:";
            // 
            // lKey2
            // 
            this.lKey2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lKey2.AutoSize = true;
            this.lKey2.Location = new System.Drawing.Point(27, 58);
            this.lKey2.Name = "lKey2";
            this.lKey2.Size = new System.Drawing.Size(45, 13);
            this.lKey2.TabIndex = 15;
            this.lKey2.Text = "Ключ 2:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(498, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 22);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(390, 28);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(83, 21);
            this.bCopy.TabIndex = 17;
            this.bCopy.Text = "Вставить";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tKey2);
            this.groupBox1.Controls.Add(this.bntGenerateKeys);
            this.groupBox1.Controls.Add(this.tKey1);
            this.groupBox1.Controls.Add(this.lKey2);
            this.groupBox1.Controls.Add(this.lKey1);
            this.groupBox1.Location = new System.Drawing.Point(498, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод ключей";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 19;
            this.button1.Text = "Копировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lText);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tMessageIn);
            this.groupBox2.Controls.Add(this.tMessageOut);
            this.groupBox2.Controls.Add(this.bCopy);
            this.groupBox2.Controls.Add(this.btnEncript);
            this.groupBox2.Controls.Add(this.btnDecript);
            this.groupBox2.Controls.Add(this.lMessageOut);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 163);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шифрование сообщения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 187);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Name = "MainForm";
            this.Text = "Афинный шифр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntGenerateKeys;
        private System.Windows.Forms.TextBox tKey1;
        private System.Windows.Forms.TextBox tKey2;
        private System.Windows.Forms.TextBox tMessageIn;
        private System.Windows.Forms.TextBox tMessageOut;
        private System.Windows.Forms.Button btnEncript;
        private System.Windows.Forms.Button btnDecript;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.Label lMessageOut;
        private System.Windows.Forms.Label lKey1;
        private System.Windows.Forms.Label lKey2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

