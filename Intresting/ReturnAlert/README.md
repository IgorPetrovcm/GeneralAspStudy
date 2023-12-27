# Вывести Alert-сообщение прямо из MVC-контроллера сервера

Чтобы вызвать `alert` сообщение, достаточно вписать в представление(с помощью `ViewData`) строку 
```csharp
("<script> alert(...) </script>")
```

В моем случае так:
```csharp
 [HttpGet]
    public async Task Index() {
        await Response.WriteAsync(@"<!doctype html>
        <head> <meta charset=""utf-8""/>
                <title>Hello</title>
        </head>
        <body>
                <script> alert('Okay') </script>
        </body>
        ");
    }
``` 