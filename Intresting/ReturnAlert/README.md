# Вывести Alert-сообщение прямо из MVC-контроллера сервера

Чтобы вызвать **alert** сообщение из контроллера на странице, можно передать в представление сообщение со скриптом:
```csharp
public IActionResult Index() 
{
        ViewBag.Message = "<script> alert('Okay') </script>";

        return View();
}
```

В представлении, с помощью движка **Razor** обработаем сообщение, использую метод `Raw`, класса `Html`:

```html 
<body>
        @Html.Raw(ViewBag.Message);
</body>
```