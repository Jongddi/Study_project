#include <stdio.h>
#include <stdlib.h>

typedef int element;
typedef struct ListNode
{
	element data;
	struct ListNode* link;
} ListNode;

void insert_node(ListNode **head, ListNode* p, ListNode* pp)
{
	if (*head == NULL)
	{
		pp->link = NULL;
		*head = pp;
	}
	else
	{
		pp->link = NULL;
		ListNode* p = *head;
		while (p->link != NULL)
			p = p->link;
		p->link = pp;
	}
}

ListNode* create(element value)
{
	ListNode* new_p;
	new_p = (ListNode*)malloc(sizeof(new_p));
	new_p->data = value;
	new_p->link = NULL;
	return new_p;
}

void print_list(ListNode* head)
{
	for (ListNode* p = head; p != NULL; p = p->link)
		printf("%d ", p->data);
}

ListNode* alternate(ListNode* headA, ListNode* headB)
{
	ListNode* p = headA;
	ListNode* q = headB;
	ListNode* r = NULL;

	while (p != NULL || q != NULL) {
		if (p != NULL) {
			insert_node(&r, r, create(p->data));
			p = p->link;
		}
		if (q != NULL) {
			insert_node(&r, r, create(q->data));
			q = q->link;
		}
	}
	return r;
}

int main(void)
{
	int node_num, node_data;
	ListNode* headA = NULL;
	ListNode* headB = NULL;
	ListNode* headC = NULL;

	printf("리스트 A의 개수 : ");
	scanf("%d", &node_num);

	for (int i = 1; i <= node_num; i++)
	{
		printf("리스트 A 노드 #%d 데이터 : ", i);
		scanf("%d", &node_data);
		insert_node(&headA, headA, create(node_data));
	}

	printf("리스트 B의 개수 : ");
	scanf_s("%d", &node_num);
	for (int i = 1; i <= node_num; i++)
	{
		printf("리스트 B 노드 #%d 데이터 : ", i);
		scanf("%d", &node_data);
		insert_node(&headB, headB, create(node_data));
	}

	printf("리스트 C : ");
	print_list(alternate(headA, headB));
	printf("\n");
	return 0;
}