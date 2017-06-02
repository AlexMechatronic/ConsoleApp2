using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para el control de balanceBot\n");
            Console.WriteLine("Para inicializar porgavor introdusca el puerto COMn al que esta asignado el modulo BT\n"+
                "Del 0-n donde n puede ser cualquier puerto COM\n");
            Console.Write("Puerto COM: ");
            string puertoCOM = "COM" + Console.ReadLine();
            Console.WriteLine("Porfavor introdusca los siguientes parametros:\n");
            Console.Write("BaudRate: ");
            int baudRate = 9600;//int.Parse(Console.ReadLine());
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            SerialPort Bluetooth = new SerialPort(puertoCOM, baudRate, Parity.None, 1);
            Bluetooth.Write("iniciando");
            Console.ReadKey();
        }
    }
}
