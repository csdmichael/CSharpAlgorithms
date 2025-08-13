public class AverageSalary {
    public double Average(int[] salary) {
        Outliers o = GetOutliers(salary);
        int sum = 0;
        for (int i = 0; i < salary.Length; i++) {
            int curr = salary[i];
            if (i != o.maxI && i != o.minI) {
                sum += curr;
            }
        }
        double av = (1.0 * sum) / (salary.Length - 2);
        return av;
    }

    private Outliers GetOutliers(int[] salary) {
        Outliers o = new Outliers();
        o.max = 0;
        o.min = -1;
        for (int i = 0; i < salary.Length; i++) {
            int curr = salary[i];
            if (curr > o.max) {
                o.max = curr;
                o.maxI = i;
            }
            if (curr < o.min || o.min == -1) {
                o.min = curr;
                o.minI = i;
            }
        }

        return o;
    }
}

public class Outliers{
    public int max;
    public int min;
    public int maxI;
    public int minI;
}