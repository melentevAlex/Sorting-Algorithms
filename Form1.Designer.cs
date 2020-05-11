namespace WindowsFormsApp14
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.shakerButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.originalBbutton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.timeOfShaker = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gen2 = new System.Windows.Forms.Label();
            this.sw = new System.Windows.Forms.Label();
            this.bu = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.countButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.ExtractButton3 = new System.Windows.Forms.Button();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.ExLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(69, 450);
            this.listBox1.TabIndex = 0;
            // 
            // shakerButton
            // 
            this.shakerButton.Location = new System.Drawing.Point(446, 172);
            this.shakerButton.Name = "shakerButton";
            this.shakerButton.Size = new System.Drawing.Size(75, 23);
            this.shakerButton.TabIndex = 1;
            this.shakerButton.Text = "Shaker";
            this.shakerButton.UseVisualStyleBackColor = true;
            this.shakerButton.Click += new System.EventHandler(this.shakerButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(69, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(69, 450);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(138, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.ScrollAlwaysVisible = true;
            this.listBox3.Size = new System.Drawing.Size(69, 450);
            this.listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(207, 0);
            this.listBox4.Name = "listBox4";
            this.listBox4.ScrollAlwaysVisible = true;
            this.listBox4.Size = new System.Drawing.Size(69, 450);
            this.listBox4.TabIndex = 4;
            // 
            // originalBbutton
            // 
            this.originalBbutton.Location = new System.Drawing.Point(446, 108);
            this.originalBbutton.Name = "originalBbutton";
            this.originalBbutton.Size = new System.Drawing.Size(75, 23);
            this.originalBbutton.TabIndex = 5;
            this.originalBbutton.Text = "Original array";
            this.originalBbutton.UseVisualStyleBackColor = true;
            this.originalBbutton.Click += new System.EventHandler(this.originalBbutton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(446, 288);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.Location = new System.Drawing.Point(446, 201);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(75, 23);
            this.bubbleButton.TabIndex = 7;
            this.bubbleButton.Text = "Bubble";
            this.bubbleButton.UseVisualStyleBackColor = true;
            this.bubbleButton.Click += new System.EventHandler(this.bubbleButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(446, 143);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(75, 23);
            this.switchButton.TabIndex = 8;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // timeOfShaker
            // 
            this.timeOfShaker.AutoSize = true;
            this.timeOfShaker.Location = new System.Drawing.Point(603, 177);
            this.timeOfShaker.Name = "timeOfShaker";
            this.timeOfShaker.Size = new System.Drawing.Size(18, 13);
            this.timeOfShaker.TabIndex = 9;
            this.timeOfShaker.Text = "sh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Spent time";
            // 
            // gen2
            // 
            this.gen2.AutoSize = true;
            this.gen2.Location = new System.Drawing.Point(603, 113);
            this.gen2.Name = "gen2";
            this.gen2.Size = new System.Drawing.Size(31, 13);
            this.gen2.TabIndex = 12;
            this.gen2.Text = "gen2";
            this.gen2.UseMnemonic = false;
            // 
            // sw
            // 
            this.sw.AutoSize = true;
            this.sw.Location = new System.Drawing.Point(603, 148);
            this.sw.Name = "sw";
            this.sw.Size = new System.Drawing.Size(20, 13);
            this.sw.TabIndex = 13;
            this.sw.Text = "sw";
            // 
            // bu
            // 
            this.bu.AutoSize = true;
            this.bu.Location = new System.Drawing.Point(603, 206);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(19, 13);
            this.bu.TabIndex = 14;
            this.bu.Text = "bu";
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.Location = new System.Drawing.Point(603, 293);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(15, 13);
            this.cl.TabIndex = 15;
            this.cl.Text = "cl";
            // 
            // listBox5
            // 
            this.listBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(276, 0);
            this.listBox5.Name = "listBox5";
            this.listBox5.ScrollAlwaysVisible = true;
            this.listBox5.Size = new System.Drawing.Size(69, 450);
            this.listBox5.TabIndex = 16;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(446, 230);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 17;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(603, 235);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(25, 13);
            this.countLabel.TabIndex = 18;
            this.countLabel.Text = "cou";
            // 
            // ExtractButton3
            // 
            this.ExtractButton3.Location = new System.Drawing.Point(446, 259);
            this.ExtractButton3.Name = "ExtractButton3";
            this.ExtractButton3.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton3.TabIndex = 23;
            this.ExtractButton3.Text = "Extract";
            this.ExtractButton3.UseVisualStyleBackColor = true;
            this.ExtractButton3.Click += new System.EventHandler(this.extractButton3_Click);
            // 
            // listBox8
            // 
            this.listBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(345, 0);
            this.listBox8.Name = "listBox8";
            this.listBox8.ScrollAlwaysVisible = true;
            this.listBox8.Size = new System.Drawing.Size(69, 450);
            this.listBox8.TabIndex = 24;
            // 
            // ExLable
            // 
            this.ExLable.AutoSize = true;
            this.ExLable.Location = new System.Drawing.Point(603, 264);
            this.ExLable.Name = "ExLable";
            this.ExLable.Size = new System.Drawing.Size(18, 13);
            this.ExLable.TabIndex = 25;
            this.ExLable.Text = "ex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExLable);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.ExtractButton3);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.bu);
            this.Controls.Add(this.sw);
            this.Controls.Add(this.gen2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeOfShaker);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.originalBbutton);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.shakerButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button shakerButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button originalBbutton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button bubbleButton;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Label timeOfShaker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gen2;
        private System.Windows.Forms.Label sw;
        private System.Windows.Forms.Label bu;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button ExtractButton3;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.Label ExLable;
    }
}

