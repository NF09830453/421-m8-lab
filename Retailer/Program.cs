/*
// See https://aka.ms/new-console-template for more information
using TVSystem;


// Memo: "The association link from the Retailer to the regular TV class must be maintained."
Console.WriteLine("\nBase TV no brand proxy check");
TV tp = new Proxy_TV();
Console.WriteLine(tp.GetInfo());

Console.WriteLine("\nSmart TV no brand check");
TV smartbase = new Smart_TV();
Console.WriteLine(smartbase.GetInfo());     //ask if Smart_TV should have its own GetInfo()
//TV tp2 = new Proxy_TV(smartbase);
//tp2.GetInfo();

// get budget from user and then call the respective proxies (child of TV_Proxy)
// need to implement "replenishTV(budget: int): TV"

//test replenish
Console.WriteLine("\nreplenish test");
TV restock = tp.ReplenishTV(350);
Console.WriteLine(restock.ToString());
Console.WriteLine(restock.GetInfo());

Console.WriteLine("\nVizio Smart TV direct check");
TV vsmart = new Vizio_Smart_TV();
Console.WriteLine(vsmart.GetInfo());

Console.WriteLine("\nSony Smart TV direct check");
TV ssmart = new Sony_Smart_TV();
Console.WriteLine(ssmart.GetInfo());


Console.WriteLine("\nUltra TV direct check");
TV ultra = new UltraHD_TV();
Console.WriteLine(ultra.GetInfo());

Console.WriteLine("\nSony Ultra TV direct check");
TV sultra = new Sony_UltraHD_TV();
Console.WriteLine(sultra.GetInfo());

/*
Console.WriteLine("\nSony Base TV proxy check");
Proxy_TV stp = new Proxy_TV(stv);
stp.GetInfo();

Console.WriteLine("\nSony Smart TV direct check");
TV ssmart = new Sony_Smart_TV();
ssmart.GetInfo();

// A Smart_TV object further has a “~getPowerUsage(): double” method to display 5.5 watts power usage per hour.
Console.WriteLine("\nSony Smart TV proxy check");
Smart_TVIF ssmartif = new Sony_Smart_TV();
TV_Proxy stp2 = new Smart_TVProxy(ssmartif);
stp2.GetInfo();

Console.WriteLine("\nSony Ultra TV direct check");
TV sultra = new Sony_UltraHD_TV();
sultra.GetInfo();

*/

