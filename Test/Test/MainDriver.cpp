#include "MainDriver.h"
#include <stdio.h>
#include <conio.h>
#include <iostream>

MainDriver::MainDriver()
{
}



void main()
{
	
	int a = 10, b;
	b = a++ + ++a;

	
	printf("%d %d", a,b);
	getchar();

}
MainDriver::~MainDriver()
{
}
