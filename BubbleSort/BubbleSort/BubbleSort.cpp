#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;
void bubbleSort(int A[], int n);
void show(int A[], int n);
void main()
{
	int arr[] = { 1, 8, 4, 2, 9, 10, 5, 17 };

	cout << "\n";
	show(arr, 8);
	cout << "\n";
	bubbleSort(arr, 8);
	show(arr, 8);

	getchar();
}

void bubbleSort(int A[], int n)
{
	int i, j, temp, flag;
	for (int i = 1; i < n; i++)
	{
		flag = 0;
		for (int  k = 0; k < n-i; k++)
		{
			if (A[k] > A[k + 1])
			{
				temp = A[k];
				A[k] = A[k + 1];
				A[k + 1] = temp;
				flag = 1;
			}
		}

		if (flag == 0)
		{
			break;
		}
	}
}

void show(int A[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << " " << A[i];
	}
}

