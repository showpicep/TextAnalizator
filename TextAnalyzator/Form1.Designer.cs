
namespace TextAnalyzator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.RichTextBox();
            this.Symbol = new System.Windows.Forms.RichTextBox();
            this.prentashWords = new System.Windows.Forms.RichTextBox();
            this.FrequentTWORD = new System.Windows.Forms.RichTextBox();
            this.tHeLonGestWORDS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Введите текст ";
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDownload.Location = new System.Drawing.Point(35, 479);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(305, 75);
            this.ButtonDownload.TabIndex = 1;
            this.ButtonDownload.Text = "Загрузить файл";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 716);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(300, 75);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnalyze.Location = new System.Drawing.Point(420, 716);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(300, 75);
            this.buttonAnalyze.TabIndex = 3;
            this.buttonAnalyze.Text = "Анализировать";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // Words
            // 
            this.Words.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Words.Location = new System.Drawing.Point(420, 21);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(300, 65);
            this.Words.TabIndex = 4;
            this.Words.Text = "";
            // 
            // Symbol
            // 
            this.Symbol.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbol.Location = new System.Drawing.Point(420, 92);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(300, 65);
            this.Symbol.TabIndex = 5;
            this.Symbol.Text = "";
            // 
            // prentashWords
            // 
            this.prentashWords.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prentashWords.Location = new System.Drawing.Point(420, 163);
            this.prentashWords.Name = "prentashWords";
            this.prentashWords.Size = new System.Drawing.Size(300, 175);
            this.prentashWords.TabIndex = 6;
            this.prentashWords.Text = "";
            // 
            // FrequentTWORD
            // 
            this.FrequentTWORD.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrequentTWORD.Location = new System.Drawing.Point(420, 345);
            this.FrequentTWORD.Name = "FrequentTWORD";
            this.FrequentTWORD.Size = new System.Drawing.Size(300, 123);
            this.FrequentTWORD.TabIndex = 7;
            this.FrequentTWORD.Text = "";
            // 
            // tHeLonGestWORDS
            // 
            this.tHeLonGestWORDS.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tHeLonGestWORDS.Location = new System.Drawing.Point(420, 475);
            this.tHeLonGestWORDS.Name = "tHeLonGestWORDS";
            this.tHeLonGestWORDS.Size = new System.Drawing.Size(300, 110);
            this.tHeLonGestWORDS.TabIndex = 8;
            this.tHeLonGestWORDS.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 803);
            this.Controls.Add(this.tHeLonGestWORDS);
            this.Controls.Add(this.FrequentTWORD);
            this.Controls.Add(this.prentashWords);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.RichTextBox Words;
        private System.Windows.Forms.RichTextBox Symbol;
        private System.Windows.Forms.RichTextBox prentashWords;
        private System.Windows.Forms.RichTextBox FrequentTWORD;
        private System.Windows.Forms.RichTextBox tHeLonGestWORDS;
    }
}

