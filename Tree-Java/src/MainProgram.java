import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import com.sun.xml.internal.messaging.saaj.soap.impl.TreeException;

import sun.awt.IconInfo;
import sun.security.jca.GetInstance;

import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;

public class MainProgram extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainProgram frame = new MainProgram();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	Tree tree = Tree.GetInstance();
	
	private JTextField txtNodeValue;
	private JButton btnNewButton_1;
	private JButton btnCreateDummyTree;
	private JButton btnPreorderTraversalrecursive;
	private JButton btnPreorderTraversalinterative;
	private JButton btnPostorderTraversalrecursive;
	private JButton btnPostorderTraversalinterative;
	private JButton btnLevelOrderTraversal;
	private JButton btnLevelOrderTraversal_1;
	private JButton btnGetMaxHeight;
	private JButton btnGetMinHeight;
	private JButton button;
	private JButton btnSearchInTree;
	private JButton btnSearchInTree_1;
	
	/**
	 * Create the frame.
	 */
	public MainProgram() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 804, 450);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		
		JButton btnNewButton = new JButton("Insert Node");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int data = 0;
				try 
				{
					data = Integer.parseInt(txtNodeValue.getText());					
				}
				catch (Exception e) 
				{
					JOptionPane.showMessageDialog(null, e.getMessage());
				}
				tree.InsertNode(data);
			}
		});
		btnNewButton.setBounds(143, 38, 227, 23);
		contentPane.add(btnNewButton);
		
		txtNodeValue = new JTextField();
		txtNodeValue.setBounds(33, 39, 86, 20);
		contentPane.add(txtNodeValue);
		txtNodeValue.setColumns(10);
		
		btnNewButton_1 = new JButton("In-Order Traversal (Recursive)");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.InorderTraversal(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnNewButton_1.setBounds(21, 228, 227, 23);
		contentPane.add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("In-Order Traversal (Interative)");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.InorderTraversalIterative(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
				
			}
		});
		btnNewButton_2.setBounds(21, 262, 227, 23);
		contentPane.add(btnNewButton_2);
		
		btnCreateDummyTree = new JButton("Create Dummy Tree");
		btnCreateDummyTree.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				tree.CreateDummyTree();				
			}
		});
		btnCreateDummyTree.setBounds(143, 72, 227, 23);
		contentPane.add(btnCreateDummyTree);
		
		btnPreorderTraversalrecursive = new JButton("Pre-Order Traversal (Recursive)");
		btnPreorderTraversalrecursive.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.PreOrderTraversal(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnPreorderTraversalrecursive.setBounds(262, 228, 227, 23);
		contentPane.add(btnPreorderTraversalrecursive);
		
		btnPreorderTraversalinterative = new JButton("Pre-Order Traversal (Interative)");
		btnPreorderTraversalinterative.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.PreorderIterative(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnPreorderTraversalinterative.setBounds(262, 262, 227, 23);
		contentPane.add(btnPreorderTraversalinterative);
		
		btnPostorderTraversalrecursive = new JButton("Post-Order Traversal (Recursive)");
		btnPostorderTraversalrecursive.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.PostOrderRecursive(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnPostorderTraversalrecursive.setBounds(538, 228, 227, 23);
		contentPane.add(btnPostorderTraversalrecursive);
		
		btnPostorderTraversalinterative = new JButton("Post-Order Traversal (Interative)");
		btnPostorderTraversalinterative.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.PostOrderIterative(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnPostorderTraversalinterative.setBounds(538, 262, 227, 23);
		contentPane.add(btnPostorderTraversalinterative);
		
		btnLevelOrderTraversal = new JButton("Level Order Traversal");
		btnLevelOrderTraversal.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.LevelOrderTraversing(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnLevelOrderTraversal.setBounds(21, 306, 227, 23);
		contentPane.add(btnLevelOrderTraversal);
		
		btnLevelOrderTraversal_1 = new JButton("Level Order Traversal (Reverse)");
		btnLevelOrderTraversal_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					tree.LevelTraversalInReverseOrder(tree.GetRoot());
					System.out.println("------------------------------------------");
				}
			}
		});
		btnLevelOrderTraversal_1.setBounds(21, 340, 227, 23);
		contentPane.add(btnLevelOrderTraversal_1);
		
		btnGetMaxHeight = new JButton("Get Max Height");
		btnGetMaxHeight.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					int data =  tree.GetMaxHeight(tree.GetRoot());
					System.out.println("Max height of Tree is : "+ data);
					System.out.println("------------------------------------------");
				}
			}
		});
		btnGetMaxHeight.setBounds(262, 306, 125, 23);
		contentPane.add(btnGetMaxHeight);
		
		btnGetMinHeight = new JButton("Get Min Height");
		btnGetMinHeight.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(tree.GetRoot() == null)
				{					
					JOptionPane.showMessageDialog(null, "No Tree Found");
				}
				else
				{
					int data =  tree.GetMinHeight(tree.GetRoot());
					System.out.println("Min height of Tree is : "+ data);
					System.out.println("------------------------------------------");
				}
			}
		});
		btnGetMinHeight.setBounds(262, 340, 125, 23);
		contentPane.add(btnGetMinHeight);
		
		JButton btnPrint = new JButton("Print");
		btnPrint.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				BTreePrinter.printNode(tree.GetRoot());
				
			}
		});
		btnPrint.setBounds(406, 306, 83, 23);
		contentPane.add(btnPrint);
		
		button = new JButton("Print");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				BTreePrinter.print(tree.GetRoot());
			}
		});
		button.setBounds(406, 340, 83, 23);
		contentPane.add(button);
		
		btnSearchInTree = new JButton("Search in Tree (Recursive)");
		btnSearchInTree.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String data  = JOptionPane.showInputDialog("Enter Integer to Search in Tree");
				try
				{
					int intData = Integer.parseInt(data);
					boolean result =  tree.FindinTree(tree.GetRoot(), intData);
					if(result)
					{
						JOptionPane.showMessageDialog(null, "Data Found", "Result", JOptionPane.INFORMATION_MESSAGE);	
					}
					else
					{
						JOptionPane.showMessageDialog(null, "Data Not Found", "Result", JOptionPane.INFORMATION_MESSAGE);
					}
				
				}
				catch(Exception ex)
				{
					JOptionPane.showMessageDialog(null, "Cannot Parse Input to Integer", "Error", JOptionPane.ERROR_MESSAGE);
				}
				
			}
		});
		btnSearchInTree.setBounds(33, 160, 227, 23);
		contentPane.add(btnSearchInTree);
		
		btnSearchInTree_1 = new JButton("Search in Tree (Iterative)");
		btnSearchInTree_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String data  = JOptionPane.showInputDialog("Enter Integer to Search in Tree");
				try
				{
					int intData = Integer.parseInt(data);
					boolean result =  tree.FindInTreeIterative(tree.GetRoot(), intData);
					if(result)
					{
						JOptionPane.showMessageDialog(null, "Data Found", "Result", JOptionPane.INFORMATION_MESSAGE);	
					}
					else
					{
						JOptionPane.showMessageDialog(null, "Data Not Found", "Result", JOptionPane.INFORMATION_MESSAGE);
					}
				
				}
				catch(Exception ex)
				{
					JOptionPane.showMessageDialog(null, "Cannot Parse Input to Integer", "Error", JOptionPane.ERROR_MESSAGE);
				}
				
			}
		});
		btnSearchInTree_1.setBounds(270, 160, 227, 23);
		contentPane.add(btnSearchInTree_1);
	}
}
