#include <stdio.h>
#define MAX_ARRAY 20                            //크기가 n개이니 임의로 지정

int items = 10;                                    //items의 값은 배열에 들어있는 원소의 개수

int delete(int array[], int loc)
{
    for (int i = loc; i < items - 1; i++)
    {
        array[i] = array[i + 1];
    }
    array[items - 1] = 0;
    return 0;
}

void main(void)
{
    int array[MAX_ARRAY] = { 1,2,3,4,5,6,7,8,9,10 };

    for (int i = 0; i < MAX_ARRAY; i++)
    {
        printf("%d ", array[i]);
    }
    printf("\n");

    delete(array, 5, 6);

    for (int i = 0; i < MAX_ARRAY; i++)
    {
        printf("%d ", array[i]);
    }
    printf("\n");
    return 0;
}