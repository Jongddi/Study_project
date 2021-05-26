#include <stdio.h>
#include <stdlib.h>

//스택 구조 생성
#define TRUE 1
#define FALSE 0
#define MAX_STACK_SIZE 100

typedef int element;
typedef struct StackType {
	element data[MAX_STACK_SIZE];
	int top;
} StackType;

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
	if (is_full(s)) {
		fprintf(stderr, "스택 포화 에러\n");
		return;
	}
	else s->data[++(s->top)] = item;
}
// 삭제함수
element pop(StackType* s)
{
	if (is_empty(s)) {
		fprintf(stderr, "스택 공백 에러\n");
		exit(1);
	}
	else return s->data[(s->top)--];
}
//인접 행렬
#define MAX_VERTICES 50
	typedef struct GraphType {
		int n;	// 정점의 개수
		int adj_mat[MAX_VERTICES][MAX_VERTICES];
	} GraphType;

	int visited[MAX_VERTICES];

	// 그래프 초기화 
	void init(GraphType * g)
	{
		int r, c;
		g->n = 0;
		for (r = 0; r < MAX_VERTICES; r++)
			for (c = 0; c < MAX_VERTICES; c++)
				g->adj_mat[r][c] = 0;
	}
	// 정점 삽입 연산
	void insert_vertex(GraphType * g, int v)
	{
		if (((g->n) + 1) > MAX_VERTICES) {
			fprintf(stderr, "그래프: 정점의 개수 초과");
			return;
		}
		g->n++;
	}
	// 간선 삽입 연산
	void insert_edge(GraphType * g, int start, int end)
	{
		if (start >= g->n || end >= g->n) {
			fprintf(stderr, "그래프: 정점 번호 오류");
			return;
		}
		g->adj_mat[start][end] = 1;
		g->adj_mat[end][start] = 1;
	}

	// 명시적인 스택을 이용한 깊이 우선 탐색
	void dfs_iterative(GraphType * g, int v)
	{
		int w;
		StackType *s;
		s = (StackType*)malloc(sizeof(StackType));
		init_stack(s);
		push(s, v);
		while (!is_empty(s))
		{
			v = pop(s);
			if (!visited[v])
			{
				visited[v] = TRUE;
				printf("정점 %d -> ", v);		// 방문한 정점 출력
			}
			for (w = 0; w < g->n; w++) 		// 인접 정점 탐색
				if (g->adj_mat[v][w] && !visited[w])
					push(s, w);	//정점 w에서 DFS 새로 시작
		}
	}

	int main(void)
	{
		GraphType* g;
		g = (GraphType*)malloc(sizeof(GraphType));
		init(g);
		for (int i = 0; i < 4; i++)
			insert_vertex(g, i);
		insert_edge(g, 0, 1);
		insert_edge(g, 0, 2);
		insert_edge(g, 0, 3);
		insert_edge(g, 1, 2);
		insert_edge(g, 2, 3);

		printf("깊이 우선 탐색\n");
		dfs_iterative(g, 0);
		printf("\n");
		free(g);
		return 0;
	}