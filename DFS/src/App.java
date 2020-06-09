import java.util.ArrayList;
import java.util.List;


public class App 
{


	public static void main(String args[])
	{
		Vertex v0 = new Vertex("0");
		Vertex v1 = new Vertex("1");
		Vertex v2 = new Vertex("2");
		Vertex v3 = new Vertex("3");
		

		
		List<Vertex> list = new ArrayList<Vertex>();
		
		v0.addNeighbour(v1);
		v0.addNeighbour(v2);
		v1.addNeighbour(v2);
		v2.addNeighbour(v0);
		v2.addNeighbour(v3);
		v3.addNeighbour(v3);
		
		list.add(v0);
		list.add(v1);
		list.add(v2);
		list.add(v3);
		
		
		DFS dfs = new DFS();
		dfs.dfs(list);
		
		System.out.println("--------------------------------");
		
	/*	BFS bfs = new BFS();
		//bfs.bfs(list);
		bfs.bfsWithQueue(v2);*/
		
		
	
	}
		

	
	
}
