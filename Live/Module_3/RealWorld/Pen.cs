namespace RealWorld
{
    // Custom Type Pen
    // Blueprint of a Pen object
    class Pen
    {
        // Fields
        // Use fields to store properties.
        private uint lineWidth = 1;
        //private ConsoleColor lineColor = ConsoleColor.Black;

        // Very C++-ish
        // Not very common in C#. DON'T USE IT (unless you wants to be the laughing stock)
        public void SetLineWidth(uint nw)
        {
            if (nw >= 0 && nw <=20)
            {
                lineWidth = nw;
            }
        }
        public uint GetLineWidth() 
        { 
            return lineWidth; 
        }    


        // Properties
        // Properties give you _controlled_ access to your private fields.
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
        // Auto-generating property. Generates it's own field.
        public ConsoleColor LineColor { get; set; } = ConsoleColor.Black;

        // Methods
        // Use methods to define behavior
        public void Write(string txt)
        {
            Console.ForegroundColor = LineColor;
            Console.WriteLine($"Writing {txt} with linewidth: {LineWidth} ");
            Console.ResetColor();
        }


        // Constructors are used to provide your fields with
        // an initial value.
        public Pen()
        {
            //lineWidth = 1; 
            //lineColor = ConsoleColor.Black;
        }
        public Pen(uint lnWidth, ConsoleColor lnColor)
        {
            LineWidth = lnWidth;
            LineColor = lnColor;
        }
    }
}
