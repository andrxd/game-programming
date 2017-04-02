$(document).ready(function () {

    $("#btnPessoa").live("click", function () {
        var pessoa = {};
        pessoa.nome = "Mumbai";
        pessoa.idade = 5;
        $.ajax({
            type: 'POST',
            url: 'wsJSON.asmx/TestePessoa',
            data: "{pessoa:" + JSON.stringify(pessoa) + "}",
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (r) {
                debugger;
                alert(r.d.nome);
                alert(r.d.idade);
            }
        });
    });

})