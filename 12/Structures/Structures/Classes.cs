using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Transaction
    {
        static uint transacNum = 0;
        PacketHeader ph;
        string accountNum;
        double amount;

        public Transaction(string acc, double val)
        {
            ph.PackNum = transacNum++;
            ph.PackLen = 512;

            accountNum = acc;
            amount = val;
        }
        public void sendTransaction()
        {
            Console.WriteLine("Пакет:" + ph.PackNum + "Длина" + ph.PackLen + "Счет" + accountNum + "Сумма: {0:C}\n",amount);
        }
    }

    class ConveyorControl
    {
        public enum Action { Старт, Стоп, Вперед, Назад };

        public void Conveyor(Action com) 
        {
            switch (com)
            { 
                case Action.Старт:
                    Console.WriteLine("Старт");
                    break;
                case Action.Стоп:
                    Console.WriteLine("Стоп");
                    break;
            }
        }
    }
}
