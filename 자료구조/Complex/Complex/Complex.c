#include <stdio.h>

typedef struct complex		//����ü complex����
{
	double real;
	double imag;
}complex;

complex complex_add(struct complex a, struct complex b)
{
	struct complex result;
	result.real = a.real + b.real;
	result.imag = a.imag + b.imag;

	printf("�Ǽ���: %.1f\n", result.real);
	printf("�����: %.1fi\n", result.imag);
	printf("���Ҽ��� ��: %.1f + %.1fi \n", result.real, result.imag);
}

int main(void)
{
	struct complex a, b;		//����ü complex�� ���� c1�� c2����
	struct complex result;		//����ü complex�� ���� result����

	printf("ù ��° �� ��° �Ǽ��θ� �Է��Ͻÿ�: ");
	scanf("%lf %lf", &a.real, &b.real);		// ����ü ��� ������ �����Ͽ� ���� �Է��Ѵ�.
	printf("ù ��° �� ��° ����θ� �Է��Ͻÿ�: ");
	scanf("%lf %lf", &a.imag, &b.imag);

	complex_add(a, b);			//���Ҽ� ��� �Լ� ȣ��

	return 0;
}