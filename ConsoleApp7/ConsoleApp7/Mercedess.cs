
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Mercedess : car
{
    public bool isAmg;
   
    public Mercedess(string model, int topspeed, double engine, double km, int hp) : base(model, topspeed, engine, km, hp)
    {
        this.isAmg=true;
    }

  

    public void getfullinfo()
    {
        Console.WriteLine($"{this.model} {this.topspeed} {this.engine} {this.km} {this.hp}");
        if (isAmg)
        {
            Console.WriteLine("amg comfortu ");
        }
        
    
    }
    public void set()
    {
        if (model.Length < 11)
        {
            Console.WriteLine("modelin adi");
        }
        else
        {
            Console.WriteLine("bu boyda masin adi olar");
        }
        if (9 > topspeed && topspeed < 1001) 
        {
            Console.WriteLine("suret dehsetdi qadasi");
        }
        else
        {
            Console.WriteLine("bu suretde masin olsa xeber ele mende alim");
        }if (engine > 0.2 && engine < 11) 
        {
            Console.WriteLine("mototrunda fulun fuludu");
        }
        else
        {
            Console.WriteLine("bu gucde masin motoru heleki yoxdu");
        }
        if (km > 0)
        {
            Console.WriteLine("masin surulub");
        }else 
        {
            Console.WriteLine("masin 0 kmdi");
        }
        if(hp>49 && hp < 1001)
        {
            Console.WriteLine("at gucu eladi");
        }
        else
        {
            Console.WriteLine("masin surursen yoxsa velosiped");
        }
       


    }

    
}
