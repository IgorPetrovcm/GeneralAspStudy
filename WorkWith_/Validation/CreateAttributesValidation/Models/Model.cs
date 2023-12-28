namespace Models;

using System.ComponentModel.DataAnnotations;

public class ArrayStringAttribut : ValidationAttribute
{
    public override bool IsValid(object val)
    {
        if (val == null)
        {
            ErrorMessage = "Значение пусто";
            return false;
        }
        string[] array = (string[])val;
        foreach (string v in array)
        {
            if (v.Length == 0) 
            {
                ErrorMessage = "Стобец пуст";
                return false;
            }
        }
        
        return true;
    }
} 