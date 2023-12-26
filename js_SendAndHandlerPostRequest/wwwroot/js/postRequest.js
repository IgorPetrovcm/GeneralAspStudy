function sendRequest() 
{
JQuery.ajax({
    dataType: "json",
    type: "POST",
    url:"http://localhost:5092/Home/Index",
    data: {value: "testRequest"}
})
}
document.getElementById('btn1').addEventListener('click',sendRequest);