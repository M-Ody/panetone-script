# Fases da compilação do PanetoneScript
A compilação do PanetoneScript é dividida em 4 etapas, todas elas com uma certa independência e funções específicas em relação às outras, de modo que uma parte pode ser alterada sem quebrar o restante.
São elas:

### 1. Carregamento e leitura
Carrega todos os arquivos de texto com a extensão **_.panetone_** localizados em uma certa pasta definida como a pasta de leitura. 
Sua função é carregar os arquivos que sofreram alteração desde a última compilação e guardá-los na memória.
Também faz a leitura dos arquivos e os carrega em objetos.

### 2. Pré-processamento
Nessa etapa, o código lido é limpo de **comentários** e **linhas em branco**. Eventuais chamadas de **pré-processamento** também são executadas aqui, 

### 3. Interpretação de sintaxe básica
Aqui a estrutura básica do código escrito em **PanetoneScript** é traduzido para **C#**. Nessa etapa são inseridas as **chaves**, as expressões **if**, **else** e afins.
### 4. Lincagem
Nessa etapa, os **eventos** são lincados entre si, assim como os **gameObjects** e **prefabs**. O código gerado para buscar a referência desses objetos também é criado nessa etapa.
### 5. Interpretação de métodos
Aqui é feita a leitura dos **métodos customizados**, que são adicionados ao ambiente do PanetoneScript por meio de **módulos**. São esses métodos que serão responsáveis pelas **ações** e **condições** dos eventos.
### 6. Integração com a engine
Nessa etapa o código gerado é **injetado** dentro da Unity e seus designados objetos.
### 7. Compilação
Por fim, o código é **compilado** junto com o resto do código C#, agindo como qualquer outro código escrito.
