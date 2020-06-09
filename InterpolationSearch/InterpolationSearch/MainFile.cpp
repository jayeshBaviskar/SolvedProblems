#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;

int interpolationSearch(int A[], int n, int e);

void main()
{
	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	int position = interpolationSearch(arr, 10, 11);
	cout << "position is " << position;
	getchar();
}
// n = Size of the Array,  e = element to search
int interpolationSearch(int A[], int n, int e)
{
	int start, pos, end;
	start = 0;
	end = n - 1;

	while ( (start <= end) && (e >= A[start]) && (e <= A[end]) )
	{
		pos = start + ( (double)(end - start) / (A[end] - A[start])) * (e - A[start]);
		if (A[pos] == e)
		{
			return pos;
		}
		else if (e > A[pos])
		{
			start = pos + 1;
		}
		else if (e < A[pos])
		{
			end = pos - 1;
		}
	}

	return -1;
}