using System;
using System.Data;
using System.Globalization;
using System.Net.Http.Headers;

class DateRevision
{
    static void Main(string[] args)
    {
        DateTime dataAtual = DateTime.Now;//DATA ATUAL E HORA ATUAL
        DateTime dataHoje = DateTime.Today;//DATA DE HOJE, E HORA DE HOJE

        DateTime data1 = new DateTime(2022, 08, 12);//SOMENTE DATA
        DateTime data2 = new DateTime(2007, 02, 26);//DATA E HORA

        int diasDiferencas = DateTime.Compare(data1, data2);
        Console.WriteLine(diasDiferencas);

        if (data1 == data2)
        {
            Console.WriteLine("iguais");
        }
        else
        {
            Console.WriteLine("nao iguais");
        }

        DateTime data3 = DateTime.Parse("1995/05/25");//CONVERTE A STRING A DATE TIME

        int ano = data2.Year;
        int mes = data2.Month;
        int dia = data2.Day;
        int hora = data2.Hour;
        int minuto = data2.Minute;
        string diaDaSemana = Convert.ToString(data2.DayOfWeek);
       
        int diaDoAno = data2.DayOfYear;
        DateTime fusoHorario = DateTime.UtcNow;
        DateTime AddDias = data1.AddDays(2);//ADICIONAR 2 DIAS NA DATA1 (mas pode ser day, mounth, hour)

        Console.WriteLine(data1.ToString("dddd", new CultureInfo("pt-br")));//PEGA O NOME DO DIA DA SEMANA EM PORTUGUES EX (QUARTA FEIRA)
        Console.WriteLine(data1);    
        Console.WriteLine(data2);
        Console.WriteLine(data3);

        //Console.WriteLine("Informe a data de hoje: ");
        //DateTime dataFornecida = Convert.ToDateTime(Console.ReadLine());

        TimeSpan horario = new TimeSpan(10, 5, 00);//O TIME SPAM VERIFICA SOMENTE HORAS
        TimeSpan ts = dataAtual.Subtract(data1);//SUBTRAIR DATAS, PARA SABER A DIFERENÇA, (pode fazer com horas, mes, etc...)
        Console.WriteLine(ts.Days);//SABER QUANTOS DIAS DE DIFERENÇA. MAIS PODE SER HORAS DE DIFERENCA 

        DateOnly somenteData = new DateOnly(2023,07,26);
    }
}
