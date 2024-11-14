namespace CliPainter.Generators
{
    class RhombusGenerator
{
    public int size;
    public char filler;
    public char background;

    public RhombusGenerator(int size, char filler, char background)
    {
        this.size = size;
        this.filler = filler;
        this.background = background;
    }
    public void generateRhombus()
     {
        if (size <= 0) 
            return;
        int width = 2 * size - 1;
        for (int i = 0; i < size; i++)
        {
            char[] buf = new char[width];
            Array.Fill(buf, background);
            for (int col = size - i - 1; col <= size + i - 1; col++)
            {
                buf[col] = filler;
            }

            Console.WriteLine(buf);
        }

        for (int i = size - 2; i >= 0; i--)
        {
            char[] buf = new char[width];
            Array.Fill(buf, background);
            for (int col = size - i - 1; col <= size + i - 1; col++)
            {
                buf[col] = filler;
            }

            Console.WriteLine(buf);
        } 
    }
}
}