using MetroFramework.Forms;
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

namespace StarboundCollectionEditor
{
    public partial class frmPatches : MetroForm
    {
        string collectionName;
        List<string> collectibles;
        string path;
        string fileType;
        string basePath = "";

        public frmPatches(string _collectionName, List<string> _collectibles, string _path)
        {
            this.collectionName = _collectionName;
            this.collectibles = _collectibles;
            this.path = _path;

            if (path.Contains("tech"))
            {
                fileType = "tech";
                basePath = "\\tech";
            }
            else if (path.Contains("liquid"))
            {
                fileType = "liqitem";
                basePath = "\\items\\liquids";
            }
            else
            {
                fileType = "item";
                basePath = "\\items\\generic\\crafting";
            }



            InitializeComponent();
        }

        private void frmPatches_Load(object sender, EventArgs e)
        {

            dgvCollectible.Rows.Clear();
            dgvCollectible.Rows.Add(1);

            foreach (string c in this.collectibles)
            {

                DataGridViewRow row = (DataGridViewRow)dgvCollectible.Rows[0].Clone();
                row.Cells[0].Value = Functions.UndoSortHack(c);
                row.Cells[1].Value = basePath;
                dgvCollectible.Rows.Add(row);
            }

            dgvCollectible.Rows.RemoveAt(0);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvCollectible.Rows)
            {
                if ((string)row.Cells[1].Value == "")
                {
                    MessageBox.Show("Missing path for: " + (string)row.Cells[0].Value);
                    return;
                }

                string patchText = @"[
    {
        ""op"": ""add"",
        ""path"": ""/collectablesOnPickup"",
        ""value"": {
            ";

                patchText += "\"" + this.collectionName + "\": \"" + row.Cells[0].Value.ToString() + "\"";

                patchText += @"
        }
    }
]";

                string patchPath = path + (row.Cells[1].Value.ToString().StartsWith("\\") ? row.Cells[1].Value.ToString() : "\\" + row.Cells[1].Value.ToString());

                if (!patchPath.EndsWith("\\"))
                {
                    patchPath += "\\";
                }

                patchPath += row.Cells[0].Value.ToString() + "." + fileType + ".patch";

                patchPath = patchPath.Replace("\\\\", "\\"); // too lazy to actuall check

                FileInfo file = new System.IO.FileInfo(patchPath);
                file.Directory.Create(); // If the directory already exists, this method does nothing.
                File.WriteAllText(patchPath, patchText);



            }
            dgvCollectible.Rows.Clear();
            dgvCollectible.Refresh();


            MetroFramework.MetroMessageBox.Show(this, "Patches Generated");
        }
    }
}
