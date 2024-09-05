const container = document.getElementById("main-content");

function redirectAddRoutine(){
  window.location.href = "http://127.0.0.1:5500/AllTask/front/add-page/html/index.html";
}

window.onload = getRoutines();

async function getRoutines(){
  const res = await fetch('http://localhost:3532/api/routine', {
    method: "GET"
  })
  let data = await res.json();
  console.log(data);
  data.forEach(e => {
    container.innerHTML += `<div class="block-container">
    <div class="text-container">
        <div class="text-group">
          <h2>${e.name}</h2>
        </div>
        <div class="text-group">
          <p class="category">${e.category.name}</p>
        </div>
        <div class="text-group">
          <p>Detalhes:</p>
          <span>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Possimus corporis, architecto...</span>
        </div>
      </div>
  </div>`
  });

  return data;
}

