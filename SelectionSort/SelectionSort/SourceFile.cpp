#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;
void selectionSort(int A[], int n);
void show(int A[], int n);
void main()
{
	int arr[] = { 1, 8, 4, 2, 9, 10, 5, 17 };



	cout << "\n";
	show(arr, 8);
	cout << "\n";
	selectionSort(arr, 8);
	show(arr, 8);
	
	getchar();
}

void selectionSort(int A[], int n)
{
	int i, j, small, temp;
	for (i = 0; i < n-1; i++)
	{
		small = i;
		for (j = i+1; j < n; j++)
		{
			if (A[j] < A[small])
			{ 
				small = j;
			}
		}

		temp = A[i];
		A[i] = A[small];
		A[small] = temp;
	}
}

void show(int A[], int n)
{
	for (int  i = 0; i < n; i++)
	{
		cout << " " << A[i];
	}
}

