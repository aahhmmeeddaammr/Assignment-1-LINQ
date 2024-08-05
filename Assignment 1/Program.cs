using System.Security.Cryptography;
using static Assignment_1.ListGenerator;
namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Restriction Operators
            #region  1. Find all products that are out of stock.
            //var restult = ProductsList.Where(p => p.UnitsInStock == 0);
            //var restult = from product in ProductsList
            //              where product.UnitsInStock == 0
            //              select product;

            //foreach (var product in restult) {
            //    Console.WriteLine(product);
            //}

            #endregion

            #region  2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = from product in ProductsList
            //             where product.UnitPrice > 3.00M
            //             select product;
            //Result = ProductsList.Where(P => P.UnitPrice > 3);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = arr.Where((s, i) => s.Length < i);
            //foreach (var s in result)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #endregion

            #region Ordering Operators

            #region  1. Sort a list of products by name

            //var Result = ProductsList.OrderBy(P => P.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.ToLower()).ToArray();
            //foreach (string str in Result)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region  3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductsList.OrderBy(P => P.UnitsInStock).Reverse().ToList();
            // var result = ProductsList.OrderBy(P => -P.UnitsInStock).ToList(); // Faster Than First One  
            //var result = ProductsList.OrderByDescending(P => P.UnitsInStock).ToList(); 
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(S => S.Length).ThenBy(S=>S);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.Length).ThenBy(x => x.ToLower()).ToArray();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine((item));
            //}
            #endregion

            #region  6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductsList.OrderBy(P => P.Category).ThenBy(P => P.UnitPrice).Reverse();
            //foreach (var Item in Result) { 
            //    Console.WriteLine(Item);    
            //}
            #endregion

            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in anarray.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x.ToLower()).ToArray();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine((item));
            //}
            #endregion

            
            #region  8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(P=>P.Length>1 && P[1]=='i').Reverse().ToArray();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

        }
    }
}
