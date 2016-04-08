using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataOrganizer
{
	public partial class MainForm : Form
	{
		private string rootPath;

		public MainForm()
		{
			InitializeComponent();

			string exePath = Directory.GetCurrentDirectory();

			rootPath = Path.Combine(exePath, "data");

			if (!Directory.Exists(rootPath))
			{
				try
				{
					Directory.CreateDirectory(rootPath);
				}
				catch (Exception ex)
				{
					statusLabel.Text = ex.Message;

					return;
				}
			}

			try
			{
				populateTree(null, rootPath);
			}
			catch (Exception ex)
			{
				statusLabel.Text = ex.Message;
			}

			treeViewContent.ExpandAll();

      updateStates();
    }

    private void populateTree(
			TreeNode node,
			string path)
		{
			var folders = Directory.EnumerateDirectories(path);

			bool useRoot = (node == null);

			foreach (string folder in folders)
			{
				string folderName = folder.Substring(folder.LastIndexOf('\\') + 1);

				TreeNode newNode = new TreeNode(folderName);

				if (useRoot)
				{
					treeViewContent.Nodes.Add(newNode);
				}
				else
				{
					node.Nodes.Add(newNode);
				}

				populateTree(newNode, folder);
			}
		}

		private void saveData()
		{
			TreeNode node = treeViewContent.SelectedNode;

			if (node != null)
			{
				try
				{
					string folderPath = Path.Combine(rootPath, node.FullPath);

					string filePath = Path.Combine(folderPath, "data.txt");

					File.WriteAllText(filePath, textBoxContent.Text);

					statusLabel.Text = "Saved: " + node.Text;
				}
				catch (Exception ex)
				{
					statusLabel.Text = ex.Message;
				}
			}
		}

		private void NewItemMenuSelection_Click(object sender, EventArgs e)
		{
			newItem(null);
		}

		private void NewItemButton_Click(object sender, EventArgs e)
		{
			newItem(null);
		}

		private void treeViewContent_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			saveData();
		}

		private void treeViewContent_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode node = e.Node;

			string folderPath = Path.Combine(rootPath, node.FullPath);

			string filePath = Path.Combine(folderPath, "data.txt");

			if (File.Exists(filePath))
			{
				textBoxContent.Text = File.ReadAllText(filePath);	
			}
			else
			{
				textBoxContent.Text = "";
			}

      updateStates();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			saveData();
		}

		private void newItem(TreeNode node)
		{
			try
			{
				FormNew dialog = new FormNew();

				if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					bool useRoot = (node == null);
					
					string folderPath = "";

					if (useRoot)
					{
						folderPath = Path.Combine(rootPath, dialog.textBoxContent.Text);
					}
					else
					{
						folderPath = Path.Combine(rootPath, node.FullPath);

						folderPath = Path.Combine(folderPath, dialog.textBoxContent.Text);
					}

					if (Directory.Exists(folderPath))
					{
						throw new Exception("Error: Name Conflict");
					}

					Directory.CreateDirectory(folderPath);

					TreeNode newNode = new TreeNode(dialog.textBoxContent.Text);
					
					if (useRoot)
					{
						treeViewContent.Nodes.Add(newNode);
					}
					else
					{
						node.Nodes.Add(newNode);
					}

					treeViewContent.SelectedNode = newNode;

					statusLabel.Text = "Created Item: " + dialog.textBoxContent.Text;
				}
			}
			catch (Exception ex)
			{
				statusLabel.Text = ex.Message;
			}
		}

		private void KeyDownExtensions(object sender, KeyEventArgs e)
		{
			bool handled = false;
			
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.A:
					{
						textBoxContent.Focus();
						
						textBoxContent.SelectAll();

						handled = true;

						break;
					}
					case Keys.S:
					{
						saveData();

						handled = true;
						
						break;
					}
				}
			}

			if (handled)
			{
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
		
		private void textBoxContent_KeyDown(object sender, KeyEventArgs e)
		{
			KeyDownExtensions(sender, e);
		}

		private void treeViewContent_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			saveData();
		}

		private void treeViewContent_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			string oldName = e.Node.Text;

			string newName = e.Label;

			if ((newName != null) && (oldName != null) && (newName != oldName))
			{
				try
				{
					TreeNode parent = e.Node.Parent;

					string thisFolder = "";
					
					if (parent == null)
					{
						thisFolder = rootPath;
					}
					else
					{
						thisFolder = Path.Combine(rootPath, parent.FullPath);
					}

					string oldPath = Path.Combine(thisFolder, oldName);

					string newPath = Path.Combine(thisFolder, newName);

					if (Directory.Exists(newPath))
					{
						throw new Exception("Error: Name Conflict");
					}
					
					Directory.Move(oldPath, newPath);
					
					e.Node.Text = e.Label;

					statusLabel.Text = "Renamed Item: \"" + oldName + "\" to \"" + newName + "\"";
				}
				catch (Exception ex)
				{
					statusLabel.Text = ex.Message;
				}
			}
		}

		private void newChildItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			newItem(treeViewContent.SelectedNode);
		}

		private void toolStripButtonNewItem_Click(object sender, EventArgs e)
		{
			newItem(treeViewContent.SelectedNode);
		}

		private void treeViewContent_KeyDown(object sender, KeyEventArgs e)
		{
			KeyDownExtensions(sender, e);
		}

    private void deleteButton_Click(object sender, EventArgs e)
    {
      deleteItem(treeViewContent.SelectedNode);
    }

    private void deleteItem(TreeNode node)
    {
      try
      {
        if (node != null)
        {
          FormDelete dialog = new FormDelete();

          if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
            string folderPath = Path.Combine(rootPath, node.FullPath);

            if (Directory.Exists(folderPath))
            {
              Directory.Delete(folderPath, true);
            }

            treeViewContent.SelectedNode = node.Parent;

            treeViewContent.Nodes.Remove(node);

            statusLabel.Text = "Deleted Item: " + folderPath;
          }
        }
      }
      catch (Exception ex)
      {
        statusLabel.Text = ex.Message;
      }

      updateStates();
    }
    private void updateStates()
    {
      bool sel = (treeViewContent.SelectedNode != null);

      deleteButton.Enabled = sel;
      deleteItemToolStripMenuItem.Enabled = sel;

      toolStripButtonNewItem.Enabled = sel;
      newChildItemToolStripMenuItem.Enabled = sel;
    }

    private void textBoxContent_DoubleClick(object sender, EventArgs e)
    {
      // override default double-click behavior,
      // which selects word and a trailing space:  

      int start = textBoxContent.SelectionStart;

      int length = textBoxContent.SelectionLength;

      if (textBoxContent.SelectedText.EndsWith(" "))
      {
        textBoxContent.Select(start, --length);
      }
    }
  }
}
