﻿namespace Hospitall_Project
{
    partial class FrmStuff
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
            this.gridStuff = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpkDob = new System.Windows.Forms.DateTimePicker();
            this.btnAddORSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStuff)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStuff
            // 
            this.gridStuff.AllowUserToAddRows = false;
            this.gridStuff.AllowUserToDeleteRows = false;
            this.gridStuff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStuff.Location = new System.Drawing.Point(180, 48);
            this.gridStuff.Name = "gridStuff";
            this.gridStuff.ReadOnly = true;
            this.gridStuff.RowHeadersWidth = 51;
            this.gridStuff.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridStuff.RowTemplate.Height = 24;
            this.gridStuff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStuff.Size = new System.Drawing.Size(743, 261);
            this.gridStuff.TabIndex = 2;
            this.gridStuff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStuff_CellClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Khmer OS Moul Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(459, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 36);
            this.label.TabIndex = 1;
            this.label.Text = "ព័ត៏មានបុគ្គលិក";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // cbxPosition
            // 
            this.cbxPosition.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(739, 363);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(223, 32);
            this.cbxPosition.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(783, 540);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "តួនាទី";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "អត្ដលេខ";
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(241, 329);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(128, 31);
            this.tbxId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ឈ្មោះ";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(241, 366);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(334, 31);
            this.tbxName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ភេទ";
            // 
            // tbxSex
            // 
            this.tbxSex.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSex.Location = new System.Drawing.Point(241, 413);
            this.tbxSex.Name = "tbxSex";
            this.tbxSex.Size = new System.Drawing.Size(334, 31);
            this.tbxSex.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "អាសយដ្ឋាន";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(241, 537);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(334, 67);
            this.tbxAddress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "លេខទូរស័ព្ទ";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(739, 406);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(223, 31);
            this.tbxPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "ប្រាក់ខែ";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.Location = new System.Drawing.Point(739, 457);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(223, 31);
            this.tbxSalary.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // tpkDob
            // 
            this.tpkDob.CustomFormat = "dd-MM-yyyy";
            this.tpkDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpkDob.Location = new System.Drawing.Point(259, 471);
            this.tpkDob.Name = "tpkDob";
            this.tpkDob.Size = new System.Drawing.Size(200, 22);
            this.tpkDob.TabIndex = 7;
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Location = new System.Drawing.Point(903, 540);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddORSave.TabIndex = 4;
            this.btnAddORSave.Text = "Add";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.AddORSave);
            // 
            // FrmStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 607);
            this.Controls.Add(this.tpkDob);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.gridStuff);
            this.Controls.Add(this.label);
            this.Name = "FrmStuff";
            this.Text = "FrmStuff";
            this.Load += new System.EventHandler(this.FrmStuff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStuff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStuff;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tpkDob;
        private System.Windows.Forms.Button btnAddORSave;
    }
}