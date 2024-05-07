# DIO - Trilha .NET - ProgramCriação do projeto da DIO
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
# Projeto de Modelagem de Celulares

Este projeto é um exemplo de modelagem de um sistema que trabalha com celulares, implementado em .NET utilizando o conceito de orientação a objetos. Consiste em uma aplicação do tipo console que simula interações básicas com dois tipos de celulares: Nokia e iPhone.

## Estrutura do Projeto

### 1. **Program.cs**
Este arquivo contém o método principal `Main`, responsável pela execução da aplicação. Nele, são instanciados objetos dos tipos Nokia e iPhone e realizadas interações com eles, como ligar, instalar aplicativos e receber chamadas.

### 2. **Models/Nokia.cs**
A classe `Nokia` representa um modelo de celular da marca Nokia. Ela herda da classe abstrata `Smartphone` e implementa o método abstrato `InstalarApp`, que permite instalar aplicativos específicos para esse modelo de celular.

### 3. **Models/Iphone.cs**
A classe `Iphone` representa um modelo de celular da marca iPhone. Assim como a classe `Nokia`, ela herda da classe abstrata `Smartphone` e implementa o método abstrato `InstalarApp`, com uma lógica específica para instalação de aplicativos no iPhone.

### 4. **Models/Smartphone.cs**
A classe abstrata `Smartphone` serve como modelo genérico para todos os tipos de celulares. Ela define propriedades e métodos comuns a todos os celulares, como número, modelo, IMEI, memória, ligar, receber ligação, entre outros. Além disso, contém o método abstrato `InstalarApp`, que deve ser implementado nas classes filhas.

## Execução do Programa
Para executar o programa, basta abrir o arquivo `Program.cs` em um ambiente de desenvolvimento .NET e compilar o projeto. Após a compilação, o programa será executado e você poderá interagir com os celulares Nokia e iPhone conforme as instruções apresentadas no console.

O projeto completo está disponível [aqui](https://github.com/seu-usuario/seu-repositorio) para que você possa estudar e fazer suas próprias implementações.

---
