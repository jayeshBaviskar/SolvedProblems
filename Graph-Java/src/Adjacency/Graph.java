package Adjacency;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Graph 
{
	private ArrayList<Integer> vertices;
	private List[] edges;
	private int vertexCount =0;
	
	public Graph(int vertexCount)
	{
		this.vertexCount = vertexCount;
		vertices = new ArrayList<Integer>();
		edges = new List[vertexCount];
		
		for (int i = 0; i < vertexCount; i++) 
		{
			vertices.add(i);
			edges[i] = new LinkedList<Integer>();			
		}
	}
	
	public void addNode(int source, int destination)
	{
		int i = vertices.indexOf(source);
		int j = vertices.indexOf(destination);
		
		if(i!=-1 || j!=-1)
		{
			edges[i].add(j);
			edges[j].add(i);
			
			
		}
	}
		
}
