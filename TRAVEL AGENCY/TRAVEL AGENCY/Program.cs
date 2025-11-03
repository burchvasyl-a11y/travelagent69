namespace TouristAgencyApp
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== ТУРИСТИЧНА АГЕНЦIЯ ===");
            Console.ResetColor();

            // Ціни на послуги
            double priceCityTour = 800;
            double priceSea = 2500;
            double priceMountains = 3000;
            double priceInsurance = 500;
            double priceHotel = 1000;
            double priceTicket = 4000;

            // Ввід даних
            Console.Write("Введiть кiлькiсть туристiв: ");
            int tourists = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть кiлькiсть днiв проживання: ");
            int days = Convert.ToInt32(Console.ReadLine());

            // Обчислення вартості
            double totalCityTour = tourists * priceCityTour;
            double totalSea = tourists * priceSea;
            double totalMountains = tourists * priceMountains;
            double totalInsurance = tourists * priceInsurance;
            double totalHotel = tourists * priceHotel * days;
            double totalTicket = tourists * priceTicket;

            double totalPrice = totalCityTour + totalSea + totalMountains +
                                totalInsurance + totalHotel + totalTicket;

            // Випадкова знижка
            Random rnd = new Random();
            double discountPercent = Math.Round(rnd.NextDouble() * 15, 2);
            double discountValue = Math.Round(totalPrice * discountPercent / 100, 2);
            double finalPrice = Math.Round(totalPrice - discountValue, 2);

            // Виведення результатів
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=== РОЗРАХУНОК ТУРУ ===");
            Console.ResetColor();

            Console.WriteLine($"Оглядова екскурсiя по мiсту: {totalCityTour} грн");
            Console.WriteLine($"Поїздка до моря: {totalSea} грн");
            Console.WriteLine($"Гiрський тур: {totalMountains} грн");
            Console.WriteLine($"Страховка: {totalInsurance} грн");
            Console.WriteLine($"Проживання ({days} дн.): {totalHotel} грн");
            Console.WriteLine($"Авiаквитки: {totalTicket} грн");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nЗагальна сума туру: {totalPrice} грн");
            Console.WriteLine($"Знижка: {discountPercent}% = {discountValue} грн");
            Console.WriteLine($"До оплати: {finalPrice} грн");
            Console.ResetColor();

            Console.WriteLine("\nБажаємо приємної подорожi!");
        }
    }
}
