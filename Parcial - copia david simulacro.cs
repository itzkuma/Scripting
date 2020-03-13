using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public double promedioMasDesv = 0; //hice publicas estas variables para que me funcionen en  todo el codigo
    public double promedioMenosDesv = 0;//esta tambien

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
        List < double > tmp= new List <double>();
        double promedio = 0;
        double desviacion = 0;
        
        //se calcula el promedio
        for (int i=0; i < notas.Length; i++)
        {
            promedio = promedio + notas[i];
        }
        promedio = promedio / notas.Length;
        
        //calculando la desviacion
        for( int i=0; i< notas.Length;i++)
        {
            desviacion = notas[i] - promedio;
            desviacion = desviacion * desviacion;
            tmp.Add(desviacion);
        }
        desviacion = 0;
        for (int i = 0; i < tmp.Count; i++)
        {
            desviacion = desviacion + tmp[i];
        }
        desviacion = Math.Sqrt((desviacion / tmp.Count)); //ya tengo la desviacion

        promedioMasDesv = promedio+desviacion;
        promedioMenosDesv = promedio - desviacion;

        for(int i = 0; i < tmp.Count; i++)
        {
            if( promedioMenosDesv < notas[i] && notas[i] < promedioMasDesv)
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
        double notaTmp = 0;
        string TmpNombre = "";
        List<double> diferencias = new List<double>();

        //Se llena la lista tmp con las diferencias de cada nota con el promedio mas la desviacion
        for(int i=0; i < notas.Length; i++)
        {
            diferencias.Add(Math.Abs(promedioMasDesv - notas[i]));
        }

            List<string>  nombresTMP = new List<string>();
        //se llena la lista nombreTMP con los los nombres del arreglo nombres
        for(int i=0; i< nombres.Length; i++)
        {
            nombresTMP.Add(nombres[i]);
        }
        for (int a = 1; a < diferencias.Count; a++)//comienza en la  primera poscicion de la lista
            for (int b = diferencias.Count - 1; b >= a; b--) //comienza en la  ultima poscicion de la lista
            {
                if (diferencias[b - 1] > diferencias[b]) //organiza de  menor a mayor las diferencias
                {
                    notaTmp = diferencias[b - 1];
                    TmpNombre = nombresTMP[b - 1];
                    diferencias[b - 1] = diferencias[b];
                    nombresTMP[b - 1] = nombresTMP[b];
                    diferencias[b] = notaTmp;
                    nombresTMP[b] = TmpNombre;
                }
            }
        for(int  i=0; i < 5;i++)
        {
            salida[i] = nombresTMP[i];
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
        for (int i = 0; i < notas.Length; i++)
        {
            if (promedioMenosDesv < notas[i] && notas[i] < promedioMasDesv)
            {
                salida.Add(nombres[i]);
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
        Char[] vocales = { 'A', 'E', 'I', 'O','U'}; //establezco las vocales
        for (int i = 0; i < nombres.Length; i++)
        {
            unNombre = nombres[i];
            contVocales = 0; //digo que el contador de vocales es cero para que no se amontonen valores en el ciclo
            for (int j = 0; j < unNombre.Length; j++)
            {

                if (unNombre[j] == vocales[0] || unNombre[j] == vocales[1] || unNombre[j] == vocales[2] || unNombre[j] == vocales[3] || unNombre[j] == vocales[4])
                {
                    contVocales++; //aumento el contador de vocales
                }
            }
            if (contVocales >= 3)
            {
                if(notas[i] > 3)
                {
                    salida.Add(nombres[i]);
                }
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


