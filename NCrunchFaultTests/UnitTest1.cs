using NCrunchFault;

namespace NCrunchFaultTests;

public class UnitTest1
{
    //ncrunch: rdi off
    [Fact]
    public void Test1()
    {
        var program = new Program();

        Assert.True(program.ExternalCall(new DateOnly(2025, 1, 1)));
    }
    //ncrunch: rdi default

    //ncrunch: rdi off
    [Fact]
    public void Test2()
    {
        var program = new Program();

        Assert.False(program.ExternalCall(new DateOnly(2025, 4, 1)));
    }
    //ncrunch: rdi default
}
