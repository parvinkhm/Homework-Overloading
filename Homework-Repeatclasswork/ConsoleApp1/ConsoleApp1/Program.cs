

//static void GetFullData(string name,string surname, int age, string address = "Ehmedli")
//{
//    string result = $"Name: {name}, Surname: {surname}, Age: {age}, Address: {address}";
//    Console.WriteLine(result);
//}

//GetFullData("Sheref", "Tanzilli", 26);


//static void GetNumsOfArray(int number, int num, params int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

////int[] numbers = { 2, 3, 5, 6, 7, };

//GetNumsOfArray(1,2,3,4,5);


//int a = 5;

//int b = 6;

//b = 100;

//Console.WriteLine(a);

//Console.WriteLine(b);


//int[] arr1 = { 1, 2, 3, 5, 6 };


//Console.WriteLine(arr1[0]);

//int[] arr2 = arr1;

//arr2[0] = 100;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);


//int a = 8;

//Test(ref a);

//Console.WriteLine(a);


//static void Test(ref int a)
//{
//    a = 20;
//    Console.WriteLine(a);
//}



//int a = 8;

//Test(out a);

//Console.WriteLine(a);


//static void Test(out int a)
//{
//    a = 20;
//    Console.WriteLine(a);
//}


//static void GetFullName(string name, string surname)
//{
//    Console.WriteLine(name + " " + surname);
//}



//StringBuilder stringBuilder = new StringBuilder("Salam");

//stringBuilder.Append("-Azerbaycan");

//Console.WriteLine(stringBuilder);


using System.Runtime.CompilerServices;

//string name = new String("salamlar");

//String surname = "";

//Console.WriteLine(name);


//string name = "Samir";

//Test(name);

//Console.WriteLine(name);


//static void Test(string name)
//{
//    name = "Xeyyam";
//    Console.WriteLine(name);
//}

//string name = "Pervin  Salam";

//Console.WriteLine(name.Length);
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name.ToLower());
//Console.WriteLine(name.Trim());
//Console.WriteLine(name.Replace("e", "a"));

//for (int i = 0;  i <name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}

//var arr = name.Split ("  ");
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}



//string str1 = "C# ";


//string str2 = "Programming";

//Console.WriteLine( str1 + str2);

//// join two strings
//string result = string.Concat(str1, str2);


//Console.WriteLine("Joined string: " + result);

//if (str1 == str2)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//bool isEqual = str1.Equals (str2);
//Console.WriteLine(isEqual);

//Console.WriteLine(str1.Substring(0, 10) +"....");

//string surname = "Filankesov";

//Console.WriteLine(surname.Contains("s"));




//string text = "salam";


//ReplaceSpecificCharFromStr(text, 1, 't'); 

//static void ReplaceSpecificCharFromStr(string str, int index, char replaceChar)
//{
//    var arr = str.ToCharArray();

//    arr[index] = replaceChar;

//    arr.ToString();

//    Console.WriteLine(arr);
//}
