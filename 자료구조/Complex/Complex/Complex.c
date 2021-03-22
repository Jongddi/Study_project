#include <stdio.h>

typedef struct complex		//구조체 complex선언
{
	double real;
	double imag;
}complex;

complex complex_add(struct complex a, struct complex b)
{
	struct complex result;
	result.real = a.real + b.real;
	result.imag = a.imag + b.imag;

	printf("실수부: %.1f\n", result.real);
	printf("허수부: %.1fi\n", result.imag);
	printf("복소수의 합: %.1f + %.1fi \n", result.real, result.imag);
}

int main(void)
{
	struct complex a, b;		//구조체 complex의 변수 c1과 c2선언
	struct complex result;		//구조체 complex의 변수 result선언

	printf("첫 번째 두 번째 실수부를 입력하시오: ");
	scanf("%lf %lf", &a.real, &b.real);		// 구조체 멤버 변수에 접근하여 값을 입력한다.
	printf("첫 번째 두 번째 허수부를 입력하시오: ");
	scanf("%lf %lf", &a.imag, &b.imag);

	complex_add(a, b);			//복소수 계산 함수 호출

	return 0;
}