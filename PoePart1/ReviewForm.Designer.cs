namespace PoePart1
{
    partial class ReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtReviewLocation;
        private System.Windows.Forms.TextBox txtReviewCategory;
        private System.Windows.Forms.RichTextBox rtbReviewDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReviewLocation = new System.Windows.Forms.TextBox();
            this.txtReviewCategory = new System.Windows.Forms.TextBox();
            this.rtbReviewDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.txtReviewLocation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReviewCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbReviewDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtReviewLocation
            // 
            this.txtReviewLocation.BackColor = System.Drawing.Color.Silver;
            this.txtReviewLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReviewLocation.Location = new System.Drawing.Point(3, 3);
            this.txtReviewLocation.Name = "txtReviewLocation";
            this.txtReviewLocation.ReadOnly = true;
            this.txtReviewLocation.Size = new System.Drawing.Size(354, 22);
            this.txtReviewLocation.TabIndex = 0;
            // 
            // txtReviewCategory
            // 
            this.txtReviewCategory.BackColor = System.Drawing.Color.Silver;
            this.txtReviewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReviewCategory.Location = new System.Drawing.Point(3, 98);
            this.txtReviewCategory.Name = "txtReviewCategory";
            this.txtReviewCategory.ReadOnly = true;
            this.txtReviewCategory.Size = new System.Drawing.Size(354, 22);
            this.txtReviewCategory.TabIndex = 1;
            // 
            // rtbReviewDescription
            // 
            this.rtbReviewDescription.BackColor = System.Drawing.Color.Silver;
            this.rtbReviewDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReviewDescription.Location = new System.Drawing.Point(3, 193);
            this.rtbReviewDescription.Name = "rtbReviewDescription";
            this.rtbReviewDescription.ReadOnly = true;
            this.rtbReviewDescription.Size = new System.Drawing.Size(354, 146);
            this.rtbReviewDescription.TabIndex = 2;
            this.rtbReviewDescription.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(363, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(234, 336);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(3, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(354, 34);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReviewForm";
            this.Text = "Review Your Inputs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
