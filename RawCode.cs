using NUnit.Framework;

namespace StringCalculatorTest
{
    class SummationOfPrimes
    {
        public static int SumOfPrimes_BelowTen(long limit)
        {
            int result = 0;

            for (var i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    result += i;
                }
            }
        
            return result;
        }

        public static bool IsPrime(long n)
        {
            for (var i = 2; i < n; i++)
            {
                if (n != 2 && n % 2 == 0)
                {
                    return false;
                }
                if (n % i == 0)
                {
                    return false;
                }
                if (n == 1)
                {
                    return true;
                }
            }

            return true;
        }
    }

    [TestFixture]
    class SummationOfPrimesTest
    {
        [Test]
        public void ShouldFind_SumOfPrimes_BelowTen()
        {
            //arrange

            //act
            var result = SummationOfPrimes.SumOfPrimes_BelowTen(2000000);
            
            //assert
            Assert.That(result, Is.EqualTo(142913828922));
        }

        [Test]
        public void ShouldFindPrimeNumbers()
        {
            //arrange

            //act

            //assert
            Assert.IsTrue(SummationOfPrimes.IsPrime(5));
        }
    }

}
