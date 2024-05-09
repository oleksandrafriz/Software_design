using System;

namespace task3
{
    public class VectorRenderer : IRenderer
    {
        public void RenderShape(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as vectors");
        }
    }
}
