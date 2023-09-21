# Servico-Desktop-Ligas-Amadoras-De-Futebol

DOCUMENTAÇÃO DE SOFTWARE

Resumo:
Este documento descreve o projeto de desenvolvimento de software para o Sistema de Gestão de Equipes. O sistema permite aos usuários criar, visualizar, pesquisar e excluir equipes. Todos os dados são armazenados em um banco de dados MySQL.

Página 1: Introdução / Objetivos do Projeto / Público Alvo.
Página 2: Requisitos Funcionais / Arquitetura e tecnologias utilizadas / Fluxo de funcionalidades.

Introdução - página 1:
Este documento apresenta o projeto do Sistema de Gestão de Equipes.

Objetivos do Projeto - página 1:

Fornece uma interface amigável para gerenciar equipes.
Habilite a criação, visualização e exclusão de equipes.
Implemente uma funcionalidade de pesquisa para encontrar equipes.
Armazene todos os dados da equipe em um banco de dados MySQL.
Público-alvo – página 1:
Este documento é destinado a desenvolvedores, testadores e qualquer pessoa envolvida no projeto.

Requisitos Funcionais - página 2:

Criação de equipe: permite que os usuários criem novas equipes fornecendo um nome de equipe e outras informações relevantes.
Visualização de equipe: exibe uma lista de todas as equipes existentes com seus detalhes.
Exclusão de equipe: permite que os usuários excluam uma equipe, removendo-a do banco de dados.
Pesquisa de equipe: implemente uma função de pesquisa para encontrar equipes por nome ou outros critérios.
Arquitetura e tecnologias utilizadas - página 2:

O Sistema de Gestão de Equipes foi desenvolvido utilizando as tecnologias: .Net/C#, Windows Form, além de API´s importadas nas classes.
Os dados são armazenados em um banco de dados MySQL para persistência.

Fluxo de funcionalidade - página 2:

Fluxo de criação da equipe:

O usuário acessa a página de criação da equipe.
O usuário insere os detalhes da equipe, incluindo o nome da equipe.
O sistema salva as informações da equipe no banco de dados.
Fluxo de visualização da equipe:

O usuário navega até a página de visualização da equipe.
O sistema recupera e exibe uma lista de todas as equipes.
Fluxo de exclusão de equipe:

O usuário seleciona uma equipe para exclusão.
O sistema confirma a exclusão e remove a equipe do banco de dados.
Fluxo de pesquisa da equipe:

O usuário acessa a página de pesquisa.
O usuário insere critérios de pesquisa (por exemplo, nome da equipe).
O sistema exibe equipes correspondentes com base nos critérios de pesquisa.
Página 3: Diagrama de caso de uso.

Caso de uso - Gerenciamento de equipe:
Descrição: Este caso de uso descreve as principais funcionalidades do Sistema de Gerenciamento de Equipe.

Fluxo geral:

O usuário interage com o sistema para criar, visualizar, excluir e pesquisar equipes.

Tela: 

![Capturar](https://github.com/TheDevCaio/Servico-Desktop-Ligas-Amadoras-De-Futebol/assets/110746976/1af2273b-a5ef-48bc-b8aa-b7529d4c046f)

Imagem do Banco Funcionando: 

![Tela](https://github.com/TheDevCaio/Servico-Desktop-Ligas-Amadoras-De-Futebol/assets/110746976/a69061e9-d4c2-406f-ba59-83098b5980f8)

