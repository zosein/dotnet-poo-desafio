## Desafio de projeto
Para este desafio, foram utilizados os conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Foram criadas as classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
- A classe Smartphone é abstrata, não permitindo instanciá-la diretamente.
- As classes Nokia e iPhone herdam da classe Smartphone e implementam o método InstalarAplicativo() de forma específica para cada marca.
- O programa principal cria instâncias de Nokia e iPhone e chama o método InstalarAplicativo() para cada um, demonstrando o comportamento individual de cada marca..

Benefícios da Orientação a Objetos:
- A classe Smartphone é abstrata, não permitindo instanciá-la diretamente.
- As classes Nokia e iPhone herdam da classe Smartphone e implementam o método InstalarAplicativo() de forma específica para cada marca.
- O programa principal cria instâncias de Nokia e iPhone e chama o método InstalarAplicativo() para cada um, demonstrando o comportamento individual de cada marca.
