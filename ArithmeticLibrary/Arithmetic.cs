namespace ArithmeticLibrary
{
    #region Interfaces
    /// <summary>
    /// Addition interface
    /// </summary>
    public interface IAddition
    {
        int Add(int a, int b);
        decimal Add(decimal a, decimal b);
        float Add(float a, float b);
        double Add(double a, double b);
        
    }

    /// <summary>
    /// Subtraction interface
    /// </summary>
    public interface ISubtraction
    {
        int Subtract(int a, int b);
        decimal Subtract(decimal a, decimal b);
        float Subtract(float a, float b);
        double Subtract(double a, double b);
    }

    /// <summary>
    /// Multiplication interface
    /// </summary>
    public interface IMultiplication
    {
        int Multiply(int a, int b);
        decimal Multiply(decimal a, decimal b);
        float Multiply(float a, float b);
        double Multiply(double a, double b);
    }

    /// <summary>
    /// Division interface
    /// </summary>
    public interface IDivision
    {
        double Divide(int a, int b);
        decimal Divide(decimal a, decimal b);
        float Divide(float a, float b);
        double Divide(double a, double b);
    }

    /// <summary>
    /// Modulus interface
    /// </summary>
    public interface IModulus
    {
        int Modulus(int a, int b);
        decimal Modulus(decimal a, decimal b);
        float Modulus(float a, float b);
        double Modulus(double a, double b);
    }

    /// <summary>
    /// Unary operations interface
    /// </summary>
    public interface IUnaryOperations
    {
        int Increment(int a);
        decimal Increment(decimal a);
        float Increment(float a);
        double Increment(double a);

        int Decrement(int a);
        decimal Decrement(decimal a);
        float Decrement(float a);
        double Decrement(double a);

        int Negate(int a);
        decimal Negate(decimal a);
        float Negate(float a);
        double Negate(double a);
    }
    #endregion

    /// <summary>
    /// Arithmetic class
    /// </summary>
    public class Arithmetic : IAddition, ISubtraction, IMultiplication, IDivision, IModulus, IUnaryOperations
    {
        #region Addition
        // addition section for all types
        public int Add(int a, int b) => a + b;
        public decimal Add(decimal a, decimal b) => a + b;
        public float Add(float a, float b) => a + b;
        public double Add(double a, double b) => a + b;


        #endregion

        #region Subtraction
        // subtraction section for all types
        public int Subtract(int a, int b) => a - b;
        public decimal Subtract(decimal a, decimal b) => a - b;
        public float Subtract(float a, float b) => a - b;
        public double Subtract(double a, double b) => a - b;

        #endregion

        #region Multiplication
        // multiplication section for all types
        public int Multiply(int a, int b) => a * b;
        public decimal Multiply(decimal a, decimal b) => a * b;
        public float Multiply(float a, float b) => a * b;
        public double Multiply(double a, double b) => a * b;

        #endregion

        #region Division
        // division section for all types
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

        public float Divide(float a, float b)
        {
            if (b == 0f)
            {
                throw new ArgumentException("The denominator cannot be zero.");
            }
            return a / b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0d)
            {
                throw new ArgumentException("The denominator cannot be zero.");
            }
            return a / b;
        }

        #endregion

        #region Modulus
        // modulus section for all types
        public int Modulus(int a, int b) => a % b;
        public decimal Modulus(decimal a, decimal b) => a % b;
        public float Modulus(float a, float b) => a % b;
        public double Modulus(double a, double b) => a % b;

        #endregion

        #region Unary Operations
        // unary operations section for all types
        public int Increment(int a) => ++a;
        public decimal Increment(decimal a) => ++a;
        public float Increment(float a) => ++a;
        public double Increment(double a) => ++a;

        public int Decrement(int a) => --a;
        public decimal Decrement(decimal a) => --a;
        public float Decrement(float a) => --a;
        public double Decrement(double a) => --a;

        public int Negate(int a) => -a;
        public decimal Negate(decimal a) => -a;
        public float Negate(float a) => -a;
        public double Negate(double a) => -a;

        #endregion
    }

}