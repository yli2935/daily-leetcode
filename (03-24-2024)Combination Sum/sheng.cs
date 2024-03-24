namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = [2, 3, 6, 7];
            int target = 7;
            IList<IList<int>> res = CombinationSum(candidates, target);


        }
        private static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(candidates);
            BackTrackCombiSum(candidates, target, 0, new List<int>(), result);
            return result;

        }
        private static void BackTrackCombiSum(int[] candidates, int target, int idx, List<int> temp, IList<IList<int>> result)
        {
            //in the question, the candidates cannot include 0 or negtive number, or else there will be infinite answeer.
            if (target == 0)
            {
                result.Add(temp.ToList());
                return;
            }
            else
            {
                while (idx < candidates.Length)
                {
                    if (candidates[idx] > target)
                    {
                        break;
                    }
                    temp.Add(candidates[idx]);
                    BackTrackCombiSum(candidates, target - candidates[idx], idx, temp, result);

                    // need to delete if there is no answer
                    temp.RemoveAt(temp.Count - 1);
                    idx++;
                }

            }

        }

    }
}
