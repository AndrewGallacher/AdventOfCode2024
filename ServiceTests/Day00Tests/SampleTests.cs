namespace ServiceTests.Day00Tests;

using Service.Day00;
using Shouldly;

public class SampleTests
{
    private Sample _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Sample();
    }

    [Test]
    public void Test1()
    {
        var result = _sut.Status();
        result.ShouldBe(1); 
    }
}
