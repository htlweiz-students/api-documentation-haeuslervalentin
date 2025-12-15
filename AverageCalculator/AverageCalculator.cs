using System.Runtime.CompilerServices;

namespace AverageCalculator;

public class AverageCalculator
{
    private List<double> values;

    public AverageCalculator()
    {
        values = new List<double>();
    }

    public void AddValue(double new_value)
    {
        values.Add(new_value);
    }

    public void AddValues(IEnumerable<double> new_values)
    {
        values.AddRange(new_values);
    }

    public double getAverage()
    {
       if(values.Any()) 
       {
            //Eigene Exception class
       }
        double avg = values.Average();
        return avg; 
    }

    public IReadOnlyList<double> getElements()
    {
        return values.AsReadOnly();
    }

    public int count()
    {
        return values.Count();
    }
}
