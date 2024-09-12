namespace PoePart1
{
    partial class ReportIssuesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLocation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUploadFile, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnBackToMainMenu, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Silver;
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Location = new System.Drawing.Point(3, 48);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(394, 61);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 67);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Silver;
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities",
            "Public Safety",
            "Parks and Recreation"});
            this.cmbCategory.Location = new System.Drawing.Point(3, 182);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(394, 24);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(403, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.Silver;
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Location = new System.Drawing.Point(403, 48);
            this.rtbDescription.Name = "rtbDescription";
            this.tableLayoutPanel1.SetRowSpan(this.rtbDescription, 3);
            this.rtbDescription.Size = new System.Drawing.Size(394, 285);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.ForeColor = System.Drawing.Color.White;
            this.btnUploadFile.Location = new System.Drawing.Point(3, 339);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(394, 39);
            this.btnUploadFile.TabIndex = 6;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(3, 384);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(394, 63);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackToMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(403, 384);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(394, 63);
            this.btnBackToMainMenu.TabIndex = 8;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(403, 339);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(394, 39);
            this.progressBar1.TabIndex = 9;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
