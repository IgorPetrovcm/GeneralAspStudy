namespace Alternative.Models
{
    public static class Check
    {
        public static bool IsValid(string[] arr)
        {
            if (arr == null) return false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    return false;
                }
                if (arr[i].Length > 10)
                {
                    return false;
                }
            }
            return true;
        }
    }
}