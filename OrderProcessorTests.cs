// OrderProcessorTests.cs
using Xunit;
using System;
using System.IO;

public class OrderProcessorTests
{
    [Fact]
    public void ProcessOrder_ExecutesAllSteps()
    {
        var sw = new StringWriter();
        Console.SetOut(sw);

        var processor = new OrderProcessor();
        processor.ProcessOrder("P001", "C123", 99.99m, "123 Main St");

        var output = sw.ToString();
        Assert.Contains("Checking stock", output);
        Assert.Contains("Processing payment", output);
        Assert.Contains("Shipping", output);
    }
}