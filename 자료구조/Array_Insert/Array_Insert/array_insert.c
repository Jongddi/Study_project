#include <stdio.h>
#define MAX_ARRAY 20                                //크기가 n개이니 임의로 지정

void insert(int array[], int loc, int value);       //insert함수 초기화

int items = 10;                                    //items의 값은 배열에 들어있는 원소의 개수

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