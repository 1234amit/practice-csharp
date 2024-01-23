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

///array code start here

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



