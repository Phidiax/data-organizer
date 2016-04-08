namespace DataOrganizer
{
	partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.treeViewContent = new System.Windows.Forms.TreeView();
      this.textBoxContent = new System.Windows.Forms.TextBox();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.NewItemButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonNewItem = new System.Windows.Forms.ToolStripButton();
      this.deleteButton = new System.Windows.Forms.ToolStripButton();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.NewItemMenuSelection = new System.Windows.Forms.ToolStripMenuItem();
      this.newChildItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.statusStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // treeViewContent
      // 
      this.treeViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewContent.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeViewContent.FullRowSelect = true;
      this.treeViewContent.HideSelection = false;
      this.treeViewContent.HotTracking = true;
      this.treeViewContent.LabelEdit = true;
      this.treeViewContent.Location = new System.Drawing.Point(0, 0);
      this.treeViewContent.Name = "treeViewContent";
      this.treeViewContent.Size = new System.Drawing.Size(341, 514);
      this.treeViewContent.TabIndex = 0;
      this.treeViewContent.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewContent_BeforeLabelEdit);
      this.treeViewContent.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewContent_AfterLabelEdit);
      this.treeViewContent.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewContent_BeforeSelect);
      this.treeViewContent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewContent_AfterSelect);
      this.treeViewContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewContent_KeyDown);
      // 
      // textBoxContent
      // 
      this.textBoxContent.AcceptsTab = true;
      this.textBoxContent.AllowDrop = true;
      this.textBoxContent.CausesValidation = false;
      this.textBoxContent.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.textBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxContent.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxContent.HideSelection = false;
      this.textBoxContent.Location = new System.Drawing.Point(0, 0);
      this.textBoxContent.Multiline = true;
      this.textBoxContent.Name = "textBoxContent";
      this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxContent.Size = new System.Drawing.Size(680, 514);
      this.textBoxContent.TabIndex = 1;
      this.textBoxContent.DoubleClick += new System.EventHandler(this.textBoxContent_DoubleClick);
      this.textBoxContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContent_KeyDown);
      // 
      // statusStrip
      // 
      this.statusStrip.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 563);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(1025, 22);
      this.statusStrip.TabIndex = 2;
      this.statusStrip.Text = "statusStrip";
      // 
      // statusLabel
      // 
      this.statusLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(1010, 17);
      this.statusLabel.Spring = true;
      // 
      // toolStrip
      // 
      this.toolStrip.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItemButton,
            this.toolStripButtonNewItem,
            this.deleteButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(1025, 25);
      this.toolStrip.TabIndex = 3;
      this.toolStrip.Text = "toolStrip";
      // 
      // NewItemButton
      // 
      this.NewItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.NewItemButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NewItemButton.Image = global::DataOrganizer.Properties.Resources.NewRootItem;
      this.NewItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.NewItemButton.Name = "NewItemButton";
      this.NewItemButton.Size = new System.Drawing.Size(23, 22);
      this.NewItemButton.Text = "New Item";
      this.NewItemButton.Click += new System.EventHandler(this.NewItemButton_Click);
      // 
      // toolStripButtonNewItem
      // 
      this.toolStripButtonNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonNewItem.Image = global::DataOrganizer.Properties.Resources.NewChildItem;
      this.toolStripButtonNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonNewItem.Name = "toolStripButtonNewItem";
      this.toolStripButtonNewItem.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonNewItem.Text = "New Child Item";
      this.toolStripButtonNewItem.Click += new System.EventHandler(this.toolStripButtonNewItem_Click);
      // 
      // deleteButton
      // 
      this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
      this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(23, 22);
      this.deleteButton.Text = "Delete Item";
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // menuStrip
      // 
      this.menuStrip.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(1025, 24);
      this.menuStrip.TabIndex = 4;
      this.menuStrip.Text = "menuStrip";
      // 
      // dataToolStripMenuItem
      // 
      this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItemMenuSelection,
            this.newChildItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
      this.dataToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
      this.dataToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.dataToolStripMenuItem.Text = "Data";
      // 
      // NewItemMenuSelection
      // 
      this.NewItemMenuSelection.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NewItemMenuSelection.Image = global::DataOrganizer.Properties.Resources.NewRootItem;
      this.NewItemMenuSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.NewItemMenuSelection.Name = "NewItemMenuSelection";
      this.NewItemMenuSelection.Size = new System.Drawing.Size(188, 22);
      this.NewItemMenuSelection.Text = "New Root Item";
      this.NewItemMenuSelection.Click += new System.EventHandler(this.NewItemMenuSelection_Click);
      // 
      // newChildItemToolStripMenuItem
      // 
      this.newChildItemToolStripMenuItem.Image = global::DataOrganizer.Properties.Resources.NewChildItem;
      this.newChildItemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newChildItemToolStripMenuItem.Name = "newChildItemToolStripMenuItem";
      this.newChildItemToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.newChildItemToolStripMenuItem.Text = "New Child Item";
      this.newChildItemToolStripMenuItem.Click += new System.EventHandler(this.newChildItemToolStripMenuItem_Click);
      // 
      // deleteItemToolStripMenuItem
      // 
      this.deleteItemToolStripMenuItem.Image = global::DataOrganizer.Properties.Resources.DeleteItem;
      this.deleteItemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
      this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
      this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.deleteItemToolStripMenuItem.Text = "Delete Item";
      this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.splitContainer.Location = new System.Drawing.Point(0, 49);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.treeViewContent);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.textBoxContent);
      this.splitContainer.Size = new System.Drawing.Size(1025, 514);
      this.splitContainer.SplitterDistance = 341;
      this.splitContainer.TabIndex = 5;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1025, 585);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.menuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DataOrganizer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewContent;
		private System.Windows.Forms.TextBox textBoxContent;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStripButton NewItemButton;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewItemMenuSelection;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripButton toolStripButtonNewItem;
		private System.Windows.Forms.ToolStripMenuItem newChildItemToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton deleteButton;
    private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
  }
}

