window.onload = function() {
    code = this.localStorage.getItem("stockCode")
    kind = this.localStorage.getItem("stockKind")
    codeNode = document.querySelector("#code")
    kindNode = document.querySelector("#kind")
    codeNode.value = code
    kindNode.value = kind
}