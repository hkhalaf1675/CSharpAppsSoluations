using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array :
            // save the data on memory on one block
            // ----> fast on access items on it

            // ----> has fixed size
            // ----> at most of times there is waste of storage space

            // if there is a case that need to increase length of array
            // --- will create new array with the new length and copy data from old one to the new one

            #region List defination and explanation
            // List
            // it is generic
            // if not fixed length
            // can take initial length or not
            // it works : when add new item : it is check is length is equal size
            // ----- it will allocate new array with new size that equal double of old size
            // ------- mean that if i have list of size 4 and that list is filled 
            // --------- that mean the new list will be size of 8 -> then 16 -> then 32
            // --- the list was initalized of size 0
            // ----- the first add will generate list of size 4
            // --- if the developer know the size at first will be good for performance
            // ---- or he know the initial size that will be duplicated 
            // -- if finised of adding the items of list and the list has spaces for more items (has free capacity)
            // ---- you do not need it : there is method that remove those extra spaces
            // ------ called : list.TrimExcess();
            // -- to know the capacity of list : there is property that return the capacity
            // ------ called : list.Capacity
            // -- on using list.RemoveAt() : 
            // ------ it's shift all the items to fill the free space 
            #endregion

            #region List Examples and methods
            List<int> numbers = new List<int>(3);
            Console.WriteLine($"Count : {numbers.Count}, Capacity : {numbers.Capacity}");
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine($"Count : {numbers.Count}, Capacity : {numbers.Capacity}");
            numbers.Add(4);
            Console.WriteLine($"Count : {numbers.Count}, Capacity : {numbers.Capacity}");
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            Console.WriteLine($"Count : {numbers.Count} , Capacity : {numbers.Capacity}");

            Console.WriteLine(numbers.Count); // return the length of list
            Console.WriteLine(numbers.Capacity);// return the current size of list

            numbers.TrimExcess();
            Console.WriteLine(numbers.Capacity);// return the current size of list

            numbers.Sort();// sort the list

            numbers.Clear();// remove all the items of list
            Console.WriteLine(numbers.Count); // return the length of list
            Console.WriteLine(numbers.Capacity);// return the current size of list 
            #endregion

            #region Dictionary defination and explanation
            // dictionary
            // it key value pair
            // used to store data on keys and values
            // can search for data by key 
            // it is consist from two arrays one for keys and the second for values
            // it is not fixed size
            // the key is unique can not repeat it [ no duplicate keys ] 
            #endregion

            #region Dictionary Examples and methods
            Dictionary<string, int> BookPhone = new Dictionary<string, int>(3);
            BookPhone.Add("ASD", 123);
            BookPhone.Add("ZXC", 456);
            BookPhone.Add("QWE", 789);

            // for prodective add to avoid exception of duplicated keys
            if (BookPhone.ContainsKey("ASD"))
                BookPhone["ASD"] = 159;
            else
                BookPhone.Add("ASD", 159);

            // prodective code for searching for value of key
            if (BookPhone.TryGetValue("ASD", out int phone))
                Console.WriteLine(phone);
            else
                Console.WriteLine("There is no book with that name");

            #endregion

        }
    }
}
