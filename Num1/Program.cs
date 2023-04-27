Console.Clear();
Start();
void Start()
{
    Console.WriteLine("Enter number N and M. N > M");
    int numN = StartNumber("N");
    int numM = StartNumber("M");
    NaturalNumber(numN, numM);
}
int StartNumber(string NumberName)
{
    Console.Write($"Enter your number {NumberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NaturalNumber(int numN, int numM)
{
    if (numN > numM) NaturalNumber(numN, numM + 1);
    Console.Write($"{numM} ");
}