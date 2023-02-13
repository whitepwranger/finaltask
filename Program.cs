// add branch main
string[] arr = {"12323","ta", "cat", "1", "Hellow"};
string[] arr_result = new string[arr.Length]; 
string result = "";
for(int i = 0, j = 0; i < arr.Length; ++i){
    if(arr[i].Length < 4){
        arr_result[j] = arr[i];
        Console.Write(arr[i] + " ");
    }
}
Console.WriteLine(result);