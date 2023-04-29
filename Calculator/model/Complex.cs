namespace Calculator.model;

public class Complex: ICalculatorModel
{
    public Complex(double real, double image)
    {
        Real = real;
        Image = image;
    }
    
    public double Real { get; set; }
    public double Image { get; set; }

    public override string ToString()
    {
        return $"(" +
               $"{(Real == 0 ? "" : Real)} " +
               $"{(Image == 0 || Real == 0 ? "" : Image < 0 ? "-" : "+")} " +
               $"{(Image < 0 ? -Image : Image == 0 ? "" : Image)}i" +
               $")";
    }
}
