using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VirtualMarketApplication
{
    public class BinarySearchTree
    {
        private BinarySearchTreeNode root;
        private string nodes;
		private ArrayList Nodes = new ArrayList();
        public BinarySearchTree()
        {

        }

        public BinarySearchTree(BinarySearchTreeNode root)
        {
            this.root = root;
        }

		public int NumberOfNodes()
        {
            return NumberOfNodes(root);
        }

        public int NumberOfNodes(BinarySearchTreeNode node)
        {
            int count = 0;
            if(root != null)
            {
                count = 1;
                count += NumberOfNodes(node.left);
                count += NumberOfNodes(node.right);
            }
            return count;
        }

        public int NumberOfLeaves()
        {
            return NumberOfLeaves(root);
        }

        public int NumberOfLeaves(BinarySearchTreeNode node)
        {
            int count = 0;
            if (root != null)
            {
                if ((node.left == null) && (node.right == null))
                    count = 1;
                else
                    count = count + NumberOfLeaves(node.left) + NumberOfLeaves(node.right);
            }
            return count;
        }

        public string PrintNodes()
        {
            return nodes;
        }

        public void PreOrder()
        {
            nodes = "";
            PreOrderInt(root);
        }

        private void PreOrderInt(BinarySearchTreeNode node)
        {
            if(node == null)
            {
                return;
            }
            Visit(node);
            PreOrderInt(node.left);
            PreOrderInt(node.right);
        }

        public void InOrder()
        {
            nodes = "";
            InOrderInt(root);
        }

        private void InOrderInt(BinarySearchTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            InOrderInt(node.left);
            Visit(node);
            InOrderInt(node.right);
        }

        private void Visit(BinarySearchTreeNode node)
        {
            nodes += node.data + " ";
        }

        public void PostOrder()
        {
            nodes = "";
            PostOrderInt(root);
        }

        private void PostOrderInt(BinarySearchTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderInt(node.left);
            PostOrderInt(node.right);
            Visit(node);
        }

        public void Insert(Product product)
        {
            // New node parent
            BinarySearchTreeNode tempParent = new BinarySearchTreeNode();
            // Start from the root and go
            BinarySearchTreeNode tempSearch = root;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                // Value already, exist
                if (product == tempSearch.data)
                {
                    return;
                }
                else if (tempSearch.left != null)
                {
                    tempSearch = tempSearch.left;
                }
                else
                {
                    tempSearch = tempSearch.left;
                }
            }
            BinarySearchTreeNode goingToInsert = new BinarySearchTreeNode(product);
            // Tree empty, add node
            if (root == null)
                root = goingToInsert;
            else if (tempParent.left == null)
            {
                tempParent.left = goingToInsert;
            }
            else
            {
                tempParent.right = goingToInsert;
            }
        }

        public BinarySearchTreeNode Search(string key)
        {
            return SearchInt(root, key);
        }

        private BinarySearchTreeNode SearchInt(BinarySearchTreeNode node,string key)
        {
            if (node == null)
            {
                return null;
            }
            else if ((string)node.data == key)
            {
                return node;
            }
            else
            {
                return (SearchInt(node.right, key));
            }
        }

		public ArrayList SearchNodes()
		{
			SearchNodesAdd(root);
			return Nodes;
		}

		private void SearchNodesAdd(BinarySearchTreeNode node)
		{
			bool founder = false;
			if (node == null && node != root)
			{
				return;
			}
			else if (node != null)
			{
				foreach (BinarySearchTreeNode itemNode in Nodes)
				{
					if (node.data == itemNode.data)
					{
						founder = true;
					}
				}
				if (founder == false)
				{
					Nodes.Add(node);
				}
				SearchNodesAdd(node.left);
				SearchNodesAdd(node.right);
			}
		}

		public BinarySearchTreeNode SearchRoot()
		{
			return root;
		}

		public BinarySearchTreeNode MinValue()
        {
            BinarySearchTreeNode tempLeft = root;
            while (tempLeft.left != null)
                tempLeft = tempLeft.left;
            return tempLeft;
        }

        public BinarySearchTreeNode MaxValue()
        {
            BinarySearchTreeNode tempRight = root;
            while (tempRight.right != null)
                tempRight = tempRight.right;
            return tempRight;
        }

        private BinarySearchTreeNode Successor(BinarySearchTreeNode NodeDelete)
        {
            BinarySearchTreeNode successorParent = NodeDelete;
            BinarySearchTreeNode successor = NodeDelete;
            BinarySearchTreeNode current = NodeDelete.right;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.left;
            }
            if (successor != NodeDelete.right)
            {
                successorParent.left = successor.right;
                successor.right = NodeDelete.right;
            }
            return successor;
        }

        public bool Delete(int value)
        {
            BinarySearchTreeNode current = root;
            BinarySearchTreeNode parent = root;
            bool isLeft = true;
            // Find node
            while ((int)current.data != value)
            {
                parent = current;
                if (value < (int)current.data)
                {
                    isLeft = true;
                    current = current.left;
                }
                else
                {
                    isLeft = false;
                    current = current.right;
                }
                if (current == null)
                {
                    return false;
                }
            }
            // STATE 1: LEAF NODE
            if (current.left == null && current.right == null)
            {
                if (current == root)
                    root = null;
                else if (isLeft)
                    parent.left = null;
                else
                    parent.right = null;
            }
            //STATE 2: SINGLE CHILDREN NODE
            else if (current.right == null)
            {
                if (current == root)
                {
                    root = current.left;
                }
                else if (isLeft)
                {
                    parent.left = current.left;
                }
                else
                {
                    parent.right = current.left;
                }
            }
            else if (current.left == null)
            {
                if (current == root)
                {
                    root = current.right;
                }
                else if (isLeft)
                {
                    parent.left = current.right;
                }
                else
                {
                    parent.right = current.right;
                }
            }
            //DURUM 3: TWO CHILDREN NODE
            else
            {
                BinarySearchTreeNode successor = Successor(current);
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeft)
                {
                    parent.left = successor;
                }
                else
                {
                    parent.right = successor;
                }
                successor.left = current.left;
            }
            return true;
        }
    }
}
