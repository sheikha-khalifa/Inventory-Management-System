namespace Inventory_Management_System_using_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<string> name = new List<string>() ;
            List<string> price = new List<string>();
            List<string> quantity = new List<string>();
            List<string> retVal;

            Console.WriteLine("Select an operation (1-7):");
            int userchoise = Convert.ToInt32(Console.ReadLine());
            if (userchoise == 1)
            {
                retVal = AddProduct();

                name.Add(retVal[0]);
                price.Add(retVal[1]);
                quantity.Add(retVal[2]);

            }
            else if (userchoise == 2)
            {
                Console.WriteLine("Enter Product to Update:");
                string updatedProdect = Console.ReadLine();

                Console.WriteLine("Enter Update quantity:");
                string updatedquantity = Console.ReadLine();

                int upquantity = Convert.ToInt32(quantity[name.IndexOf(updatedProdect)]);
                upquantity += Convert.ToInt32(updatedquantity);

                quantity[name.IndexOf(updatedProdect)] = upquantity.ToString();

            }
            else if (userchoise == 3) foreach (string item in name) Console.WriteLine(item);
            else if (userchoise == 4) { }



        }

       
        static List<string> AddProduct() 
            {
            List<string> getproduct = new List<string>();
            //string[] getproduct = new string[3];
            Console.WriteLine("Enter product name:");
            getproduct.Add(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            getproduct.Add(Console.ReadLine());
            Console.WriteLine("Enter product quantity:");
            getproduct.Add(Console.ReadLine());

            return getproduct;
        }
}
}