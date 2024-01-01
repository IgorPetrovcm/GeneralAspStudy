namespace ManagingModelBinding.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;


public class User
{
    [BindRequired]
    public int Id {get; set;}

    [BindRequired]
    public string Login {get; set;}

    public string Description {get; set;} = "";

    public string Email {get; set;} = "";

    [BindRequired]
    public bool Has {get; set;}
}