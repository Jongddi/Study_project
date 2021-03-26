#include <stdio.h>
#include <stdlib.h>

#define MAX_STACK_SIZE 100	// 스택의 최대 크기
typedef int element;		// 데이터의 자료형
element  stack[MAX_STACK_SIZE]; // 1차원 배열
int  top = -1;

// 공백 상태 검출 함수
int is_empty()
{
	return (top == -1);
}
// 포화 상태 검출 함수
int is_full()
{
	return (top == (MAX_STACK_SIZE - 1));
}
// 삽입 함수
void push(element item)
{
	if (is_full()) {
		fprintf(stderr, "스택 포화 에러\n");
		return;
	}
	else stack[++top] = item;
}
// 삭제 함수
element pop()
{
	if (is_empty()) {
		fprintf(stderr, "스택 공백 에러\n");
		exit(1);
	}
	else return stack[top--];
}
// 피크 함수
element peek()
{
	if (is_empty()) {
		fprintf(stderr, "스택 공백 에러\n");
		exit(1);
	}
	else return stack[top];
}

int main(void) {
	int arr, stack;

	printf("정수 배열의 크기 : ");
	scanf("%d", &arr);
	printf("정수를 입력하시오 : ");
	for (int i = 0; i < arr; i++) {
		scanf("%d", &stack);
		push(stack);
	}
	printf("반전된 정수 배열 : ");
	for (int i = 0; i < arr; i++) {
		printf("%d ", pop(stack));
	}
	printf("\n");
	return 0;
}