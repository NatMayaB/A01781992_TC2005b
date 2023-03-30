//EJERCICIO 3
const sampleTable = document.getElementById("sampleTable");
const btnInsertRow = document.getElementById("btn-insert-r");
const btnInsertColumn = document.getElementById("btn-insert-c");

btnInsertRow.addEventListener("click", () => {
    const newRow = sampleTable.insertRow();
    const newCell1 = newRow.insertCell();
    const newCell2 = newRow.insertCell();
    newCell1.innerHTML = "New row column 1";
    newCell2.innerHTML = "New row column 2";
});

btnInsertColumn.addEventListener("click", () => {
    const rows = sampleTable.getElementsByTagName("tr");
    for (let i = 0; i < rows.length; i++) {
        const newCell = rows[i].insertCell();
        newCell.innerHTML = `New column ${i + 1}`;
    }
});

//EJERCICIO 4
//obtener la tabla y los inputs
const table = document.getElementById("myTable");
const rowIndex = document.getElementById("rowIndex");
const colIndex = document.getElementById("colIndex");
const newValue = document.getElementById("newValue");
const changeBtn = document.getElementById("btn-change");

//agregar un event listener al botón
changeBtn.addEventListener("click", function() {
//convertir los valores de las entradas a números enteros
    const r = parseInt(rowIndex.value);
    const c = parseInt(colIndex.value);
//verificar que los valores son válidos
    if (r >= table.rows.length || c >= table.rows[0].cells.length) {
        alert("Invalid index!");
        return;
    }
//actualizar el contenido de la celda seleccionada
    table.rows[r].cells[c].innerHTML = newValue.value;
});



