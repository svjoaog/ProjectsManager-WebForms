
# Gestão de Projetos FUNDEP

Aplicação WEB para cadastro e listagem de projetos utilizando ASP.NET WebForms.




## Funcionalidades

- Cadastrar novos projetos com os atributos: 
    - Número do projeto;
    - Número do subprojeto;
    - Nome do projeto;
    - Nome do coordenador do projeto;
    - Saldo do projeto.


- Listar projetos ja existentes em formato tabela
    
    - Dados são carregados a partir do arquivo XML via serviço WCF.



Regras:

- Nenhum campo pode ser vazio ou nulo;
- Projetos com mesmo número não são permitidos







## Stack utilizada

ASP.NET Web Forms

.NET Framework 4.8

WCF (Windows Communication Service)

XML para persistencia de dados

IDE Visual Studio Community 2026






## Arquitetura

O projeto foi feito utilizando arquitetura em camadas:

- Fundep.Gestao.Projeto.Web aplicando as interfaces de interação (UI) para usuário e consumindo o serviço WCF para operações com dados.

- O serviço WCF ProjectsWcfServiceLibrary é responsável pela implementação dos services que interage diretamente com o arquivo XML (persistencia de dados).





## Compilando a solução

#### Pré-requisitos
    1. Windows
    2. Visual Studio 2026 (ASP.NET e .NET Framework 4.8)
    3. ISS Express

#### Passo a Passo
    1. Clonar o repositório: git clone https://github.com/svjoaog/ProjectsManager-WebForms.git

    2. Abrir a solução Fundep.Gestao.Projeto.Web.slnx localizada na raiz do projeto utilizando Visual Studio
    
    3. Restaurar pacotes NuGet (Clicar com botão direito na solução)

    4. Compilar (Crtl + Shift + B) e Executar (F5)




    


## Decisões

- O projeto inicialmente foi feito sem a utilização do serviço WCL a fim de entender seu funcionamento mais profundamente e para uma visualização do projeto a curto prazo. Depois do entendimento do serviço, foi feito o refatoramento do código e limpeza das pastas que não eram mais necessárias para o projeto (commit: refactor: remove web dependecy from service library);


## Aprendizados

Já possuia certo conhecimento em ASP.NET e WebForms para desenvolvimento de páginas web. Nesse projeto foi possivel compreender as caracteristicas e funcionalidades do WCF, servindo para separar camadas de interface e regras de negócio. Ele auxilia em reutilização, na manutenção e escalabilidade do projeto. 


## Autor
 
**João Vitor Gonçalves**

Projeto desenvolvido para avaliação técnica e aprendizado.

