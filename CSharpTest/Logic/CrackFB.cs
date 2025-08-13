using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class CrackFB {
    //https://www.educative.io/blog/cracking-top-facebook-coding-interview-questions

    /*
    Arrays: move zeros to the left
    Given an integer array, move all elements that are 0 to the left while maintaining the order of other elements in the array. The array has to be modified in-place. Try it yourself before reviewing the solution and explanation.
    */
    public int[] MoveZerosLeft(int[] arr) {
        if (arr == null) { 
            return null;
        }
        else if (arr.Length == 0) { 
            return arr;
        }
        else {
            int writePos = arr.Length - 1;
            int readPos = arr.Length - 1;
            
            while (readPos >= 0) {
                if (arr[writePos] != 0) {
                    readPos--;
                    writePos--;
                } else {
                    if (arr[readPos] == 0) {
                        readPos--;
                    } else {
                        arr[writePos] = arr[readPos];
                        arr[readPos] = 0;
                        readPos--;
                        writePos--;
                    }
                }
            }

            return arr;
        }
    }

    /*
    Arrays: Merge overlapping intervals
    You are given an array (list) of interval pairs as input where each interval has a start and end timestamp. The input array is sorted by starting timestamps. You are required to merge overlapping intervals and return a new output array.
    Consider the input array below. Intervals (1, 5), (3, 7), (4, 6), (6, 8) are overlapping so they should be merged to one big interval (1, 8). Similarly, intervals (10, 12) and (12, 15) are also overlapping and should be merged to (10, 15).
    Try it yourself before reviewing the solution and explanation.
    */
    public List<IntervalPair> MergeOverlapIntervals(IntervalPair[] intervals) {
        List<IntervalPair> overlapIntervals = new List<IntervalPair>();
        if (intervals == null) {
            return overlapIntervals;
        } else if (intervals.Length == 0) {
            return overlapIntervals;
        } else {
            int index = 0;
            while (index <= intervals.Length - 1) {
                if (index == intervals.Length - 1) {
                    overlapIntervals.Add(intervals[index]);
                    index++;
                } else {
                    IntervalPair curr = intervals[index];
                    IntervalPair next = intervals[index + 1];

                    if (curr.end >= next.start) {
                        //Merge Intervals
                        int maxEnd = (curr.end > next.end)? curr.end: next.end;
                        IntervalPair merged = new IntervalPair(curr.start, maxEnd);
                        intervals[index + 1] = merged;
                        index = index + 1;
                    } else {
                        overlapIntervals.Add(intervals[index]);
                        index++;
                    }
                }
            }
            return overlapIntervals;
        }
    }

    public void TraverseInOrder(TreeNode root, ref LinkedList l) {
        if (root == null) {
            return;
        } else {
            if (root.left != null) {
                TraverseInOrder(root.left, ref l);
            }

            l.AddNode(root.val);

            if (root.right != null) {
                TraverseInOrder(root.right, ref l);
            }
            
        }
    }

    public LinkedList BTtoLL(TreeNode root) {
        LinkedList ll = new LinkedList();
        
        TraverseInOrder(root, ref ll);

        return ll;
    }


  
  private int countDistinctTriangles(int[][] arr) {
    // Write your code here
    int distinct = 0;
    
    if (arr != null) {
      Dictionary<string, int> dictArr = new Dictionary<string, int>();
      
      for (int i = 0; i < arr.Length; i++) {
        int[] currTri = arr[i];
        int[] sortedTri = MergeSort(currTri);
        string sTri = ConcatenateArray(sortedTri, "-");
        if (dictArr.ContainsKey(sTri)) {
          dictArr[sTri]++;
        }
        else {
          dictArr.Add(sTri, 1);
        }
      }
      distinct = dictArr.Count;
    }
    
    return distinct;
  }

  public double CalculatePower(int x, int n) {
        if (x == 0) {
            return 0;
        } else if (x == 1 || n == 0) {
            return 1;
        } else if (n == 1) {
            return x;
        } else if (n == -1) {
            return 1.0/x;
        } else {
            double pow = CalculatePower(x, n/2);
            if (n % 2 == 0) {
                return pow * pow;
                
            } else {
                if (n < 0) {
                    return (1.0/x)*(pow * pow);
                }
                else {
                    return pow * pow * x;
                }
            }
        }
    }
  
  private string ConcatenateArray(int[] arr, string delimiter) {
    string s = "";
    for(int i = 0; i < arr.Length; i++) {
      if (i == 0) {
        s += arr[i];
      } else {
        s += delimiter + arr[i];
      }
    }
    Console.WriteLine("Concatenated: " + s);
    return s;
  }
  
  private int[] MergeSort(int[] arr) {
    int[] sortedArr = arr;
    return sortedArr;
  }
}

public class LinkedList {
    public LLNode head;
    public LLNode tail;
    public int size = 0;

    public void AddNode(int data) {
        LLNode node = new LLNode(data);
        if (size == 0) {
            head = node;
            tail = node;
        }
        else {
            node.prev = tail;
            tail.next = node;
            tail = node;
        }
        size++;
    }

    
}

public class LLNode {
    public LLNode(int d) {
        this.data = d;
    }
    public int data;
    public LLNode prev;
    public LLNode next;
}

public class IntervalPair {
    public IntervalPair(int s, int e) {
        this.start = s;
        this.end = e;
    }
    public IntervalPair(){

    }
    public int start;
    public int end;
}
