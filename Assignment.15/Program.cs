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
            #region Question03
            //PrintList(ProductList.TakeWhile(p=>p.UnitPrice<25).OrderBy(p=>p.UnitPrice));
            #endregion
            #region Question04
            //Console.WriteLine(ProductList.Where(p=>p.Category== "Seafood").All(p=>p.UnitsInStock>0));
            #endregion
            #region Question05
            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine(ids.Contains(9));
            #endregion
            #region Question06
            //PrintList(ProductList.GroupBy(p=>p.Category)
            //                     .Select(g => new { Category=g.Key,Count=g.Count()}));
            #endregion
            #region Question07
            //PrintList(ProductList.GroupBy(p => p.Category)
            //                     .Select(g => new { Category = g.Key}));
            #endregion
            #region Question08
            //PrintList(ProductList.GroupBy(p=>p.Category)
            //                     .Where(g=>g.Count()>3)
            //                     .Select(g=>new { Category =g.Key,Count=g.Count()}));
            #endregion
            #region Question09
            //PrintList( from customer in CustomerList
            //           group customer by customer.Country
            //           into g
            //           select new 
            //           {
            //                Country =g.Key,
            //                Count=g.Count(), 
            //                TotalOrderValue = g.Sum(c=>c.Orders.Sum(o=>o.Total))
            //           }
            //         );
            #endregion
            #region Question10
            //Console.WriteLine(ProductList.Sum(p=>p.UnitsInStock));
            #endregion
            #region Question11
            //Console.WriteLine("CHEAPEST:"+ ProductList.OrderBy(p => p.UnitPrice).First());
            //Console.WriteLine("MOST EXPENSIVE:" + ProductList.OrderBy(p => p.UnitPrice).Last());
            #endregion
            #region Question12
            //PrintList(ProductList.Select(p=>p.Category).Distinct());
            #endregion
            #region Question13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //PrintList(setA.Except(setB));
            #endregion
            #region Question14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //PrintList(list1.Except(list2, StringComparer.OrdinalIgnoreCase));
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
