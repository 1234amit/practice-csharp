// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int x = 5;
//Console.WriteLine(x);

//int y = 10;
//Console.WriteLine(y);

//double z = 5.5;
//Console.WriteLine(z);

//string s = "amit";
//Console.WriteLine(s);

//char c = 'a';

//bool b = false;
//Console.WriteLine(b);

//const int k = 5;


//string[] names = new string[4];
//names[0] = "amit";
//names[1] = "toma";
//names[2] = "tuli";
//names[3] = "kali";

//string middlePersonName = names[2];
//Console.WriteLine(names[2]);
//Console.WriteLine(middlePersonName);


//to take input from user
//string line = Console.ReadLine();
//int size = 0;
//bool success = false;

//success = int.TryParse(line, out size);

//if (success)
//{
//    string[] names = new string[size];

//    for (int i = 0; i < size; i++)
//    {
//        names[i] = Console.ReadLine();
//    }

//    string middlePerson = names[names.Length / 2];
//    Console.WriteLine(middlePerson);

//}
//else
//{
//    Console.WriteLine("Size is not in correct formet");
//}

/*
//single dimension array
string line = Console.ReadLine();
int size = 0;
bool success = false;

success = int.TryParse(line, out size);
if (success)
{
    string[] names = new string[size];

    for(int i=0; i<size; i++)
    {
        names[i] = Console.ReadLine();
    }

    string middlePerson = names[names.Length / 2];
    Console.WriteLine(middlePerson);
}
else
{
    Console.WriteLine("size is not in correct formet");
}

//multidimension array
int[,] grid = new int[3, 3];
grid[0, 0] = 1;
grid[0, 1] = 2;
grid[1, 1] = 4;

Console.WriteLine(grid[1, 1]);

*/


//create normal array
/*
int[] array = new int[4];
string[] keywords = ["amit", "toma", "golu", "soma", "buri"];

Console.WriteLine(keywords[4]);
*/

/*
//creating a 2 dimensional array 
int[,]numbers = { { 1, 4, 2, 12 }, { 3, 6, 8, 9 } };
Console.WriteLine(numbers[0, 2]);
Console.WriteLine(numbers[0, 3]);

//change element of the 2D array
int[,] numbersOne = { { 1, 4, 6 }, { 2, 7, 9 } };
Console.WriteLine("Before Changing value:{0}", numbersOne[0, 0]);
numbersOne[0, 0] = 5;
Console.WriteLine(numbersOne[0, 0]);
*/

/*
int[,] numbers = { { 1, 3, 4 }, { 5, 6, 7 } };
foreach(int i in numbers)
{
    Console.WriteLine(i);
}

for(int i=0; i<numbers.GetLength(0); i++)
{
    Console.WriteLine(i);
}


//for loop using 2D array
using System.Runtime.ExceptionServices;

///array code start here
int[,] numbers = { { 1, 4, 6 }, { 2, 3, 7 } };
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)  // Fix: Change 'i' to 'j' here
    {
        Console.WriteLine(numbers[i, j]);
    }
}



//another code for loop using 2D array
int[,] numbersOne = { { 1, 4, 7 }, { 2, 5, 7 } };
for(int i=0; i<numbersOne.GetLength(0); i++)
{
    for(int j=0; j<numbersOne.GetLength(1); j++)
    {
        Console.WriteLine(numbersOne[i, j]);
    }
}




//jaggedArray 
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[4];

jaggedArray[0][0] = 79;
jaggedArray[0][1] = 49;
jaggedArray[1][0] = 80;
jaggedArray[1][1] = 68;
jaggedArray[1][2] = 56;
jaggedArray[2][0] = 57;
jaggedArray[2][1] = 34;
jaggedArray[2][2] = 88;
jaggedArray[2][3] = 92;

for(int i=0; i<jaggedArray.GetLength(0); i++)
{
    double avg = 0;
    for(int j=0; j<jaggedArray[i].Length; j++)
    {
        avg = avg + jaggedArray[i][j];
    }

    Console.WriteLine(avg / jaggedArray[i].Length);
}



int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int [2];
jaggedArray[1] = new int [3];

jaggedArray[0][0] = 79;
jaggedArray[0][1] = 90;
jaggedArray[1][0] = 80;
jaggedArray[1][1] = 68;
jaggedArray[1][2] = 56;

for(int i=0; i<jaggedArray.GetLength(0); i++)
{
    double avg = 0;
    for(int j=0; j < jaggedArray[i].Length; j++)
    {
        avg = avg + jaggedArray[i][j];
    }
    Console.WriteLine(avg / jaggedArray[i].Length);

}

*/

int[][] jaggedArray = new int[3][];

jaggedArray[0] = [1, 3, 5, 7, 9];
jaggedArray[1] = [0, 2, 4, 6];
jaggedArray[2] = [11, 22];

int[][] jaggedArray2 = [
    [1, 3, 5, 7, 9],
    [0, 2, 4, 6],
    [11, 22]
];

jaggedArray2[0][1] = 77;
jaggedArray2[2][1] = 88;

int[][,] jaggedArray3 =
[
    new int[,] { { 1, 3 }, { 5, 7 } },
    new int[,] { { 0, 2 }, { 4, 6 }, { 8, 10 } },
    new int[,] { { 11, 22 }, { 99, 88 }, { 0, 9 } }
];

Console.Write("{0}", jaggedArray3[0][1, 0]);
Console.WriteLine(jaggedArray3.Length);




