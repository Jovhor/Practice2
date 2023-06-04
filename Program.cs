using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иван Сидоров", emailName = "dolores1@mail.ru";
            byte age = 25;
            float ballProg = 30.5f, 
                ballMath = 29.1f, 
                ballPhis = 100.4f, 
                ballz, 
                ballzMid;
            ballz = ballProg + ballMath + ballPhis;
            ballzMid = ballz / 3;
            Console.WriteLine($" ФИО: {fullName} \n " +
                $" Возраст: {age} \n " +
                $" email: {emailName} \n " +
                $" Баллы по программированию:  {ballProg} \n " +
                $" Баллы по математике: {ballMath} \n " +
                $" Баллы по физике: {ballPhis} \n " +
                $" Средний балл: {ballzMid:0.0} \n "+
                $" Общий балл: {ballz}");
            Console.ReadKey();
            
        }
    }

}
