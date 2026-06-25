public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) 
    {
        if (pairs.Count == 0) return [];

        List<List<Pair>> iterations = [[..pairs]];

        for(int x = 1; x < pairs.Count; x++) {
            int y = x - 1;
            bool isLower = false;

            while(y >=0 && pairs[y + 1].Key < pairs[y].Key)
            {
                var tmpPair = pairs[y];
                pairs[y] = pairs[y + 1];
                pairs[y + 1] = tmpPair;
                // iterations.Add([..pairs]);
                 isLower = true;
                 y--;
            }      
            iterations.Add([..pairs]);        
        }
        return iterations;
    }
}
