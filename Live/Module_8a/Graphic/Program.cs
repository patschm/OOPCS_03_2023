namespace Graphic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Form fm1 = new Form();
            fm1.Text = "Hello Form";

            Button btn1 = new Button();
            btn1.Location = new Point(50, 50);
            btn1.Width = 100;
            btn1.Height = 100;
            btn1.Text = "Click me!!";
            btn1.Click += Hellup;

            fm1.Controls.Add(btn1);

            fm1.Show();

            btn1.PerformClick();
            Task.Delay(10000).Wait();
            Console.ReadLine();
        }

        static void Hellup(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                (sender as Button)!.Parent.BackColor = Color.Red;
            }
        }
    }
}