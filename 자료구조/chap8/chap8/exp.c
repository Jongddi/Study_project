#include <stdio.h>
#include <stdlib.h>

typedef struct TreeNode {
	int data;
	struct TreeNode* left, * right;
} TreeNode;
//		     5
//	     3		 17
//    1	   4   16  25
TreeNode n1 = { 1,  NULL, NULL };
TreeNode n2 = { 4,  NULL,  NULL };
TreeNode n3 = { 3,  &n1,  &n2 };
TreeNode n4 = { 16, NULL, NULL };
TreeNode n5 = { 25, NULL, NULL };
TreeNode n6 = { 17, &n4,  &n5 };
TreeNode n7 = { 5, &n3,  &n6 };
TreeNode* exp = &n7;

// 수식 계산 함수
int evaluate(TreeNode* root)
{
	if (root == NULL)
		return 0;
	if (root->left == NULL && root->right == NULL)
		return root->data;
	else {
		int sum = root->data;
		sum = sum + evaluate(root->left) + evaluate(root->right);
		return sum;
	}
	return 0;
}
// 
int main(void)
{
	printf("노드의 합은 %d입니다. \n", evaluate(exp));
	return 0;
}