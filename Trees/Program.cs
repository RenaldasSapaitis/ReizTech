//The height of a tree is the length of the path from the root to the deepest node in the tree. 
//A (rooted) tree with only a node (the root) has a height of zero." 

//We know that binary trees have a root node, and that every node can have a maximum of two children

// C# program to find the height of
// an N-ary tree
using System;
 
public class Trees
{
 
// Structure of a node of an n-ary tree, can also be written as a struct with vectors.
public class Node
{
    public char key;
    public List<Node > child;
};
 
// function to create a new tree node.
static Node newNode(int key)
{
    Node temp = new Node();
    temp.key = (char) key;
    temp.child = new List<Node>();
    return temp;
}
 
// Function that returns height of tree.
static int heightOfTree(Node ptr)
{
    // Base case
    if (ptr == null)
        return 0;
 
    // Check for all children and find max height.
    int maxHeight = 0;
    foreach (Node n in ptr.child)
        maxHeight = Math.Max(maxHeight,
                            heightOfTree(n));
 
    return maxHeight + 1 ;
}
public static void Main(String[] args)
{
     
    /* create below tree from assignment, labeling each branch
    *             A
    *            /  \
    *           B    C 
    *          /   / | \
    *         D    E F G
    *             / / \
    *            H  I J
    *               |
    *               K
    */
    Node root = newNode('A');
    (root.child).Add(newNode('B'));
    (root.child).Add(newNode('C'));
    (root.child[0].child).Add(newNode('D'));
    (root.child[1].child).Add(newNode('E'));
    (root.child[1].child).Add(newNode('F'));
    (root.child[1].child).Add(newNode('G'));
    (root.child[1].child[0].child).Add(newNode('H'));
    (root.child[1].child[1].child).Add(newNode('I'));
    (root.child[1].child[1].child).Add(newNode('J'));
    (root.child[1].child[1].child[0].child).Add(newNode('K'));
     
    Console.Write("the depth of this tree is " + heightOfTree(root) + "\n");
}
}