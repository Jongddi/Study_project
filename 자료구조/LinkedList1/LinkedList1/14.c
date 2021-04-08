#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
    char name[10];
    int age;
    double height;
} element;

typedef struct{
    element data;
    struct ListNode* link;
} ListNode;

void error(char *message)
{
    fprintf(stderr, "%s\n", message);
    exit(1);
}
void insert_last(ListNode **head, element value)
{
    ListNode *p = (ListNode*)malloc(sizeof(ListNode));
    if (p == NULL)
        return;
    p->data = value; p->link = NULL;
    if (*head == NULL)
        *head = p;
    else
    {
        ListNode *temp = *head;
        while (temp->link != NULL)
            temp = temp->link;
        temp->link = p;
    }
}

void print_list(ListNode *head)
{
    for (ListNode *p = head; p != NULL; p = p->link)
        printf("Name: %s // Age: %d // Heigh: %g \n", p->data.name, p->data.age, p->data.height);
}


int main(void)
{
    ListNode *head = NULL;
    element data;

    for (int i = 0; i < 4; i++)
    {
        printf("Name: Age: Heigh: \n");
        scanf("%s %d %lf", data.name, &(data.age), &(data.height));
        insert_last(&head, data);
    }
    print_list(head);
    return 0;
}