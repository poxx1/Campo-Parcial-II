using System;

namespace ParcialLastra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lastra OS");


            Funcionalidades func = new Funcionalidades();

            Componente root = new Directorio(@"C");
            func.directoryList.Add(root);

            func.currentDirectory = root;

            //Componente dir1 = new Directorio("dir1");
            //Componente dir2 = new Directorio("dir2");

            //Componente archivo1 = new Archivo("file1.txt", 10);
            //Componente archivo2 = new Archivo("file2.txt", 120);
            //Componente archivo3 = new Archivo("file3.txt", 20);

            //root.AgregarHijo(dir1);
            //root.AgregarHijo(dir2);

            //Componente archivo1 = new Archivo("file1.txt", 10);
            //dir1.AgregarHijo(archivo1);

            //dir2.AgregarHijo(archivo2);
            //dir2.AgregarHijo(archivo3);

            //Console.WriteLine($"El dir {root.Nombre} tiene como hijos {root.ObtenerHijos().Count} directorios.");

            //dir1.ObtenerHijos();
            //dir2.ObtenerHijos();

            //Proceso
            func.loginService();

           
        }
    }
}
