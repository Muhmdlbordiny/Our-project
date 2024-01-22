using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static Trainig2.ListGenerators;
namespace Trainig2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Linq to object 
            //Console.WriteLine(Product_List[0]);
            //#region Where - filteration 
            //var result = Product_List.Where(P => P.UnitStocks == 0);
            //result = from P in Product_List
            //         where P.UnitStocks == 0
            //         select P;
            //result = Product_List.Where(P => P.UnitStocks == 0 && (P.Category == "Condiment"));
            //result = from p in Product_List
            //         where (p.UnitStocks == 0) && (p.Category == "Condiment")
            //         select p;
            //result = Product_List.Where((p, i) => p.UnitStocks == 0 && i <= 5);
            //indexed where  vaild in fluent syntax 
            // can`t be written using Query Expresion 

            #endregion
            #region - select : Transformation operator
            //project/ transform every elment in input squence to a new elment in output seq of New data type
            // var Result = Product_List.Select(p => p.ProductName);// product =>string
            //or
            // Result = from p in Product_List
            //  select p.ProductName;
            //Console.WriteLine("-------------------");
            //var Result = Product_List.Where(p => p.UnitStocks == 0)
            //    .Select(p => new { Id = p.ProductID, p.ProductName });
            //----------------------------
            //Result = from p in Product_List
            //         select new { Id = p.ProductID, p.ProductName }; 
            //>product >= Anonymous type

            #endregion


            #region
            //var Discountedlst = Product_List.Select(p => new Product() { 
            //    ProductID = p.ProductID, 
            //    Category = p.Category, 
            //    ProductName = p.ProductName,
            //    UnitStocks = p.UnitStocks,
            //    UnitPrice = 0.9M * p.UnitPrice 
            //});
            //product =>product
            //Discountedlst = from p in Product_List
            //                select new Product()
            //                {
            //                    ProductID = p.ProductID,
            //                    Category = p.Category,
            //                    ProductName = p.ProductName,
            //                    UnitStocks = p.UnitStocks,
            //                    UnitPrice = 0.9M * p.UnitPrice
            //                };

            // indexed select , vaild only in fluent syntax format
            //var result = Product_List.Where(p => p.UnitStocks == 0) // o/p of where using as i/p to select
            //    .Select((p, i) => new { index = i, Name = p.ProductName });

            //var result = Product_List.Select(p => new { Name = p.ProductName, NewPrice = p.UnitPrice * 1.1M })
            //    .Where(p => p.NewPrice > 20);
            //var R01 = Product_List.Select(p => new { Name = p.ProductName, NewPrice = p.UnitPrice * 1.1M });
            //var R02 = R01.Where(p => p.NewPrice > 20);
            //var RR01 = from p in Product_List
            //           select new { Name = p.ProductName, NewPrice = p.UnitPrice * 1.1M }; //relation where by select and sort
            //var RR02 = from p in RR01
            //           where p.NewPrice > 20
            //           select p;
            //var RR = from p in Product_List
            //         select new { Name = p.ProductName, NewPrice = p.UnitPrice * 1.1M }
            //        into TaxedPrdlst      // introduce new Range varible to continue Query using New (only)Range varible
            //         where TaxedPrdlst.NewPrice > 20
            //         select TaxedPrdlst;
            #endregion

            #region ordering Elements
            //var result = Product_List.OrderBy(P => P.UnitStocks)
            //    .Select(p => new { p.ProductName, p.UnitStocks,p.UnitPrice });

            //result = from p in Product_List
            //         orderby p.UnitStocks
            //         select new { p.ProductName, p.UnitStocks,p.UnitPrice };

            //result = Product_List.OrderByDescending(P => P.UnitStocks)
            //    .Select(p => new { p.ProductName, p.UnitStocks,p.UnitPrice });
            //result = from p in Product_List
            //         orderby p.UnitStocks descending
            //         select new { p.ProductName, p.UnitStocks,p.UnitPrice };

            //result = Product_List.OrderByDescending(P => P.UnitStocks)
            //    .ThenBy(p=>p.UnitPrice)
            //    .Select(p => new { p.ProductName, p.UnitStocks, p.UnitPrice });
            //result = from p in Product_List
            //         orderby p.UnitStocks descending,p.UnitPrice
            //         select new { p.ProductName, p.UnitStocks, p.UnitPrice };
            //result = Product_List.OrderByDescending(P => P.UnitStocks)
            //   .ThenByDescending(p => p.UnitPrice)
            //   .Select(p => new { p.ProductName, p.UnitStocks, p.UnitPrice });
            //result = from p in Product_List
            //         orderby p.UnitStocks descending, p.UnitPrice descending
            //         select new { p.ProductName, p.UnitStocks, p.UnitPrice };

            #endregion

            #region Element Operators -Imidiate Execution 
            //retuen single element:
            //vaild only fluent syntax

            // List<Product> Discounted = new List<Product>();// Empty sequency
            //var Result = Product_List.First(p=>p.UnitStocks==0);
            //Result = Product_List.Last();
            //Result = Product_List.Last(p=>p.UnitStocks==0);

            //Result = Discounted.First();// if i/p seq have no element , throw Exeception
            //Result = Discounted.FirstOrDefault();//return first i/p seq ,return default value if empty seq,no Exeception willbe thrown
            //REsult = defaylt(product)
            // Result = Discounted.LastOrDefault();

            //  Result = Product_List.First(p => p.UnitPrice > 300); // no element matching predicate , throw Exeception 
            //Result = Product_List.FirstOrDefault(p => p.UnitPrice > 300);

            //Hybird (Query Expression).Fluent syntax
            //var R = (from p in Product_List
            //         where p.UnitStocks == 0
            //         select new { p.ProductName, p.Category }).First();

            //Result = Product_List.ElementAt(8);
            //Result = Product_List.ElementAt(170);// throw Exeception
            // Result = Product_List.ElementAtOrDefault(170);

            //Discounted.Add(Product_List[0]);
            //Result = Product_List.Single();// return single element in seq (only one  element in i/p seq  )
            //throw exeception if empty seq more than one element exists
            //Result = Discounted.Single();

            //Result = Product_List.Single(p => p.ProductID == 7);// Throw Exeception if more than one product Matched predicate or
            //                                                    // if No elements Matchs predicate
            //Result = Product_List.SingleOrDefault(p => p.ProductID == 777);// Throw Exeception if more than one product Matched predicate 
            //                                                               // return Default if no elements Matchs predicate
            //Result = Product_List.SingleOrDefault(p => p.UnitStocks ==0); //Exeception 
            // Console.WriteLine(Result?.ProductName ?? "invaild");
            #endregion


            #region -Agregate - imidate Execution
            //var Result = Product_List.Count();
            //Result = Product_List.Count(p => p.UnitStocks == 0);
            // var Result = Product_List.Max();
            // return Max (based on Icompareable<T> implementation )product

            //var Result = Product_List.Max(p=>p.UnitPrice);// Max unit price
            //Product prd = Product_List.Min() ;
            //Result = Product_List.Min(p => p.UnitPrice);
            //var rsl = (from p in Product_List
            //           where p.UnitPrice == Product_List.Min(p => p.UnitPrice)
            //           select p).FirstOrDefault();
            //Console.WriteLine(rsl?.ProductName ?? "Na");
            //Console.WriteLine(Product_List.Average(p=>p.UnitStocks));
            //Console.WriteLine(Product_List.Sum(p=>p.UnitStocks));
            //Product_List.Aggregate() ;

            //Console.WriteLine(Result);
            #endregion


            #region - Generators Operators :
            // Generating output seqence (only way to call them is a static members from Enumerable Class)

            //var Result = Enumerable.Range(0,10);
            //var R01 = Enumerable.Empty<Product>();
            //var R02 = Enumerable.Repeat(3, 10);
            //Product_List[2].ProductName = "temp";
            //var R03 = Enumerable.Repeat(Product_List[2], 5);

            #endregion
            #region - select Many
            // output seq  count > input seq count
            // transform each element in input seq to sub  seq (IEnumarble)
            // List<String> Namelist = new List<string>() { "mohamed ashraf", "aya halem", "ahmed ashraf" };
            // var R03 = Namelist.SelectMany(FN => FN.Split(' ')).OrderByDescending(SN=>SN.Length);
            // // Query Syntax :use Multiple  from tp product  select Many 
            //var R0 = from FN in Namelist
            //       from SN in FN.Split(' ')
            //       orderby SN.Length descending
            //       select SN;
            // var R02 = R03.SelectMany(SN => SN.ToCharArray());


            #endregion
            #region - Casting - imidiate Execution

            //List<Product> Unav = Product_List.Where(p => p.UnitStocks == 0).ToList();
            //Product[] prd = Product_List.Where(p => p.UnitStocks == 0).OrderBy(p=>p.UnitPrice).ToArray();

            //var _prd = Product_List.Where(p => p.UnitStocks == 0)
            //.ToHashSet(,);
            // .ToDictionary(p => p.ProductID);(key selector)//Dic<long,product)
            // .ToDictionary(p => p.ProductID,prd=>new {prd.ProductID,prd.ProductName });(key selector,valueselector)//Dic<long,anonymous[long,string])
            //  .ToLookup();
            #endregion

            #region
            // differnce between lookup &Dictionary
            //string[] names = { "mo7a", "bero", "miso", "nosa", "mido", "zozo", "7oms", "yoyo" };
            //var lookup = names.ToLookup(item => item[0]);
            //foreach(var group in lookup)
            //{
            //    Console.WriteLine("group-{0}", group.Key);
            //    foreach (var item in group)
            //        Console.WriteLine("\t"+item);
            //}
            //var test = names.GroupBy(item => item[0]);
            //foreach(var group in test)
            //{
            //    Console.WriteLine("group-{0}", group.Key);
            //    foreach (var item in group)
            //        Console.WriteLine("\t"+item);
            //}
            #endregion
            #region - index , range C# 8.0
            //var lst01 = Enumerable.Range(0,100); //0>>99
            //var lst1 = lst01.ToList();
            //Console.WriteLine(lst1[0]);
            //Console.WriteLine(lst1[^1]);//last element
            //Range Result = 1..^10;
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int R = Arr[0]; // orignal using index of 0
            //R = Arr[^1];
            //var L = Arr[1..3];
            //var L01 = Arr[1..^3];
            ////Console.WriteLine(L01);
            //Console.WriteLine(R);
            //Console.WriteLine(L);

            #endregion
            #region
            // var seq1 = Enumerable.Range(0, 100); //0>>99 start , count
            //var seq2 = Enumerable.Range(50, 100); // 50....149 because 50 start count 100 numbers 


            //var result = seq1.Union(seq2); // remove duplicates
            //result = seq1.Concat(seq2); // allows Duplicate
            //result = result.Distinct(); // remove Duplicate 
            //result = seq1.Except(seq2); //find in seq1 dont find in seq2
            //result = seq1.Intersect(seq2);//find in seq1 , find in seq2 intersection
            //foreach (var item in result)
            //    Console.Write($"{item},");
            //Console.WriteLine("");
            #endregion
            #region - Quantifiers - return Boolean

            // Console.WriteLine(
            // Product_List.Any() // return true if i/p seq have at least one element
            // Product_List.Any(p=>p.UnitStocks>200)//return true if i/p seq have at least one element Matching predicate 
            //    Product_List.All(p=>p.UnitStocks>0) // return true of all elements in input seq matching predicate 
            //seq1.SequenceEqual(seq2)
            //  );
            #endregion
            #region -Zip operator  //input 2 seq , one comined o/p seq 
            //List<string> NameList = new List<string>() { "mohamed", "ali", "Eslam" };
            //var lst02 = Enumerable.Range(0,10);
            //var Result = NameList.Zip(lst02, (FN, i) => new { i,Name = FN.ToUpper() });

            #endregion
            #region -Group
            //var Result = from p in Product_List
            //             where p.UnitStocks > 0
            //             group p by p.Category
            //             into prdGroups
            //             where prdGroups.Count() >= 1
            //             orderby prdGroups.Count() descending
            //             //select prdGroups;
            //             select new { Category = prdGroups.Key, prductCount = prdGroups.Count() };
            //Result = Product_List.GroupBy(p => p.Category).Where(prdG => prdG.Count() >= 1).OrderByDescending(pG=>pG.Count())
            //    .Select(pG=>new { Category = pG.Key, prductCount = pG.Count() });
            //foreach (var prdGroup in Result)
            //{
            //    Console.WriteLine($"Group Key  {prdGroup.Key}");
            //    //foreach (var prd in prdGroup)
            //    //    Console.WriteLine($"..prd  {prd.ProductName}");

            //}
            #endregion
            #region let / into - introducing new range varible in Query syntax

            List<string> Names = new List<string>() { "ahmed", "ali", "miso", "eslam", "miso" };
            //aieuoAIEUO
            //Regular Expression 
            //var Result = from M in Names
            //                 //where M.Length>=2 don`t
            //             select Regex.Replace(M, "[aieuoAIEUO]", string.Empty)
            //             // restart Query with a range vrible ,old range varible is not Acessable
            //             into Novo
            //             where Novo.Length >= 2
            //             orderby Novo, Novo.Length descending
            //             select Novo;

            //var Result = from M in Names
            //             let Novo= Regex.Replace(M, "[aieuoAIEUO]", string.Empty) // let ,Continue Query With added Range Varible
            //             where Novo.Length >= 2
            //             orderby Novo,M.Length ,Novo.Length descending
            //             select Novo;
            #endregion
            //foreach (var item in Result)
            //  Console.WriteLine(item);
        }
    }
}