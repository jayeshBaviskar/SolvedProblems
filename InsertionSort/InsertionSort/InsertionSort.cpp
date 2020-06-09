#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;
void insertionSort(int A[], int n);
void show(int A[], int n);
void main()
{
	int arr[] = { 1, 8, 4, 2, 9, 10, 5, 17 };



	cout << "\n";
	show(arr, 8);
	cout << "\n";
	insertionSort(arr, 8);
	show(arr, 8);

	getchar();
}

void insertionSort(int A[], int n)
{
	int i, value, index;
	for (i = 1; i < n; i++)
	{
		value = A[i];
		index = i;
		while (index > 0 && A[index - 1] > value)
		{
			A[index] = A[index - 1];
			index = index - 1;
		}

		A[index] = value;
	}
}

void show(int A[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << " " << A[i];
	}
}

