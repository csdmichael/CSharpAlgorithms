public class DiagonalSum {
    public int GetDiagonalSum(int[][] mat) {
        int i = 0, j = 0, k = mat.Length - 1;
        int sum = 0;
        while (k >= 0) {
            if (i == k) {
                sum += mat[i][j];
            }
            else {
                sum += mat[i][j] + mat[k][j];
            }
            i++; j++; k--;
        }
        return sum;
    }
}

/*
0,0   2,0
1,1   1,1
2,2   0,2

i: 0->n
j: 0->n
k: n-1->0
j: 0->n
*/