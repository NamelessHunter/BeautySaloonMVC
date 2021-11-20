namespace BeautySaloonMVC.View
{
    partial class ProductView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 30, 30, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProductName.Location = new System.Drawing.Point(6, 258);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(332, 61);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Название";
            this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // labelCost
            // 
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCost.Location = new System.Drawing.Point(75, 328);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(164, 23);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Цена";
            // 
            // labelActive
            // 
            this.labelActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActive.Location = new System.Drawing.Point(102, 371);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(100, 23);
            this.labelActive.TabIndex = 3;
            this.labelActive.Text = "Не активен";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(338, 412);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelActive;
    }
}
