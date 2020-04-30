class CadastroModelo {
    getDados() {
        var descricao = document.getElementById('descricaoModelo').value;

        var data = {
            "descricao": descricao,
        }

        $.ajax({
            type: 'POST',
            url: '/home/cadastromodelo',
            contentType: 'application/json',
            data: JSON.stringify(data)
        }).done(function (response) {
            alert(response)
            location.reload()

        });
    }
}

var cadastromodelo = new CadastroModelo();