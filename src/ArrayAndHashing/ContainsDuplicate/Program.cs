var numbers = new[] { 1, 2, 45, 2, 21, 6 };
var numbers2 = new[] { 1, 2, 4, 5, 6, 7 };

Console.WriteLine(CheckDuplicate(numbers2));

static bool CheckDuplicate(int[] numberList) 
{
    var set = new HashSet<int>();

    foreach(var item in numberList)
    {
        // Add method will return false, if element already exists in given set.
        // If found then we know there is already a duplicate element.
        if(!set.Add(item)) 
        {
            return true;
        }
    }

    return false;
}