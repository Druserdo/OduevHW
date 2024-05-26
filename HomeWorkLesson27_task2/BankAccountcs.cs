using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson27_task2
{
    internal class BankAccountcs
    {
        private decimal BallansAccount;
        private decimal StartBallansAccount;

        public BankAccountcs(decimal ballansAccount, decimal startBallansAccount)
        {
            BallansAccount = ballansAccount;
            StartBallansAccount = startBallansAccount;
        }
        public decimal Replenishment(decimal amountOfMoney)
        {
            if (amountOfMoney < 0)
            {
                StartBallansAccount += amountOfMoney;
                BallansAccount = StartBallansAccount;
                

            }
            Console.WriteLine($"Ваш баланс равен: {BallansAccount}");
            return BallansAccount;

        }
        //public decimal CashWithdrawal(decimal amountOfMoney)
        //{
        //    if (StartBallansAccount < amountOfMoney)
        //    {

        //    }
        //}

        //        содержащий методы для выполнения
        //операций со счетом, такие как пополнение, снятие денег, проверка
        //баланса и т.д.
    }
}
