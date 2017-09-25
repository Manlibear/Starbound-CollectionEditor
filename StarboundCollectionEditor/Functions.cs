using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarboundCollectionEditor
{
    class Functions
    {
        public static string SortOrderHack(string item)
        {
            if (item.EndsWith("bar") && !item.EndsWith("zzzbar"))
            {
                item = item.Remove(item.Length - 3, 3) + "zzzbar";
            }

            if (item.EndsWith("crystal") && !item.EndsWith("zzzcrystal"))
            {
                item = item.Remove(item.Length - "crystal".Length, "crystal".Length) + "zzzcrystal";
            }

            if (item.StartsWith("refined") && !item.EndsWith("zzzrefined"))
            {
                item = item.Replace("refined", "") + "zzzrefined"; 
            }

            if (item.StartsWith("gene_") && !item.EndsWith("_gene"))
            {
                item = item.Replace("gene_", "") + "_gene";
            }

            return item;
        }

        public static string UndoSortHack(string item)
        {
            item = item.Replace("zzzbar", "bar");
            item = item.Replace("zzzcrystal", "crystal");
            item = item.Contains("zzzrefined") ? "refined" + item.Replace("zzzrefined", "") : item;
            item = item.Contains("_gene") ? "gene_" + item.Replace("_gene", "") : item;

            return item;
        }
    }
}
