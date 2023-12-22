# First steps study Dependensy Injection

**Dependency injection (DI)** или внедрение зависимостей 
представляет механизм, который позволяет сделать 
взаимодействующие в приложении объекты слабосвязанными. 

Такие объекты связаны между собой через абстракции, 
например, через интерфейсы, что делает всю систему более 
гибкой, более адаптируемой и расширяемой.

# Установка сервисов

Фреймворк **ASP.NET** по умолчанию имеет встроенный контейнер
внедрения зависимостей.
Этот контейнер представлен нам интерфейсом `IServiceProvider`.
Сами зависимости называются **сервисами** 

### Установка внутренних сервисов фреймворка 

За предоставление сервисов в приложении, в классе `WebApplicationBuilder`,
определено свойство `Services` - объект интерфейса `IServiceCollection`,
саму коллекцию сервисов.

`Services` иммет в себе на момент написания, **88** встроенных
сервисов. 

#### Информация о сервисах в IServiceCollection

Каждый сервис в коллекции I`ServiceCollection `является 
объектом класса `ServiceDescriptor`.

Наиболее важные свойства `ServiceDescriptor`:
+ `ServiceType`: тип сервиса
+ `ImplementationType`: тип реализации сервиса
+ `Lifetime`: жизненный цикл сервиса

Получим все сервисы и выведем на страницу их свойства:

Контроллер  `Home`:
```csharp
using System.Collections.Specialized;

namespace MvcApp;
using Microsoft.AspNetCore.Mvc;
using System.Text;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        IServiceCollection services = WebApplication.CreateBuilder().Services;

        StringCollection strCollection = new StringCollection();
        
        foreach (ServiceDescriptor serviceDescript in services)
        {
            strCollection.Add(
                $"{serviceDescript.ServiceType}\t{serviceDescript.ImplementationType}\t{serviceDescript.Lifetime}");
        }

        ViewBag.Message = strCollection;
        return View();
    }
}
```
Представление `Index`:
```cshtml
@using System.Collections.Specialized
@using System.Text;
<!doctype html>
<html>
<head>
    <meta charset="UTF-8"/>
    <title>Dependency Injection Services</title>
</head>
<body>
@{
    StringCollection str = ViewBag.Message;
    foreach (string line in str)
    {
        <p>line</p>
    }
}
</body>
</html>
```