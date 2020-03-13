using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public double promedio = 0;

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        
        double promedio125 = 0;
        //se calcula el promedio
        for (int i = 0; i < notas.Length; i++)
        {
            promedio = promedio + notas[i];
        }
        promedio = promedio / notas.Length;
        promedio125 = promedio * 1.25;

        for (int i=0; i< notas.Length; i++)
        {
            if (notas[i] >= promedio125)
            {
                salida++;
            }
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[3];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            for (int j = 0; j < notas.Length - 1; j++)
            {
                if (notas[j] > notas[j + 1]) // ordena de menor a mayor
                {
                    double tmp1 = notas[j];
                    notas[j] = notas[j + 1];
                    notas[j + 1] = tmp1;
                    string tmp2 = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tmp2;
                }
            }
        }
        int contSalida = 0;
        Char[] vocales = { 'A', 'E', 'I', 'O', 'U' }; //establezco las vocales
        string unNombre = "";
        for (int i = 0; i < nombres.Length; i++)
        {
            unNombre = nombres[i];          
                if (unNombre[unNombre.Length-1] == vocales[0] || unNombre[unNombre.Length - 1] == vocales[1] || unNombre[unNombre.Length - 1] == vocales[2] || unNombre[unNombre.Length - 1] == vocales[3] || unNombre[unNombre.Length - 1] == vocales[4])
                {
                if (contSalida == 3)
                {
                    break;
                }
                salida[contSalida] = nombres[i];
                    contSalida++;
                }
        }
        
        //- Arriba de esta línea va su código --------
        return salida;
    }


    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string unNombre = "";
        bool contVocales = false;
        Char[] vocales = { 'A', 'E', 'I', 'O', 'U' }; //establezco las vocales
        for (int i = 0; i < nombres.Length; i++)
        {
            unNombre = nombres[i];
            
            contVocales = false; //digo que el contador de vocales es cero para que no se amontonen valores en el ciclo
            for (int j = 0; j < unNombre.Length; j++)
            {

                if (unNombre[0] == 'A' || unNombre[0] == 'E'||unNombre[0] == 'I'|| unNombre[0] == 'O' || unNombre[0] == 'U')
                {
                    contVocales=true; //aumento el contador de vocales
                }
            }
            if (contVocales ==true )
            {
              if(notas[i] > promedio)
              {
               salida.Add(nombres[i]);
              }
 
            }

        }


            //- Arriba de esta línea va su código --------
            return salida;
    }


    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        string unNombre = "";
        int contVocales = 0;
        Char[] vocales = { 'A', 'E', 'I', 'O', 'U' }; //establezco las vocales
        for (int i = 0; i < nombres.Length; i++)
        {
            unNombre = nombres[i];
            contVocales = 0; //digo que el contador de vocales es cero para que no se amontonen valores en el ciclo
            for (int j = 0; j < unNombre.Length; j++)
            {

                if (unNombre[j] != vocales[0] && unNombre[j] != vocales[1] && unNombre[j] != vocales[2] && unNombre[j] != vocales[3] && unNombre[j] != vocales[4])
                {
                    contVocales++; //aumento el contador de vocales
                }
            }
            if (contVocales >= 5)
            {
               
             salida.Add(nombres[i]);
                
            }

        }
        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }


    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


