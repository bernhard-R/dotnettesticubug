using System.Globalization;

namespace sampleproject;

public class MyClass
{
    public static string SomeTestableMethod()
    {
	var culture = CultureInfo.GetCultures(CultureTypes.NeutralCultures).Single(c=>c.TwoLetterISOLanguageName == "en");
        DateTime datetime = new(1978, 06, 02);
	return datetime.ToString(culture);
    }
}
