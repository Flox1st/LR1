using project.DZ3;

System.Console.WriteLine("\nZadanie 3:");

var t = new Tree(1);
t.AddBranch(new Tree(2));
t.AddBranch(new Tree(3));

t.branch[0].AddBranch(new Tree(21));
t.branch[0].AddBranch(new Tree(22));
t.branch[1].AddBranch(new Tree(31));
t.branch[1].AddBranch(new Tree(32));

t.branch[1].branch[1].AddBranch(new Tree(321));
t.branch[0].branch[1].AddBranch(new Tree(221));
t.branch[0].branch[1].branch[0].AddBranch(new Tree(2211));

t.PrintTree();