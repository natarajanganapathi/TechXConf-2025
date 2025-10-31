# Polyglot Notebooks Setup Guide for C# in Jupyter (.ipynb)

This guide will help you set up your environment to run and demo C# code in Jupyter Notebooks using Polyglot Notebooks.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

- [Visual Studio Code](https://code.visualstudio.com/) (VS Code) or [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

- [Jupyter](https://jupyter.org/) (optional, for running notebooks outside VS Code)

- Internet connection (for downloading extensions and packages)

---

## 1. Install .NET SDK

Download and install the latest .NET SDK from the [official website](https://dotnet.microsoft.com/download).

Verify installation:

```bash

dotnet --version

```

---

## 2. Install Visual Studio Code

Download and install [VS Code](https://code.visualstudio.com/).

---

## 3. Install Required VS Code Extensions

Open VS Code and install the following extensions:

- **Polyglot Notebooks**  

  Search for \"Polyglot Notebooks\" in the Extensions Marketplace and install it.

- **Jupyter**  

  Search for \"Jupyter\" and install the official extension by Microsoft.

- **.NET Interactive Notebooks**  

  (Polyglot Notebooks extension now includes .NET Interactive support, but if needed, search for \".NET Interactive Notebooks\" and install.)

---

## 4. Verify Installation

- Open VS Code.

- Press `Ctrl+Shift+P` and type `Jupyter: Create New Blank Notebook`.

- In the new notebook, select the C# kernel (should appear as `.NET (C#)` or similar).

- Run a simple C# cell:

```csharp

    Console.WriteLine(\"Hello from C# in Polyglot Notebooks!\");

```

---

## 5. Opening and Running .ipynb Files

- Open your `.ipynb` file in VS Code.

- Ensure the kernel is set to `.NET (C#)` for C# cells.

- Run cells as usual.

---

## 6. (Optional) Install Jupyter and .NET Interactive CLI

If you want to run notebooks outside VS Code (e.g., in Jupyter Lab):

1. Install Jupyter:

```bash

    pip install jupyter

```

2. Install .NET Interactive:

```bash

    dotnet tool install --global Microsoft.dotnet-interactive

    dotnet interactive jupyter install

```

3. Launch Jupyter Notebook:

```bash

    jupyter notebook

```

4. Open your `.ipynb` file and select the `.NET (C#)` kernel.

---

## Troubleshooting

- If the C# kernel does not appear, restart VS Code and ensure all extensions are enabled.

- Make sure the .NET SDK is correctly installed and added to your PATH.

---

## References

- [Polyglot Notebooks Documentation](https://github.com/dotnet/interactive)

- [VS Code Polyglot Notebooks Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)

- [.NET Interactive Notebooks](https://github.com/dotnet/interactive/blob/main/docs/NotebooksOnJupyter.md)

---

**Feedback or questions? Let me know!**

