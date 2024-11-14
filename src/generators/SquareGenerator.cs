namespace CliPainter.Generators
{
class SquareGenerator
{
    public int size;
    public char background;

    public SquareGenerator(int size, char background)
    {
        this.size = size;
        this.background = background;
    }
    public void generateSquare()
     {
        if (size <= 0) 
            return;
        for (int i = 0; i < size; i++ )
        {
            char[] buf = new char[size];
            Array.Fill(buf, background); 
            Console.WriteLine(buf);
        }
          
     } 
         
}
}