using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    

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

        //promedio
        int i = 0;
        double promedio = 0;
        double sumaNotas = 0;

        for (i = 0; i < notas.Length; i++)
        {
            sumaNotas = notas[i]+ sumaNotas;
        }


        for (i=0; i< notas.Length; i++)
        {
            promedio = (sumaNotas/ notas.Length);
        }
        
        for (i=0; i < notas.Length; i++)
        {
            if (notas[i] >= (promedio + 0.5)) 
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

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for(int i=0; i < notas.Length; i++)
        {
            for(int j=0; j<notas.Length-1; j++)
            {
                if (notas[j] > notas[j + 1])
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
        for (int i=0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
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
        decimal Median(decimal[] data)
        {
            Array.Sort(data);
            return data[data.Length / 2];
        }

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > ((data[data.Length / 2] + 0.5)))
            {
                
            }
        }





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

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }
}


