using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExercise
{
    public class Die : IRandom
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        public const int Sides = 6;

        public Die(Random randomGenerator)
        {
            randomNumberSupplier = randomGenerator;
            numberOfEyes = NewTossHowManyEyes();
        }

        public void Toss()
        {
            numberOfEyes = NewTossHowManyEyes();
        }

        private int NewTossHowManyEyes()
        {
            return randomNumberSupplier.Next(1, Sides + 1);
        }

        public int NumberOfEyes()
        {
            return numberOfEyes;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", numberOfEyes);
        }
    }
