
# Introdução ao .NET

### Diferença entre .NET e C#

O .NET e o C# estão intimamente ligados, mas existem diferenças entre estes termos, pois eles tratam de coisas distintas que são utilizadas juntas.  
O **.NET** é uma plataforma de desenvolvimento unificado que permite construir diferentes tipos de aplicações. O **C#** é uma linguagem de programação utilizada no .NET.  
O .NET não é uma linguagem de programação. Ele abrange várias linguagens e ferramentas, que permitem construir aplicações de tipos variados, incluindo:

| Tipo de Aplicação | Ferramentas |
|:--:|:--:|
| Desktop | WPF / Windows Forms / UWP |
| Web | ASP.NET |
| Cloud | Azure |
| Mobile | Xamarin |
| Games | Unity |
| IoT | ARM32 / ARM64 |
| AI | ML.NET / .NET for Apache Spark |

O .NET fornece diversas bibliotecas que facilitam construir aplicativos com essas soluções, fornecendo uma base para que estes aplicativos sejam criados. Ele abstrai e prepara o ambiente para facilitar a construção do aplicativo sem precisar implementar a solução do zero.

As ferramentas que podem utilizar o .NET incluem:

- Visual Studio
- Visual Studio for Mac
- Visual Studio Code
- Command Line Interface

E as linguagens que podem ser utilizadas no .NET são:

- C#
- F#
- Visual Basic

O C# é uma parte do ecossistema do .NET. Ele é uma das linguagens de programação utilizada para o desenvolvimento de aplicativos usando as ferramentas, bibliotecas e infraestrutura do .NET.

# História do .NET

O .NET foi criado com o objetivo principal de competir com o Java. Na época de sua criação, em 2002, o conceito de multiplataforma era muito importante no mundo da tecnologia, e o Java foi pioneiro neste conceito com o uso da JVM, o que revolucionou a área e fez o Java ganhar muita popularidade.  
Com isso, a Microsoft queria implementar esse conceito no Windows. Assim surgiu o .NET Framework, criado com a ideia de ser uma alternativa multiplataforma do Windows. Porém, diferente do Java que rodava em qualquer plataforma, o .NET era amarrado ao Windows, e servia principalmente para facilitar o desenvolvimento de aplicativos no Windows.

### Linha do Tempo do .NET

- 1998 - Início do desenvolvimento do .NET
	- Windows XP
- 2002 - .NET 1.0 / C# 1.0 / Visual Studio .NET 2002
- 2005 - .NET 2.0 / C# 2.0
- 2004 - Mono 1.0
- 2006 - .NET 3.0
- 2007 - .NET 3.5 / C# 3.0
	- 2009 - Windows 7
- 2010 - .NET 4.0 / C# 4.0
- 2011 - Mono para Android / Xamarin foi fundado
- 2012 - .NET 4.5 / C# 5.0
- 2014 - Fundação da .NET Foundation
	- 2015 - Windows 10
- 2015 - C# 6.0 / Visual Studio Code 1.0
- 2016 - Xamarin comprado pela Microsoft / .NET Core 1.0 / .NET 4.6.2 / .NET Standard 1.0
- 2017 - .NET 7.0 / C# 7.0 
- 2018 - Github adquirido pela Microsoft
- 2019 - .NET 4.8 (Final) / C# 8.0 / .NET Core 3.0
- 2020 - .NET 5 (Core) / C# 9.0
- 2021 - .NET 6 / C# 10.0

### Diferença entre .NET Framework e .NET (Ou .NET Core)

O .NET Framework é a versão legado que só funciona em Windows.  
O .NET é a versão atual que é multiplataforma. (Anteriormente chamada de .NET Core)

O .NET atual foi feito reescrito do zero, pensado para funcionar em qualquer plataforma, sem precisar necessariamente do Windows. O .NET Framework é integrado com o Windows, portanto ele não funciona em outras plataformas.  
As maiores vantagens de utilizar o .NET Core, por ser multiplataforma, são a facilidade de desenvolver aplicativos para vários sistemas e o barateamento do custo dos servidores, pois os aplicativos podem ser instalados em um servidor Linux, assim não sendo necessário comprar uma licença do Windows.

### Mudanças no .NET Core

A versão .NET 5 é uma versão que trouxe diversas mudanças na plataforma .NET. Ela é uma nova versão do .NET Core, que foi lançada depois do .NET Core 3.1, e também levou ao .NET Framework ser descontinuado.  
A partir desta versão, o .NET Core, agora chamado apenas de .NET, passa a ser a versão oficial da plataforma .NET, e ele foi lançado diretamente na versão 5 para não confundir com o .NET Framework, que tem como sua versão final o .NET Framework 4.8.