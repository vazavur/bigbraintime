namespace bigbraintime
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рандомайзерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вФайлtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посланиеРазработчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputtext_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.посланиеРазработчикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изФайлаToolStripMenuItem,
            this.рандомайзерToolStripMenuItem,
            this.заданиеToolStripMenuItem,
            this.гистограммаtoolStripMenuItem,
            this.вФайлtoolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // изФайлаToolStripMenuItem
            // 
            this.изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            this.изФайлаToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.изФайлаToolStripMenuItem.Text = "Из файла";
            this.изФайлаToolStripMenuItem.Click += new System.EventHandler(this.изФайлаToolStripMenuItem_Click);
            // 
            // рандомайзерToolStripMenuItem
            // 
            this.рандомайзерToolStripMenuItem.Name = "рандомайзерToolStripMenuItem";
            this.рандомайзерToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.рандомайзерToolStripMenuItem.Text = "Рандомайзер";
            this.рандомайзерToolStripMenuItem.Click += new System.EventHandler(this.рандомайзерToolStripMenuItem_Click);
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.заданиеToolStripMenuItem.Text = "Задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.заданиеToolStripMenuItem_Click);
            // 
            // гистограммаtoolStripMenuItem
            // 
            this.гистограммаtoolStripMenuItem.Name = "гистограммаtoolStripMenuItem";
            this.гистограммаtoolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.гистограммаtoolStripMenuItem.Text = "Гистограмма";
            this.гистограммаtoolStripMenuItem.Click += new System.EventHandler(this.гистограммаtoolStripMenuItem_Click);
            // 
            // вФайлtoolStripMenuItem
            // 
            this.вФайлtoolStripMenuItem.Name = "вФайлtoolStripMenuItem";
            this.вФайлtoolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.вФайлtoolStripMenuItem.Text = "В файл";
            this.вФайлtoolStripMenuItem.Click += new System.EventHandler(this.вФайлtoolStripMenuItem_Click);
            // 
            // посланиеРазработчикаToolStripMenuItem
            // 
            this.посланиеРазработчикаToolStripMenuItem.Name = "посланиеРазработчикаToolStripMenuItem";
            this.посланиеРазработчикаToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.посланиеРазработчикаToolStripMenuItem.Text = "Послание разработчика";
            this.посланиеРазработчикаToolStripMenuItem.Click += new System.EventHandler(this.посланиеРазработчикаToolStripMenuItem_Click);
            // 
            // outputtext_textBox
            // 
            this.outputtext_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.outputtext_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputtext_textBox.Location = new System.Drawing.Point(12, 36);
            this.outputtext_textBox.Multiline = true;
            this.outputtext_textBox.Name = "outputtext_textBox";
            this.outputtext_textBox.Size = new System.Drawing.Size(583, 240);
            this.outputtext_textBox.TabIndex = 1;
            this.outputtext_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outputtext_textBox.TextChanged += new System.EventHandler(this.outputtext_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputtext_textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "BIGBRAINTIME";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рандомайзерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вФайлtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посланиеРазработчикаToolStripMenuItem;
        private System.Windows.Forms.TextBox outputtext_textBox;
        private System.Windows.Forms.Button button1;
    }
}