namespace ArithmeticLibrary
{
    public interface IAddition
    {
        int Add(int a, int b);
        decimal Add(decimal a, decimal b);
    }

    public interface ISubtraction
    {
        int Subtract(int a, int b);
        decimal Subtract(decimal a, decimal b);
    }

    public interface IMultiplication
    {
        int Multiply(int a, int b);
        decimal Multiply(decimal a, decimal b);
    }

    public interface IDivision
    {
        double Divide(int a, int b);
        decimal Divide(decimal a, decimal b);
    }

    public interface IModulus
    {
        int Modulus(int a, int b);
        decimal Modulus(decimal a, decimal b);
    }

    public interface IUnaryOperations
    {
        int Increment(int a);
        decimal Increment(decimal a);

        int Decrement(int a);
        decimal Decrement(decimal a);

        int Negate(int a);
        decimal Negate(decimal a);
    }

    public class Arithmetic : IAddition, ISubtraction, IMultiplication, IDivision, IModulus, IUnaryOperations
    {
        #region Addition

        public int Add(int a, int b) => a + b;
        public decimal Add(decimal a, decimal b) => a + b;

        #endregion

        #region Subtraction

        public int Subtract(int a, int b) => a - b;
        public decimal Subtract(decimal a, decimal b) => a - b;

        #endregion

        #region Multiplication

        public int Multiply(int a, int b) => a * b;
        public decimal Multiply(decimal a, decimal b) => a * b;

        #endregion

        #region Division

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("The denominator cannot be zero.");
            }
            return (double)a / b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0m)
            {
                throw new ArgumentException("The denominator cannot be zero.");
            }
            return Math.Round(a / b, 2);
        }

        #endregion

        #region Modulus

        public int Modulus(int a, int b) => a % b;
        public decimal Modulus(decimal a, decimal b) => a % b;

        #endregion

        #region Unary Operations

        public int Increment(int a) => ++a;
        public decimal Increment(decimal a) => ++a;

        public int Decrement(int a) => --a;
        public decimal Decrement(decimal a) => --a;

        public int Negate(int a) => -a;
        public decimal Negate(decimal a) => -a;

        #endregion
    }

}