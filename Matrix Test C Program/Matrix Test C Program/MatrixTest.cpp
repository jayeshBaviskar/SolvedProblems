#include "MatrixTest.h"
#include<stdio.h>
#include<iostream>
#include<conio.h>

const int row = 4;
const int col = 4;
int newRow = -1;
int newCol = -1;

int NewArray[4][4];
void printArray(int newRow, int newCol, int a[row][col])
{
	printf("\n ----------------------- \n");

	for (int i = 0; i < newRow; i++)
	{
		for (int j = 0; j < newCol; j++)
		{
			printf(" %d", a[i][j]);
		}
		printf("\n");

	}
}

void removeRowsHavingZeros(int arr[row][col])
{
	for (int i = 0; i < row; i++)
	{	
		int rowCounter = 0;
		++newRow;

		for (int j = 0; j < col; j++)
		{
			NewArray[newRow][j] = arr[i][j];

			if (arr[i][j] == 0)
				rowCounter++;			
		}

		if (rowCounter == 4)
			--newRow;		
	}
}

void removeColumnsHavingZeros(int arr[row][col])
{
	for (int i = 0; i < row; i++)
	{
		int colCounter = 0;
		++newCol;

		for (int j = 0; j < col; j++)
		{
			NewArray[j][newCol] = arr[j][i];

			if (arr[j][i] == 0)
				colCounter++;
		}

		if (colCounter == 4)
			--newCol;
	}
}

void main()
{
	int arr[4][4] = {
		{ 1, 2, 0, 5 },
		{ 3, 0, 0, 0 },
		{ 1, 8, 0, 0 },
		{ 5, 6, 0, 9 }
	};

	/* One more Example
		int arr[4][4] = {
		{ 1, 2, 1, 5},
		{ 3, 0, 0, 0},
		{ 0, 0, 0, 0},
		{ 5, 6, 7, 9}
		};
	*/

	int newArr[4][4];

	printArray(row, col, arr);

	removeRowsHavingZeros(arr);
	removeColumnsHavingZeros(NewArray);
	
	printArray(newRow+1, newCol+1, NewArray);

	getch();
}

