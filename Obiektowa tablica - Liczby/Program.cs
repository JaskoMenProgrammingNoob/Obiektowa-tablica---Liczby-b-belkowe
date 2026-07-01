class Liczby
{
    int n = 6;
    double[] tablica;
    

    public Liczby()
    {
        tablica = new double[n];
    }

    public void czytaj_dane()
    {

        Random losowa = new Random();
        int los = losowa.Next(0, 20);
        for (int i = 0; i < n; i++)
        {
            tablica[i] = losowa.Next(0, 20);
        }
    }
    
    public void przetworz_dane()
    {
        
        
        for(int i = 1; i < n - 1; i++)
        {
            
            for( int j = n - 1; j >= i; j--)
            {
                if (tablica[j - 1] > tablica[j])
                {
                    double temp = tablica[j - 1];
                    tablica[j - 1] = tablica[j];
                    tablica[j] = temp;

                    
                }

            }
            
        }
    }
    public void wyswietl_dane()
    {
        
        
            for (int j = 0;  j < n; j++)
            {
                
                Console.Write($"{tablica[j],4}");
            }
        
    }

    static void Main(string[] args)
    {
        Liczby liczby = new Liczby();
        liczby.czytaj_dane();
        liczby.przetworz_dane();
        liczby.wyswietl_dane();

    }
}
