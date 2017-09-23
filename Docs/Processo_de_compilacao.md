# Fases da compila��o do PanetoneScript
A compila��o do PanetoneScript � dividida em 4 etapas, todas elas com uma certa independ�ncia e fun��es espec�ficas em rela��o �s outras, de modo que uma parte pode ser alterada sem quebrar o restante.
S�o elas:

### 1. Carregamento e leitura
Carrega todos os arquivos de texto com a extens�o **_.panetone_** localizados em uma certa pasta definida como a pasta de leitura. 
Sua fun��o � carregar os arquivos que sofreram altera��o desde a �ltima compila��o e guard�-los na mem�ria.
Tamb�m faz a leitura dos arquivos e os carrega em objetos.

### 2. Pr�-processamento
Nessa etapa, o c�digo lido � limpo de **coment�rios** e **linhas em branco**. Eventuais chamadas de **pr�-processamento** tamb�m s�o executadas aqui, 

### 3. Interpreta��o de sintaxe b�sica
Aqui a estrutura b�sica do c�digo escrito em **PanetoneScript** � traduzido para **C#**. Nessa etapa s�o inseridas as **chaves**, as express�es **if**, **else** e afins.
### 4. Lincagem
Nessa etapa, os **eventos** s�o lincados entre si, assim como os **gameObjects** e **prefabs**. O c�digo gerado para buscar a refer�ncia desses objetos tamb�m � criado nessa etapa.
### 5. Interpreta��o de m�todos
Aqui � feita a leitura dos **m�todos customizados**, que s�o adicionados ao ambiente do PanetoneScript por meio de **m�dulos**. S�o esses m�todos que ser�o respons�veis pelas **a��es** e **condi��es** dos eventos.
### 6. Integra��o com a engine
Nessa etapa o c�digo gerado � **injetado** dentro da Unity e seus designados objetos.
### 7. Compila��o
Por fim, o c�digo � **compilado** junto com o resto do c�digo C#, agindo como qualquer outro c�digo escrito.
