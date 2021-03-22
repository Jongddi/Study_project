#include <stdio.h>
#include <string.h>
#define MAX_ARRAY 20

int Delete(int array[], int loc, int items)
{
	for (int i = loc; i < items - 1; i++)
	{
		array[i] = array[i + 1];
	}
	array[items - 1] = 0;
	return 0;
}
int main(void)
{
	int n = 10;
	int array[MAX_ARRAY] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	for (int i = 0; i < n - 1; i++)
	{
		printf("%d ", array[i]);
	}
	printf("\n");

	Delete(array, 5, n);

	for (int i = 0; i < n - 1; i++)
	{
		printf("%d ", array[i]);
	}
	printf("\n");
	return 0;
}