;
var cssCode;
var jsCode;

var frame;


function start() {

     htmlCode = document.getElementById("htmlCode").value;
     cssCode = "<style>" + document.getElementById("cssCode").value + "</style>";
     jsCode = "<scri" + "pt>" + document.getElementById("jsCode").value + "</scri" + "pt>";

     frame = document.getElementById("preview-window").contentWindow.document;

}


function showPreview2() {

    
    frame.open();
    frame.write(htmlCode + cssCode + jsCode);
    frame.close();

}

