// See https://aka.ms/new-console-template for more information
using _421_m8_lab;
using TVSystem;


// Memo: "The association link from the Retailer to the regular TV class must be maintained."
Console.WriteLine("\nBase TV no brand proxy check");
TV tp = new TV_Proxy();
tp.GetInfo();

Console.WriteLine("\nSmart TV no brand proxy check");
TV smartbase = new Smart_TV();
TV tp2 = new TV_Proxy(smartbase);
tp2.GetInfo();

// get budget from user and then call the respective proxies (child of TV_Proxy)
// need to implement "replenishTV(budget: int): TV"

Console.WriteLine("\nSony Base TV direct check");
TV stv = new Sony_TV();
stv.GetInfo();

Console.WriteLine("\nSony Base TV proxy check");
TV_Proxy stp = new TV_Proxy(stv);
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