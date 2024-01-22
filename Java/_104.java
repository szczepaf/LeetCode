public class _104 {
    public int maxDepth(TreeNode root) {
        return maxDepthHelper(root, 0);

    }
    public int maxDepthHelper(TreeNode node, int depth){
        if (node == null) return depth;
        return 1 + Math.max(maxDepthHelper(node.right, depth), maxDepthHelper(node.left, depth));
    }
}
