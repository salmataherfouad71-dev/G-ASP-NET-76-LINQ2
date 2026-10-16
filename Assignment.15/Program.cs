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
            #region Question10*
            //PrintList(
            //    from customer in CustomerList
            //    from order in customer.Orders
            //    where order.OrderDate.Year >= 1997
            //    select new
            //    {
            //        customer.CustomerID,
            //        order.OrderDate
            //    }
            //         );
            #endregion
            #region Question11*
            //PrintList(ProductList.Select((p,i)=>$"{i+1}-{p.ProductName}"));
            #endregion
            #region Question12*
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //PrintList(Arr.OrderBy(w=>w.Length).ThenBy(w=>w,StringComparer.OrdinalIgnoreCase));
            #endregion
            #region Question13*
            //PrintList(Arr.Where(w => char.ToLower(w[1]) =='i').Reverse()); 
            #endregion
            #region Question01
            //PrintList(ProductList.OrderByDescending(p=>p.UnitPrice).Take(3));
            #endregion
            #region Question02
            //PrintList(ProductList.Skip((2-1)*5).Take(5));
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
