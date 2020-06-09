// compile with: /EHsc /W4 /MTd  
#include <set>  
#include <iostream>  
#include <vector>  
#include <string>
#include <conio.h>
#include <stdio.h>

using namespace std;
struct node
{
	int data;
	struct node *leftchild;
	struct node *rightchild;
};

void insert(int data);
bool isElementAvail(int data);
void preorder(struct node *root);
void inorder(struct node *root);
void postorder(struct node *root);

struct node* root = NULL;

int main()
{
	cout << "\n-----------------------------\n";
	cout << isElementAvail(70);
	cout << isElementAvail(90);
	cout << "\n-----------------------------\n";

	insert(100);
	insert(70);
	insert(150);
	insert(120);
	insert(80);

	cout << "\n-----------------------------\n";
	
	cout << isElementAvail(70);
	cout << isElementAvail(90);


	cout << "\n-------------PRE ORDER----------------\n";
	preorder(root);

	cout << "\n-------------POST ORDER----------------\n";
	postorder(root);

	cout << "\n-------------IN ORDER----------------\n";
	inorder(root);
	getchar();
}

void insert(int data)
{
	cout << "\n Processing " << data;
	struct node *tempdata = (struct node *) malloc(sizeof(struct node *));
	tempdata->data = data;
	tempdata->rightchild = NULL;
	tempdata->leftchild = NULL;

	struct node *current;
	struct node *parent;

	if (root == NULL)
	{
		cout << " \n Root is NUll so " << data << " will be Root Element";
		root = tempdata;
	}
	else
	{
		current = root;
		parent = NULL;
		while (1)
		{
			parent = current;
			if (data < parent->data)
			{
				cout << "\n Traversing to Left Node";
				current = parent->leftchild;
				if (current == NULL)
				{
					cout << "\n Data Inserted";
					parent->leftchild = tempdata;
					break;
				}
			}
			else
			{
				cout << "\n  Traversing to Right Node";
				current = parent->rightchild;
				if (current == NULL)
				{
					cout << "\n  Data Inserted";
					parent->rightchild = tempdata;
					break;
				}
			}
		}
	}
}

bool isElementAvail(int data)
{
	bool isAvail = false;
	struct node *current = root;
	if (root == NULL)
	{	
		return false;
	}

	while (current->data != data)
	{
		isAvail = true;

		if (data > current->data)
		{
			current = current->rightchild;
		}
		else
		{
			current = current->leftchild;
		}

		if (current == NULL)
		{
			isAvail = false;
			break;
		}
	}
	return isAvail;
}

void inorder(struct node *root)
{
	if (root != NULL)
	{
		inorder(root->leftchild);
		cout << " " << root->data;
		inorder(root->rightchild);
	}
}

void postorder(struct node *root)
{
	if (root != NULL)
	{
		postorder(root->leftchild);
		postorder(root->rightchild);
		cout << " " << root->data;
	}
}


void preorder(struct node *root)
{
	if (root != NULL)
	{
		cout << " " << root->data;
		preorder(root->leftchild);
		preorder(root->rightchild);
	}
}