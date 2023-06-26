using Katas._5kyu;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List<int> test = new List<int> { 1, 2, 3, 4, 5 };
//int? n = SumOfK.chooseBestSum(11, 3, test);


List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
//int? n = SumOfK.chooseBestSum(163, 3, ts);

int ?n = 0;

ts = new List<int> { 50 };
n = SumOfK.chooseBestSum(163, 3, ts);

Console.WriteLine(n);