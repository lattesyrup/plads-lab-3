namespace trees.Classes;
#nullable disable

internal class TreeNode(int info, TreeNode left, TreeNode right)
{
    public readonly int info = info;
    public TreeNode left = left;
    public TreeNode right = right;

    public TreeNode(int info) : this(info, null, null) { }
}
