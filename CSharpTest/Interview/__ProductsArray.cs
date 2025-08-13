public class ProductsArray {
    public int[] GetProductsArray(int[] arr) {
        int product = 1;
        int zeros = 0;

        //Multiply all non zeros and count num of zeros
        for (int i = 0; i < arr.Length; i++) {
            int curr = arr[i];
            if (curr == 0) {
                zeros++;
                if (zeros > 1) break;
            } else {
                product *= curr;
            }
        }

        int[] res = new int[arr.Length];

        if (zeros > 1) {
            for (int i = 0; i < arr.Length; i++) {
                res[i] = 0;
            }
        }
        else {
            for (int i = 0; i < arr.Length; i++) {
                int curr = arr[i];
                if (curr == 0) {
                    res[i] = product;
                }
                else {
                    if (zeros == 1) {
                        res[i] = 0;
                    }
                    else {
                        res[i] = product / curr;
                    }
                }
            }
        }

        return res;
    }
}