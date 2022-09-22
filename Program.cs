using System;

namespace fullsenyum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new Agya("michelin");
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();


            mobil mobil2 = new Avanza("Bridgestone");
            mobil2.NyalakanMesin();
            mobil2.MatikanMesin();
            ((Avanza)mobil2).NyalakanLampu();

            mobil civic1 = new civic("Bridgestone");
            ((civic)civic1).VtecKickedIn();

            //menggunakan VtecKickedIn pada Honda
            //mobil honda1 = new Honda("Civic", "Bridgestone");
            //honda1.NyalakanMesin();
            //honda1.MatikanMesin();
            //((civic1)honda1).VtecKickedIn();
        }
    }
}



//MOBIL
class mobil
{
    public string merk;
    public string tipe;
    public string ban;

    public mobil(string merk, string tipe, string ban)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine("Mesin mobil " + this.merk + " bertipe " + this.tipe + " menyala ");
    }

    public void MatikanMesin()
    {
        Console.WriteLine("Mesin mobil " + this.merk + " bertipe " + this.tipe + " mati ");
        Console.WriteLine("Merek ban yang digunakan " + this.tipe + " adalah " + this.ban);
    }
}

// mobil merk toyota
class toyota : mobil
{
    public string merk;
    public toyota(string merk, string ban) : base("Toyota", merk, ban)
    {
    }

    public void NyalakanLampu()
    {
        Console.WriteLine("Lampu mobil " + this.merk + " bertipe " + this.tipe + " menyala ");
    }

}

//mobil merk daihatsu
class daihatsu : mobil
{
    public string merk;
    public daihatsu(string merk, string ban) : base("Daihatsu", merk, ban)
    {
    }

}

//mobil merk honda
class Honda : mobil
{
    public string merk;
    public Honda(string merk, string ban) : base("Honda", merk, ban)
    {
    }
}


//toyota tipe agya
class Agya : toyota
{
    public string tipe;
    public Agya(string ban) : base("Agya", ban)
    {
    }
}

//toyota tipe innova
class Innova : toyota
{
    public string tipe;
    public Innova(string ban) : base("Innova", ban)
    {
    }
}

//toyota tipe avanza
class Avanza : toyota
{
    public string tipe;
    public Avanza(string ban) : base("Avanza", ban)
    {
    }
}

//daihatsu tipe ayla
class Ayla : daihatsu
{
    public string tipe;
    public Ayla(string ban) : base("Ayla", ban)
    {
    }
}

//daihatsu tipe xenia
class Xenia : daihatsu
{
    public string tipe;
    public Xenia(string ban) : base("Xenia", ban)
    {
    }
}

//honda tipe brio
class Brio : Honda
{
    public string tipe;
    public Brio(string ban) : base("Brio", ban)
    {
    }
}

//honda tipe civic
class civic : Honda
{
    public string tipe;
    public civic(string ban) : base("Civic", ban)
    {
    }
    public void VtecKickedIn()
    {
        Console.WriteLine("Ngeeeng Wooosh!");
    }
}


//BAN
class ban
{
    public string merk;
    public ban(string merk)
    {
        this.merk = merk;
    }
}

//ban merk michellin
class michelin : ban
{
    public string merk;
    public michelin(string merk) : base("Michelin")
    {
    }
}

//ban merk bridgestone
class bridgestone : ban
{
    public string merk;
    public bridgestone(string merk) : base("Bridgestone")
    {
    }
}



