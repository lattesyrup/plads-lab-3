namespace trees.Classes;
#nullable disable

internal class BinaryTree(TreeNode root)
{
    public TreeNode root = root;

    public BinaryTree() : this(null) { }

    /// <summary>
    /// Returns a new balanced binary tree
    /// created from an array with pre-order.
    /// </summary>
    /// <param name="data">An array to create from.</param>
    /// <returns>A TreeNode, root of a tree.</returns>
    public TreeNode CreateBalanced(int[] data)
    {
        TreeNode root;
        if (data.Length == 0) root = null;
        else if (data.Length == 1) root = new TreeNode(data[0]);
        else root = new TreeNode(
            data[0],
            CreateBalanced(data.AsSpan().Slice(1, data.Length / 2).ToArray()),
            CreateBalanced(data.AsSpan().Slice(data.Length / 2 + 1).ToArray())
        );
        return root;
    }

    /// <summary>
    /// Filters this tree recursively with pre-order:
    /// numbers lower than given are in first list,
    /// numbers greater are in second list. Task method.
    /// </summary>
    /// <param name="n">Number to filter on.</param>
    /// <returns>A pair of cycled double linked lists.</returns>
    public (CycledDoubleLinkedList, CycledDoubleLinkedList)
        TaskFilter(int n)
    {
        CycledDoubleLinkedList less = new();
        CycledDoubleLinkedList greater = new();

        FilterNodes(root, n, ref less, ref greater);

        return (less, greater);
    }

    private void FilterNodes(
        TreeNode root,
        int n,
        ref CycledDoubleLinkedList lessList,
        ref CycledDoubleLinkedList greaterList)
    {
        if (root != null)
        {
            if (root.info > n) greaterList.InsertAfterLast(root.info);
            else lessList.InsertAfterLast(root.info);
            
            FilterNodes(root.left, n, ref lessList, ref greaterList);
            FilterNodes(root.right, n, ref lessList, ref greaterList);
        }
    }
}
