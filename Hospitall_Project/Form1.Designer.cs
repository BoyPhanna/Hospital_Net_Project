namespace Hospitall_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridPosition = new System.Windows.Forms.DataGridView();
            this.btnAddORSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ព័ត៏មានតួនាទី";
            // 
            // gridPosition
            // 
            this.gridPosition.AllowUserToAddRows = false;
            this.gridPosition.AllowUserToDeleteRows = false;
            this.gridPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPosition.Location = new System.Drawing.Point(34, 58);
            this.gridPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridPosition.Name = "gridPosition";
            this.gridPosition.ReadOnly = true;
            this.gridPosition.RowHeadersWidth = 51;
            this.gridPosition.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPosition.RowTemplate.Height = 24;
            this.gridPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPosition.Size = new System.Drawing.Size(658, 201);
            this.gridPosition.TabIndex = 1;
            this.gridPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPosition_CellClick);
            // 
            // btnAddORSave
            // 
            this.btnAddORSave.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddORSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddORSave.Location = new System.Drawing.Point(592, 287);
            this.btnAddORSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddORSave.Name = "btnAddORSave";
            this.btnAddORSave.Size = new System.Drawing.Size(100, 50);
            this.btnAddORSave.TabIndex = 3;
            this.btnAddORSave.Text = "ថែម";
            this.btnAddORSave.UseVisualStyleBackColor = true;
            this.btnAddORSave.Click += new System.EventHandler(this.btnAddORSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.Location = new System.Drawing.Point(472, 287);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(133, 287);
            this.tbxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPosition.Multiline = true;
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(174, 50);
            this.tbxPosition.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ឈ្មោះតួនាទី";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddORSave);
            this.Controls.Add(this.gridPosition);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPosition;
        private System.Windows.Forms.Button btnAddORSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.Label label2;
    }
}

