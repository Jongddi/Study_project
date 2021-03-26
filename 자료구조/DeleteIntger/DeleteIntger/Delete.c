#include <stdio.h>
#include <stdlib.h>
#define MAX_STACK_SIZE 100

typedef char element;
typedef struct {
	element data[MAX_STACK_SIZE];
	int top;
} StackType;

// 스택 초기화 함수
void init_stack(StackType* s)
{
	s->top = -1;
}

// 공백 상태 검출 함수
int is_empty(StackType* s)
{
	return (s->top == -1);
}
// 포화 상태 검출 함수
int is_full(StackType* s)
{
	return (s->top == (MAX_STACK_SIZE - 1));
}
// 삽입함수
void push(StackType* s, element item)
{
	if (is_full(s))
	{
		fprintf(stderr, "스택 포화 에러\n");
		return;
	}
	else s->data[++(s->top)] = item;
}
// 삭제함수
element pop(StackType* s)
{
	if (is_empty(s))
	{
		fprintf(stderr, "스택 공백 에러\n");
		exit(1);
	}
	else return s->data[(s->top)--];
}
// 피크함수
element peek(StackType* s)
{
	if (is_empty(s))
	{
		fprintf(stderr, "스택 공백 에러\n");
		exit(1);
	}
	else return s->data[s->top];
}

int main(void)
{
	printf("정수를 입력하시오. : ");
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
	printf("출력 : ");
	while (!is_empty(&s2)) {
		printf("%d", pop(&s2));
	}
	printf("\n");
	return 0;
}