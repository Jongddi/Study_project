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
void small_value(TreeNode* root, int value) {
	if (root == NULL)
		return;
	if (root->data < value)
		printf("%d보다 작은 노드 :  %d\n", value, root->data);
	small_value(root->left, value);
	small_value(root->right, value);
}
// 
int main(void)
{
	int a = 0;
	printf("값을 입력하시오 : ");
	scanf("%d", &a);
	small_value(exp,a);
	return 0;
}