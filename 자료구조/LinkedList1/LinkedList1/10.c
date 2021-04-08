#include <stdio.h>
#include <stdlib.h>

typedef element;
typedef struct ListNode {
	element data;
	struct ListNode* link;
}ListNode;

void insert(ListNode** head, ListNode* p, ListNode* pp)
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

ListNode* create_node(element value)
{
	ListNode* p;
	p = (ListNode*)malloc(sizeof(p));
	p->data = value;
	p->link = NULL;
	return p;
}

void print_list(ListNode* head)
{
	for (ListNode* p = head; p != NULL; p = p->link)
		printf("%d->", p->data);
	printf("NULL\n");
}

int count(ListNode* head)
{
	int count = 0;
	ListNode* p = head;
	while (p != NULL)
	{
		count++;
		p = p->link;
	}
	return count;
}

int main(void)
{
	int node_num, node_data;
	ListNode* head = NULL;

	printf("노드의 개수 : ");
	scanf("%d", &node_num);

	for (int i = 1; i <= node_num; i++)
	{
		printf("노드 #%d 데이터 : ", i);
		scanf("%d", &node_data);
		insert(&head, head, create_node(node_data));
	}

	printf("연결 리스트 노드의 개수 = %d\n", count(head));
	return 0;
}