
Solution sol = new Solution();
Console.WriteLine(sol.IsPalindrome(-123321));
public class Solution
{
    const int DIVISOR = 10;
    public int numCifras(int x)
    {
        int contNumCifras = 0;
        if ( x != 0)
        {
            while (x > 0)
            {
                x = x / DIVISOR;
                contNumCifras++;
            }
        }
        return contNumCifras;
    }

    public int[] numero_vector(int x)
    {
        int[] vectorCifrasN = new int[numCifras(x)];
        int n, i = 0;
        while (x > 0)
        {
            n = x % DIVISOR; 
            x = x / DIVISOR;
            vectorCifrasN[i] = n;
            i++;
        }
        return vectorCifrasN;
    }

    public void MostrarVector(int x) 
    {
        int[] v_numero = numero_vector(x);
        for (int i = 0; i < v_numero.Length; i ++)
        {
            Console.WriteLine(v_numero[i]);
        }
    }
    public bool IsPalindrome(int x)
    {
        bool palindrome = true;

        if (x < 0) { palindrome = false; }
        if (x > 0)
        {
            int[] v_numero = numero_vector(x);
            int numCifras_X = numCifras(x);
            int j = v_numero.Length-1;
            for (int i = 0; i < v_numero.Length && palindrome == true && numCifras_X/2 > i; i++)
            {
                Console.WriteLine("Numero i:" + v_numero[i] + " Numero j: " + v_numero[j]);
                if (v_numero[i] != v_numero[j]) { palindrome = false;}
                
                j--;
            }
        }
        return palindrome;
    }
}