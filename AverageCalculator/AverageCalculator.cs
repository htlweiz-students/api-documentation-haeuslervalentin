using System.Runtime.CompilerServices;

namespace AverageCalculator;

public class AverageCalculator
{
    private readonly List<double> values;

    public AverageCalculator()
    {
        
        values = new List<double>();
    }

    /// <summary>
    /// Adds only 'ONE' Value to the list values.
    /// </summary>
    /// <param name="new_value">The new Value you want to add to the list.</param>
    public void AddValue(double new_value)
    {
        values.Add(new_value);
    }

    /// <summary>
    /// Adds one ore more Values to the list values.
    /// </summary>
    /// <param name="IEnumerable<double> new_values">The method expects a collection of double values ​​as input.</param>
    public void AddValues(IEnumerable<double> new_values)
    {
        values.AddRange(new_values);
    }

    /// <summary>
    /// Calculates the average of the intern list values.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Throws an InvalidOperationException Exception if the intern list values does not contain any double values 
    /// </exception>
    /// <returns>The average of the intern list values.</returns>
    public double getAverage()
    {
        if(!values.Any()) 
       {
            throw new InvalidOperationException("No values present");
       }
        double avg = values.Average();
        return avg; 
    }

    /// <summary>
    /// Makes the list only readable.
    /// </summary>
    /// <returns>Returns a onlyreadable list.</returns>
    public IReadOnlyList<double> getElements()
    {
        return values.AsReadOnly();
    }

    /// <summary>
    /// Counts the number of double values in the intern list values.
    /// </summary>
    /// <returns>Returns the Lenght of values.</returns>
    public int count()
    {
        return values.Count();
    }
}
