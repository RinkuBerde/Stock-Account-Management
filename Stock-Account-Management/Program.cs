using Newtonsoft.Json;

namespace Stock_Account_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Stock-Account-Management!!!");
            //Creating obj for StockManager
            StockManager stockManager = new StockManager();
            //getting path of json file
            string file = @"C:\Users\RINKU\Desktop\Day6\Stock-Account-Management\Stock-Account-Management\Stock.json";
            //DeserializeO Json file
            StockUtility stockUtility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(file));
            Console.WriteLine("Enter which operation to perform\n 1-Add a stock\n 2-Remove a stock\n 3-Display Stocks");
            int num = Convert.ToInt32(Console.ReadLine());
            var fs = stockUtility.stocksList;
            switch (num)
            {
                case 1:
                    stockManager.AddStock(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                    stockManager.DisplayStocks(fs);
                    break;
                case 2:
                    stockManager.DeleteInventory(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                    stockManager.DisplayStocks(fs);
                    break;
                case 3:
                    stockManager.DisplayStocks(fs);
                    break;
            }
        }
    }
}