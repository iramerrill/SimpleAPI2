using SimpleAPI2.Controllers;

namespace SimpleAPI2.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Ira Merrill", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}