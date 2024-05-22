using sampleproject;

namespace sampleprojecttests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
	Assert.Equal(MyClass.SomeTestableMethod(), "6/2/1978 12:00:00 AM");
    }
}
