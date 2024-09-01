const container = document.getElementById("main-content");


for (let i = 0; i < 15; i++) {
  container.innerHTML += `<div class="block-container">
  <div class="text-container">
      <div class="text-group">
        <h2>Titulo</h2>
      </div>
      <div class="text-group">
        <p class="category">Categoria1</p>
        <p class="category">Categoria1</p>
        <p class="category">Categoria</p>
      </div>
      <div class="text-group">
        <p>Detalhes:</p>
        <span>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Possimus corporis, architecto...</span>
      </div>
    </div>
</div>`;
}