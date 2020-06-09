#include<stdio.h>
#include<conio.h>
#include<iostream>

using namespace std;

struct node
{
	int data;
	struct node *next;
};

struct node *head = NULL;
void insertAtEnd(int data);
void main()
{
	insertAtEnd(10);
	insertAtEnd(20);
	getchar();
}

void insertAtEnd(int data)
{
	struct node *tempnode = (struct node *) malloc(sizeof(struct node *));
	tempnode->data = data;
	tempnode->next = NULL;
	
	struct node *current; 

	if (head == NULL)
	{
		head = tempnode;
		cout << "Record inserted at head successfully";
	}
	else
	{
		current = head;
		while (head->next != NULL)
		{
			current = head->next;
		}

		head->next = current;
		cout << "record inserted successfully";
		

	}
}
