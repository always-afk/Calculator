function HistoryClick(e) {
    var resText = e.textContent;
    var resTextParts = resText.split(" ");

    var ftext = document.ClientIn.fnum;
    ftext.value = resTextParts[4];
    var stext = document.ClientIn.snum;
    stext.value = resTextParts[4];
}