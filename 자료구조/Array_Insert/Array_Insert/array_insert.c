#include <stdio.h>
#define MAX_ARRAY 20                                //ũ�Ⱑ n���̴� ���Ƿ� ����

void insert(int array[], int loc, int value);       //insert�Լ� �ʱ�ȭ

int items = 10;                                    //items�� ���� �迭�� ����ִ� ������ ����

void insert(int array[], int loc, int value)
{
    for (int i = items - 1; i >= loc; i--)
    {
        array[i + 1] = array[i];
    }
        
    array[loc] = value;
    items++;
    return;
}

void main(void)
{
    int array[MAX_ARRAY] = { 1,2,3,4,5,6,7,8,9,10 };
    
    for (int i = 0; i < MAX_ARRAY; i++)
    {
        printf("%d ", array[i]);
    }
    printf("\n");

    insert(array, 5, 6);

    for (int i = 0; i < MAX_ARRAY; i++)
    {
        printf("%d ", array[i]);
    }
    printf("\n");

}