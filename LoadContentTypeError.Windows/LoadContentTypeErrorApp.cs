using Stride.Engine;

namespace LoadContentTypeError
{
    class LoadContentTypeErrorApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
