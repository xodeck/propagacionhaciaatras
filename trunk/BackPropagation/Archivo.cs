using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BackPropagation
{
    class Archivo
    {
        private String path;
        private StreamReader lectura;
        private StreamWriter escritura;

        /*
         * Constructor para lectura de archivos
         * * param String path: Contiene la dirección del archivo que se abrirá
         */
        public Archivo(String path) {
            this.path = path;
            if (File.Exists(path))
            {                
                lectura = new StreamReader(this.path);
                lectura.Close();
            }
        }

        /*
         * Constructor para escritura de archivos
         * param bool sustituir: Si está en true se sustituye el archivo(se reescribe), en caso contrario se agregan datos al final del archivo
         * param String path: Contiene la dirección del archivo que se guardará
         */
        public Archivo(bool sustituir, String path) {
            this.path = path;
            if (File.Exists(path))
                escritura = new StreamWriter(this.path, !sustituir);
            else
                escritura = new StreamWriter(this.path);
            escritura.AutoFlush = true;
            Console.Out.WriteLine("Se creo el archivo " + path + " correctamente");
            escritura.Close();
        }


        public void escribirReglon(int []vector) {
            escritura = new StreamWriter(this.path, true);
            for(int i=0;i<vector.Length;i++)
                escritura.Write(vector[i]+" ");
            escritura.WriteLine();
            escritura.Close();
        }

        public void escribirReglon(double [] vector)
        {
            escritura = new StreamWriter(this.path, true);
            for (int i = 0; i < vector.Length; i++)
                escritura.Write(vector[i] + " ");
            escritura.WriteLine();
            escritura.Close();
        }

        public void escribirReglon(String reglon)
        {
            escritura = new StreamWriter(this.path,true);
            escritura.WriteLine(reglon);
            escritura.Close();
        }

        public List<String> leerArchivo()
        {          
          String linea;
          List<String> archivo = new List<String>();
          lectura = new StreamReader(this.path);

          while ((linea = lectura.ReadLine())!= null)
          {            
            archivo.Add(linea);
          }
          lectura.Close();
          return archivo;        
        }

        public String leerLinea()
        {
            lectura = new StreamReader(this.path);
            String linea=lectura.ReadLine();
            lectura.Close();
            return linea;
        }
    }
}
