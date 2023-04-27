Console.Clear();
Start();
void Start()
{
    Console.WriteLine("Enter number N and M. N > M");
    int numN = StartNumber("N");
    int numM = StartNumber("M");
    int numSumm = numM;
    SumNumber(numN, numM, numSumm);
}
int StartNumber(string NumberName)
{
    Console.Write($"Enter your number {NumberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void SumNumber(int numN, int numM, int numSumm)
{
    if (numN > numM) SumNumber(numN - 1, numM, numSumm += numN);
    else Console.WriteLine($"Summ number from N to M = {numSumm}");
}