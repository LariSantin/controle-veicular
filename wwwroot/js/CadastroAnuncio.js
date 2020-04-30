class CadastroAnuncio{
    getDados() {
        var ano = document.getElementById('ano').value;
        var valorVenda = document.getElementById('valorVenda').value;
        var valorCompra = document.getElementById('valorCompra').value;
        var descricao = document.getElementById('descricao').value;
        var codigo = document.getElementById('codigo').value;
        var cor = document.getElementById('cor').value;
        var tipoCombustivel = document.getElementById('tipoCombustivel').value;
        var dataVenda = document.getElementById('dataVenda').value;
        var marca = document.getElementById('SelectMarca').value;
        var modelo = document.getElementById('SelectModelo').value;

        var data = {
            "codigo": codigo,
            "descricao": descricao,
            "dataVenda": dataVenda,
            "cor": cor,
            "valorCompra": valorCompra,
            "valorVenda": valorVenda,
            "ano": ano,
            "tipoCombustivel": tipoCombustivel,
            "idmarca": marca,
            "idmodelo": modelo
        }

        $.ajax({
            type: 'POST',
            url: '/home/cadastroanuncio',
            contentType: 'application/json',
            data: JSON.stringify(data)
        }).done(function (response) {
            alert(response)
            location.reload()

        });
        
    }

    carregarMarcas() {
        $.ajax({
            url: '/home/buscamarcas',
            type: 'GET',
            contentType: 'application/json',
        }).done(function (response) {
            console.log(response)
            var selectMarca = document.getElementById('SelectMarca');
            $(selectMarca).children().remove();
            $.each(response, function (index) {
                var option = new Option(response[index].descricao, response[index].id);
                $(selectMarca).append(option);
            });
        });
    }

    carregarModelos() {
        $.ajax({
            url: '/home/buscamodelos',
            type: 'GET',
            contentType: 'application/json',
        }).done(function (response) {
            console.log(response)
            var selectModelo = document.getElementById('SelectModelo');
            $(selectModelo).children().remove();
            $.each(response, function (index) {
                var option = new Option(response[index].descricao, response[index].id);
                $(selectModelo).append(option);
            });
        });
    }
}

var cadastroaanuncio = new CadastroAnuncio();

$("#dataVenda").keydown(function () {
    $("#dataVenda").mask("99/99/9999")
});

