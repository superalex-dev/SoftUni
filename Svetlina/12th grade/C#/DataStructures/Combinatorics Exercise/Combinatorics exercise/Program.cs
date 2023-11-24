public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public int FindSecondMinimumValue(TreeNode root) {
    int minVal = root.val;
    int? secondMinVal = null;
    
    if (root == null || root.left == null && root.right == null) 
    {
        return -1;
    }

    DFS(root, ref minVal, ref secondMinVal);
}

public void DFS(TreeNode node, ref int minVal, ref int? secondMinVal) {
    if (node == null) {
        return;
    }
    
    if (node.val > minVal && (!secondMinVal.HasValue || node.val < secondMinVal)) {
        secondMinVal = node.val;
    }

    DFS(node.left, ref minVal, ref secondMinVal);
    DFS(node.right, ref minVal, ref secondMinVal);
}