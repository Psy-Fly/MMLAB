using System.Numerics;

List<BigRational> MultiplicativeMethod(BigRational b, BigRational a, BigRational m, int count)
{
    List<BigRational> randomNumbers = new List<BigRational>(); 
    BigRational x = b; 

    for (int i = 0; i < count; i++)
    {
        x = (a * x) % m;  
        randomNumbers.Add(x);  
    }
    
    return randomNumbers;
}

List<int> GenerateSequence(int N)
{
    BigRational b = 1;
    BigRational a = 22695477;
    BigRational m = Math.Pow(2, 32);
    
    List<BigRational> randomSequence = MultiplicativeMethod(b, a, m, N);

    List<int> normalSequence = new List<int>();
    
    for (int i = 0; i < randomSequence.Count; i++)
    {
        BigRational randomNumber = randomSequence[i] / m * 10;
        normalSequence.Add((int)BigRational.Round(randomNumber, 1));
    }

    return normalSequence;
}

var sequence = GenerateSequence(100000);

for (int i = 0; i < sequence.Count; i++)
{
    Console.WriteLine(sequence[i]);
}
