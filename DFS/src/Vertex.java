import java.util.ArrayList;
import java.util.List;

public class Vertex {
	private String name;
	private boolean isVisited;
	private List<Vertex> neighbours;

	public Vertex(String n) {
		name = n;
		neighbours = new ArrayList<Vertex>();
	}

	public void addNeighbour(Vertex v) {
		neighbours.add(v);
	}

	@Override
	public String toString() {
		return name;

	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public boolean isVisited() {
		return isVisited;
	}

	public void setVisited(boolean isVisited) {
		this.isVisited = isVisited;
	}

	public List<Vertex> getNeighbours() {
		return neighbours;
	}

	public void setNeighbours(List<Vertex> neighbours) {
		this.neighbours = neighbours;
	}

}
