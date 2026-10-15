# 📱 Desafio de Programação Orientada a Objetos — .NET

Projeto desenvolvido como parte da **Trilha .NET da Digital Innovation One (DIO)**, com o objetivo de aplicar os principais conceitos de Programação Orientada a Objetos (POO) utilizando C# e .NET.

## 📌 Sobre o projeto

O projeto consiste no desenvolvimento de um sistema de console que simula funcionalidades de smartphones de diferentes fabricantes.

A aplicação utiliza uma classe abstrata chamada `Smartphone`, que define características e comportamentos compartilhados, e duas classes derivadas, `Nokia` e `Iphone`, que implementam comportamentos específicos.

## 🚀 Funcionalidades

- Representação de smartphones de diferentes marcas e modelos.
- Simulação de chamadas telefônicas.
- Simulação do recebimento de ligações.
- Instalação de aplicativos com comportamentos específicos para cada smartphone.
- Exibição de informações dos dispositivos.

## 🛠️ Tecnologias utilizadas

- C#
- .NET 6
- Programação Orientada a Objetos (POO)
- Visual Studio Code
- Git e GitHub

## 🧠 Conceitos aplicados

**Abstração:** utilização da classe abstrata `Smartphone` para representar características e comportamentos comuns.

**Herança:** implementação das classes `Nokia` e `Iphone`, que herdam funcionalidades da classe `Smartphone`.

**Polimorfismo:** sobrescrita do método `InstalarAplicativo()` para permitir comportamentos específicos em cada dispositivo.

**Encapsulamento:** utilização de propriedades e métodos para organizar os dados e comportamentos dos objetos.

## 📂 Estrutura do projeto

```text
trilha-net-poo-desafio/
├── Models/
│   ├── Smartphone.cs
│   ├── Nokia.cs
│   └── Iphone.cs
├── docs/
│   └── README-DIO.md
├── Program.cs
├── DesafioPOO.csproj
└── README.md
```

## ▶️ Como executar

**1. Clone o repositório:**

```bash
git clone https://github.com/jose-nt7/trilha-net-poo-desafio.git
```

**2. Acesse a pasta do projeto:**

```bash
cd trilha-net-poo-desafio
```

**3. Execute a aplicação:**

```bash
dotnet run
```

> O projeto utiliza .NET 6, versão que já encerrou seu período de suporte. Recomenda-se utilizar um ambiente compatível para execução.

## 💻 Exemplo de execução

```text
=== NOKIA ===
Ligando...
Recebendo ligação...
Instalando o aplicativo Instagram no Nokia 3310...
Modelo: Nokia 3310
Número: 123456789
Marca: Nokia
Ano: 2000

=== IPHONE ===
Ligando...
Recebendo ligação...
Instalando o aplicativo WhatsApp no iPhone 12...
Modelo: iPhone 12
Número: 947454825
Marca: Apple
Ano: 2020
```

## 📚 Desafio original

Este projeto foi desenvolvido a partir do desafio educacional disponibilizado pela Digital Innovation One.

A descrição original do desafio foi preservada em [README-DIO.md](docs/README-DIO.md).

## 👨‍💻 Autor

**José Ribeiro**

Desenvolvedor em formação, com foco em desenvolvimento de software, tecnologias .NET e boas práticas de programação.

GitHub: [jose-nt7](https://github.com/jose-nt7)

---

Projeto desenvolvido para fins educacionais e aprimoramento dos conhecimentos em C# e Programação Orientada a Objetos.