namespace Hospitall_Project
{
    partial class FrmMedicine
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
            this.gridMedicine = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDecription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.btnAddORSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMedicine
            // 
            this.gridMedicine.AllowUserToAddRows = false;
            this.gridMedicine.AllowUserToDeleteRows = false;
            this.gridMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicine.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMedicine.Location = new System.Drawing.Point(180, 75);
            this.gridMedicine.Name = "gridMedicine";
            this.gridMedicine.ReadOnly = true;
            this.gridMedicine.RowHeadersWidth = 51;
            this.gridMedicine.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMedicine.RowTemplate.Height = 24;
            this.gridMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMedicine.Size = new System.Drawing.Size(779, 261);
            this.gridMedicine.TabIndex = 4;
            this.gridMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMedicine_CellClick);
            this.gridMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMedicine_CellContentClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Khmer OS Moul Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(477, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(173, 36);
            this.label.TabIndex = 3;
            this.label.Text = "ព័ត៏មានថ្នាំពេទ្យ";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(299, 398);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(334, 31);
            this.tbxName.TabIndex = 9;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ឈ្មោះ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(299, 361);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(128, 31);
            this.tbxId.TabIndex = 10;
            this.tbxId.TextChanged += new System.EventHandler(this.tbxId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "អត្ដលេខ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "ព័ត៏មានលំអិត";
            // 
            // tbxDecription
            // 
            this.tbxDecription.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDecription.Location = new System.Drawing.Point(299, 447);
            this.tbxDecription.Multiline = true;
            this.tbxDecription.Name = "tbxDecription";
            this.tbxDecription.Size = new System.Drawing.Size(334, 88);
            this.tbxDecription.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ចំនួន";
            // 
            // tbxQty
            // 
            this.tbxQty.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQty.Location = new System.Drawing.Point(756, 398);
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(185, 31);
            this.tbxQty.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(649, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "តម្លៃ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(756, 447);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(185, 31);
            this.tbxPrice.TabIndex = 9;
            this.tbxPrice.TextChanged += new System.EventHandler(this.tbxPrice_TextChanged);
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Location = new System.Drawing.Point(866, 512);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddORSave.TabIndex = 11;
            this.btnAddORSave.Text = "Add";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.btnAddORSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(746, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 618);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxDecription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridMedicine);
            this.Controls.Add(this.label);
            this.Name = "FrmMedicine";
            this.Text = "FrmMedicine";
            this.Load += new System.EventHandler(this.FrmMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMedicine;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDecription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Button btnAddORSave;
        private System.Windows.Forms.Button btnDelete;
    }
}