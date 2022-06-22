﻿

function meu_callback(conteudo) {

    if (!("erro" in conteudo)) {

        //Atualiza os campos com os valores.

        document.getElementById('NomeRua').value = (conteudo.logradouro);

        document.getElementById('Bairro').value = (conteudo.bairro);

        document.getElementById('Cidades').value = (conteudo.localidade);

        document.getElementById('Estados').value = (conteudo.uf);

    } //end if.

    else {

        //CEP não Encontrado.

        limpa_formulario_cep();

        alert("CEP não encontrado.");

        document.getElementById('Cep').value = ("");

    }

}

function pesquisacep(valor) {
    //Nova variável "cep" somente com dígitos.
    var cep = valor.replace(/\D/g, '');
    //Verifica se campo cep possui valor informado.

    if (cep !== "") {
        //Expressão regular para validar o CEP.
        var validacep = /^[0-9]{8}$/;
        //Valida o formato do CEP.

        if (validacep.test(cep)) {
            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('NomeRua').value = "...";
            document.getElementById('Bairro').value = "...";
            document.getElementById('Cidades').value = "...";
            document.getElementById('Estados').value = "...";


            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            script.src = '//viacep.com.br/ws/' + cep + '/json/?callback=meu_callback';
            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);
        }
        //end if.

        else {
            //cep é inválido.
            limpa_formulario_cep();
            alert("Formato de CEP inválido.");
        }

    }
    //end if.

    else {
        //cep sem valor, limpa formulário.
        limpa_formulario_cep();
    }

}
