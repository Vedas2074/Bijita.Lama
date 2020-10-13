namespace AccessModifierAndMethods
{
    internal class AccessModifier//class ko accessmodifier internal by default
    {
        internal int x;
        public int y;
        internal void DoSomething()//within project
        {

        }
        public int CalculateAverage(int[] numbers)//by default private class
        {
            //calculate average
            return 0;
        }
    }
}