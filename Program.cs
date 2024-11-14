using System;

namespace cli_painter;


class HeartGenerator
{
    public int size;
    public char filler;
    public char background;

    public HeartGenerator(int size, char filler, char background) {
        this.size = size;
        this.filler = filler;
        this.background = background;
    }
    public void generateHeart()
    {
        if (size <= 0)
            return;
        int width = 5 * size - 2;
        char[] buf = new char[width];
        for (int i = 1 - size; i < (width + 1) / 2; i++)
        {
            int outer = Math.Abs(i), center = 2 - size - 2 * i;
            Array.Fill(buf, filler);
            Array.Fill(buf, background, 0, outer);
            
            Array.Fill(buf, background, width - outer, width - (width - outer));
            if (center > 0)
                Array.Fill(buf, background, (width - center) / 2, ((width + center) / 2) - ((width - center) / 2));
        
            Console.WriteLine(buf);
        }
    }
}

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



class Program
{
    static void Main(string[] args)
    {   
        //Heart
        Console.ForegroundColor = ConsoleColor.Red;
        HeartGenerator smallHeart = new HeartGenerator(size: 1, filler: '$', background: '•');
        smallHeart.generateHeart();
        HeartGenerator bigHeart = new HeartGenerator(size: 5, filler: '@', background: '•');
        bigHeart.generateHeart();
        HeartGenerator cuteHeart = new HeartGenerator(size: 5, filler: '\u2665', background: '\u2661');
        cuteHeart.generateHeart();
        HeartGenerator binaryHeart = new HeartGenerator(size: 5, filler: '1', background: '0');
        binaryHeart.generateHeart();
        //Square
        SquareGenerator bigSquare = new SquareGenerator(size: 20, background: '•');
        bigSquare.generateSquare();
        //Rhombus
        RhombusGenerator bigRhombus = new RhombusGenerator(size: 10, filler: '$', background: '•');
        bigRhombus.generateRhombus(); 
    }
}   