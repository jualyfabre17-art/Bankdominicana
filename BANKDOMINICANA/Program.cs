// Jualy Fabre
Console.WriteLine("Bienvenido a BANKDOMINICA");

//Verificar y crear contrasena
string pin = "";
string userPin = "";
string name = ""; 
int tries= 0;

while(tries < 3)
{
    Console.Write("Ingrese un nombre de usuario -> ");
    name = Console.ReadLine();
    Console.Write("Cree un pin para su cuenta -> ");
    pin = Console.ReadLine();
    Console.Write("Ingresar PIN ->");
    userPin = Console.ReadLine();
   

    if(userPin == pin)
    {
        Console.WriteLine($"PIN correcto, ingresando {name}...");
        break;
    }
    else
    {
        Console.WriteLine("Intente de nuevo");
    }
        tries++;
    
}
if (tries == 3)
    {
        Console.WriteLine("PIN incorrecto, seccion cerrada");
        Console.WriteLine("");
    }

//Menu principal
int saldo =0;
int retiro = 0;
int balance = 0 ;
string salida = "";
bool respSI = true;
bool continuar = true;
do
{  
    Console.WriteLine("Ingrese la opcion");
    Console.WriteLine("1.Consultar saldo");
    Console.WriteLine("2.Depositar dinero");
    Console.WriteLine("3.Retirar dinero");
    Console.WriteLine("4.Ver historial");
    Console.WriteLine("5.Salir");

string opt = Console.ReadLine();
switch (opt)
{
        case "1":
            Console.WriteLine($"Su saldo actual es {saldo} RD$");
            break;
        case "2":
            Console.Write("Ingrese cantidad a depositar ->");
            int depDinero = int.Parse(Console.ReadLine());
            saldo += depDinero;
            break;
        case "3":
            Console.Write("Cantidad a retirar ->");
            int retDinero = int.Parse(Console.ReadLine());
            saldo -= retDinero;
            break;
        case "4":
            Console.Write("No disponible por el momento...");
            break;
        case "5":
            Console.Write("Desea salir? Si/No ");
            salida = Console.ReadLine().ToLower();
            if(salida == "si" ) 
            {
                Console.WriteLine($"Gracias {name} por preferirnos");
                continuar = !true;
            }

                break;
        default:
            Console.WriteLine("Esta opcion no es valida, intente de nuevo");
            
            break;
}
} while (continuar);

Console.WriteLine("BANKDOMINICANA");