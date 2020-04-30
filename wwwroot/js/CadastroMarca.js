class CadastroMarca {
    getDados() {
        var descricao = document.getElementById('descricaoMarca').value;
            
        var data = {
            "descricao": descricao,
        }

        $.ajax({
            type: 'POST',
            url: '/home/cadastromarca',
            contentType: 'application/json',
            data: JSON.stringify(data)
        }).done(function (response) {
            alert(response)
            location.reload()

        });
    }

 }

var cadastromarca = new CadastroMarca();