
public class Graph 
{

	boolean adjMarix[][];
	int vertex;
	
	public Graph(int vertex)
	{
		this.vertex = vertex;
		adjMarix = new boolean[vertex][vertex];
	}
	
	public void addEdge(int i,int j)
	{
		if( (i>0) && (i<vertex) && (j>0) && (j<vertex) )
		{
			adjMarix[i][i] = true;
			adjMarix[j][i] = true;
		}
	}
	
	
	public void removeEdge(int i, int j)
	{
		if( (i>0) && (i<vertex) && (j>0) && (j<vertex) )
		{
			adjMarix[i][i] = false;
			adjMarix[j][i] = false;
		}
	}
	
	public boolean isEdge(int i, int j)
	{
		if( (i>0) && (i<vertex) && (j>0) && (j<vertex) )
		{
			return adjMarix[i][j];
		}
		else
		{
			return false;
		}
	}
	
}
