namespace StrictHandler
{
    public class StrictCalculator
    {
        public StrictCalculator(Modes mode, bool loose)
        {
            var intValue = (int)mode;
            Result = intValue < 2 ? Convert.ToBoolean(intValue) : loose;
        }
        public enum Modes { StrictDisabled = 0, StrictEnabled = 1, Loose = 2 }
        public bool Result { get; }
    }
}
