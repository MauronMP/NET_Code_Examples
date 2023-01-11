int Min = 0;
int Max = 10;


int[] numbers = new int[1000000];

Random randNum = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randNum.Next(Min, Max);
}
DateTime dt = DateTime.Now;
var numerosAltos_1 = numbers.TakeWhile(n => n > 5);
TimeSpan ts = DateTime.Now - dt;
var t_1 = ts.TotalMilliseconds.ToString();


DateTime dt2 = DateTime.Now;
IEnumerable<int>  numerosAltos = 
    from number in numbers
    where number > 5
    orderby number ascending
    select number;
var numerosAltosSQL = numerosAltos;
TimeSpan ts2 = DateTime.Now - dt2;
var t_2 = ts2.TotalMilliseconds.ToString();

Console.WriteLine("Lambda con while: " + t_1 + ",Con sql: " + t_2);
// Output:
// 5 4 1 3