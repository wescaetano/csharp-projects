using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Notebook", 25.99, EProductType.Product);
            Console.WriteLine(product);
            Product manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 35.50, EProductType.Service);
            Console.WriteLine(manutencaoEletrica);
        }
    }
    
    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
        
        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }
        
        
        public override string ToString()
        {
            return "Id: " + Id.ToString() + ", nome do produto: " + Name + ", preço: " + Price.ToString() + ", tipo: " + Type.ToString();
        }
        
        
        
    }

    enum EProductType
    {
        Product = 1,
        Service= 2
    }
}

