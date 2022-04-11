public static int uniqWolfs(List<int> arr)
{
    var uniqList = arr.GroupBy(num => num).OrderBy(num => num.Key).ToList();
    int count = 0;
    int maxFreq = 0;

    foreach(var uniqNum in uniqList){
        int num_count = uniqNum.Count();

        if(num_count > count){
            count = num_count;
            maxFreq = uniqNum.Key;
        }
    }
    return maxFreq;
}