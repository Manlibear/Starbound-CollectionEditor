using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using MetroFramework.Forms;

namespace StarboundCollectionEditor
{
    public partial class frmMain : MetroForm
    {
        public List<string> lCollection = new List<string>();
        string fileName = "";
        


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult drCollection = ofdCollection.ShowDialog();

            if (drCollection == DialogResult.OK && File.Exists(ofdCollection.FileName))
            {
                lCollection = new List<string>();
                tvCollection.Nodes.Clear();
                fileName = ofdCollection.FileName;
                AddCollectionFromFile(ofdCollection.FileName);

                PopulateTree();
                lblSelect.Hide();

                btnAddCollectable.Enabled = btnExport.Enabled = btnPatches.Enabled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int order = 1;

            JObject jOutput = new JObject();

            jOutput.Add("name", txtName.Text);
            jOutput.Add("title", txtTitle.Text);
            jOutput.Add("type", txtType.Text);
            jOutput.Add("collectables", new JObject());

            JObject jCollectables = jOutput["collectables"] as JObject;
            

            foreach (string col in lCollection)
            {
                string c = Functions.UndoSortHack(col);
                
                string sCollectable = "{\"order\": " + order + ",\"item\": \"" + c + "\"}";

                jCollectables.Add(c, JObject.Parse(sCollectable));
                order++;
            }

            File.WriteAllText(fileName, jOutput.ToString());

           

            MetroFramework.MetroMessageBox.Show(this, "Export complete");

            lCollection.Clear();
            PopulateTree();


        }

        private void AddCollectionFromFile(string fileName)
        {
            AddCollectionFromFile(fileName, lCollection);
        }

        private void AddCollectionFromFile(string fileName, List<string> collection)
        {
            dynamic jCollection = JObject.Parse(File.ReadAllText(fileName));

            txtName.Text = jCollection.name;
            txtTitle.Text = jCollection.title;
            txtType.Text = jCollection.type;

            foreach (var collectable in jCollection.collectables)
            {
                string item = (string)collectable.First.item.Value;
                if (!collection.Contains(item))
                {
                    collection.Add(Functions.SortOrderHack(item));
                }
            }
        }


        private void PopulateTree()
        {
            tvCollection.Nodes.Clear();

            lCollection.Sort();

            foreach (string col in lCollection)
            {
                tvCollection.Nodes.Add(new TreeNode(col));
            }

        }
        
        private void btnAddCollectable_Click(object sender, EventArgs e)
        {
            txtCollectable.Text = txtCollectable.Text.Trim();

            if (!lCollection.Contains(txtCollectable.Text))
            {
                lCollection.Add(Functions.SortOrderHack(txtCollectable.Text));
                PopulateTree();

            }

            txtCollectable.Text = "";
        }

        private void tvCollection_KeyPress(dynamic sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Back)
            {
                string collectableName = sender.SelectedNode.Text;

                DialogResult drDelete = MessageBox.Show("Are you sure you want to delete '" + collectableName + "'?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (drDelete == DialogResult.Yes)
                {
                    if (lCollection.Contains(collectableName))
                    {
                        lCollection.Remove(collectableName);

                        PopulateTree();
                    }
                }
            }
        }

        private void btnPatches_Click(object sender, EventArgs e)
        {
            ofdBaseCollection.Title = "Select uneditted collection:";

            DialogResult drBase = ofdBaseCollection.ShowDialog();

            if(drBase == DialogResult.OK)
            {
                string baseFile = ofdBaseCollection.FileName;

                List<string> lBase = new List<string>();

                AddCollectionFromFile(baseFile, lBase);

                List<string> lDiff = lCollection.Where(x => !lBase.Contains(x)).ToList<string>();

                List<string> lRemoved = lBase.Where(x => !lCollection.Contains(x)).ToList<string>();

                frmPatches fPatches = new frmPatches(txtName.Text, lDiff, @"E:\Games\Steam\steamapps\common\Starbound\mods - hardcore\FUCollectionsExtension\");
                fPatches.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
    }
}
