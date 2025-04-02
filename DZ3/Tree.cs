using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace project.DZ3
{
    internal class Tree
    {
        int level;
        int value;
        public List<Tree> branch;

        public Tree(int NewValue)
        {
            level = 0;
            value = NewValue;
            branch = new List<Tree>();
        }

        public void AddBranch(Tree child)
        {
            branch.Add(child);
            child.level = level + 1;
        }

        public void PrintTree()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < level; i++)
            {
                sb.Append("--");
            }
            sb.Append("|");

            Console.WriteLine($"{sb.ToString()}Tree level: {level}, value: {value}");

            if (branch.Count > 0)
            {
                foreach (Tree child in branch)
                {
                    child.PrintTree();
                }
            }
        }
    }
}
