namespace Programowanie_ASP.NET.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public string Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Subtract:
                        return "-";
                    case Operators.Multiply:
                        return "*";
                    case Operators.Divide:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return Operator != null && X != null && Y != null;
        }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add:
                    return (double)(X + Y);
                case Operators.Subtract:
                    return (double)(X - Y);
                case Operators.Multiply:
                    return (double)(X * Y);
                case Operators.Divide:
                    return Y != 0 ? (double)(X / Y) : double.NaN;
                default:
                    return double.NaN;
            }
        }
    }

    public enum Operators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

}
