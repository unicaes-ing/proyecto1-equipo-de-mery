using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    class Program
    {
        //Acevedo Mery
        //Aguilar Julio
        //Esquivel Marco
        //Palacios Diego
        //--- *** VARIABLES GLOBALES *** ---
        static int[] cBebidas = { 50, 50, 50, 50, 50, 50, 50, 50 };
        static decimal[] pBebida = { 1.25m, 2.00m, 0.50m, 0.75m, 1.00m, 2.00m, 1.25m, 0.50m };
        //cantidad de sodas y monedas
        static int[] monedas = { 50, 50, 50, 50 }; //banco de monedas 50 de c\u
        static int[] billetes = { 50, 50 }; //banco de billetes 50 de c\u
        //refil de monedas y sodas
        //cambio de precio
        static decimal dinero = 0.00M; // agregar total y vuelto
        static int m;
        static int comprar;
        static int cant = 0;
        static void Main(string[] args)
        {
            // Menu principal.
            int op = 0;
            do
            {
                Console.SetWindowSize(150, 43);
                Console.Clear();
                Console.WriteLine("Dinero actual: ${0}", dinero);
                Console.WriteLine("*** MENU PRINCIPAL ***");
                Console.WriteLine("* 1 * Realizar Compra.");
                Console.WriteLine("* 2 * Modo Administración.");
                Console.WriteLine("* 3 * Salir.");
                Console.WriteLine("\n *** Selecione una opción. ***");
                op = System.Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //LLAMAR INGRESO DE DINERO
                        //LLAMAR MODO VENTA
                        if ((monedas[0] > 0) || (monedas[1] > 0) || (monedas[2] > 0) || (monedas[3] > 0))
                        {
                            modoVenta();
                        }
                        else
                        {
                            Console.WriteLine("No hay dinero en el banco, su compra no se puede realizar");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        //LLAMAR MODO ADMIN
                        modoAdmin();
                        break;
                    default:
                        break;
                }

            } while (op != 3);
            Console.WriteLine("Presione <Enter> para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        // --- *** FUNCIONES *** ---
        public static decimal ingresoMonedas(decimal dinero)
        {
            int opDinero = 0, opMonedas = 0, opBil = 0;
            //dinero = 0.00M;
            Console.Clear();
            Console.WriteLine("Dinero actual: ${0}", dinero);
            Console.WriteLine("*** Seleccione denominación ***");
            Console.WriteLine("* 1 * Monedas");
            Console.WriteLine("* 2 * Billetes");
            opDinero = System.Convert.ToInt32(Console.ReadLine());
            if (opDinero == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*** Seleccione denominación de MONEDAS ***");
                    Console.WriteLine("* 1 * $0.05");
                    Console.WriteLine("* 2 * $0.10");
                    Console.WriteLine("* 3 * $0.25");
                    Console.WriteLine("* 4 * $1.00");
                    Console.WriteLine("* 5 * Siguiente");
                    opMonedas = System.Convert.ToInt32(Console.ReadLine());
                    switch (opMonedas)
                    {
                        case 1:
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("*Cantidad de monedas de: $0.05");
                                cant = System.Convert.ToInt32(Console.ReadLine());
                            } while (cant <= 0);
                            dinero = dinero + (0.05M * cant);
                            monedas[0] = monedas[0] + cant;
                            break;
                        case 2:
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("*Cantidad de monedas de: $0.10");
                                cant = System.Convert.ToInt32(Console.ReadLine());
                            } while (cant <= 0);
                            dinero = dinero + (0.10M * cant);
                            monedas[1] = monedas[1] + cant;
                            break;
                        case 3:
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("*Cantidad de monedas de: $0.25");
                                cant = System.Convert.ToInt32(Console.ReadLine());
                            } while (cant <= 0);
                            dinero = dinero + (0.25M * cant);
                            monedas[2] = monedas[2] + cant;
                            break;
                        case 4:
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("*Cantidad de monedas de: $1.00");
                                cant = System.Convert.ToInt32(Console.ReadLine());
                            } while (cant <= 0);
                            dinero = dinero + (1.00M * cant);
                            monedas[3] = monedas[3] + cant;
                            break;
                        default:
                            break;
                    }
                } while (opMonedas != 5);
            }
            else
            {
                if (opDinero == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("*** Seleccione denominación de BILLETES ***");
                        Console.WriteLine("* 1 * $1.00");
                        Console.WriteLine("* 2 * $5.00");
                        Console.WriteLine("* 3 * Siguiente");
                        opBil = System.Convert.ToInt32(Console.ReadLine());
                        switch (opBil)
                        {
                            case 1:
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("*Cantidad de billetes de: $1.00");
                                    cant = System.Convert.ToInt32(Console.ReadLine());
                                } while (cant <= 0);
                                dinero = dinero + (1.00M * cant);
                                billetes[0] = billetes[0] + cant;
                                break;
                            case 2:
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("*Cantidad de billetes de: $5.00");
                                    cant = System.Convert.ToInt32(Console.ReadLine());
                                } while (cant <= 0);
                                dinero = dinero + (5.00M * cant);
                                billetes[1] = billetes[1] + cant;
                                break;
                            default:
                                break;
                        }
                    } while (opBil != 3);
                }
            }
            // Console.WriteLine("Dinero actual: ${0}", dinero);
            return dinero;
        }
        static int menuBebidas()
        {
            int opMB, opMG;
            Console.Clear();
            Console.WriteLine("*** MENU DE BEBIDAS ***");
            Console.WriteLine("* 1 * Gaseosas.");
            Console.WriteLine("* 2 * Jugos.");
            Console.WriteLine("* 3 * Té Frios.");
            Console.WriteLine("* 4 * Agua.");
            Console.WriteLine("* 5 * Salir.");
            Console.WriteLine("\n *** Selecione una opción. ***");
            opMB = Convert.ToInt32(Console.ReadLine());
            switch (opMB)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("*** MENU DE GASEOSAS ***");
                    Console.WriteLine("* 1 * Coca~Cola.");
                    Console.WriteLine("* 2 * Pepsi.");
                    Console.WriteLine("* 3 * Salir.");
                    Console.WriteLine("\n *** Selecione una opción. ***");
                    opMG = Convert.ToInt32(Console.ReadLine());
                    switch (opMG)
                    {
                        case 1:
                            return 0;
                        case 2:
                            return 1;
                        default:
                            return -1;
                    }
                case 2:
                    Console.Clear();
                    Console.WriteLine("*** MENU DE JUGOS ***");
                    Console.WriteLine("* 1 * Naranja.");
                    Console.WriteLine("* 2 * Mandarina.");
                    Console.WriteLine("* 3 * Salir");
                    opMG = Convert.ToInt32(Console.ReadLine());
                    switch (opMG)
                    {
                        case 1:
                            return 2;
                        case 2:
                            return 3;
                        default:
                            return -1;
                    }
                case 3:
                    Console.Clear();
                    Console.WriteLine("*** TE ***");
                    Console.WriteLine("* 1 * Limón.");
                    Console.WriteLine("* 2 * Durazno.");
                    Console.WriteLine("* 3 * Salir");
                    opMG = Convert.ToInt32(Console.ReadLine());
                    switch (opMG)
                    {
                        case 1:
                            return 4;
                        case 2:
                            return 5;
                        default:
                            return -1;
                    }
                case 4:
                    Console.Clear();
                    Console.WriteLine("*** Aguas ***");
                    Console.WriteLine("* 1 * 200ml.");
                    Console.WriteLine("* 2 * 500ml.");
                    Console.WriteLine("* 3 * Salir");
                    opMG = Convert.ToInt32(Console.ReadLine());
                    switch (opMG)
                    {
                        case 1:
                            return 6;
                        case 2:
                            return 7;
                        default:
                            return -1;
                    }
                default:
                    return -1;
            }
        }
        // --- *** FUNCION VENTA *** ---
        public static void modoVenta()
        {
            int cb = 0; //cb cuantas bebidas escoge  m=posicion en arreglo de bebida
            // 1. Permitirá insertar billetes y/o monedas de las denominaciones permitidas. (mostrando el total acumulado)
            dinero = ingresoMonedas(dinero);
            // 2.Se podrá seleccionar el tipo de bebida a dispensar. (mostrando un menú)
            m = menuBebidas();
            if (m > -1)
            {
                do
                {
                    Console.WriteLine("Cantidad de bebidas");
                    cb = System.Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                } while (cb <= 0 || cb >= 100);
                if ((cBebidas[m] - cb) < 0) { Console.WriteLine("No hay suficientes bebidas"); }
                else
                {
                    // 3.Si la cantidad de dinero insertado es igual o superior al precio de la bebida seleccionada, dispensará la bebida y el
                    // cambio en monedas(si aplica)
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(string.Format("Dinero insertado: {0:c2}", dinero));
                    Console.WriteLine(string.Format("Total a pagar: {0:c2}", pBebida[m] * cb));
                    if (dinero >= (pBebida[m] * cb))
                    {
                        //descarga de la maquina----------------------------------------------------------------------------
                        cBebidas[m] = cBebidas[m] - cb;
                        if ((dinero - pBebida[m] * cb) > 0)
                        {
                            decimal cambio = dinero - pBebida[m] * cb;
                            Console.WriteLine("Cambio" + cambio);
                        }
                        //dinero = 0;aqui descontarian a la maquina y devolveria vuelto
                        // cambio o vuelto?                            
                        // 4.Simular el despacho de la bebida.
                        VueltoyAnimacion();
                        dinero = 0.00m;
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("Dinero insuficiente");
                        // 5.En caso contrario, permitirá agregar el dinero faltante o cancelar toda la operación y regresar el dinero insertado
                        do
                        {
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("1- Salir \n 2-Ingresar monedas");
                            comprar = Convert.ToInt32(Console.ReadLine());
                        } while (comprar != 1 && comprar != 2);
                        if (comprar == 1)
                        {
                            Console.WriteLine("Se regresaron {0}", dinero);
                            dinero = 0.00m;
                            cant = 0;
                            monedas[0] = 0;
                            monedas[1] = 0;
                            monedas[2] = 0;
                            monedas[3] = 0;
                            billetes[0] = 0;
                            billetes[1] = 0;
                            Console.WriteLine("Presione ENTER");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.Clear();
                    }
                }
            }
        }
        static int[] totalMonedas = new int[4];
        static string[] nombreMonedas = { "1 Dolar", "0.25 Centavos", "0.10 Centavos", "0.05 Centavos" }; //Para que se impriman luego
        static int contador1D = 10;    //ContadordeMonedasde1Dolar
        static int contador25C = 10;   //ContadordeMonedasde25Centavos
        static int contador10C = 10;   //ContadordeMonedasde10Centavos
        static int contador5C = 10;    //ContadordeMonedasde5Centavos
        static void compras()
        {
            int comprar;
            do
            {
                VueltoyAnimacion();
                Console.WriteLine("1- Comprar\n 2- Salir");
                comprar = Convert.ToInt32(Console.ReadLine());
            } while (comprar == 1 && (monedas[0] > 0) && (monedas[1] > 0) && (monedas[2] > 0) && (monedas[3] > 0));
            Console.WriteLine("El saldo del banco es insuficiente para realizar otra compra");
            Console.WriteLine("Presione <enter> para regresar");
            Console.ReadKey();
            Console.Clear();
        }
        static void VueltoyAnimacion()
        {
            decimal MONEDA1D = 100;  //totalMonedas [0]       
            decimal MONEDA25C = 25;  //totalMonedas [1] 
            decimal MONEDA10C = 10;  //totalMonedas [2]
            decimal MONEDA5C = 5;    //totalMonedas [3]
            int r = m;
            decimal costo, recibido, vuelto, vuelto2;
            costo = pBebida[r];
            costo = costo * 100;
            recibido = dinero;
            recibido = recibido * 100;
            if (recibido >= costo)
            {
                vuelto = recibido - costo;
                vuelto2 = vuelto;
                do
                {
                    Console.Clear();
                    if (vuelto2 >= MONEDA1D && contador1D > 0)
                    {
                        vuelto2 -= MONEDA1D;
                        totalMonedas[0]++;
                        contador1D--;
                        continue;
                    }
                    if (contador1D == 0) Console.WriteLine("Monedas de 1 dolar agotadas");
                    if (vuelto2 >= MONEDA25C && contador25C > 0)
                    {
                        vuelto2 -= MONEDA25C;
                        totalMonedas[1]++;
                        contador25C--;
                        continue;
                    }
                    if (contador25C == 0) Console.WriteLine("Monedas de 0.25 centavos agotadas");
                    if (vuelto2 >= MONEDA10C && contador10C > 0)
                    {
                        vuelto2 -= MONEDA10C;
                        totalMonedas[2]++;
                        contador10C--;
                        continue;
                    }
                    if (contador10C == 0) Console.WriteLine("Monedas de 0.10 centavos agotadas");
                    if (vuelto2 >= MONEDA5C && contador5C > 0)
                    {
                        vuelto2 -= MONEDA5C;
                        totalMonedas[3]++;
                        contador5C--;
                        continue;
                    }
                    if (contador5C == 0) Console.WriteLine("Monedas de 0.05 centavos agotadas");
                    break;
                } while (vuelto2 != 0);
                //Aqui descuenta del banco
                monedas[3] = monedas[3] - totalMonedas[0];
                monedas[2] = monedas[2] - totalMonedas[1];
                monedas[1] = monedas[1] - totalMonedas[2];
                monedas[0] = monedas[0] - totalMonedas[3];
                for (int monedas = 0; monedas < totalMonedas.Length; monedas++)
                {
                    if (totalMonedas[monedas] != 0)
                        if (totalMonedas[monedas] == 1)
                            Console.WriteLine("[{0}] moneda de {1}\n", totalMonedas[monedas], nombreMonedas[monedas]);
                        else
                            Console.WriteLine("[{0}] monedas de {1}\n", totalMonedas[monedas], nombreMonedas[monedas]);
                }
                totalMonedas[0] = 0;
                totalMonedas[1] = 0;
                totalMonedas[2] = 0;
                totalMonedas[3] = 0;
                Console.WriteLine("ENTER para terminar compra");
                Console.ReadKey();
                for (int i = 1; i < 22; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("╔════════════════════════════════════╦═══════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║╔═════════╗                         ║                Maquina de                                 ║");
                    Console.WriteLine("║║         ║                         ║                            Bebidas                        ║");
                    Console.WriteLine("║╚═════════╝                         ║                                                           ║");
                    Console.WriteLine("╠════════════════════════════════════╬═══════════════════════════════════════════════════════════╣");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║    ╔════════════╗    ╔════════════╗    ╔════════════╗     ║");
                    Console.WriteLine("║                                    ║    ║ ▄ Bebida   ║    ║ ▄ Bebida   ║    ║ ▄ Bebida   ║     ║");
                    Console.WriteLine("║                                    ║    ║ ▀    1     ║    ║ ▀    2     ║    ║ ▀    3     ║     ║");
                    Console.WriteLine("║                                    ║    ╚════════════╝    ╚════════════╝    ╚════════════╝     ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║    ╔════════════╗    ╔════════════╗    ╔════════════╗     ║");
                    Console.WriteLine("║                                    ║    ║ ▄ Bebida   ║    ║ ▄ Bebida   ║    ║ ▄ Bebida   ║     ║");
                    Console.WriteLine("║════════════════════════════════════║    ║ ▀    4     ║    ║ ▀    5     ║    ║ ▀    6     ║     ║");
                    Console.WriteLine("║   Inserte el dinero                ║    ╚════════════╝    ╚════════════╝    ╚════════════╝     ║");
                    Console.WriteLine("║   ╔═════════╗  ╔╗                  ║                                                           ║");
                    Console.WriteLine("║   ╚═════════╝  ╚╝                  ║                                                           ║");
                    Console.WriteLine("║                                    ║    ╔════════════╗    ╔════════════╗    ╔════════════╗     ║");
                    Console.WriteLine("║════════════════════════════════════║    ║ ▄ Bebida   ║    ║ ▄ Bebida   ║    ║ ▄ Bebida   ║     ║");
                    Console.WriteLine("║                                    ║    ║ ▀    7     ║    ║ ▀    8     ║    ║ ▀    9     ║     ║");
                    Console.WriteLine("║                                    ║    ╚════════════╝    ╚════════════╝    ╚════════════╝     ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ╠══════════════════╦══════════════════════╦═════════════════╣");
                    Console.WriteLine("║                                    ║                  ║                      ║                 ║");
                    Console.WriteLine("║                                    ║                  ╚══════════════════════╝                 ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("║                                    ║                                                           ║");
                    Console.WriteLine("╚════════════════════════════════════╩═══════════════════════════════════════════════════════════╝");
                    Console.SetCursorPosition(98, i + 8);
                    Console.WriteLine("╔═════════╗");
                    Console.SetCursorPosition(98, i + 9);
                    Console.WriteLine("║ ▀ Bebida║");
                    Console.SetCursorPosition(98, i + 10);
                    Console.WriteLine("╚═════════╝");
                    System.Threading.Thread.Sleep(500);
                    if (i < 21)
                    {
                        Console.Clear();
                    }
                }
                Console.WriteLine("ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // --- *** FUNCION ADMIN *** ---
        public static void modoAdmin()
        {
            string clave = "1234", c2;
            int m = 0, intento = 0, op, cBebid;
            decimal preciob;
            // 1. Solicitar clave de acceso para el modo administración.
            do
            {
                Console.WriteLine("\tIntentos: " + intento + " de 5");
                Console.WriteLine("Ingrese la clave de acceso: ");
                c2 = Console.ReadLine();
                intento = intento + 1;
            } while (c2 != (clave) && intento < 5);
            if (c2 == clave)
            {
                Console.Clear();
                Console.WriteLine("Clave correcta");
                Console.WriteLine("\nPresione <Enter> para continuar");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.Clear();
                    Console.WriteLine("*** ADMIN MENU  ***");
                    Console.WriteLine("* 1 * Administrar bebida.");
                    Console.WriteLine("* 2 * Admistrar banco.");
                    Console.WriteLine("* 3 * Ver detalles máquina.");
                    Console.WriteLine("* 4 * Salir.");
                    Console.WriteLine("\n *** Selecione una opción. ***");
                    op = System.Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            // 2.Permitirá administrar bebidas: establecer precio y cantidad de bebidas existentes de cada tipo de bebida. (al cargar
                            // bebidas a la máquina, deberá tomar en cuenta la cantidad existente y la capacidad de la máquina)                           
                            Console.Clear();
                            Console.WriteLine("*** MENU PRINCIPAL ***");
                            Console.WriteLine("* 1 * Cambiar precio.");
                            Console.WriteLine("* 2 * Modificar cantidad.");
                            Console.WriteLine("* 3 * Salir.");
                            Console.WriteLine("\n *** Selecione una opción. ***");
                            op = System.Convert.ToInt32(Console.ReadLine());
                            int cantidad;
                            switch (op)
                            {
                                case 1:
                                    m = menuBebidas();
                                    do
                                    {
                                        Console.WriteLine("Nuevo precio");
                                        preciob = System.Convert.ToDecimal(Console.ReadLine());
                                    } while (preciob <= 0);
                                    if (preciob > 0)
                                    {
                                        pBebida[m] = preciob;
                                    }
                                    break;
                                case 2:
                                    m = menuBebidas();
                                    do
                                    {
                                        Console.WriteLine("Ingrese la cantidad de bebidas, menos de 50 unidades");
                                        cBebid = System.Convert.ToInt32(Console.ReadLine());
                                    } while (cBebid <= 0 || cBebid >= 50);
                                    if ((cBebid + cBebidas[m]) < 100)
                                    {
                                        cBebidas[m] = cBebidas[m] + cBebid;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            // 3.Permitirá administrar el banco de monedas: cargar, resetear o descargar monedas del banco de monedas.
                            Console.Clear();
                            Console.WriteLine("1-Cargar monedas");
                            Console.WriteLine("2-Descargar");
                            Console.WriteLine("3-Resetear");
                            Console.WriteLine("4-Salir");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("*** Seleccione denominación de MONEDAS ***");
                                    Console.WriteLine("* 1 * $0.05");
                                    Console.WriteLine("* 2 * $0.10");
                                    Console.WriteLine("* 3 * $0.25");
                                    Console.WriteLine("* 4 * $1.00");
                                    op = Convert.ToInt32(Console.ReadLine());
                                    switch (op)
                                    {
                                        case 1:
                                            Console.WriteLine("Cuantas monedas quiere agregar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[0] = monedas[0] + cantidad;
                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.WriteLine("Cuantas monedas quiere agregar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[1] = monedas[1] + cantidad;
                                            Console.Clear();
                                            break;
                                        case 3:
                                            Console.WriteLine("Cuantas monedas quiere agregar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[2] = monedas[2] + cantidad;
                                            Console.Clear();
                                            break;
                                        case 4:
                                            Console.WriteLine("Cuantas monedas quiere agregar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[3] = monedas[3] + cantidad;
                                            Console.Clear();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("*** Seleccione denominación de MONEDAS ***");
                                    Console.WriteLine("* 1 * $0.05");
                                    Console.WriteLine("* 2 * $0.10");
                                    Console.WriteLine("* 3 * $0.25");
                                    Console.WriteLine("* 4 * $1.00");
                                    op = Convert.ToInt32(Console.ReadLine());
                                    switch (op)
                                    {
                                        case 1:
                                            Console.WriteLine("Cuantas monedas quiere retirar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[0] = monedas[0] - cantidad;
                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.WriteLine("Cuantas monedas quiere retirar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[1] = monedas[1] - cantidad;
                                            Console.Clear();
                                            break;
                                        case 3:
                                            Console.WriteLine("Cuantas monedas quiere retirar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[2] = monedas[2] - cantidad;
                                            Console.Clear();
                                            break;
                                        case 4:
                                            Console.WriteLine("Cuantas monedas quiere retirar");
                                            cantidad = Convert.ToInt32(Console.ReadLine());
                                            monedas[3] = monedas[3] - cantidad;
                                            Console.Clear();
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("ENTER PARA RESETEAR LAS MONEDAS");
                                    Console.ReadKey();
                                    monedas[0] = 0;
                                    monedas[1] = 0;
                                    monedas[2] = 0;
                                    monedas[3] = 0;
                                    billetes[0] = 0;
                                    billetes[1] = 0;
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("ENTER para salir");
                                    Console.ReadKey();
                                    break;
                            }
                            // 4.Permitirá administrar el banco de billetes: resetear o descargar billetes del banco de billetes.
                            break;
                        case 3:
                            // 5.Permitirá conocer el detalle de la máquina: fecha y hora actual, cantidad existente de cada tipo de bebida, cantidad                            
                            // de billetes y monedas por cada denominación y el total de dinero acumulado en la máquina.
                            Console.Clear();
                            Console.WriteLine("* ESTATUS *");
                            DateTime fecha = DateTime.Now;
                            Console.WriteLine("\nFecha:\t" + fecha);
                            Console.WriteLine("\t*** ESTOCK DE BEBIDAS ***");
                            Console.WriteLine("\n*GASEOSAS*");
                            Console.WriteLine("\tCoca~Cola: " + cBebidas[0]);
                            Console.WriteLine("\tPepsi: " + cBebidas[1]);
                            Console.WriteLine("\n*JUGOS*");
                            Console.WriteLine("\tNaranja: " + cBebidas[2]);
                            Console.WriteLine("\tMandarina: " + cBebidas[3]);
                            Console.WriteLine("\n*TE FRIOS*");
                            Console.WriteLine("\tLimon: " + cBebidas[4]);
                            Console.WriteLine("\tDurazno: " + cBebidas[5]);
                            Console.WriteLine("\n*AGUA.*");
                            Console.WriteLine("\t200ml: " + cBebidas[6]);
                            Console.WriteLine("\t500ml: " + cBebidas[7]);
                            Console.WriteLine("\n\t*** ESTOCK DE DINERO ***");
                            Console.WriteLine("\n*MONEDAS*");
                            Console.WriteLine("\t$0.05: " + monedas[0]);
                            Console.WriteLine("\t$0.10: " + monedas[1]);
                            Console.WriteLine("\t$0.25: " + monedas[2]);
                            Console.WriteLine("\t$1.00: " + monedas[3]);
                            Console.WriteLine("\n*BILLETES*");
                            Console.WriteLine("\t$1.00: " + billetes[0]);
                            Console.WriteLine("\t$5.00: " + billetes[1]);
                            Console.WriteLine("\nPresione <Enter> para continuar");
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                } while (op != 4);
            }
        }
    }
}
