using Assignment._15.DataSources;
using Assignment._15.Models;
using static Assignment._15.DataSources.Source;
namespace Assignment._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*There is some questions it didn't answer it in the previous assignment because,
             we hadn’t taken it yet.So in this assignment I am goning to answer it. 
             I marked it with (*)*/
            #region Question08*
            //PrintList(ProductList.OrderBy(p=>p.Category).ThenByDescending(p=>p.UnitPrice));
            #endregion
            #region Question09*
            //PrintList(ProductList.Where(p=>p.Category== "Beverages")
            //                     .OrderByDescending(p => p.UnitsInStock)
            //                     .Select(p => new { p.ProductName,p.UnitsInStock}));
            #endregion
        }
        static void PrintList<T>(IEnumerable<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
