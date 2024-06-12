// dataset
List<int> numbers = [17, 166, 288, 324, 531, 792, 946, 157, 276, 441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227, 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396, 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784, 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450, 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150];

while (true)
{
    Console.Write("Choose between Basic search(1), Range Search(2) and Exit(3): ");
    string? str = Console.ReadLine();
    if (int.Parse(str) == 3 || str.ToLower() == "exit")
    {
        Console.WriteLine("done");
        break;
    }
    else if (str.ToLower() == "basic" || str.ToLower() == "basic search" || int.Parse(str) == 1)
    {
        Console.Write("Enter an Integer: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (numbers.Contains(num))
            {
                int indexnum = numbers.IndexOf(num);
                Console.WriteLine($"The integer {num} is found at index {indexnum}. ");
            }
            else
            {
                Console.WriteLine($"The integer {num} is not found. ");
            }
        }
        catch 
        {
            Console.WriteLine($"The input is not a numeric value!");
        }
    }

    // range sreach 

    else if (str.ToLower() == "range" || str.ToLower() == "range search" || int.Parse(str) == 2)
    {
        Console.Write("Enter the lower bound: ");
        string? strlow = Console.ReadLine();
        int low = 0;
        if (string.IsNullOrEmpty(strlow))
        {
            low = numbers.Min();
        } 
        else
        {
            try
            {
                low = int.Parse(strlow);   
            }
            catch { Console.WriteLine($"The input is not a numeric value!"); }
        }
        Console.Write("Enter the higher bound: ");
        string? strhigh = Console.ReadLine();
        int high = 0;
        if (string.IsNullOrEmpty(strhigh))
        {
            high = numbers.Max();
        }
        else
        {
            try
            {
                high = int.Parse(strhigh);
            }
            catch { Console.WriteLine($"The input is not a numeric value!"); }
        }
        List<int> range = new List<int>();
        foreach (int i in numbers)
        {
            if (i >= low && i <= high)
            {
                range.Add(i);
            }
        }
        int numRange = range.Count;
        range.Sort();
        string strRange = string.Join(", ", range);
        Console.WriteLine($"The search found {numRange} integers greater than {low} and less than {high}. ther are: {strRange}");
    }
}