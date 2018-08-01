using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flir.Atlas.Live.Device;

namespace GigabitCamera
{
    // *****************************************************************************
    // This sample code is taken and modified from
    // Pleora Technologies Inc distributed sample code.
    //
    // *****************************************************************************

    public partial class GenICamParameters : Form
    {

        private List<GenICamParameter> _arrParameters;
        private readonly ThermalGigabitCamera _camera;

        public GenICamParameters(ThermalGigabitCamera camera)
        {
            InitializeComponent();
            _camera = camera;
        }

        /// <summary>
        /// Builds the GenICam device interface tree.
        /// </summary>
        public void BuildTree(List<GenICamParameter> arrParameters)
        {
            _arrParameters = arrParameters;
            treeView.Nodes.Clear();
            foreach (var parameter in arrParameters)
            {
                // Create parameter node
                TreeNode lNode = new TreeNode(parameter.Name);
                lNode.ImageIndex = 2;
                lNode.SelectedImageIndex = 3;

                // Set tag to parameter, used to reference parameter when selected.
                lNode.Tag = parameter;
                
                // Get category
                TreeNode lCategory = GetCategory(parameter);

                // Add parameter node to category.
                lCategory.Nodes.Add(lNode);
            }

            // Expand all.
            treeView.ExpandAll();

            // Look for first leaf node, select.
            TreeNode lCurrent = treeView.Nodes[0];
            for (; ; )
            {
                if (lCurrent.Nodes.Count <= 0)
                {
                    treeView.SelectedNode = lCurrent;
                    break;
                }

                lCurrent = lCurrent.Nodes[0];
            }

            // Make sure the first node (leaf or not) is visible (scroll up).
            treeView.Nodes[0].EnsureVisible();
        }

        private TreeNode GetCategory(GenICamParameter parameter)
        {
            // We don't want to show the "Root\\" level all categories start with, remove it.
            string lCategory = parameter.Category;
            if (lCategory.IndexOf("Root\\") == 0)
            {
                lCategory = lCategory.Substring("Root\\".Length);
            }

            // Break categories in a list of strings. They are separated by backslashes
            // as in Category\\Example\\Test.
            List<String> lCategories = new List<string>();
            int lIndex = lCategory.IndexOf("\\");
            while (lIndex > 0)
            {
                lCategories.Add(lCategory.Substring(0, lIndex));
                lCategory = lCategory.Substring(lIndex + 1);

                lIndex = lCategory.IndexOf("\\");
            }
            lCategories.Add(lCategory);

            // Get (or create as needed) the category node requested.
            TreeNode lCurrent = null;
            foreach (string lC in lCategories)
            {
                if (lCurrent == null)
                {
                    // Current is null, root level. Use treeView for Nodes container.
                    if (!treeView.Nodes.ContainsKey(lC))
                    {
                        // Not found, create
                        TreeNode lNode = treeView.Nodes.Add(lC, lC);
                        lNode.ImageIndex = 0;
                        lNode.SelectedImageIndex = 1;
                    }
                    // Set current category for next iteration.
                    lCurrent = treeView.Nodes[lC];
                }
                else
                {
                    // Use current.
                    if (!lCurrent.Nodes.ContainsKey(lC))
                    {
                        // Not found, create
                        TreeNode lNode = lCurrent.Nodes.Add(lC, lC);
                        lNode.ImageIndex = 0;
                        lNode.SelectedImageIndex = 1;
                    }
                    // Set current category for next iteration.
                    lCurrent = lCurrent.Nodes[lC];
                }
            }

            // Last current is the last category at the end of the category
            // path, this is what we need to return.
            return lCurrent;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode.Tag == null)
            {
                return;
            }

            GenICamParameter lP = (GenICamParameter)treeView.SelectedNode.Tag;

            // List where all name/value attribute pairs are added.
            List<ListViewItem> lList = new List<ListViewItem>();

            // Common properties for all parameters.
            FillParameter(lList, lP);

            GenICamInteger gi = lP as GenICamInteger;
            if (gi != null)
            {
                FillInteger(lList,gi);
            }

