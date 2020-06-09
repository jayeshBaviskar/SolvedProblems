import java.util.List;
import java.util.Stack;


public class DFS
{
	private Stack<Vertex> stack;
	
	public DFS()
	{
		stack = new Stack<Vertex>();
	}
	
	public void dfs(List<Vertex> vertexList)
	{
		// only for multiple clusters
		for (Vertex v : vertexList) {
			if(!v.isVisited())
			{
				v.setVisited(true);
				dfsWithStack(v);
				
			}
		}
	}

	private void dfsWithStack(Vertex root) {

		stack.add(root);
		root.setVisited(true);
		
		while( !stack.isEmpty())
		{
			Vertex retrivedVertex = stack.pop();
			System.out.print(retrivedVertex + " ");
			
			
			for(Vertex v : retrivedVertex.getNeighbours())
			{
				if(! v.isVisited())
				{
					v.setVisited(true);
					stack.push(v);
				}
			}
		}
		
	}

}
