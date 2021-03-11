#include <stdio.h>

int factorial(int n)
{
	int i=0, result = 1;

	for (i = 1; i <= n; i++)
	{
		printf("factorial(%d)\n", i);
		result = result * i;
	}
	return (result);
}

int main()
{
	printf("%d\n", factorial(3));
	return 0;
}