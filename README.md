# AgarioModified

![.NET 6.0](https://img.shields.io/badge/.NET-6.0-blue) ![C#](https://img.shields.io/badge/Language-C%23-blueviolet) ![WinForms](https://img.shields.io/badge/UI-WinForms-lightgrey) ![MIT License](https://img.shields.io/badge/License-MIT-lightgrey)

> Versão desktop modificada do jogo **Agar.io**, desenvolvida em C# com WinForms, adicionando controles via teclado e customização de skins.

---

## 📚 Sumário

- [Sobre o Projeto](#sobre-o-projeto)
- [Tecnologias](#tecnologias)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Uso](#uso)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Contribuindo](#contribuindo)
- [Licença](#licença)
- [Autor](#autor)

---

## 💡 Sobre o Projeto

O **AgarioModified** é uma aplicação WinForms em C# que emula a jogabilidade do **Agar.io** na sua máquina local, oferecendo:

- **Controles por teclado** (setas ou WASD) para movimentar a célula do jogador.
- **Suporte a skins customizadas**, permitindo alterar seu visual via arquivos de imagem.
- **Log de pontuação** e comportamento de colisão entre células.

Este projeto serve como base para estudos de manipulação gráfica em GDI+ e lógica de jogos multiplayer simples.

---

## 🚀 Tecnologias

| Componente    | Tecnologia                          |
|---------------|-------------------------------------|
| Framework     | .NET 6.0                            |
| Linguagem     | C# / .NET                           |
| UI            | Windows Forms (WinForms)            |
| Bibliotecas   | System.Drawing, System.Windows.Forms |

---

## ✅ Pré-requisitos

- Windows 10 ou superior
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Visual Studio 2022 ou equivalente com suporte a WinForms

---

## 🛠️ Instalação

```bash
# 1. Clone o repositório
git clone https://github.com/pepes1234/AgarioModified.git
cd AgarioModified
# 2. Abra a solução no Visual Studio
double-click AgarioModified.sln
```

---

## ▶️ Uso

1. Defina **AgarioModified** como projeto de inicialização no Visual Studio.
2. Pressione **F5** ou **Run** para compilar e executar.
3. Na aplicação:
   - Use **setas** ou **WASD** para mover sua célula.
   - Carregue skins na pasta `Skins/` (formato `.png`) e selecione no menu de opções.

---

## 🗂️ Estrutura do Projeto

```plain
AgarioModified/
├── AgarioModified.sln        # Solução do Visual Studio
├── AgarioModified/           # Projeto WinForms
│   ├── Program.cs            # Ponto de entrada
│   ├── MainForm.cs           # Lógica de UI e game loop
│   ├── MainForm.Designer.cs  # Designer WinForms
│   ├── Game.cs               # Lógica de jogo (movimentação, colisão)
│   ├── SkinManager.cs        # Carregamento e aplicação de skins
│   ├── Skins/                # Pasta para arquivos de imagem de skins
│   ├── Resources/            # Assets adicionais (sons, imagens)
│   └── app.config            # Configurações do projeto
├── .gitignore
├── LICENSE
└── README.md                 # Este documento
```

---

## 🤝 Contribuindo

1. Faça um **fork** deste repositório.
2. Crie uma branch:  
   ```bash
git checkout -b feature/minha-feature
```  
3. Commit suas alterações:  
   ```bash
git commit -m "feat: descrição da feature"
```  
4. Push para seu fork:  
   ```bash
git push origin feature/minha-feature
```  
5. Abra um **Pull Request**.

---

## 📄 Licença

Este projeto está sob a **MIT License**. Veja o arquivo [LICENSE](LICENSE) para detalhes.

---

## 👤 Autor

Desenvolvido com ❤️ por [@pepes1234](https://github.com/pepes1234)

