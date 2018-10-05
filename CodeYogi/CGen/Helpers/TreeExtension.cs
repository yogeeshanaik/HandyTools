using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class TreeExtension
{
    public static IEnumerable<TreeNode> FlattenTree(this TreeView tv)
    {
        return FlattenTree(tv.Nodes);
    }

    public static IEnumerable<TreeNode> FlattenTree(this TreeNodeCollection coll)
    {
        return coll.Cast<TreeNode>()
                    .Concat(coll.Cast<TreeNode>()
                                .SelectMany(x => FlattenTree(x.Nodes)));
    }

    /// <summary>
    /// Searches node by text and highlights it by selecting node
    /// </summary>
    /// <param name="tv"></param>
    /// <param name="key"></param>
    /// <returns>Returns count of searched nodes</returns>
    public static int SearchNode(this TreeView tv, string key)
    {
        if (key.Length > 0)
        {
            ClearBackColor(tv);

            try
            {
                TreeNode[] tn = tv.FlattenTree()
                                    .Cast<TreeNode>()
                                    .Where(r => r.Text.ToLower().Contains(key.ToLower()))
                                    .ToArray();

                //TreeNode[] tn = tvFiles.Nodes[0].Nodes.Find(txtNodeFilter.Text, true);
                for (int i = 0; i < tn.Length; i++)
                {
                    tv.SelectedNode = tn[i];
                    tv.SelectedNode.BackColor = Color.Yellow;
                }
                return tn.Count();
            }
            catch { }            
        }
        return 0;
    }

    #region Remove BackColor

    // recursively move through the treeview nodes
    // and reset backcolors to white
    private static void ClearBackColor(TreeView tv)
    {
        TreeNodeCollection nodes = tv.Nodes;
        foreach (TreeNode n in nodes)
        {
            ClearRecursive(n);
        }
    }

    // called by ClearBackColor function
    private static void ClearRecursive(TreeNode treeNode)
    {
        foreach (TreeNode tn in treeNode.Nodes)
        {
            tn.BackColor = Color.White;
            ClearRecursive(tn);
        }
    }

    #endregion
}

