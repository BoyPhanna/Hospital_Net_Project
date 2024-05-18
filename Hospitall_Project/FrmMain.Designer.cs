namespace Hospitall_Project
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.Client_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.អតថជនទងអសToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Product_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Medicine_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Room_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Stuff = new System.Windows.Forms.ToolStripMenuItem();
            this.Position_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.AllStuff_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.History_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Khmer OS Moul Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home_Menu,
            this.Client_Menu,
            this.Product_Menu,
            this.Stuff});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home_Menu
            // 
            this.Home_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckIn,
            this.CheckOut,
            this.History_Menu});
            this.Home_Menu.Font = new System.Drawing.Font("Khmer OS Moul Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Menu.Name = "Home_Menu";
            this.Home_Menu.Size = new System.Drawing.Size(92, 31);
            this.Home_Menu.Text = "ទំព័រដើម";
            // 
            // CheckIn
            // 
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(238, 32);
            this.CheckIn.Text = "កត់ត្រាការចូល";
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(238, 32);
            this.CheckOut.Text = "កត់ត្រាការចេញ";
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // Client_Menu
            // 
            this.Client_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.អតថជនទងអសToolStripMenuItem});
            this.Client_Menu.Name = "Client_Menu";
            this.Client_Menu.Size = new System.Drawing.Size(91, 31);
            this.Client_Menu.Text = "អតិថិជន";
            // 
            // អតថជនទងអសToolStripMenuItem
            // 
            this.អតថជនទងអសToolStripMenuItem.Name = "អតថជនទងអសToolStripMenuItem";
            this.អតថជនទងអសToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.អតថជនទងអសToolStripMenuItem.Text = "អតិថិជនទាំងអស់";
            this.អតថជនទងអសToolStripMenuItem.Click += new System.EventHandler(this.Client_Menu_Click);
            // 
            // Product_Menu
            // 
            this.Product_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Medicine_Menu,
            this.Tool_Menu,
            this.Room_Menu});
            this.Product_Menu.Name = "Product_Menu";
            this.Product_Menu.Size = new System.Drawing.Size(74, 31);
            this.Product_Menu.Text = "សម្ភារៈ";
            // 
            // Medicine_Menu
            // 
            this.Medicine_Menu.Name = "Medicine_Menu";
            this.Medicine_Menu.Size = new System.Drawing.Size(167, 32);
            this.Medicine_Menu.Text = "ថ្នាំពេទ្យ";
            this.Medicine_Menu.Click += new System.EventHandler(this.Medicine_Menu_Click);
            // 
            // Tool_Menu
            // 
            this.Tool_Menu.Name = "Tool_Menu";
            this.Tool_Menu.Size = new System.Drawing.Size(167, 32);
            this.Tool_Menu.Text = "ឧបករណ៍";
            this.Tool_Menu.Click += new System.EventHandler(this.Tool_Menu_Click);
            // 
            // Room_Menu
            // 
            this.Room_Menu.Name = "Room_Menu";
            this.Room_Menu.Size = new System.Drawing.Size(167, 32);
            this.Room_Menu.Text = "បន្ទប់";
            this.Room_Menu.Click += new System.EventHandler(this.Room_Menu_Click);
            // 
            // Stuff
            // 
            this.Stuff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Position_Menu,
            this.AllStuff_Menu});
            this.Stuff.Name = "Stuff";
            this.Stuff.Size = new System.Drawing.Size(82, 31);
            this.Stuff.Text = "បុគ្គលិក";
            // 
            // Position_Menu
            // 
            this.Position_Menu.Name = "Position_Menu";
            this.Position_Menu.Size = new System.Drawing.Size(216, 32);
            this.Position_Menu.Text = "តូនាទី";
            this.Position_Menu.Click += new System.EventHandler(this.Position_Menu_Click);
            // 
            // AllStuff_Menu
            // 
            this.AllStuff_Menu.Name = "AllStuff_Menu";
            this.AllStuff_Menu.Size = new System.Drawing.Size(216, 32);
            this.AllStuff_Menu.Text = "បុគ្គលិកទាំងអស់";
            this.AllStuff_Menu.Click += new System.EventHandler(this.AllStuff_Menu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // History_Menu
            // 
            this.History_Menu.Name = "History_Menu";
            this.History_Menu.Size = new System.Drawing.Size(238, 32);
            this.History_Menu.Text = "ប្រវត្ដិការចេញចូល";
            this.History_Menu.Click += new System.EventHandler(this.History_Menu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 648);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home_Menu;
        private System.Windows.Forms.ToolStripMenuItem Client_Menu;
        private System.Windows.Forms.ToolStripMenuItem Product_Menu;
        private System.Windows.Forms.ToolStripMenuItem Stuff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Position_Menu;
        private System.Windows.Forms.ToolStripMenuItem AllStuff_Menu;
        private System.Windows.Forms.ToolStripMenuItem Medicine_Menu;
        private System.Windows.Forms.ToolStripMenuItem Tool_Menu;
        private System.Windows.Forms.ToolStripMenuItem អតថជនទងអសToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Room_Menu;
        private System.Windows.Forms.ToolStripMenuItem CheckIn;
        private System.Windows.Forms.ToolStripMenuItem CheckOut;
        private System.Windows.Forms.ToolStripMenuItem History_Menu;
    }
}