using System;
using System.Collections.Generic;
using System.Text;

namespace ParcialLastra
{
    public class Funcionalidades
    {
        public List<Componente> directoryList = new List<Componente>();
        public Componente currentDirectory = new Directorio("21830921839021839021");

        public void MD()
        {
            bool dirCheck = false;

            //Crear directorio
            Console.WriteLine("Make dir: ");
            string dir = Console.ReadLine();

            foreach (Componente c in directoryList)
            {
                if (c.Nombre.Replace(@"\","") == dir)
                {
                    Console.WriteLine("Directory already exist");
                }

                else
                {
                    Componente directorio = new Directorio(dir);
                    Console.WriteLine(@$"{dir}:\ Created!");

                    currentDirectory.AgregarHijo(directorio);

                    //directoryList.Add(directorio);

                    break;
                }
                
            }
        }

        public void CD()
        {
            Console.WriteLine("CD ");
            string dir = Console.ReadLine();

            foreach (Componente c in directoryList)
            {
                if (c.Nombre.Replace(@"\", "") == dir)
                {
                    Console.WriteLine(dir + @"\: ");

                    break;
                }
            }
        }

        public void MF()
        {
            bool seCreo = false;
            Console.WriteLine("mk file -n ");
            string name = Console.ReadLine();
            Console.WriteLine("-wh ");
            int wh = Int32.Parse(Console.ReadLine());

            var childs = currentDirectory.ObtenerHijos();
            if (childs.Count > 0)
            {

                foreach (Archivo a in childs)
                {
                    if (a.Nombre.Replace(@"\", "") != name)
                    {
                        Componente archivo = new Archivo(name, wh);
                        currentDirectory.AgregarHijo(archivo);

                        Console.WriteLine(name + " created");
                        seCreo = true;
                        break;
                    }
                }

                if (!seCreo)
                {
                    Console.WriteLine($"{name} file already exist");
                }
            }

            else {    
                Componente archivo = new Archivo(name, wh);
                currentDirectory.AgregarHijo(archivo);
                Console.WriteLine(name + " created");
            }
        }

        public void LS()
        {
            //Console.WriteLine($"El dir {root.Nombre} tiene como hijos {root.ObtenerHijos().Count} directorios.");
            var childs = currentDirectory.ObtenerHijos();
            if (childs.Count == 0)
            {
                Console.WriteLine("This directory doesn't contains any file nor directory");
            }
            else
            {
                Console.WriteLine("Tree view: ");
                foreach (var a in childs)
                {
                   Console.WriteLine(a.Nombre + " " + a.ObtenerCapacidad);            
                }
            }
        }
            public void DI()
        {

        }

        public bool login(string pw, string us)
        {
            if (pw == "1234" && us == "admin")

                return true;

            return false;
        }

        public void loginService()
        {
            string user = "";
            string password = "";
            bool pasoLogin = false;

            while (pasoLogin == false)
            {
                Console.WriteLine("User: ");
                user = Console.ReadLine();

                Console.WriteLine("Password: ");
                password = Console.ReadLine();

                if (pasoLogin = login(password, user))
                {
                    Console.WriteLine("Success!");
                    consoleService();
                }

                Console.WriteLine("pw erronea");
            }

            Console.WriteLine("Success!");
        }

        public void consoleService()
        {
            bool connected = true;
            string command = "";

            while (connected != false)
            {
                Console.WriteLine("_");
                command = Console.ReadLine();

                switch (command)
                {
                    case "MD":
                        MD();
                        break;

                    case "CD":
                        CD();
                        break;

                    case "MF":
                        MF();
                        break;

                    case "LS":
                        LS();
                        break;

                    case "DI":
                        Console.WriteLine("disconnected");
                        loginService();//func.DI();
                        break;

                    default:
                        Console.WriteLine($"{command} no se reconoce como un comando interno o externo, programa o archivo por lotes ejecutable.");
                        break;
                }
            }
        }
    }
}