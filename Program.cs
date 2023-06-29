// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Client client1=new Client();
            // System.Console.WriteLine("Enter Client Balance");
            // client1.balance= Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Enter Client Name");
            // client1.name=Console.ReadLine();
            Client client1 = new Client("John", 800);



            client1.defauult(); 
        } 
       
    }    
   public class Client
    {
        public String? name;
        public double principlalAmount;
        public int timeInMonths;
        public int balance;
        public double payment;

         //a constructor
        public Client(String name, int balance){
            this.name=name;
            this.balance=balance;
        }

        //method for checking the balance
        public void defauult(){
            if (balance>900)
            {
                System.Console.WriteLine("The customer has defaulted");
            }else
            {
                System.Console.WriteLine("The customer " +name+ " is on track");
            }
        }
       //method for evaluating months
       public static double interest(int timeInMonths,double principlalAmount)
       {
            double d=Convert.ToDouble(timeInMonths);
            double payment = d/principlalAmount;
            return payment;
       }
    }

    class payment
    {
        public int balance = 90;
        public void message(){
            System.Console.WriteLine("Please pay");
        }
    }
    class check : payment{
        
    }
}