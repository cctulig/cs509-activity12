namespace StringLibrary;

/// <summary>
/// Class <c>BasicMath</c> contains basic math functions
/// </summary>
public class BasicMath
{
    /// <summary>
    /// Method <c>add</c> Adds two doubles and returns the result
    /// </summary>
    static public double add(double x, double y)
    {
        var a = someOtherFunction(x);
        return a + y;
    }

    static private double someOtherFunction(double a)
    {
        return a;
    }
}
