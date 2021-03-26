#include <stdio.h>
#include <stdlib.h>
#define MAX_STACK_SIZE 100

typedef char element;
typedef struct {
	element data[MAX_STACK_SIZE];
	int top;
} StackType;

// ���� �ʱ�ȭ �Լ�
void init_stack(StackType* s)
{
	s->top = -1;
}

// ���� ���� ���� �Լ�
int is_empty(StackType* s)
{
	return (s->top == -1);
}
// ��ȭ ���� ���� �Լ�
int is_full(StackType* s)
{
	return (s->top == (MAX_STACK_SIZE - 1));
}
// �����Լ�
void push(StackType* s, element item)
{
	if (is_full(s))
	{
		fprintf(stderr, "���� ��ȭ ����\n");
		return;
	}
	else s->data[++(s->top)] = item;
}
// �����Լ�
element pop(StackType* s)
{
	if (is_empty(s))
	{
		fprintf(stderr, "���� ���� ����\n");
		exit(1);
	}
	else return s->data[(s->top)--];
}
// ��ũ�Լ�
element peek(StackType* s)
{
	if (is_empty(s))
	{
		fprintf(stderr, "���� ���� ����\n");
		exit(1);
	}
	else return s->data[s->top];
}

int main(void)
{
	printf("������ �Է��Ͻÿ�. : ");
	char p[MAX_STACK_SIZE];
	scanf("%s", p);

	StackType s1, s2;
	init_stack(&s1);
	init_stack(&s2);

	int i = 0;
	while (p[i] != NULL) {
		if (p[i] != p[i + 1])
			push(&s1, p[i] - '0');
		i++;
	}
	while (!is_empty(&s1)) {
		push(&s2, pop(&s1));
	}
	printf("��� : ");
	while (!is_empty(&s2)) {
		printf("%d", pop(&s2));
	}
	printf("\n");
	return 0;
}