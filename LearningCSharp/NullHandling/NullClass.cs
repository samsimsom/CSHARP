using static System.Console;

namespace NullHandling
{
    public class NullClass
    {
        public void NullExampleOne()
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!

            // int? thisCouldBeNull = null;
            // WriteLine(thisCouldBeNull); // Output: empty line because it's null
            // WriteLine(thisCouldBeNull.GetValueOrDefault());
            //
            // thisCouldBeNull = 7;
            // WriteLine(thisCouldBeNull);
            // WriteLine(thisCouldBeNull.GetValueOrDefault());

            string authorName = null;

            // int x = authorName.Length;
            int? y = authorName?.Length;
            WriteLine(y); // null

            var result = authorName?.Length ?? 3; // null sa 3 ata!
            WriteLine(result);

        }
    }
}