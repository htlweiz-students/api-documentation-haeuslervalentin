using System.Runtime.CompilerServices;

namespace AverageCalculator.Tests;

public class ConstructorTests
{
    [Fact]
    public void Constructor_InitializesList()
    {
        var cal = new AverageCalculator();
        Assert.NotNull(cal.getElements());
    }

    [Fact]
    public void Constructor_ListIsEmpty()
    {
        var cal = new AverageCalculator();
        Assert.Empty(cal.getElements());
    }

    [Fact]
    public void Constructor_CountIsZero()
    {
        var cal = new AverageCalculator();
        Assert.Equal(0, cal.count());
    }
}

public class AddValue
{
    [Fact]
    public void AddOneValue_check_value()
    {
        AverageCalculator Cal = new();
        var one_value = 2384.42;

        Cal.AddValue(one_value);

        Assert.Equal(Cal.getElements()[0], one_value);
    }
    
    [Fact]
    public void AddOneValue_check_count()
    {
        AverageCalculator Cal = new();
        var one_value = 2384.42;

        Cal.AddValue(one_value);

        Assert.Equal(1, Cal.count());
    }

    [Fact]
    public void AddOneValue_allow_multiple_calls()
    {
        AverageCalculator Cal = new();
        var one_value = 2384.42;
        var count = 2;

        Cal.AddValue(one_value);
        Cal.AddValue(one_value);

        Assert.Equal(Cal.count(), count);
    }
}

public class AddValues()
{
    [Fact]
    public void AddValues_AddsMultipleValues_Count()
    {
        AverageCalculator Cal = new();
        var multiple_values = new List<double> { 24.68 , 324.563, 234.84};
        
        Cal.AddValues(multiple_values);

        Assert.Equal(3, Cal.count());
    }

    [Fact]
    public void AddValues_AddsMultipleValues_GetElementsByOrder()
    {
        AverageCalculator Cal = new();
        double[] multiple_values = {5, 10, 25};

        Cal.AddValues(multiple_values);

        Assert.Equal(3, Cal.count());
        Assert.Equal(5, Cal.getElements()[0]);
        Assert.Equal(10, Cal.getElements()[1]);
        Assert.Equal(25, Cal.getElements()[2]);
    }

    [Fact]
    public void AddValues_Adds_AddEmpty_Array()
    {
        AverageCalculator Cal = new();

        Cal.AddValues(Array.Empty<double>());

        Assert.Equal(0, Cal.count());
    }
}
public class GetAverageTests
{
    [Fact]
    public void GetAverage_OneValue_ReturnsValue()
    {
        var cal = new AverageCalculator();
        cal.AddValue(10);

        Assert.Equal(10, cal.getAverage());
    }

    [Fact]
    public void GetAverage_MultipleValues_ReturnsCorrectAverage()
    {
        var cal = new AverageCalculator();
        cal.AddValues(new double[] { 10, 20 });

        Assert.Equal(15, cal.getAverage());
    }

    [Fact]
    public void GetAverage_NoValues_ThrowsException()
    {
        var cal = new AverageCalculator();

        Assert.Throws<InvalidOperationException>(() => cal.getAverage());
    }
}

public class GetElementsTests
{
    [Fact]
    public void GetElements_ReturnsReadOnlyList()
    {
        var cal = new AverageCalculator();

        Assert.IsAssignableFrom<IReadOnlyList<double>>(cal.getElements());
    }

    [Fact]
    public void GetElements_ReturnsCorrectValues()
    {
        var cal = new AverageCalculator();
        cal.AddValue(3);

        Assert.Single(cal.getElements());
    }

    [Fact]
    public void GetElements_CannotBeModified()
    {
        var cal = new AverageCalculator();
        var elements = cal.getElements();

        Assert.False(elements is List<double>);
    }
}