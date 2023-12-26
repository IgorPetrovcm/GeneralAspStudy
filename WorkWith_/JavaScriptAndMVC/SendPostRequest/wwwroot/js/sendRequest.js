function sendRequest1()
{
    let data = {value:'Hello user'};

    fetch('http://localhost:5032/Home/Index', {
        method: 'POST',
        headers: 
        {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    })
    .then(response => response.json()) 
    .then(response_data => { console.log(response_data);
    })
    .catch(error => {console.log(error); });
}

var textInput = document.getElementById('text_input');

var btn = document.getElementById('btn1');

btn.addEventListener('click',sendRequest1)
