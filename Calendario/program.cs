using System;

class Program
{
    static void Main()
    {
        DateTime calendario = DateTime.Now;
        DateTime diaMesActual = new DateTime(calendario.Year, calendario.Month, 1);
        int diasDelMes = DateTime.DaysInMonth(diaMesActual.Year, diaMesActual.Month);
        int primerDiaSemana = (int)diaMesActual.DayOfWeek;

        Console.WriteLine("\t{0} {1}", calendario.ToString("MMMM"), calendario.Year);
        Console.WriteLine("lu ma mi ju vi sa do");

        // Crear un arreglo para representar el calendario
        string[,] calendarioArray = new string[6, 7];
        int diaActual = 1;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i == 0 && j < primerDiaSemana || diaActual > diasDelMes)
                {
                    calendarioArray[i, j] = "  ";
                }
                else
                {
                    calendarioArray[i, j] = diaActual.ToString().PadLeft(2, ' ');
                    diaActual++;
                }
            }
        }

        // Imprimir el calendario
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(calendarioArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
