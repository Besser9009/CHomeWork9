Console.Clear();
Start();
void Start()
{
    Console.WriteLine("Enter number N and M. N > M");
    uint numN = StartNumber("N");
    uint numM = StartNumber("M");
    Console.WriteLine(AkcNum(numN, numM));
}
uint StartNumber(string NumberName)
{
    Console.Write($"Enter your number {NumberName}: ");
    uint num = Convert.ToUInt32(Console.ReadLine());
    return num;
}
uint AkcNum(uint numN, uint numM)
{
    if (numN == 0) return numM + 1;
    else if ((numN != 0) && (numM == 0)) return AkcNum(numN - 1, 1);
    else return AkcNum(numN - 1, AkcNum(numN, numM - 1));
    
}