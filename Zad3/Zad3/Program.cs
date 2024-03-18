namespace Zad3;
public class Program
{
    public static void Main(String[] args)
    {
        int GeneratorNumeru = 0;




    }
}






public abstract class Kontener{

    protected double Waga;
    protected double Wysokosc;
    protected double Glebokosc;
    protected double MaxLadownosc;
    protected String KodSeryjny;
    
    protected Kontener(double waga, double wysokosc, double glebokosc, double maxLadownosc)
    {
        Waga = waga;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        MaxLadownosc = maxLadownosc;
        KodSeryjny = "KON-";
    }

    protected void Oproznij(Kontener kontener)
    {
        
    }

    protected void Zaladuj(Kontener kontener)
    {
        
    }
    
    
    
    
    
    
    
    

    protected Kontener(double waga, double wysokosc, double glebokosc)
    {
        throw new NotImplementedException();
    }
}

public class KontenerNaPlyn : Kontener

{
    public KontenerNaPlyn(double waga, double wysokosc, double glebokosc, double maxLadownosc) : base(waga, wysokosc, glebokosc, maxLadownosc)
    {
    }
}



