class CadastroMarca {
    getDados() {
        var descricao = document.getElementById('descricaoMarca').value;
        if (descricao === "") {
            $('#validaDescricao').html("O campo Descrição é obrigatório")
        } else {
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
 }

var cadastromarca = new CadastroMarca();