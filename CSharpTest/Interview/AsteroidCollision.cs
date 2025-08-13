public class AsteroidCollision {
    public int[] PerformAsteroidCollision(int[] asteroids) {
        Stack<int> sp = new Stack<int>();
        Queue<int> sn = new Queue<int>();

        for (int i = 0; i < asteroids.Length; i++) {
            int curr = asteroids[i];
            if (curr < 0) {
                sn.Enqueue(curr);
            } else {
                sp.Push(curr);
            }
        }

        while(sp.Count > 0 && sn.Count > 0) {
            int p = sp.Pop();
            int n = sn.Dequeue();

            if (-1 * n > p) {
                sn.Enqueue(n);
            } else if (p > -1 * n) {
                sp.Push(p);
            }
        }

        int[] res;
        if (sp.Count > 0) {
            res = new int[sp.Count];
            int ctr = sp.Count - 1;
            while (sp.Count > 0) {
                int curr = sp.Pop();
                res[ctr] = curr;
                ctr--;
            }
        }
        else if (sn.Count > 0) {
            res = new int[sn.Count];
            int ctr = 0;
            while (sn.Count < sn.Count) {
                int curr = sn.Dequeue();
                res[ctr] = curr;
                ctr++;
            }
        }
        else {
            res = new int[0];
        }

        return res;
    }
}