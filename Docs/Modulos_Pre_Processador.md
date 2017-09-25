InitialPreProcessorCheck
	Checa por erros simples na escrita de diretivas de pré processamento

CheckForPreProcessorDirectives
	Localiza e salva em uma Lista as diretivas encontradas e a linha onde foram achadas

CheckForStrings
	Localiza strings, salva elas em um array de strings no gerenciador de compilação e as substitui por ##str001, etc

CleanBlanks
	Limpa linhas em branco e espaços duplos

CheckAndCreateBlocks
	Checa por blocos de pre processamento (#if - #endif) e os encapsula em seus devidos blocos em modo de árvore (#if fora #if dentro #endif fora #endif). Blocos são definidos no namespace CustomModules

ExecuteBlocks
	Executa os blocos checados e deleta, altera ou adiciona linhas de acordo com a diretiva. Os modulos definidos no CustomModules recebem o bloco de código e trabalham sobre ele. Por exemplo, um módulo customizado #if - #endif recebe o bloco de código entre essa duas diretivas e faz o que deve ser feito, como, por exemplo, excluir o bloco inteiro se a condição for falsa ou apenas manter se for verdadeira

ExecuteDirectives
	Execução de todas as outras diretivas que não de bloco, definidas em CustomModules. Funciona de modo semelhante à anterior

Refresh
	Excluir linhas vazias, por exemplo

Diretiva para impedir um bloco de código de passar por outra etapa??
