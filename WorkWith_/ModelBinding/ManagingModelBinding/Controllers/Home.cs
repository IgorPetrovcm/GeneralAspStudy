namespace ManagingModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ManagingModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;


public class Home : Controller
{
    public string Index(User user)
    {
        if (ModelState.IsValid)
        {
            return $"Id: {user.Id}; Login: {user.Login}; Description: {user.Description}; Email: {user.Email}; Has: {user.Has}";
        }
        else 
        {
            StringBuilder str = new StringBuilder();

            str.Append("Error count: " + ModelState.ErrorCount + "\n");

            foreach (var errorPair in ModelState.Keys)
            {
                str.Append(errorPair);
            }

            return str.ToString();
        }
    }
}