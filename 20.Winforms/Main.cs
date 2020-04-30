using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _20.Winforms
{
    static class MainApp
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>s
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run(new Form1());
            Console.WriteLine("8");
            Form1 form = new Form1();

            
            form.Width = 1000;
            form.Height = 100;

            //form.MouseDown += new MouseEventHandler(form_MouseDown);
            // form.MouseLeave += new EventHandler(ttt);
            form.MouseHover += new EventHandler(ttt);
            form.MouseEnter += new EventHandler(ttt);
            //form.MouseDown += new EventHandler(form_MouseDown);
            //form.MouseHover += new MouseEventHandler(form_MouseDown);
            //form.MouseHover += new MouseEventHandler(form_MouseDown);
            // form.MouseEnter += new MouseEventHandler(form_MouseDown);
            // form.MaximizedBoundsChanged += new MouseEventHandler(form_MouseDown);
            Application.Run(form);
            
        }

        static void ttt(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            int oldWidth = form.Width;
            int oldHeight = form.Height;
            Console.WriteLine($"EventName : {e.ToString()}");

        }

        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldWidth = form.Width;
            int oldHeight = form.Height;

            if (e.Button == MouseButtons.Left)
            {
                    if (oldWidth <oldHeight)
                    {
                        form.Width = oldHeight;
                        form.Height = oldHeight;
                    }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (oldHeight < oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;   
                }

            }
            Console.WriteLine("Size of Window has been changed.");
            Console.WriteLine($"Width: {form.Width}, Height: {form.Height}");
        }
    }

    // class MainApp : Form
    // {
    //     /// <summary>
    //     ///  The main entry point for the application.
    //     /// </summary>
    //     [STAThread]
    //     static void Main()
    //     {
    //         MainApp form = new MainApp();
    //         form.Width = 300;
    //         form.Height =200;

    //         form.MouseDown += new MouseEventHandler(form_MouseDown);
        
    //     }

    //     static void form_MouseDown(object sender, MouseEventArgs e)
    //     {
    //         Form form = (Form)sender;
    //         int oldWidth = form.Width;
    //         int oldHeight = form.Height;

    //         if (e.Button == MouseButtons.Left)
    //         {
    //             if ( oldWidth < oldHeight)
    //             {
    //                 form.Width = oldHeight;
    //                 form.Height =oldWidth;

    //             }
    //         }
    //         else if (e.Button == MouseButtons.Right)
    //         {
    //             if (oldHeight < oldWidth)
    //             {
    //                 form.Width = oldHeight;
    //                 form.Height = oldWidth;
    //             }
    //             Console.WriteLine("eeuoeu");
    //             Console.WriteLine($"Width : {form.Width}, Height: {form.Height}");
    //         }
    //     }
    // }
}
