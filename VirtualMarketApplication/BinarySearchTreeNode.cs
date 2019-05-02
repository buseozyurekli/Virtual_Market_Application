using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMarketApplication
{
    public class BinarySearchTreeNode
    {
        public object data;
        public BinarySearchTreeNode left;
        public BinarySearchTreeNode right;
        public BinarySearchTreeNode()
        {
        }
        public BinarySearchTreeNode(object data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
