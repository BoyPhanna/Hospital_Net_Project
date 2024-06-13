namespace Hospitall_Project
{
    partial class FrmCheckout
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnAddTool = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbxRoom = new System.Windows.Forms.TextBox();
            this.tbxCheckIn = new System.Windows.Forms.TextBox();
            this.tbxMedicine = new System.Windows.Forms.TextBox();
            this.tbxTool = new System.Windows.Forms.TextBox();
            this.tbxToolQty = new System.Windows.Forms.TextBox();
            this.tbxMedicineQty = new System.Windows.Forms.TextBox();
            this.gridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(53, 92);
            this.gridView.Margin = new System.Windows.Forms.Padding(2);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.RowTemplate.Height = 24;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(844, 246);
            this.gridView.TabIndex = 10;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(302, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "កត់ត្រាអាការៈ និង ទូទាត់វិកាយប័ត្រ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(48, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "អត្ដលេខការចូល";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(48, 471);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "ថ្នាំពេទ្យដែលប្រើ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(48, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "ឧបករដែលប្រើ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(48, 527);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "លេខបន្ទប់";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(787, 435);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 49);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "រួចរាល់";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(48, 579);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "ចំនួន";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(48, 634);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "ចំនួន";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.Red;
            this.btnAddMedicine.Location = new System.Drawing.Point(657, 360);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(110, 51);
            this.btnAddMedicine.TabIndex = 14;
            this.btnAddMedicine.Text = "ថែម";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnAddTool
            // 
            this.btnAddTool.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTool.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddTool.Location = new System.Drawing.Point(787, 360);
            this.btnAddTool.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(110, 51);
            this.btnAddTool.TabIndex = 14;
            this.btnAddTool.Text = "ថែម";
            this.btnAddTool.UseVisualStyleBackColor = true;
            this.btnAddTool.Click += new System.EventHandler(this.btnAddTool_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(48, 703);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "ទឹកប្រាក់សរុប";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(198, 709);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(16, 17);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "0";
            // 
            // tbxRoom
            // 
            this.tbxRoom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxRoom.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoom.Location = new System.Drawing.Point(201, 527);
            this.tbxRoom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRoom.Multiline = true;
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.ReadOnly = true;
            this.tbxRoom.Size = new System.Drawing.Size(289, 26);
            this.tbxRoom.TabIndex = 12;
            // 
            // tbxCheckIn
            // 
            this.tbxCheckIn.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCheckIn.Location = new System.Drawing.Point(201, 360);
            this.tbxCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCheckIn.Multiline = true;
            this.tbxCheckIn.Name = "tbxCheckIn";
            this.tbxCheckIn.Size = new System.Drawing.Size(289, 26);
            this.tbxCheckIn.TabIndex = 12;
            this.tbxCheckIn.Click += new System.EventHandler(this.tbxCheckIn_Click);
            this.tbxCheckIn.TextChanged += new System.EventHandler(this.tbxCheckIn_TextChanged);
            // 
            // tbxMedicine
            // 
            this.tbxMedicine.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMedicine.Location = new System.Drawing.Point(201, 471);
            this.tbxMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMedicine.Multiline = true;
            this.tbxMedicine.Name = "tbxMedicine";
            this.tbxMedicine.Size = new System.Drawing.Size(289, 26);
            this.tbxMedicine.TabIndex = 12;
            this.tbxMedicine.Click += new System.EventHandler(this.tbxMedicine_Click);
            // 
            // tbxTool
            // 
            this.tbxTool.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTool.Location = new System.Drawing.Point(201, 419);
            this.tbxTool.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTool.Multiline = true;
            this.tbxTool.Name = "tbxTool";
            this.tbxTool.Size = new System.Drawing.Size(289, 26);
            this.tbxTool.TabIndex = 12;
            this.tbxTool.Click += new System.EventHandler(this.tbxTool_Click);
            this.tbxTool.TextChanged += new System.EventHandler(this.tbxTool_TextChanged);
            // 
            // tbxToolQty
            // 
            this.tbxToolQty.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxToolQty.Location = new System.Drawing.Point(201, 579);
            this.tbxToolQty.Margin = new System.Windows.Forms.Padding(2);
            this.tbxToolQty.Multiline = true;
            this.tbxToolQty.Name = "tbxToolQty";
            this.tbxToolQty.Size = new System.Drawing.Size(289, 26);
            this.tbxToolQty.TabIndex = 12;
            this.tbxToolQty.Click += new System.EventHandler(this.tbxTool_Click);
            // 
            // tbxMedicineQty
            // 
            this.tbxMedicineQty.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMedicineQty.Location = new System.Drawing.Point(201, 634);
            this.tbxMedicineQty.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMedicineQty.Multiline = true;
            this.tbxMedicineQty.Name = "tbxMedicineQty";
            this.tbxMedicineQty.Size = new System.Drawing.Size(289, 26);
            this.tbxMedicineQty.TabIndex = 12;
            this.tbxMedicineQty.Click += new System.EventHandler(this.tbxMedicine_Click);
            // 
            // gridView2
            // 
            this.gridView2.AllowUserToAddRows = false;
            this.gridView2.AllowUserToDeleteRows = false;
            this.gridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView2.Location = new System.Drawing.Point(394, 92);
            this.gridView2.Margin = new System.Windows.Forms.Padding(2);
            this.gridView2.Name = "gridView2";
            this.gridView2.ReadOnly = true;
            this.gridView2.RowHeadersWidth = 51;
            this.gridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.RowTemplate.Height = 24;
            this.gridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView2.Size = new System.Drawing.Size(503, 246);
            this.gridView2.TabIndex = 10;
            this.gridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            this.gridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 765);
            this.Controls.Add(this.btnAddTool);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMedicineQty);
            this.Controls.Add(this.tbxToolQty);
            this.Controls.Add(this.tbxTool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMedicine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCheckIn);
            this.Controls.Add(this.tbxRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView2);
            this.Controls.Add(this.gridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCheckout";
            this.Text = "FrmCheckout";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnAddTool;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbxRoom;
        private System.Windows.Forms.TextBox tbxCheckIn;
        private System.Windows.Forms.TextBox tbxMedicine;
        private System.Windows.Forms.TextBox tbxTool;
        private System.Windows.Forms.TextBox tbxToolQty;
        private System.Windows.Forms.TextBox tbxMedicineQty;
        private System.Windows.Forms.DataGridView gridView2;
    }
}