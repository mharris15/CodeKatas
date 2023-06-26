using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas._5kyu
{
    public static class SumOfK
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {

            if (t < 0 || k <= 0 || ls.Count < k)
            {
                return null;
            }
            List <List<int> > combinations = new List<List<int>>();
            GenerateCombinations(ls, k, 0, new List<int>(), combinations);

            return MaxDistance(t, combinations); 
        }


        private static void GenerateCombinations(List<int> elements, int size, int index,List<int> currentCombination, List<List<int>> combinations)
        {
            // If current combination is of size, add to list of combinations
            if(currentCombination.Count == size)
            {
                combinations.Add(new List<int> (currentCombination));
                return;
            }
            for(int i = index; i < elements.Count; i++)
            {
                currentCombination.Add(elements[i]);
                GenerateCombinations(elements, size, i + 1, currentCombination,combinations);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }


        private static int? MaxDistance(int distance, List<List<int>> combinations)
        {
            int maxDistance = 0;
            foreach (List<int> combination in combinations) {
                int combinationDistance = 0;
                for(int i = 0; i< combination.Count; i++)
                {
                    combinationDistance += combination[i];
                }
                // If max distance is achieved return
                if(combinationDistance == distance)
                {
                    return combinationDistance;
                }
                // Make new max distance
                if(combinationDistance > maxDistance && combinationDistance < distance)
                {
                    maxDistance = combinationDistance;
                }
            }
            return maxDistance == 0 ? null : maxDistance;
        }
    }
}
