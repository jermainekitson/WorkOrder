
namespace Work_Order_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCrewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createCrewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCrewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWorkOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 618);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addWorkOrderToolStripMenuItem,
            this.createCrewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem1,
            this.viewEmployeeToolStripMenuItem,
            this.viewWorkOrderToolStripMenuItem});
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.addEmployeeToolStripMenuItem.Text = "Administrator";
            // 
            // addWorkOrderToolStripMenuItem
            // 
            this.addWorkOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCrewToolStripMenuItem1,
            this.createCrewToolStripMenuItem2,
            this.assignCrewToolStripMenuItem,
            this.viewCrewsToolStripMenuItem});
            this.addWorkOrderToolStripMenuItem.Name = "addWorkOrderToolStripMenuItem";
            this.addWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.addWorkOrderToolStripMenuItem.Text = "Manager";
            // 
            // createCrewToolStripMenuItem
            // 
            this.createCrewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMembersToolStripMenuItem,
            this.viewWorkOrderToolStripMenuItem1});
            this.createCrewToolStripMenuItem.Name = "createCrewToolStripMenuItem";
            this.createCrewToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.createCrewToolStripMenuItem.Text = "Operator";
            // 
            // addEmployeeToolStripMenuItem1
            // 
            this.addEmployeeToolStripMenuItem1.Name = "addEmployeeToolStripMenuItem1";
            this.addEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.addEmployeeToolStripMenuItem1.Text = "Add Employee";
            // 
            // viewEmployeeToolStripMenuItem
            // 
            this.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            this.viewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewEmployeeToolStripMenuItem.Text = "View Employee";
            // 
            // viewWorkOrderToolStripMenuItem
            // 
            this.viewWorkOrderToolStripMenuItem.Name = "viewWorkOrderToolStripMenuItem";
            this.viewWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewWorkOrderToolStripMenuItem.Text = "View Work Order";
            // 
            // createCrewToolStripMenuItem1
            // 
            this.createCrewToolStripMenuItem1.Name = "createCrewToolStripMenuItem1";
            this.createCrewToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.createCrewToolStripMenuItem1.Text = "Create Work Order";
            // 
            // createCrewToolStripMenuItem2
            // 
            this.createCrewToolStripMenuItem2.Name = "createCrewToolStripMenuItem2";
            this.createCrewToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.createCrewToolStripMenuItem2.Text = "Create Crew";
            // 
            // assignCrewToolStripMenuItem
            // 
            this.assignCrewToolStripMenuItem.Name = "assignCrewToolStripMenuItem";
            this.assignCrewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.assignCrewToolStripMenuItem.Text = "Assign Crew";
            // 
            // viewCrewsToolStripMenuItem
            // 
            this.viewCrewsToolStripMenuItem.Name = "viewCrewsToolStripMenuItem";
            this.viewCrewsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewCrewsToolStripMenuItem.Text = "View Crews";
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewMembersToolStripMenuItem.Text = "View Members";
            // 
            // viewWorkOrderToolStripMenuItem1
            // 
            this.viewWorkOrderToolStripMenuItem1.Name = "viewWorkOrderToolStripMenuItem1";
            this.viewWorkOrderToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.viewWorkOrderToolStripMenuItem1.Text = "View Work Order";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWorkOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCrewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createCrewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem assignCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCrewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWorkOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

