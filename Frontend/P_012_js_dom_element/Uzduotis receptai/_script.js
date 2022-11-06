function changeRecipeToTinginys() {
    const list_of_ol = document.getElementsByClassName('recipe tinginys')
    for (const ol of list_of_ol) {
        if(ol.classList.contains("recipe kakava"))
        ol.classList.remove("recipe tinginys2")
        else {
            li.classList.add('recipe tinginys2')
        }
    }
}