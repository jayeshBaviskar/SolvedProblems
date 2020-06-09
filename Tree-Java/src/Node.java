
public class Node 
{
	private int data;
	private Node right;
	private Node left;
	
	public Node(int data)
	{
		this.data= data;
		right=null;
		left=null;
	}
	
	public int GetData()
	{
		return data;
	}
	
	public Node GetRight()
	{
		return right;
	}
	
	public Node GetLeft()
	{
		return left;
	}
	
	
	public void SetLeft(Node left)
	{
		this.left = left;
	}
	
	public void GetData(int data)
	{
		this.data =data;
	}
	
	public void SetRight(Node right)
	{
		this.right=right;
	}
	
	
	
	
}
