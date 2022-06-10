using EcommerceWebsite.Models;
using EcommerceWebsite.Services;

ProductServices service = new();


//evvele:

//foreach (var product in service.GetAll())
//{
//    Console.WriteLine(product.Name + "" + product.Price);
//}


//Console.WriteLine("id daxil edin");

//var simvol = Console.ReadLine();

//var info = service.GetbyId(Convert.ToInt32(simvol));
//Console.WriteLine(info.Name);


//goto evvele;

Evvele:
Console.WriteLine("1.Ana sehife");
Console.WriteLine("2.Mehsullar");

var menu=Console.ReadLine();

switch (Convert.ToInt32(menu)) {

    case 1:
        Console.Clear();
        foreach (var product in service.GetAll())
        {
            Console.WriteLine(product.Name + "" + product.Price);
        }
        Console.WriteLine("id daxil edin");
        var klik=Console.ReadLine();

        var server = service.GetbyId(Convert.ToInt32(klik));
        Console.WriteLine(server.Name+""+server.Baxissayi);


        goto Evvele;
      break;

        case 2:
        Console.WriteLine("Qiymet daxil edin: ");

        var filter = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(filter))
        {
            filter = "0";
        }

       foreach (var product in service.GetFilter(filter))
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("bele mehsul tapilmadi");
            Console.WriteLine("_________________________________________");
        }


       
        break;

          case 3:


         Console.Write("ID :");
        var id = Console.ReadLine();
        Console.Write("Mehsul adi :");
        var name = Console.ReadLine();
        Console.Write("Price :");
        var price = Console.ReadLine();
        Console.Write("Sahe :");
        var Sahe = Console.ReadLine();

        Product yeniMehsul = new()
        {
            Id = Convert.ToInt32(id),
            Name = name,
            Price = Convert.ToDecimal(price),
            Sahe = Convert.ToDecimal(Sahe),
            Baxissayi = 0,


        };




break;
   
    default:
        break;

}






























