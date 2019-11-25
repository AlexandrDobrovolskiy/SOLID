using System;

namespace BAD
{
    interface CoffeeMachine
    {
        void makeEspresso();
        void makeBlack();
        void makeCappuccino();
        void makeLatte();
    }

    class StandardCoffeeMachine : CoffeeMachine
    {
        public void makeBlack()
        {
            Console.WriteLine("Black coffee is my favorite!");
        }

        public void makeEspresso()
        {
            Console.WriteLine("Energizing!");
        }

        public void makeCappuccino()
        {
            throw new NotImplementedException("Shit I can't work with milk!");
        }

        public void makeLatte()
        {
            throw new NotImplementedException("Shit I can't work with milk!");
        }
    }
}

namespace GOOD
{
    interface CoffeeMachine
    {
        void makeEspresso();
        void makeBlack();
    }

    interface MilkCoffeeMachine : CoffeeMachine
    {
        void makeCappuccino();
        void makeLatte();
    }

    class StandardCoffeeMachine : CoffeeMachine
    {
        public void makeBlack()
        {
            Console.WriteLine("Black coffee is my favorite!");
        }

        public void makeEspresso()
        {
            Console.WriteLine("Energizing!");
        }
    }

}
