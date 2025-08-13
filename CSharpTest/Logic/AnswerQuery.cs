using System.Collections.Generic;

public class AnswerQuery {
  public int[] answerQueries(List<Query> queries, int N) {
    if (queries == null || N == 0) {
      return null;
    }
    else if (queries.Count == 0) {
      return new int[]{};
    }
    else {
      List<int> res = new List<int>();
      bool[] data = new bool[N];
      for (int i = 0; i < N; i++) {
        data[i] = false;
      }
      
      for (int i = 0; i < queries.Count; i++) {
        Query q = queries[i];
        if (q.type == 1) {
          if (q.index <= data.Length) {
            data[q.index - 1] = true;
          }
        }
        else if (q.type == 2) {
          int ans = GetAnswer(data, q.index);
          res.Add(ans);
        }
      }
      return res.ToArray();
    }
  }
  
  private int GetAnswer(bool[] data, int x) {
    if (x <= data.Length) {
      for (int i = x; i < data.Length; i++) {
        if (data[i-1] == true) {
          return i;
        }
      }
      return -1;
    }
    else {
      return -1;
    }
  }
}

public class Query {
  public int type;
  public int index;
}