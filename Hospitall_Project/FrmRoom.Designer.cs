namespace Hospitall_Project
{
    partial class FrmRoom
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
            this.btnAddORSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridRoom = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radioFree = new System.Windows.Forms.RadioButton();
            this.radioBusy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Location = new System.Drawing.Point(413, 368);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(67, 23);
            this.btnAddORSave.TabIndex = 28;
            this.btnAddORSave.Text = "Add";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.btnAddORSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "ឈ្មោះ";
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(180, 360);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(120, 31);
            this.tbxId.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "អត្ដលេខ";
            // 
            // gridRoom
            // 
            this.gridRoom.AllowUserToAddRows = false;
            this.gridRoom.AllowUserToDeleteRows = false;
            this.gridRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoom.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridRoom.Location = new System.Drawing.Point(61, 74);
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.ReadOnly = true;
            this.gridRoom.RowHeadersWidth = 51;
            this.gridRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridRoom.RowTemplate.Height = 24;
            this.gridRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRoom.Size = new System.Drawing.Size(771, 261);
            this.gridRoom.TabIndex = 23;
            this.gridRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoom_CellClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Khmer OS Moul Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(358, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 36);
            this.label.TabIndex = 22;
            this.label.Text = "ព័ត៏មានបន្ទប់";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // radioFree
            // 
            this.radioFree.AutoSize = true;
            this.radioFree.Checked = true;
            this.radioFree.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFree.Location = new System.Drawing.Point(180, 408);
            this.radioFree.Name = "radioFree";
            this.radioFree.Size = new System.Drawing.Size(61, 28);
            this.radioFree.TabIndex = 30;
            this.radioFree.TabStop = true;
            this.radioFree.Text = "ទំនេរ";
            this.radioFree.UseVisualStyleBackColor = true;
            this.radioFree.CheckedChanged += new System.EventHandler(this.radioFree_CheckedChanged);
            // 
            // radioBusy
            // 
            this.radioBusy.AutoSize = true;
            this.radioBusy.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBusy.Location = new System.Drawing.Point(248, 408);
            this.radioBusy.Name = "radioBusy";
            this.radioBusy.Size = new System.Drawing.Size(81, 28);
            this.radioBusy.TabIndex = 31;
            this.radioBusy.Text = "មិនទំនេរ";
            this.radioBusy.UseVisualStyleBackColor = true;
            this.radioBusy.CheckedChanged += new System.EventHandler(this.radioBusy_CheckedChanged);
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 573);
            this.Controls.Add(this.radioBusy);
            this.Controls.Add(this.radioFree);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridRoom);
            this.Controls.Add(this.label);
            this.Name = "FrmRoom";
            this.Text = "FrmRoom";
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddORSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridRoom;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radioFree;
        private System.Windows.Forms.RadioButton radioBusy;
    }
}