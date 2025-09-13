using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, codigo = 0;
            double cant = 0, pre = 0, monto_bruto = 0;
            string datos = "", usuario = "", clave = "", s_usuario = "", s_clave = "", pro = "", c = "";

            // Definimos los stocks iniciales
            int stock1 = 30, stock2 = 20, stock3 = 30, stock4 = 40;
            int stock5 = 50, stock6 = 40, stock7 = 40, stock8 = 40;

            while (opc != 3)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("-----------------Sistema v1------------------");
                Console.WriteLine("Sistema Logístico");
                Console.WriteLine("Ingresar N° 1 para registrar usuario");
                Console.WriteLine("Ingresar N° 2 para Logearse");
                Console.WriteLine("Ingresar N° 3 para salir");
                Console.Write("Opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 3)
                {
                    Console.WriteLine("Usted salió del sistema");
                }
                else
                {
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("***************Registro de usuario**********************");
                            Console.Write("Por favor ingresar el nombre y apellidos: ");
                            datos = Console.ReadLine();
                            Console.Write("Generar tu usuario: ");
                            usuario = Console.ReadLine();
                            Console.Write("Generar tu contraseña: ");
                            clave = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("*******************Logeo******************************");
                            Console.Write("Usuario: ");
                            s_usuario = Console.ReadLine();
                            Console.Write("Password: ");
                            s_clave = Console.ReadLine();

                            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(clave))
                            {
                                Console.WriteLine("No ha registrado usuario y contraseña");
                            }
                            else
                            {
                                if (usuario == s_usuario && clave == s_clave)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*********************************************************");
                                    Console.WriteLine("Bienvenido al Sistema - Módulo de registro de inventarios");
                                    Console.WriteLine("*********************************************************");

                                    Console.WriteLine("Inventario");
                                    Console.WriteLine("COD   Cant   Descripción                  Precio");
                                    Console.WriteLine("1     {0}    Monitor                     S/.150.00", stock1);
                                    Console.WriteLine("2     {0}    Teclado                     S/.50.00", stock2);
                                    Console.WriteLine("3     {0}    Mouse                       S/.40.00", stock3);
                                    Console.WriteLine("4     {0}    Laptops                     S/.60.00", stock4);
                                    Console.WriteLine("5     {0}    Tablets                     S/.70.00", stock5);
                                    Console.WriteLine("6     {0}    Iphone                      S/.70.00", stock6);
                                    Console.WriteLine("7     {0}    Audifonos                   S/.70.00", stock7);
                                    Console.WriteLine("8     {0}    SmartWatch                  S/.70.00", stock8);

                                    opc = 3; // salir del menú principal para pasar a compras
                                }
                                else if (usuario != s_usuario && clave != s_clave)
                                {
                                    Console.WriteLine("Usuario y clave incorrecto");
                                }
                                else if (clave != s_clave)
                                {
                                    Console.WriteLine("Clave incorrecta");
                                }
                                else
                                {
                                    Console.WriteLine("Usuario incorrecto");
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }
            }

            monto_bruto = 0;
            c = "NO";
            while (c != "SI")
            {
                Console.Write("Ingresa el código del item: ");
                codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo <= 0 || codigo > 8)
                {
                    Console.WriteLine("Código Inválido, ingrese un código del 1 al 8");
                }
                else
                {
                    Console.Write("Ingresa la cantidad: ");
                    cant = Convert.ToDouble(Console.ReadLine());

                    switch (codigo)
                    {
                        case 1:
                            pro = "Monitor"; pre = 150;
                            if (cant > stock1) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock1);
                            else { stock1 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 2:
                            pro = "Teclado"; pre = 50;
                            if (cant > stock2) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock2);
                            else { stock2 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 3:
                            pro = "Mouse"; pre = 40;
                            if (cant > stock3) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock3);
                            else { stock3 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 4:
                            pro = "Laptops"; pre = 60;
                            if (cant > stock4) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock4);
                            else { stock4 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 5:
                            pro = "Tablets"; pre = 70;
                            if (cant > stock5) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock5);
                            else { stock5 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 6:
                            pro = "Iphone"; pre = 70;
                            if (cant > stock6) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock6);
                            else { stock6 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 7:
                            pro = "Audifonos"; pre = 70;
                            if (cant > stock7) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock7);
                            else { stock7 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        case 8:
                            pro = "SmartWatch"; pre = 70;
                            if (cant > stock8) Console.WriteLine("Stock insuficiente, solo hay {0} unidades disponibles.", stock8);
                            else { stock8 -= (int)cant; monto_bruto += (cant * pre); Console.WriteLine("{0}---{1}---{2}---{3}---{4}", codigo, pro, cant, pre, cant * pre); }
                            break;
                        default:
                            Console.WriteLine("Código Inválido");
                            break;
                    }

                    Console.Write("¿Desea terminar la compra (si/no)?: ");
                    c = Console.ReadLine().ToUpper();
                }
            }

            Console.WriteLine("Detalle de la venta total");
            Console.WriteLine("El monto bruto es: {0}", monto_bruto);
            Console.WriteLine("El IGV es: {0}", monto_bruto * 0.18);
            Console.WriteLine("La venta total es: {0}", monto_bruto + (monto_bruto * 0.18));

            Console.ReadKey();
        }
    }
}