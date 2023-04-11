namespace PizzaShopDecorator2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem ThinChickenCheeseTomato = new ThinCrust();
            ThinChickenCheeseTomato = new Chicken(ThinChickenCheeseTomato);
            ThinChickenCheeseTomato = new Cheese(ThinChickenCheeseTomato);
            ThinChickenCheeseTomato = new Tomato(ThinChickenCheeseTomato);

            Console.WriteLine("{0}: {1:C}",ThinChickenCheeseTomato.GetDescription(),
               ThinChickenCheeseTomato.GetPrice()) ;

            MenuItem Thick = new ThickCurst() ;
            Thick = new Bacon(Thick);
            Thick = new Ham(Thick);
            Thick = new Avocado(Thick);
            Thick = new Tomato(Thick);
            Thick = new Cheese(Thick);
            Thick = new Cheese(Thick);
            Console.WriteLine("{0}: {1:C}", Thick.GetDescription(),
               Thick.GetPrice());

        }
    }
}