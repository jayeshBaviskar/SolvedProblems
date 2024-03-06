// See https://aka.ms/new-console-template for more information
//https://www.geeksforgeeks.org/program-to-reverse-an-array/



/*   LOGIC

Just navigate till array length /2 and swap the  element located at length - current index, with the current one

*/

string[] a = {"1", "2" , "3" , "4" , "5", "6"};

string[] result = ReverseArray(a);

foreach (var item in result)
{
    Console.Write(item + " ");
}


string[] ReverseArray(string[] arr){
    for (int i = 0; i < arr.Length / 2 ; i++)
    {
        string temp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = temp;
    }

return arr;
}
