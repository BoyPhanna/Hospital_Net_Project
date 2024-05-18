namespace Hospitall_Project
{
    partial class FrmCheckIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxClient = new System.Windows.Forms.TextBox();
            this.tbxRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDoctor = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxDiseases = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAddNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Moul Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "កត់ត្រាការចូល";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Moul Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "ឈ្មោះអតិថិជន";
            // 
            // tbxClient
            // 
            this.tbxClient.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClient.Location = new System.Drawing.Point(206, 163);
            this.tbxClient.Name = "tbxClient";
            this.tbxClient.Size = new System.Drawing.Size(146, 31);
            this.tbxClient.TabIndex = 5;
            this.tbxClient.Click += new System.EventHandler(this.tbxClient_Click);
            this.tbxClient.TextChanged += new System.EventHandler(this.tbxClient_TextChanged);
            // 
            // tbxRoom
            // 
            this.tbxRoom.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoom.Location = new System.Drawing.Point(206, 109);
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.Size = new System.Drawing.Size(146, 31);
            this.tbxRoom.TabIndex = 5;
            this.tbxRoom.Click += new System.EventHandler(this.tbxRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Moul Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "លេខបន្ទប់";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Moul Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "ឈ្មោះគ្រូពេទ្យទទួលព្យាបាល";
            // 
            // tbxDoctor
            // 
            this.tbxDoctor.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDoctor.Location = new System.Drawing.Point(749, 107);
            this.tbxDoctor.Name = "tbxDoctor";
            this.tbxDoctor.Size = new System.Drawing.Size(146, 31);
            this.tbxDoctor.TabIndex = 7;
            this.tbxDoctor.Click += new System.EventHandler(this.tbxDoctor_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(60, 294);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.RowTemplate.Height = 24;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(814, 227);
            this.gridView.TabIndex = 9;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(799, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "រួចរាល់";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxDiseases
            // 
            this.tbxDiseases.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiseases.Location = new System.Drawing.Point(206, 231);
            this.tbxDiseases.Name = "tbxDiseases";
            this.tbxDiseases.Size = new System.Drawing.Size(306, 31);
            this.tbxDiseases.TabIndex = 5;
            this.tbxDiseases.Click += new System.EventHandler(this.tbxDiseases_Click);
            this.tbxDiseases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDiseases_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Moul Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "អាការៈជម្ងឺ";
            // 
            // tbxAddNewClient
            // 
            this.tbxAddNewClient.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddNewClient.Location = new System.Drawing.Point(397, 159);
            this.tbxAddNewClient.Name = "tbxAddNewClient";
            this.tbxAddNewClient.Size = new System.Drawing.Size(75, 43);
            this.tbxAddNewClient.TabIndex = 10;
            this.tbxAddNewClient.Text = "ថ្មី";
            this.tbxAddNewClient.UseVisualStyleBackColor = true;
            this.tbxAddNewClient.Click += new System.EventHandler(this.tbxAddNewClient_Click);
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 598);
            this.Controls.Add(this.tbxAddNewClient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDiseases);
            this.Controls.Add(this.tbxClient);
            this.Controls.Add(this.label1);
            this.Name = "FrmCheckIn";
            this.Text = "FrmCheckIn";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxClient;
        private System.Windows.Forms.TextBox tbxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDoctor;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxDiseases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tbxAddNewClient;
    }
}