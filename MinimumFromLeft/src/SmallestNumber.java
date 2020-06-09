import java.util.Stack;

public class SmallestNumber 
{
	static void PrintSmallestFromLeft(int arr[])
	{
		Stack stack = new Stack();		
		for(int i=0; i< arr.length; i++)
		{
			while(!stack.empty() && ( (int) stack.peek() >= arr[i]))
			{
				stack.pop();
			}
			
			if(stack.empty())
			{
				System.out.print("_ ");
			}
			else
			{
				System.out.print(stack.peek() + " ");
			}			
			stack.push(arr[i]);
		}
		
	}
	
	public static void main(String[] args) 
	{
		int arr[]  = {1,4,6,2,4,8,1,9,2};
		// op Should be _,1,4,1,2,4,_,1,1
		SmallestNumber.PrintSmallestFromLeft(arr);

	}

}
