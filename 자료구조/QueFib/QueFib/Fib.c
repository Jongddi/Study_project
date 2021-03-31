#include <stdio.h>
#include <stdlib.h>

#define MAX_QUEUE_SIZE 40
typedef int element;
typedef struct {
	element data[ MAX_QUEUE_SIZE ];
	int front, rear;
}QueueType;

void error(char *message)
{
	fprintf(stderr, "%s\n", message);
	exit(1);
}

void init_queue(QueueType *q)
{
	q->front = q->rear = 0;
}

int is_empty(QueueType *q)
{
	return(q->front == q->rear);
}

int is_full(QueueType *q) 
{
	return ((q->rear + 1) % MAX_QUEUE_SIZE == q->front);
}

void enqueue(QueueType *q, element item) {
	if (is_full(q))
		error("포화상태\n");
	q->rear = (q->rear + 1) % MAX_QUEUE_SIZE;
	q->data[q->rear] = item;
}

element dequeue(QueueType *q)
{
	if (is_empty(q))
		error("공백상태\n");
	q->front = (q->front + 1) % MAX_QUEUE_SIZE;
	return q->data[q->front];
}

element peek(QueueType *q)
{
	if (is_empty(q))
		error("공백상태\n");
	q->front = (q->front + 1) % MAX_QUEUE_SIZE;
}

int fibonachi(QueueType *q, int n) 
{
	if (n == 0) return 0;
	else if (n == 1) return 1;

	for (int i = 2; i <= n; i++) {
		int d = dequeue(q);
		enqueue(q, d + q->data[q->rear]);
	}
	return q->data[q->rear];
}

int main(void)
{
	QueueType q;
	int n;
	int i=0;
	while (i<11) {
		init_queue(&q);
		enqueue(&q, 0);
		enqueue(&q, 1);
		printf("찾고싶은 피보나치 수열의 위치: ");
		scanf("%d", &n);
		printf("%d번째 피보나치 수열의 값 : %d\n", n, fibonachi(&q, n));
		i++;
	}
	return 0;
}