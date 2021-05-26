#include <stdio.h>
#include <stdlib.h>

//���� ���� ����
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
	if (is_full(s)) {
		fprintf(stderr, "���� ��ȭ ����\n");
		return;
	}
	else s->data[++(s->top)] = item;
}
// �����Լ�
element pop(StackType* s)
{
	if (is_empty(s)) {
		fprintf(stderr, "���� ���� ����\n");
		exit(1);
	}
	else return s->data[(s->top)--];
}
//���� ���
#define MAX_VERTICES 50
	typedef struct GraphType {
		int n;	// ������ ����
		int adj_mat[MAX_VERTICES][MAX_VERTICES];
	} GraphType;

	int visited[MAX_VERTICES];

	// �׷��� �ʱ�ȭ 
	void init(GraphType * g)
	{
		int r, c;
		g->n = 0;
		for (r = 0; r < MAX_VERTICES; r++)
			for (c = 0; c < MAX_VERTICES; c++)
				g->adj_mat[r][c] = 0;
	}
	// ���� ���� ����
	void insert_vertex(GraphType * g, int v)
	{
		if (((g->n) + 1) > MAX_VERTICES) {
			fprintf(stderr, "�׷���: ������ ���� �ʰ�");
			return;
		}
		g->n++;
	}
	// ���� ���� ����
	void insert_edge(GraphType * g, int start, int end)
	{
		if (start >= g->n || end >= g->n) {
			fprintf(stderr, "�׷���: ���� ��ȣ ����");
			return;
		}
		g->adj_mat[start][end] = 1;
		g->adj_mat[end][start] = 1;
	}

	// ������� ������ �̿��� ���� �켱 Ž��
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
				printf("���� %d -> ", v);		// �湮�� ���� ���
			}
			for (w = 0; w < g->n; w++) 		// ���� ���� Ž��
				if (g->adj_mat[v][w] && !visited[w])
					push(s, w);	//���� w���� DFS ���� ����
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

		printf("���� �켱 Ž��\n");
		dfs_iterative(g, 0);
		printf("\n");
		free(g);
		return 0;
	}