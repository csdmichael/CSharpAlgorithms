public class RandomPickWithWeight {
    public int PickIndex(int[] weights) {
        if (weights == null) {
            return -1;
        } else if (weights.Length == 0) {
            return -1;
        } else if (weights.Length == 1) {
            return 0;
        } else {
            Dictionary<int, int> dictWeightedIndexes = new Dictionary<int, int>();
            int weightedIndex = 0;
            for (int i = 0; i < weights.Length; i++) {
                int currWeight = weights[i];
                if (currWeight > 0) {
                    for (int j = 0; j < currWeight; j++) {
                        dictWeightedIndexes.Add(weightedIndex, i);
                        weightedIndex += 1;
                    }
                }
            }
            int wi = Random.Shared.Next(dictWeightedIndexes.Count - 1);
            return dictWeightedIndexes[wi];
        }
    }
}