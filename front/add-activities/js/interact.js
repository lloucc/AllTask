// Função para adicionar tarefas
function Add_Task(element){
    var task_add = element.closest(".day");

    var num_add = Number(task_add.querySelector(".add_num").value) || 1;    

    for (let i = 0; i < num_add; i++) {
        // Criando todos os elementos da tarefa
        var tsk_cont = document.createElement("div");
        tsk_cont.setAttribute("class", "tasks-container");

        var chck_cont = document.createElement("div");
        chck_cont.setAttribute("class", "checkbox-container");

        var smp_chck = document.createElement("label");
        smp_chck.setAttribute("class", "simple-checkbox");

        var chck = document.createElement("input");
        chck.setAttribute("type", "checkbox");

        var chck_mk = document.createElement("span");
        chck_mk.setAttribute("class", "checkmark");

        var tsk_tx = document.createElement("div");
        tsk_tx.setAttribute("class", "tasks-text");

        // Criando os parágrafos diretamente
        let p1 = document.createElement('p');
        p1.textContent = "Tarefa";

        let p2 = document.createElement('p');
        p2.textContent = "Dificuldade";

        let p3 = document.createElement('p');
        p3.textContent = "Tempo";

        let p4 = document.createElement('p');
        p4.textContent = "-";
        p4.setAttribute("class","icon_-");
        p4.setAttribute("onclick","Delet_Task(this)");

        //Adicionando Elementos ao 'day'
        tsk_tx.appendChild(p1);
        tsk_tx.appendChild(p2);
        tsk_tx.appendChild(p3);
        tsk_tx.appendChild(p4);

        smp_chck.appendChild(chck);
        smp_chck.appendChild(chck_mk);

        chck_cont.appendChild(smp_chck);

        tsk_cont.appendChild(chck_cont);
        tsk_cont.appendChild(tsk_tx);

        task_add.appendChild(tsk_cont);
    }
} 

function Delet_Task(task){
    var tsk_cont = task.closest(".tasks-container");
    tsk_cont.remove();
}
