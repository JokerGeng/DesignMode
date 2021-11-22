using System;

namespace AdapterMode
{
    class Program
    {
        static void Main(string[] args)
        {
            TextView view = new TextView();
            TextShapeObjectAdapter objectAdapter = new TextShapeObjectAdapter(view);

            TextViewOther viewOther = new TextViewOther();
            TextShapeObjectAdapter objectAdapterOther = new TextShapeObjectAdapter(viewOther);

            TextShapeClassAdapter classAdapter = new TextShapeClassAdapter();
            TextShapeClassAdapterOther classAdapterOther = new TextShapeClassAdapterOther();



            Console.WriteLine("Hello World!");
        }
    }
}
