namespace Inheritance
{
    abstract class Pen
    {
        private uint lineWidth = 1;
        public uint LineWidth
        {
            get
            { 
                return lineWidth; 
            }
            set 
            {
                if (value >= 0 && value <= 20)
                {
                    lineWidth = value;
                }
            }
        }
        public ConsoleColor LineColor { get; set; } = ConsoleColor.Black;
        // virtual offers the possibility for derived classes to override the behavior of the base class.
        // However it is not mandatory
        // Virtual makes this behavior polymorph-ready
        //public virtual void Write(string txt)
        //{
        //    Console.ForegroundColor = LineColor;
        //    Console.WriteLine($"Writing {txt} with linewidth: {LineWidth} ");
        //    Console.ResetColor();
        //}


        // abstract is also an enabler for polymorphism but
        // derived classes are obliged to override them.
        public abstract void Write(string txt);
    }
}
