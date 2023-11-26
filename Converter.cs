public class Converter
{
    public static int Do(float x)
    {
        if (x == 0)
        {
            throw new ArgumentException();
        }
        else if (x >= 100.7)
        {
            return 1000;
        }
        else if (x < 0 && x >= -30.4)
        {
            return (int)x - 5;
        }
        else if (x <= -30.5)
        {
            return -2000;
        }
        else
        {
            return (int)x;
        }
    }
}
