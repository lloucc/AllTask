function redirectHome(){
  window.location.href = "http://127.0.0.1:5500/AllTask/front/home-page/html/index.html";
}

document.getElementById("form").addEventListener("submit", function (e) {
  e.preventDefault();

  const daysArray = [];

  if(document.getElementById('domingo').checked === true){
    daysArray.push(0);
  }
  if(document.getElementById('segunda').checked === true){
    daysArray.push(1);
  }
  if(document.getElementById('terça').checked === true){
    daysArray.push(2);
  }
  if(document.getElementById('quarta').checked === true){
    daysArray.push(3);
  }
  if(document.getElementById('quinta').checked === true){
    daysArray.push(4);
  }
  if(document.getElementById('sexta').checked === true){
    daysArray.push(5);
  }
  if(document.getElementById('sabado').checked === true){
    daysArray.push(6);
  }

  const formData = {
    Name: document.getElementById('name').value,
    CategoryId: 1,
    Days: daysArray
  }
  
  sendData(formData)

});

async function sendData(formData){
  await fetch('http://localhost:3532/api/routine', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(formData)
  })
  .then(res => {
    if(res.ok){
      window.location.href = "http://127.0.0.1:5500/AllTask/front/home-page/html/index.html";
    } else {
      alert("Erro ao criar rotina")
    }
  })
}