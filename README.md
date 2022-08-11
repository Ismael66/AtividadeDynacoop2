# AtividadeDynacoop02
Lucas Albertim Barbosa Rodrigues
Criação do plugin: Plugin que realiza a verificação se já existe CPF cadastrado na entidade de contato.

Adicionando o campo foi contexto atual na variável cpf, para aí podermos fazer a verificação se o estágio que o contexto está rodando é o de pre validation, essa condição sendo verdadeira ele vai fazer uma busca na entidade contato e guardar o campo onde o cpf do contexto seja igual ao cpf existente no ambiente. 
Foi feita a condição que caso essa busca retorne resultado maior que 0, ele vai disparar a mensagem impedindo salvar o registro, caso não tenha ele vai continuar o salvamento do registro. 

Luiz Venuto
Criação da solução, tabela e campos no dynamics e criação do fluxo da action.

Foi criada uma Coluna com o nome “Nível do Cliente” do tipo LookUp na tabela “Conta”, uma tabela na solução chamada “Nível do Cliente” onde possui um campo para adicionar qual nível do cliente entra as opções de:  Silver, Gold, Platinum e Diamond do tipo texto, um campo para as respectivas porcentagens com o tipo decimal e um campo “Frete Grátis” na tabela “Nível do Cliente” do tipo opção sim ou não.
No Power Automate foram criadas duas etapas:
A primeira etapa foi usada à operação de Gatilho Microsoft Dataverse (Quando uma linha é adicionada, modificada ou excluída), o tipo de alteração usado foi o Criar, o nome da tabela para identificar foi a “Oportunidades” e o escopo Organization.
Na Segunda etapa foi usada à operação de ação Microsoft Dataverse (Executar uma ação associada), o nome da tabela para identificar foi a “Oportunidades”, o nome da ação new_ActionOportunidadeDynacoop e o ID de Linha o id da oportunidade criado.

Ismael Mateus de Souza
Criação da Action: Action que busca na conta o nível do cliente e preenche o campo “porcentagem de desconto” na tabela de Oportunidades.

Para criação da Action implementei uma classe criada em aula chamada Action Implemet que tem o objetivo de tornar a Action mais organizada e limpa.
Na Action utilizei uma requisição Fetch capaz de adentrar a conta principal da oportunidade criada, e nela adentrar a tabela de Nível de Cliente em busca da porcentagem de desconto escolhida. Afim de que, usando essa informação seja possível modificar o valor da coluna porcentagem de desconto na tabela Oportunidade.
Depois da criação registrei o assembly da action no programa XRMToolbox e criei também um processo do tipo action nas configurações avançadas do dynamics para ligação da action.
