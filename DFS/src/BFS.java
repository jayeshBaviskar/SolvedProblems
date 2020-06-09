import java.util.ArrayDeque;
import java.util.List;
import java.util.Queue;
import java.util.Stack;


public class BFS
{
	private Queue<Vertex>  queue;
	
	
	public BFS()
	{
		queue = new ArrayDeque<Vertex>();
	}
	
	public void bfs(List<Vertex> vertexList)
	{
		// only for multiple clusters
		for (Vertex v : vertexList) {
			if(!v.isVisited())
			{
				v.setVisited(true);
				bfsWithQueue(v);
				
			}
		}
	}

	public void bfsWithQueue(Vertex root) {

		
		queue.add(root);
		root.setVisited(true);
		
		while( !queue.isEmpty())
		{
			
			Vertex retrivedVertex = queue.poll();
			System.out.print(retrivedVertex + " ");
			
			
			for(Vertex v : retrivedVertex.getNeighbours())
			{
				if(! v.isVisited())
				{
					v.setVisited(true);
					queue.add(v);
				}
			}
		}
		
	}

}
