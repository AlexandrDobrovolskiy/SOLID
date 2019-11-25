
namespace BAD // Нарушение принципа
{
    class Bird
    {
        public void fly() { }
    }
    class Duck : Bird { }

    class Ostrich : Bird { }
}

namespace GOOD // Принцип не нарушается
{
    public class Bird { }
    public class FlyingBirds : Bird
    {
        public void fly() { }
    }

    class Duck : FlyingBirds { }
    class Ostrich : Bird { }
}
