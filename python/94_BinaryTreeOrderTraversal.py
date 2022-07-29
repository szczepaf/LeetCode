# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    

    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        listAnswer = []
        if root is None:
            return []
        listAnswer += self.inorderTraversal(root.left)
        listAnswer.append(root.val)
        listAnswer += self.inorderTraversal(root.right)
        
        return listAnswer
        
        
