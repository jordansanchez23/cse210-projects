
public class Fraction
{
    private int _top;
    private int _bottom;


    //Constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor with 1 parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //Constructor with 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getter for the top number
    public int getTop()
    {
        return _top;
    }


    //Getter for the bottom number
    public int getBottom()
    {
        return _bottom;
    }

    //Setter for the top number
    public void setTop(int top)
    {
        _top = top;
    }

    //Setter for the bottom number
    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    //method that returns the fraction in the form 3/4
    public string GetFractionString()
    {
        string format = $"{_top}/{_bottom}";
        return format;
    }

    //A method that converts the fraction to decimals
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}


