// See https://aka.ms/new-console-template for more information

using CSharpTest.algorithms;
using System;

class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");

        /*
            TreeAlgorithms ta = new TreeAlgorithms();
            NodeBT root = new NodeBT("5");
            root.left = new NodeBT("3");
            root.right = new NodeBT("7");
            //NodeBT root = null;
            //ta.TreeVisibleNodeBTsLeft(root);
            //ta.TreeVisibleNodeBTsRight(root);
            ta.TraverseBFS(root);
        */

        /*
            ListAlgorithms la = new ListAlgorithms();
            List<int> common = la.CommonElementsTwoLists(new []{3,5,9,11}, new []{2,3,4,7,11,12,15});

        */
        /*
            SortAlgorithms sa = new SortAlgorithms();

            int[] sortedArr = sa.BubbleSort(new int[] {
                10,5,9,2,3,7,4
            });

            int[] sortedArr2 = sa.MergeSort(new int[] {
                10,5,9,2,3,7,4
            });
        */
        /*
            MiscAlgorithms ma = new MiscAlgorithms();
            int res = ma.Fib(6);
            //O(2^n)
            Console.WriteLine(res);
        */
        /*
            StackAlgorithms sa = new StackAlgorithms();
            sa.Push(5);
            sa.Push(4);
            sa.Push(3);

            int a = sa.Pop();
            Console.WriteLine(a);

            int b = sa.Pop();
            Console.WriteLine(b);

            int c = sa.Pop();
            Console.WriteLine(c);

            int d;
            try {
                d = sa.Pop();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            */
        /*
        QueueAlgorithms q = new QueueAlgorithms();
        q.Enqueue(5);
        q.Enqueue(4);
        q.Enqueue(3);

        int a = q.Dequeue();
        Console.WriteLine(a);

        int b = q.Dequeue();
        Console.WriteLine(b);

        int c = q.Dequeue();
        Console.WriteLine(c);

        int d;
        try {
            d = q.Dequeue();
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        */
        /*
        MiscAlgorithms m = new MiscAlgorithms();
        TreeNodeBT root = new TreeNodeBT(2);
        root.left = new TreeNodeBT(1);
        root.right = new TreeNodeBT(3);

        QueryOnTree[] q = new QueryOnTree[] {
            new QueryOnTree(){nodeVal = 1, searchChar = 'a'},
            new QueryOnTree(){nodeVal = 2, searchChar= 'b'},
            new QueryOnTree(){nodeVal = 2, searchChar= 'a'}
        };
        int[] res = m.SolveQueries(root, "aba", q);
        */
        //CrackFB c = new CrackFB();
        //int[] arr = c.MoveZerosLeft(new int[]{1,10,20,0,59,63,0,88,0});
        /*
        List<IntervalPair> res = c.MergeOverlapIntervals(
            new IntervalPair[] {
                new IntervalPair() { start = 1, end = 5},
                new IntervalPair() { start = 3, end = 7},
                new IntervalPair() { start = 4, end = 6},
                new IntervalPair() { start = 6, end = 8}
            });
        */
        /*
            TreeNodeBT root = new TreeNodeBT(2);
            root.left = new TreeNodeBT(1);
            root.right = new TreeNodeBT(3);
            LinkedList ll = c.BTtoLL(root);
        */
        /*
            TreeNodeBT root1 = new TreeNodeBT(2);
            root1.left = new TreeNodeBT(1);
            root1.right = new TreeNodeBT(3);
            root1.right.right = new TreeNodeBT(7);

            TreeNodeBT root2 = new TreeNodeBT(2);
            root2.left = new TreeNodeBT(1);
            root2.right = new TreeNodeBT(3);

            TreeNodeBT root3 = new TreeNodeBT(2);
            root3.left = new TreeNodeBT(3);
            root3.right = new TreeNodeBT(1);
            root3.left.left = new TreeNodeBT(7);

            TreeMirror tm = new TreeMirror();
            bool res1 = tm.IsTreeMirror(root1, root2);
            bool res2 = tm.IsTreeMirror(root1, root3);
        */
        /*
            ArrayAnomaly a = new ArrayAnomaly();
            int anom = a.FindFirstAnomaly(new int[] {
                3,4,5,7,8,9
            });
        */
        /*
            CrackFB cf = new CrackFB();
            double x = cf.CalculatePower(3,-5);
        */
        /*
            ValidPaligrome p = new ValidPaligrome();
            bool res1 = p.IsValidPaligrome("A man, a plan, a canal: Panama"); //true
            bool res2 = p.IsValidPaligrome(""); //true
            bool res3 = p.IsValidPaligrome("man woman"); 
        */
        /*
            RangeSumBST r = new RangeSumBST();
            TreeNodeBT root = new TreeNodeBT(9);
            root.left = new TreeNodeBT(5);
            root.right = new TreeNodeBT(12);
            root.left.left = new TreeNodeBT(2);
            root.left.right = new TreeNodeBT(6);
            root.right.right = new TreeNodeBT(14);
            int res = r.GetRangeSumBST(6, 12, root);
            */
        /*
        RandomPickWithWeight rw = new RandomPickWithWeight();
        int res = rw.PickIndex(new int[] {1,3,4,5,2});
        */
        /*
            KClosestPointsToOrigin k = new KClosestPointsToOrigin();
            int [][] res = k.GetKClosestPointsToOrigin(
                new int[][] {
                    new int[] {3,3}, 
                    new int[] {5,-1}, 
                    new int[] {-2,4}, 
                }
            , 2);
            */
        /*
            RunningSum r = new RunningSum();

            int res = r.GetSubArraysSumEqK(new int[] {1,2,3,4,5}, 0);
        */
        /*
            VOrderTreeTraversal v = new VOrderTreeTraversal();
            TreeNodeBTExt root = new TreeNodeBTExt(1);
            root.left = new TreeNodeBTExt(2);
            root.right = new TreeNodeBTExt(6);
            root.left.right = new TreeNodeBTExt(7);
            root.left.right.left = new TreeNodeBTExt(4);
            root.left.right.right = new TreeNodeBTExt(5);
            root.left.right.right.left = new TreeNodeBTExt(8);
            root.right.left = new TreeNodeBTExt(3);
            List<int> res = v.TraverseVOrder(root);
            */
        /*
        GroupShiftedStrings g = new GroupShiftedStrings();
          List<List<string>> res = g.GetShiftedStrsGroups(
            new string[] {
                    "abd", "bce", "ac", "ya", "h", "p"
                }
            );
        */

        /*
        InvalidParantheses i = new InvalidParantheses();
        string res = i.RemoveMinInvalidParantheses("((((H)e(llo(xyz)World)))");
        */
        /*
            ReverseString r = new ReverseString();
            string res = r.Reverse("The sky is dark blue");
            */
        /*
            StringAnagrams a = new StringAnagrams();
            bool res1 = a.AreWordsAnagrams("we are guys", "guys we are");
            bool res2 = a.AreWordsAnagrams("guys we ar", "guys we are");
            bool res3 = a.AreWordsAnagrams("we are gxys", "guys we are");
        */
        /*
            ZerosToLeft z = new ZerosToLeft();
            int[] res = z.MoveZerosLeft(new int[] {
                0,0,5,0,3,0
            });
            */
        /*
            MergeOverlappingIntervals m = new MergeOverlappingIntervals();
            List<Interval> res = m.MergeIntervals(
                new Interval[] {
                    new Interval() { p1 = 1, p2 = 5},
                    new Interval() { p1 = 3, p2 = 7},
                    new Interval() { p1 = 4, p2 = 6},
                    new Interval() { p1 = 6, p2 = 8},
                    new Interval() { p1 = 9, p2 = 11}
                });
          */
        /*
          TreeToLinkedList t = new TreeToLinkedList();
          TNodeBT r = new TNodeBT(5);
          r.left = new TNodeBT(3);
          r.right = new TNodeBT(8);
          r.right.right = new TNodeBT(11);
          LList res = t.TransformTreeToList(r);  
          */
        /*
            StockMaxProfit s = new StockMaxProfit();
            int res = s.GetMaxProfit(new int[] {7,1,5,3,6,4,11});
            */
        /*
            ReverseStringInPlace r = new ReverseStringInPlace();
            string res = r.ReverseString("Hello Meta interview");
            */
        /*
            GraphAlgorithms ga = new GraphAlgorithms();
            Graph g = new Graph(false);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(1, 0);
            g.AddEdge(1, 5);
            g.AddEdge(2, 5);
            g.AddEdge(3, 0);
            g.AddEdge(3, 4);
            g.AddEdge(4, 6);
            g.AddEdge(5, 1);
            g.AddEdge(6, 5);   

            ga.BFSGraph(0, g);
        */
        /*
            TripletsWithZeroSum t = new TripletsWithZeroSum();
            t.FindTripletsZeroSum(new int[] {
                0, -1, 2, -3, 1
            });
        */
        /*
            SortAlgorithms sa = new SortAlgorithms();

            int[] sortedArr = sa.QuickSort(new int[] {
                10,5,9,2,3,7,4
            });

            int[] sortedArr2 = sa.QuickSort(new int[] {
                10,5,9,2,3,7,4
            });
        */
        /*
            AboveAverageSubArrays a = new AboveAverageSubArrays();
            Subarray[] res = a.aboveAverageSubarrays(new int[] {3, 4, 2});
            */
        /*
        AnswerQuery aq = new AnswerQuery();
        //queries = [[2, 3], [1, 2], [2, 1], [2, 3], [2, 2]]
        //Output = [-1, 2, -1, 2]
        List<Query> q = new List<Query>();
        q.Add(new Query() {type=2, index=3});
        q.Add(new Query() {type=1, index=2});
        q.Add(new Query() {type=2, index=1});
        q.Add(new Query() {type=2, index=3});
        q.Add(new Query() {type=2, index=2});
        int[] res = aq.answerQueries(q, 5);
        */
        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /*
        VertOrderTreeTraversal v = new VertOrderTreeTraversal();
            VTreeNodeBT root = new VTreeNodeBT(1);
            root.left = new VTreeNodeBT(2);
            root.right = new VTreeNodeBT(6);
            root.left.right = new VTreeNodeBT(7);
            root.left.right.left = new VTreeNodeBT(4);
            root.left.right.right = new VTreeNodeBT(5);
            root.left.right.right.left = new VTreeNodeBT(8);
            root.right.left = new VTreeNodeBT(3);
            int[] res = v.TraverseVOrder(root);
           */
        /*
        GroupShiftedStringsE g = new GroupShiftedStringsE();
          List<List<string>> res = g.GetShiftedStrsGroups(
            new string[] {
                    "abd", "bce", "ac", "ya", "h", "p"
                }
            );
        */

        /*
        InvalidPAranthesesE i = new InvalidPAranthesesE();
        string res = i.RemoveMinInvalidParantheses("((((H)e(llo(xyz)World)))");
        */
        /*
            ReverseStringE r = new ReverseStringE();
            string res = r.Reverse("The sky is dark blue");
        */

        /*
            ZerosToLeftE z = new ZerosToLeftE();
            int[] res = z.MoveZerosLeft(new int[] {
                //0,0,5,0,3,0
                1,2,0,7,0,0,3
            });
        */

        /*
        StringAnagramsE a = new StringAnagramsE();
        bool res1 = a.AreWordsAnagrams("we are guys", "guys we are");
        bool res2 = a.AreWordsAnagrams("guys we ar", "guys we are");
        bool res3 = a.AreWordsAnagrams("we are gxys", "guys we are");
        */

        /*
            MergeOverlappingIntervalsE m = new MergeOverlappingIntervalsE();
            List<Interval> res = m.MergeIntervals(
                new Interval[] {
                    new Interval() { p1 = 1, p2 = 5},
                    new Interval() { p1 = 3, p2 = 7},
                    new Interval() { p1 = 4, p2 = 6},
                    new Interval() { p1 = 6, p2 = 8},
                    new Interval() { p1 = 9, p2 = 11}
                });
        */


        /*
            ArrayAnomalyE a = new ArrayAnomalyE();
            int anom = a.FindFirstAnomaly(new int[] {
                3,4,5,7,8,9
            });
        */

        /*
            ValidPaligromeE p = new ValidPaligromeE();
            bool res1 = p.IsValidPaligrome("A man, a plan, a canal: Panama"); //true
            bool res2 = p.IsValidPaligrome(""); //true
            bool res3 = p.IsValidPaligrome("man woman"); 
        */
        /*
            List<string> dict = new List<string>
                { "this", "th", "is", "famous", "Word", "break", 
                    "b", "r", "e", "a", "k", "br", "bre", "brea", "ak", "problem" };

            string word = "Wordbreakproblem";
            WordBreak w = new WordBreak();
            w.wordBreak(dict, word, "");
        */
        /*
            NextLargerNum n = new NextLargerNum();
            int res1 = n.GetNextLargerNum(12345);
            int res2 = n.GetNextLargerNum(321432);
            */
        /*
            PalingromeOneInvalid p = new PalingromeOneInvalid();
            bool res1 = p.IsValidPalingrome("abca");
            bool res2 = p.IsValidPalingrome("abcba");
            bool res3 = p.IsValidPalingrome("abcxa");
            */
        /*
        MinCostAllPoints m = new MinCostAllPoints();

        int[][] points1 = {
            new int []{ 0,0 },
            new int []{ 2,2 },
            new int []{ 3,10 },
            new int []{ 5,2 },
            new int []{ 7,0 }
        };
        int res1 = m.MinCostConnectPoints(points1);

        //points = [[3,12],[-2,5],[-4,1]]
            int[][] points2 = {
            new int []{ 3,12 },
            new int []{ -2,5 },
            new int []{ -4,1 }
        };
        int res2 = m.MinCostConnectPoints(points2);
        */
        /*
        LastStoneWeight l = new LastStoneWeight();
        int res1 = l.GetLastStoneWeight(new int[]{2,7,4,1,8,1});
        int res2 = l.GetLastStoneWeight(new int[]{4,3,4,3,2});
        */
        /*
        AverageSalary a = new AverageSalary();
        double res = a.Average(new int[]{4000,3000,1000,2000});
        */
        /*
        DigitsAddition d = new DigitsAddition();
        int res = d.AddDigits(38);
        */
        /*
        ArraySign s = new ArraySign();
        int res = s.GetArraySign(new int[]{9,72,34,29,-49,-22,-77,-17,-66,-75,-44,-30,-24});
        */
        /*
        KthLargest k = new KthLargest(3, new[] {4, 5, 8, 2});
        int? res1 = k.Add(3);   // return 4
        int? res2 = k.Add(5);   // return 5
        int? res3 = k.Add(10);  // return 5
        int? res4 = k.Add(9);   // return 8
        int? res5 = k.Add(4);   // return 8
        */
        /*
        MergeArrays m = new MergeArrays();
        int [] res = m.Merge(new int[] {1,2,3,0,0,0}, 3, new int[] {2,5,6}, 3);
        */
        /*
        RemoveElement r = new RemoveElement();
        int res1 = r.RemoveElementVal(new int[] {3,2,2,3}, 3);
        int res2 = r.RemoveElementVal(new int[] {0,1,2,2,3,0,4,2}, 2);
        int res3 = r.RemoveElementVal(new int[] {3,3}, 3);
        */
        /*
        RomanToInteger r = new RomanToInteger();
        int res1 = r.RomanToInt("III");
        */
        /*
        ValidParentheses v = new ValidParentheses();
        bool res = v.IsValid("([)]");
        */
        /*
        GroupAnagrams g = new GroupAnagrams();
        IList<IList<string>> res = g.GetGroupAnagrams(
           new []{"eat","tea","tan","ate","nat","bat"} 
        );
        */
        /*
        ReverseVowelsString r = new ReverseVowelsString();
        string res = r.ReverseVowels("Hello");
        */
        /*
        LetterCombOfPhone l = new LetterCombOfPhone();
        IList<string> res = l.LetterCombinations("23");
        */

        /*
        ProductsArray p = new ProductsArray();
        int[] res1 = p.GetProductsArray(new int[] {1,2,3,4});
        int[] res2 = p.GetProductsArray(new int[] {1,0,3,4});
        int[] res3 = p.GetProductsArray(new int[] {1,0,0,4});
        int[] res4 = p.GetProductsArray(new int[] {});
        */
        /*
        CompressString c = new CompressString();
        int res1 = c.Compress(new char[]{'a','a','b', 'b', 'c', 'c', 'c'});
        int res2 = c.Compress(new char[]{'a','b','c'});
        */
        /*
        HappyNumber h = new HappyNumber();
        bool res1 = h.IsHappy(19);
        */
        /*
        SummaryRanges s = new SummaryRanges();
        IList<string> res1 = s.GetSummaryRanges(new int[]{0,1,2,4,5,7});
        IList<string> res2 = s.GetSummaryRanges(new int[]{0,2,3,4,6,8,9});
        */
        /*
        QuickSortAlgo q = new QuickSortAlgo();
        int[] res = q.sort(new int[]{5,3,7,2,10,1});
        */
        /*
        SortedArrayToBinarySearchTree s = new SortedArrayToBinarySearchTree();
        TreeNodeBT res = s.SortedArrayToBST(new int[] {-10,-3,0,5,9});
        */
        /*
        DecimalToBinary d = new DecimalToBinary();
        string res1 = d.ConvertToBits(11);
        string res2 = d.ConvertToBits(3);
        */
        /*
        RemoveStarsAlgo r = new RemoveStarsAlgo();
        String res1 = r.RemoveStars("leet**cod*e");
        */
        /*
        AsteroidCollision a = new AsteroidCollision();
        int[] res1 = a.PerformAsteroidCollision(new int[]{-2,-1,1,2});
        */
        /*
        NextNumberSameDigits n = new NextNumberSameDigits();
        int res1 = n.GetNextNumberSameDigits(321);
        int res2 = n.GetNextNumberSameDigits(312);
        int res3 = n.GetNextNumberSameDigits(647521);
        */
        /*
        LinkedListNodeBT n4 = new LinkedListNodeBT(4);
        LinkedListNodeBT n3 = new LinkedListNodeBT(3, n4);
        LinkedListNodeBT n2 = new LinkedListNodeBT(2, n3);
        LinkedListNodeBT n1 = new LinkedListNodeBT(1, n2);
        n1.other = n4;
        n2.other = n3;
        n4.other = n4;
        LinkedListNodeBT res = LinkedListCopy.deepCopyLinkedList(n1);
        */
        //string res = LongestPalindrome.GetLongestPlaindrome("abccbzzxzdzx21");
        int minDepth = minTreeDepth.GetMinTreeDepth(new TreeNode(5, new TreeNode(3, new TreeNode(1))));
        Console.ReadLine();
    }
}