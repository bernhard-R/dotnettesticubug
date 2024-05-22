using sampleproject;

namespace sampleprojecttests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
	Assert.Equal(MyClass.SomeTestableMethod(), "06/02/1978 00:00:00 AM");
    }
}
