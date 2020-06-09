#include "DoublyLinkedList.h"
#include<stdio.h>
#include<stdlib.h>

// Node
struct Node
{
	int data;
	struct Node* XOR_Next_Prev;  /* XOR of next and previous node */
};

// XOR value of Previous and Next Addresses
struct Node* XOR(struct Node *a, struct Node *b)
{
	return (struct Node*) ((unsigned int)(a) ^ (unsigned int)(b));
}


void insert(struct Node **head_ref, int data)
{
	// Create new node
	struct Node *new_node = (struct Node *) malloc(sizeof(struct Node));
	new_node->data = data;

	/* Since new node is being inserted at the begining, XOR_Next_Prev of new node
	will always be XOR of current head and NULL */
	new_node->XOR_Next_Prev = XOR(*head_ref, NULL);

	/* If linked list is not empty, then XOR_Next_Prev of current head node will be XOR
	of new node and node next to current head */
	if (*head_ref != NULL)
	{
		// *(head_ref)->XOR_Next_Prev is XOR of NULL and next. So if we do XOR of 
		// it with NULL, we get next
		struct Node* next = XOR((*head_ref)->XOR_Next_Prev, NULL);
		(*head_ref)->XOR_Next_Prev = XOR(new_node, next);
	}

	// Change head
	*head_ref = new_node;
}

// prints contents of doubly linked list in forward direction
void printList(struct Node *head)
{
	struct Node *curr = head;
	struct Node *prev = NULL;
	struct Node *next;

	printf("Following are the nodes of Linked List: \n");

	while (curr != NULL)
	{
		// print current node
		printf("%d ", curr->data);

		// get address of next node: curr->XOR_Next_Prev is next^prev, so curr->XOR_Next_Prev^prev
		// will be next^prev^prev which is next
		next = XOR(prev, curr->XOR_Next_Prev);

		// update prev and curr for next iteration
		prev = curr;
		curr = next;
	}
}

// Main Program
int main()
{

	struct Node *head = NULL;
	insert(&head, 1);
	insert(&head, 2);
	insert(&head, 5);
	insert(&head, 10);

	// print Linked list
	printList(head);
	getchar();
	return (0);
}