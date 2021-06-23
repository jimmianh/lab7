using System;

namespace lap7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //lab6
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            Heater heater2 = new Heater(100);
            thermostat.OnTemperatureChange += heater2.OnTemperatureChanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;
            Console.Write("Enter temperature:");
            thermostat.CurrentTemperature = int.Parse(Console.ReadLine());
            //lab7
            // var employees = new EmployeeManager();
            // while (true)
            // {
            //     Console.WriteLine("---------------Menu--------------");
            //     Console.WriteLine("1: tao moi nhan vien: ");
            //     Console.WriteLine("2: hien thi thong tin nhan vien: ");
            //     Console.WriteLine("3: sua thong tin nhan vien: ");
            //     Console.WriteLine("4: xoa thong tin nhan vien: ");
            //     Console.WriteLine("5: thoat: ");
            //     Console.WriteLine("----------------------------------");
            //     Console.WriteLine("vui long nhap tu 1>5");
            //     var choice = int.Parse(Console.ReadLine());
            //     switch (choice)
            //     {
            //         case 1:
            //             //Console.WriteLine("");
            //             employees.Save()
            //                 ;
            //             break;
            //         case 2:
            //             //Console.WriteLine();
            //             employees.FintAll();
            //             break;
            //         case 3:
            //             employees.Update();
            //             break;
            //         case 4:
            //             employees.Delete();
            //             break;
            //     }
            //
            //     if (choice == 5)
            //     {
            //         Console.ReadLine();
            //     }
            // }
        }
    }
}