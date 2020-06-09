import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

import javax.swing.JOptionPane;

public class Tree 
{
	Node root = null;
	
	static Tree tree = null;
	
	private Tree()
	{
		//tree = new Tree();
	}
	
	
	public  static Tree GetInstance()
	{
		if(tree == null)
		{
			tree = new Tree();
			return tree;
		}
		else
		{
			return tree;
		}
	}
	public Node GetRoot()
	{
		return root;
	}
	
	public void InsertNode(int data)
	{
		if(root == null) // if this is First Node of the Tree
		{
			Node node = new Node(data);
			root = node;
			JOptionPane.showMessageDialog(null, data + " Inserted at root");
		}
		else
		{
			Node currNode = root;
			Node prevNode = null;
			while(currNode!=null)
			{
				prevNode = currNode;
				
				if(currNode.GetData() > data)
				{
					currNode = currNode.GetLeft();
				}
				else
				{
					currNode = currNode.GetRight();
				}
			}
			
			if(prevNode.GetData() > data)
			{
				Node node = new Node(data);
				prevNode.SetLeft(node);
				JOptionPane.showMessageDialog(null, data + " Inserted at Left");
			}
			else
			{
				Node node = new Node(data);
				prevNode.SetRight(node);
				JOptionPane.showMessageDialog(null, data + " Inserted at Right");
			}
		}		
	}
	
	
	public void InorderTraversal(Node root)
	{
		if(root != null)
		{
			InorderTraversal(root.GetLeft());
			System.out.println(root.GetData());
			InorderTraversal(root.GetRight());
		}
	}
	
	public void PreOrderTraversal(Node root)
	{
		if(root!=null)
		{
			System.out.println(root.GetData());
			PreOrderTraversal(root.GetLeft());
			PreOrderTraversal(root.GetRight());
		}
	}
	
	public void PostOrderRecursive(Node root)
	{
		if(root!=null)
		{
			PostOrderRecursive(root.GetLeft());
			PostOrderRecursive(root.GetRight());
			System.out.println(root.GetData());
			
		}
	}
	
	public void PostOrderIterative(Node root)
	{
		Stack<Node> s1 = new Stack<Node>();
		Stack<Node> s2 = new Stack<Node>();
		
		Node currNode = root;
		s1.push(currNode);
		
		while(!s1.isEmpty())
		{
			Node node = s1.pop();
			s2.push(node);
			
			if(node.GetLeft() != null)
			{
				s1.push(node.GetLeft());
			}
			
			if(node.GetRight() != null)
			{
				s1.push(node.GetRight());	
			}						
		}
		
		while(!s2.empty())
		{
			Node node = s2.pop();
			System.out.println(node.GetData());
		}
	}
	
	public void InorderTraversalIterative(Node root)
	{
		Node currNode = root;
		Stack<Node> stack = new Stack<Node>();
		boolean isDone = false;
		
		while(!isDone)
		{
			if(currNode != null)
			{
				stack.push(currNode);
				currNode = currNode.GetLeft();
			}
			else
			{
				if(stack.isEmpty())
				{
					isDone = true;
				}
				else
				{
					Node node = stack.pop();
					System.out.println(node.GetData());
					currNode = node.GetRight();
				}
			}
		}
	}
	
	public void PreorderIterative(Node root)
	{
		Node currNode = root;
		Stack<Node> stack = new Stack<Node>();
		stack.push(currNode);
		while(!stack.isEmpty())
		{
			Node node = stack.pop();
			System.out.println(node.GetData());
			
			if(node.GetRight() != null)
			{
				stack.push(node.GetRight());
			}
			
			if(node.GetLeft() != null)
			{
				stack.push(node.GetLeft());
			}						
		}		
	}
	
	
	public void LevelOrderTraversing(Node root)
	{
		Queue<Node> queue = new LinkedList<Node>();
		Node currNode = root;
		queue.offer(currNode);
		
		while(!queue.isEmpty())
		{
			Node node = queue.poll();
			System.out.println(node.GetData());
			
			if(node.GetLeft() != null)
			{
				queue.offer(node.GetLeft());
			}
			
			if(node.GetRight() != null)
			{
				queue.offer(node.GetRight());
			}
		}
		
	}
	
	
	public int GetMaxHeight(Node root)
	{
		if(root == null)
		{
			return 0;
		}
		else
		{
			int lheight = GetMaxHeight(root.GetLeft());
			int rheight= GetMaxHeight(root.GetRight());
			
			if(lheight > rheight)
			{
				return lheight +1;
			}
			else
			{
				return rheight + 1 ;
			}
		}
		
	}
	
	public int GetMinHeight(Node root)
	{
		if(root == null)
		{
			return 0;
		}
		else
		{
			int lheight = GetMaxHeight(root.GetLeft());
			int rheight= GetMaxHeight(root.GetRight());
			
			if(lheight < rheight)
			{
				return lheight +1;
			}
			else
			{
				return rheight + 1 ;
			}
		}
		
	}
	
	public void LevelTraversalInReverseOrder(Node root)
	{
		Node currNode = root;
		Queue<Node> queue = new LinkedList<Node>() ;
		Stack<Node> stack = new Stack<Node>();
		
		queue.offer(currNode);
		
		while(!queue.isEmpty())
		{
			currNode = queue.poll();
			stack.push(currNode);
			
			if(currNode.GetLeft() != null)
			{
				queue.offer(currNode.GetLeft());
			}
			
			if(currNode.GetRight() != null)
			{
				queue.offer(currNode.GetRight());
			}
			
		}
		
		while (!stack.isEmpty()) 
		{
			currNode = stack.pop();
			System.out.println(currNode.GetData());			
		}
		
	}
	
	public boolean FindinTree(Node root, int data)
	{
		if(root == null)
		{
			return false;
		}
		
		if(root.GetData() == data)
		{
			return true;
		}
		
		return (FindinTree(root.GetLeft(),data)  || FindinTree(root.GetRight(),data));
	}
	
	
	
	public boolean FindInTreeIterative(Node root, int data)
	{
		Queue<Node> queue = new LinkedList<Node>();
		if(root == null)
		{
			return false;
		}
		
		queue.offer(root);
		while(!queue.isEmpty())
		{
			Node node = queue.poll();
			if(node.GetData() == data)
			{
				return true;
			}
			
			if(node.GetLeft() != null)
			{
				queue.offer(node.GetLeft());
			}
			
			if(node.GetRight() != null)
			{
				queue.offer(node.GetRight());
			}
			
		}
		
		return false;
	}
	public void CreateDummyTree()
	{
		InsertNode(50);
		InsertNode(10);
		InsertNode(30);
		InsertNode(20);
		InsertNode(40);
		InsertNode(90);
		InsertNode(70);
		InsertNode(80);
		InsertNode(60);
	}
	
}
