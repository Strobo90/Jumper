using Jumper_Idaho;
namespace Jumper_Idaho //
{    class Program    // creates the Program class
    {
        static void Main(string[] args)
        {
            Game director = new Game();   // call the Game function to control the Game flow
            director.StartGame();
        }
    }
}