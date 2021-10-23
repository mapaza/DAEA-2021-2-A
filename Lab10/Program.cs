using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace Lab10
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            Boolean menu = true;

            while (menu){

                Console.WriteLine("-----BIENVENIDO(A) AL MENU DE CONSULTAS LINQ -----------");
                Console.Write("\n1º) C1: Listar todos los Productos" +
                    "\n" + "2º) C2: Listar productos que tengan como nombre de categorías 'Beverages'" +
                    "\n" + "3º) C3: Listar productos con un precio menor a 20" +
                    "\n" + "4º) C4: Listar productos cuyo nombre sea Queso" +
                    "\n" + "5º) C5: Listar productos por paquetes 'pkg' o 'pkgs'" +
                    "\n" + "6º) C6: Listar productos que empiecen con A" +
                    "\n" + "7º) C7: Listar los productos sin stock disponible" +
                    "\n" + "8º) C8: Listar productos descontinuados" +
                    "\n" + "9º) C9: Insertar Producto" +
                    "\n" + "10º) C10: Insertar Categoria" +
                    "\n" + "11º) C11: Editar Producto" +
                    "\n" + "12º) C12: Eliminar Producto" +
                    "\n" + "13º) Salir");
                
                string val;
                Console.Write("\n Seleccione una opción: ");
                val = Console.ReadLine();
                int a = Convert.ToInt32(val);
                
                if (a == 1)
                {
                    C1_Lista_Productos();
                }
                else if (a == 2)
                {
                    C2_Lista_Productos_categoryname_beverages();

                }
                else if (a == 3)
                {
                    C3_Listar_productos_precio_menor_a_20();
                }
                else if (a == 4)
                {
                    C4_Listar_productos_nombre_sea_Queso();
                }
                else if (a == 5)
                {
                    C5_Listar_productos_por_paquetes();
                }
                else if (a == 6)
                {
                    C6_Listar_productos_empiecen_con_A();
                }
                else if (a == 7)
                {
                    C7_Listar_productos_sin_stock();
                }
                else if (a == 8)
                {
                    C8_Listar_productos_descontinuados();
                }
                else if (a == 9)
                {
                    C9_Insertar_Producto();
                }
                else if (a == 10)
                {
                    C10_Insertar_Categoria();
                }
                else if (a == 11)
                {
                    C11_Update_Producto();
                }
                else if (a == 12)
                {
                    C12_Delete_Producto();
                }
                else
                {
                    Console.WriteLine("Hasta Luego!");
                    menu = false;
                    Console.ReadKey();
                }
                
            }
        }

        static void C1_Lista_Productos()
        {
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación de Consulta
            var query = from p in context.Products
                       select p;
            //Ejecución de Consulta
            Console.Title = "C1: Listar todos los Productos";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C2_Lista_Productos_categoryname_beverages()
        {
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where
                         p.Categories.CategoryName == "Beverages"
                        select p;

            //Ejecución de Consulta
            Console.Title = "C2: Listar productos que tengan como nombre de categorías 'Beverages'";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C3_Listar_productos_precio_menor_a_20()
        {
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where p.UnitPrice < 20
                        select p;

            //Ejecución de Consulta
            Console.Title = "C3: Listar productos con un precio menor a 20";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C4_Listar_productos_nombre_sea_Queso()
        {//DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where p.ProductName.Contains("Queso")
                        select p;

            //Ejecución de Consulta
            Console.Title = "C4: Listar productos cuyo nombre sea Queso";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C5_Listar_productos_por_paquetes()
        {
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                        select p;

            //Ejecución de Consulta
            Console.Title = "C5: Listar productos por paquetes 'pkg' o 'pkgs'";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }

        static void C6_Listar_productos_empiecen_con_A()
        {//DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where p.ProductName.StartsWith("A")
                        select p;

            //Ejecución de Consulta
            Console.Title = "C6: Listar productos que empiecen con A";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C7_Listar_productos_sin_stock()
        {
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where p.UnitsInStock <= 0
                        select p;

            //Ejecución de Consulta
            Console.Title = "C7: Listar los productos sin stock disponible";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "PRECIO", "EMPAQUE", "STOCK", "UN.ORDEN", "DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice, prod.QuantityPerUnit, prod.UnitsInStock, prod.UnitsOnOrder, prod.Discontinued);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }

        static void C8_Listar_productos_descontinuados()
        {
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var query = from p in context.Products
                        where p.Discontinued == true
                        select p;

            //Ejecución de Consulta
            Console.Title = "C8: Listar productos descontinuados";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE","PRECIO","EMPAQUE","STOCK","UN.ORDEN","DISCONTINUADO");
            foreach (var prod in query)
            {
                table.AddRow(prod.ProductID, prod.ProductName, prod.UnitPrice,prod.QuantityPerUnit,prod.UnitsInStock,prod.UnitsOnOrder, prod.Discontinued);   
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C9_Insertar_Producto()
        {
            Console.Title = "C9: Agregar registros a Productos";
            Console.WriteLine("Se agregó el elemento a la Tabla");
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            Products p = new Products();
            p.ProductName = "Peruvian Cofee";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;
            //Ejecucion Consulta
            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();
            //
            C1_Lista_Productos();
        }
        static void C10_Insertar_Categoria()
        {
            Console.Title = "C9: Agregar registros a Categorias";
            Console.WriteLine("Se agregó el elemento a la Tabla");
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            Categories c = new Categories();
            c.CategoryName = "Golosinas";
            c.Description = "Caramelo, chupertines  y demás.";

            //Ejecucion Consulta
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();
            //
            //DataContext
            NorthwndDataContext context2 = new NorthwndDataContext();
            //Creación de Consulta
            var query = from c2 in context2.Categories
                        select c2;
            //Ejecución de Consulta
            Console.Title = " Listar todas las Categorias";
            Console.WriteLine("Title: {0}", Console.Title);
            var table = new ConsoleTable("ID", "NOMBRE", "DESCRIPCION");
            foreach (var cat in query)
            {
                table.AddRow(cat.CategoryID, cat.CategoryName, cat.Description);
            }
            table.Write();
            Console.WriteLine("Presione enter para volver al menú");

            Console.ReadKey();
        }
        static void C11_Update_Producto()
        {
            Console.Title = "C11:Editar registros de Productos";
            
            Console.WriteLine("Se editó el elemento a la Tabla");
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var product = (from pr in context.Products
                           where pr.ProductName =="Tofu"
                           select pr).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;
            
            //Ejecucion Consulta
            
            context.SubmitChanges();
            //
            C1_Lista_Productos();
        }
        static void C12_Delete_Producto()
        {
            Console.Title = "C12:Eliminar registros de Productos";

            string val;
            Console.Write("\n Ingrese el ID del producto a eliminar: ");
            val = Console.ReadLine();
            int id = Convert.ToInt32(val);

            Console.WriteLine("Se eliminó el elemento a la Tabla");
            //DataContext
            NorthwndDataContext context = new NorthwndDataContext();
            //Creación Consulta
            var product = (from pr in context.Products
                           where pr.ProductID == id
                           select pr).FirstOrDefault();
            try
            {
                //Ejecucion Consulta
                context.Products.DeleteOnSubmit(product);
                context.SubmitChanges();
                //
                C1_Lista_Productos();
            }
            catch
            {
                Console.WriteLine("El elemento no se encontró o ya ha sido eliminado");
                Console.ReadKey();
            }
            
        }

    }
}
