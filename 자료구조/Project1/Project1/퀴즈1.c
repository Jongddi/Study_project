#include <stdio.h>

int sub(int n)
{
	if (n < 0)
		return 0;
	return n + sub(n - 3);
}

int main(void)
{
	printf("%d\n", sub(10));
	return 0;
}