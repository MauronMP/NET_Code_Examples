
//<sumary>
// Uso a modo de ejemplo
//</sumary>
Solution sol = new Solution();
int[] numerosEvaluar = {3,3,1,2,9};
Console.WriteLine(String.Join(",", sol.TwoSum(numerosEvaluar, 6)));

/// <sumary>
/// Class <c>Solution</c> Encuentra dos elementos de un array que sumen exactamente el valor de target.
/// <param name="nums">Array de numeros enteros.</param>
/// <param name="target">Numero que tiene que ser la suma de dos elementos de nums.</param>
/// </sumary>
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] posicionesSumatoria = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            for(int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    posicionesSumatoria[0] = i;
                    posicionesSumatoria[1] = j;
                }
            }
        }
        return posicionesSumatoria;
    }
}



