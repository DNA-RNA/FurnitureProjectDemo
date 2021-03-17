using Bussiness.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
           
            Console.WriteLine(" MOBİLEYA' YA HOŞGELDİNİZ ");
            Console.WriteLine("<<<<<KATEGORİLER>>>>>");

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryId + " : " + 
                category.CategoryName + " : " + category.Declaration);

            }

            Console.WriteLine("<<<<<üRÜNLER>>>>>");
          
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine( product.ProductName +
                " : " + product.UnitPrice + "TL. Stok Durumu : " + product.UnitsInStock);

            }

            Console.WriteLine("<<<<<RENK ÇEŞİTLERİ>>>>>");

            ColorManager colorManager = new ColorManager(new InMemoryColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " : " + color.ColorName);
            }

            Console.WriteLine("<<<<<MARKA ÇEŞİTLERİ>>>>>");

            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " : " + brand.BrandName);
            }
        }
    }
}
