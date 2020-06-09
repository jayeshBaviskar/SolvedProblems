// RowColEliminate.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int Row = -1, a[4][4], arr[4][4];
	for (int i = 0; i < 4; i++)
	{
		int r = 0;
		Row=Row + 1;
		for (int j = 0; j < 4; j++)
		{
			if (a[i][j] == 0)
			{
				++r;
			}
		}
		if (r == 4)
		{
			--Row;
		}
		else
		{
			for (int k =0 ; k < 4; k++)
				arr[Row][k] = a[j][k];
		}
	}

	return 0;
}