            GenICamBoolean gb = lP as GenICamBoolean;
            if (gb != null)
            {
                FillBoolean(lList, gb);
            }

            GenICamString gs = lP as GenICamString;
            if (gs != null)
            {
                FillString(lList, gs);
            }

            // Float.
            GenICamFloat gf = lP as GenICamFloat;
            if (gf != null)
            {
                FillFloat(lList, gf);
            }

            // Register.
            GenICamCommand gc = lP as GenICamCommand;
            if (gc != null)
            {
                FillRegister(lList, gc);
            }
            // One-shot update of the list of attributes to the list view.
            listView1.BeginUpdate();
            listView1.Items.Clear();
            listView1.Items.AddRange(lList.ToArray());
            listView1.EndUpdate();
        }

        private void FillRegister(List<ListViewItem> lList, GenICamCommand gc)
        {
        }

        private void FillFloat(List<ListViewItem> aList, GenICamFloat aParameter)
        {
            // Try catch use as failure has to be expected when reading value.
            ListViewItem lLVI = new ListViewItem("Value");
            string lValue = "";
            try
            {
                lValue = aParameter.Value.ToString();
            }
            catch (Exception ex)
            {
                // Display error message.
                lValue = ex.Message;
            }
            lLVI.SubItems.Add(lValue);
            lLVI.Group = listView1.Groups[1];
            aList.Add(lLVI);
        }

        private void FillString(List<ListViewItem> aList, GenICamString aParameter)
        {
            // Try catch use as failure has to be expected when reading value.
            ListViewItem lLVI = new ListViewItem("Value");
            string lValue = "";
            try
            {
                lValue = aParameter.Value;
            }
            catch (Exception ex)
            {
                // Display error message.
                lValue = ex.Message;
            }
            lLVI.SubItems.Add(lValue);
            lLVI.Group = listView1.Groups[1];
            aList.Add(lLVI);
        }

        private void FillBoolean(List<ListViewItem> aList, GenICamBoolean aParameter)
        {
            // Try catch use as failure has to be expected when reading value.
            ListViewItem lLVI = new ListViewItem("Value");
            string lValue = "";
            try
            {
                // Display error message.
                lValue = aParameter.Value.ToString();
            }
            catch (Exception ex)
            {
                lValue = ex.Message;
            }
            lLVI.SubItems.Add(lValue);
            lLVI.Group = listView1.Groups[1];
            aList.Add(lLVI);
        }

        private void FillInteger(List<ListViewItem> aList, GenICamInteger aParameter)
        {
            ListViewItem lLVI = new ListViewItem("Value");
            string lValue = "";
            try
            {
                lValue = aParameter.Value.ToString();
            }
            catch (Exception ex)
            {
                // Display error message
                lValue = ex.Message;
            }
            lLVI.SubItems.Add(lValue);
            lLVI.Group = listView1.Groups[1];
            aList.Add(lLVI);
        }

        private void FillParameter(List<ListViewItem> aList, GenICamParameter aParameter)
        {
            ListViewItem lLVI = new ListViewItem("Name");
            lLVI.SubItems.Add(aParameter.Name);
            lLVI.Group = listView1.Groups[0];
            aList.Add(lLVI);

            lLVI = new ListViewItem("Type");
            lLVI.SubItems.Add(aParameter.Type.ToString());
            lLVI.Group = listView1.Groups[0];
            aList.Add(lLVI);

            lLVI = new ListViewItem("Description");
            lLVI.SubItems.Add(aParameter.Description);
            lLVI.Group = listView1.Groups[0];
            aList.Add(lLVI);

            lLVI = new ListViewItem("Category");
            lLVI.SubItems.Add(aParameter.Category);
            lLVI.Group = listView1.Groups[0];
            aList.Add(lLVI);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            foreach (var genICamParameter in _arrParameters)
            {
                try
                {
                    genICamParameter.Refresh();
                }
                catch
                {
                    
                    
                }
                
            }
            BuildTree(_arrParameters);
        }

    }
}
