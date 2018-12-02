namespace Chronos.Core
{
    public class Sum
    {
        private readonly int _a;
        private readonly int _b;

        public Sum(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int Value => _a + _b;
    }
}