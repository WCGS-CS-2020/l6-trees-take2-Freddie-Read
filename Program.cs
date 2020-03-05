using System;
using System.Text;

namespace L6Trees
{
    // Print out the tree using the different tree traversal metods
    
    class Node
    {
        private Node left;
        private Node right;
        private string _item;

        public Node(string item) 
        {
            _item = item;
        }
        public void addNode(string item)
        {
            if (sortAlphabet(item, _item) == true)
            {
                if (left == null)
                    left = new Node(item);
                else
                    left.addNode(item);
            }
            else if (sortAlphabet(item, _item) == false)
            {
                if (right == null)
                    right = new Node(item);
                else
                    right.addNode(item);
            }
        }
        public bool findNode(string item) 
        {
            if (item == _item)
                return true;
            else if (sortAlphabet(item, _item) == true)
                return left.findNode(item);
            else if (sortAlphabet(item, _item) == false)
                return right.findNode(item);
            else
                return false;
        }
        //Doesn't work yet
        public bool deleteNode(string item) 
        {
            if (item == _item)
            {
                _item = "";
                return true;
            }
            else if (sortAlphabet(item, _item) == true)
            {
                left.deleteNode(item);
            }
            else if (sortAlphabet(item, _item) == false)
            {
                right.deleteNode(item);
            }
            else
            {
                return false;
            }
            return false;
        }
        //Doesn't work yet
        public void printTree() 
        {
            try
            {
                if (left._item != null)
                {
                    Console.WriteLine(left._item);
                    left.printTree();
                }
            }
            catch (Exception)
            {
                try
                {
                    if (right._item != null)
                    {
                        Console.WriteLine(right._item);
                        right.printTree();
                    }
                }
                catch (Exception)
                {
                    
                }
            }
            
            
        }

        bool sortAlphabet(string item, string _item)
        {

            byte[] itemAscii = Encoding.ASCII.GetBytes(item);
            byte[] _itemAscii = Encoding.ASCII.GetBytes(_item);

            /*if (itemAscii[0] < _itemAscii[0])
                return true;
            else if (itemAscii[0] > _itemAscii[0])
                return false;
            */

            return itemAscii[0] < _itemAscii[0] ? true : false;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            foreach (var mon in months)
            {
                if (root == null)
                    root = new Node(mon);
                else
                    root.addNode(mon);
            }

            /*Console.WriteLine("Enter node to search");
            string ans = Console.ReadLine();
            if (root.findNode(ans) == true)
                Console.WriteLine("Node exists");
            else
                Console.WriteLine("Node doesn't exist");*/

            /*Console.WriteLine("Enter node to delete");
            ans = Console.ReadLine();
            if (root.deleteNode(ans) == true)
                Console.WriteLine("Node deleted");
            else
                Console.WriteLine("Node doesn't exist");*/

            root.printTree();

            Console.ReadLine();

            // print out the tree using different traversal methods
            //
        }
    }
}
