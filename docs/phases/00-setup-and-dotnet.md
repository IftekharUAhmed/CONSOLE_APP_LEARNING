# Phase 0 — Setup & .NET ki jinish

> ⏱️ Relax mode: 1–2 din. Kono code mukhosto korar dorkar nai, shudhu *bojho*.

## 🎯 Ei phase shesh e tumi parba
- Bolte parba .NET, C#, SDK, Runtime, CLR er parthokko
- Visual Studio 2026 e console project banate ar chalate parba
- `Program.cs` er protiti line er mane bujhbe
- `Console.WriteLine("Hello")` ke tukro tukro kore explain korte parba

---

## 1. C# ar .NET — eki jinish na!

### What
- **C#** = ekta **language** (bhasha). Jemon Bangla ekta bhasha.
- **.NET** = ekta **platform** — C# code ke chalanor jonno engine + ready-made tools/library.

Upoma: C# holo **recipe lekhar bhasha**, .NET holo **puro rannaghor** (chula, hari-patil, moshla).
Recipe (code) likhle hobe na, rannaghor (.NET) chara ranna (program run) hobe na.

### Why
.NET thakar karone tomake nije theke screen e lekha print kora, file porar code,
memory manage — kichui likhte hoy na. Shob ready ache (**BCL** — Base Class Library).

### .NET er bhitorer jinish
| Jinish | Kaj | Kar lage |
|--------|-----|----------|
| **SDK** | Code build/compile korar tools + `dotnet` command | Developer (tumi) |
| **Runtime** | Build kora app chalano | Je app chalabe |
| **CLR** | Runtime er engine — code chalay, memory dekhe | Automatic |
| **BCL** | Built-in class: `Console`, `Math`, `List`... | Tumi use korbe |

Tomar PC te check: Visual Studio er **View → Terminal** khule likho:
```
dotnet --version
```
(Tomar machine e .NET 10 SDK installed ache ✅)

---

## 2. Code kivabe run hoy? (How it works)

```
  Program.cs  ──(C# compiler)──►  IL code (.dll)  ──(JIT, run time e)──►  Machine code  ──► CPU chalay
   (tumi likho)                   (majhamajhi bhasha)                      (0 ar 1)
```

- **Compile**: C# → **IL** (Intermediate Language). Eta `bin/` folder e `.dll` hishebe thake.
- **JIT** (Just-In-Time): program chalanor shomoy IL → tomar CPU er machine code.

### Why ei 2 step?
IL ek bar banale seta Windows, Linux, Mac — shob jaygay chole. Shudhu oi machine er
runtime ta IL ke local machine code banay. **Ekbar likho, shob jaygay chalao.**

🎤 *Interview Q: "Managed code ki?"* → Je code CLR er under e chole (memory GC manage kore) — sheta managed code.

---

## 3. Amader Project Setup (already done ✅) — ki, keno, kivabe

Project already toiri kora ache. Ekhane bujhbo **ki ki banano holo, keno, ar kivabe**.

### Folder structure
```
C:\CONSOLE_APP_LEARNING\
├── ShopConsole.slnx          ← SOLUTION file — VS 2026 e eta double-click kore kholo
├── .gitignore                ← git ke bole kon file track korbe na (bin/, obj/)
├── .editorconfig             ← code style er niyom (indent, naming) — VS automatically mane
├── docs\                     ← amader learning docs
└── src\                      ← "source" — shob app er code ekhane
    └── ShopConsole\
        ├── ShopConsole.csproj ← PROJECT file
        └── Program.cs         ← tomar code ekhan theke shuru
```
Build korle `src\ShopConsole\bin\` ar `obj\` folder toiri hoy — egula compiler er output,
tumi kokhono haat diba na (muche dileo abar build e chole ashbe).

### Kon command diye banano holo (CLI — Command Line Interface)
VS e "Create new project" click korle pichone ei kaj gulai hoy. CLI janle bujhba VS ashole ki kore.

| Command | What | Why |
|---------|------|-----|
| `dotnet new sln -n ShopConsole` | Khali **solution** file (`ShopConsole.slnx`) banay | Onek project ek sathe rakhar container |
| `dotnet new console -n ShopConsole -o src/ShopConsole -f net10.0 --use-program-main` | Console app **project** banay | `-n` nam, `-o` kothay, `-f` .NET version, `--use-program-main` = classic `Main` method style (top-level na) — jeno bhitorer structure dekhte pao |
| `dotnet sln add src/ShopConsole/ShopConsole.csproj` | Project ke solution e jog kore | Na korle solution jane na project ta ache |
| `dotnet new gitignore` | `.gitignore` banay | `bin/obj` er moto generated file git e jabe na |
| `dotnet new editorconfig` | `.editorconfig` banay | Shob file e same code style — team e consistent code (pore detail) |
| `git init -b main` | Ei folder ke git repository banay | Code er history rakha — bhul korle ager version e fera jay |

### `src\` folder keno? (Why)
Ekhon ekta e project, kintu pore aro ashbe (Phase 16-17):
```
src\ShopConsole\            ← console app (UI)
src\ShopConsole.Core\       ← business logic (class library)
tests\ShopConsole.Tests\    ← unit tests
```
Shuru thekei `src\` / `tests\` alada rakhle pore gochano shohoj — eta .NET world e common convention.

### VS 2026 e kholo (Hands-on 🛠️)
1. Visual Studio 2026 → **Open a project or solution** → `C:\CONSOLE_APP_LEARNING\ShopConsole.slnx`
2. **Ctrl + F5** → console e `Hello, World!` dekhbe ✅

### Solution Explorer e ki dekhba
```
Solution 'ShopConsole'         ← .slnx file (container — onek project rakhte pare)
 └── src                       ← solution folder (shudhu gochano, VS e dekhay)
      └── ShopConsole          ← .csproj file (ekta project)
           ├── Dependencies     ← .NET library gula
           └── Program.cs       ← tomar code
```

**Solution vs Project** — Ekta shop (solution) e onek department (project) thakte pare:
pore amra `ShopConsole.Core`, `ShopConsole.Tests` emon alada project add korbo (Phase 16-17).

`ShopConsole` project e **double-click** korle `.csproj` file khulbe:
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>              <!-- run kora jay emon app (library na) -->
    <TargetFramework>net10.0</TargetFramework> <!-- kon .NET version -->
    <ImplicitUsings>enable</ImplicitUsings>    <!-- common using automatic -->
    <Nullable>enable</Nullable>                <!-- null safety warning (Phase 9) -->
  </PropertyGroup>
</Project>
```
Ekhon eta niye tension nai — shudhu jene rakho project er settings ekhane thake.

---

## 4. `Program.cs` — line by line 🔍

Tomar `src\ShopConsole\Program.cs` e ekhon ei code ta ache:
```csharp
namespace ShopConsole;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

| Line | What | Why |
|------|------|-----|
| `namespace ShopConsole;` | Code ke ekta "naam er folder" e rakha | Onek library te same nam er class thakte pare (`Product` tomar, `Product` arekjoner). Namespace confusion thekay. |
| ↳ `;` diye shesh | **File-scoped namespace** (C# 10+) — pura file ei namespace e | Purono style e `namespace X { ... }` likhte hoto, ek level extra indent. Ekhon `;` dile pura file er jonno — kom indent, porte shohoj |
| `{ }` | **Block** — kothay shuru, kothay shesh | C# e indentation na, braces e scope thik hoy |
| `class Program` | `Program` nam er ekta **class** | C# e **shob code kono class er bhitore** thakte hoy. Access modifier na likhle class by default `internal` = shudhu ei project theke access (Phase 7) |
| `static void Main(string[] args)` | **Entry point** — program ekhan theke shuru | Runtime ke jante hobe kon jaiga theke chalabe |
| ↳ `static` | Object na baniyei call kora jay | Program shuru howar age kono object nai, tai `static` lagbe |
| ↳ `void` | Kichu return kore na | (Phase 3 e detail) |
| ↳ `Main` | Fixed nam — runtime ei nam e khoje | |
| ↳ `string[] args` | Command line theke ashe input (array of string) | Ekhon use korbo na |
| `Console.WriteLine("Hello, World!");` | Screen e lekha print + new line | |
| `;` | **Statement** er shesh | C# ke bole "ei instruction shesh" |

### `Console.WriteLine("Hello, World!")` tukro tukro kore
```
System . Console . WriteLine ( "Hello, World!" ) ;
  │        │          │              │          └─ statement shesh
  │        │          │              └─ argument (method ke deya data)
  │        │          └─ METHOD (kaj: line print kora)
  │        └─ CLASS (console related shob method er group)
  └─ NAMESPACE (System — .NET er core namespace)
```
`System` keno likhte hoy na? Karon `.csproj` e `ImplicitUsings` enable — `using System;` automatic ache.

> 💡 Ei pattern **sob jaygay**: `Namespace.Class.Method(arguments)`.
> `Math.Max(3, 7)` → `Math` class er `Max` method. Ekbar bujhle shob built-in method porte parba.

---

## 5. Top-level statements (modern style)

C# 9 theke upore er 10 line er boiler-plate na likhe shudhu eta likhleo chole:
```csharp
Console.WriteLine("Hello, World!");
```

**What**: Compiler nije pichone `Program` class ar `Main` method baniye dey.
**Why**: Choto program e kom lekha. Beginner der jonno sohoj.
**But**: Bhitore ashole same class + Main e ache. Tai amra classic ta age bujhlam. ✅

Pore amra top-level style e jabo (Phase 1 theke) — karon ekhon tumi jano pichone ki hocche.

---

## 6. Comments
```csharp
// Single line comment — compiler ignore kore

/* Multi-line
   comment */

/// <summary>XML doc comment — method/class er documentation (pore dekhbo)</summary>
```
**Why**: Code *ki* kore seta code nije bole; comment likho *keno* korcho seta bolte.

---

## 7. Build, Run, Debug

| Shortcut | Kaj |
|----------|-----|
| **Ctrl + Shift + B** | Build — shudhu compile kore, error ache kina dekhe |
| **Ctrl + F5** | Run *without* debugging — console window khola thake ✅ (eta e beshi use korbo) |
| **F5** | Run *with* debugging — breakpoint e thambe (Phase 6) |

Error hole niche **Error List** window e dekhabe (View → Error List). Red squiggly line = compile error.

---

## ⚠️ Common Mistakes
- `;` bhule jaoa → `CS1002: ; expected`
- `console.writeline` → C# **case-sensitive**! `Console.WriteLine` thik.
- `{` khulle `}` bondho na kora
- ".NET Framework" template select kora (purono, Windows-only)

## 🏋️ Exercise (nije koro)
1. `ShopConsole.slnx` VS e khule `Ctrl+F5` diye chalao.
2. 3 ta line print koro: shop er nam, address, "Welcome!"
3. Ichha kore ekta `;` muche dao → error message poro → thik koro. (Error porte shikha ekta skill!)
4. `Console.Write` ar `Console.WriteLine` duita diye try koro — parthokko ki?
5. `Console.WriteLine();` (khali) dile ki hoy?

## 🎤 Interview Questions
1. C# ar .NET er parthokko ki?
2. CLR ki kaj kore?
3. IL ar JIT ki? .NET code keno cross-platform?
4. SDK vs Runtime?
5. `Main` method keno `static`?
6. Top-level statements ki? Pichone ki hoy?
7. Namespace keno use kori?

✅ Shesh hole `LEARNING_PLAN.md` e Phase 0 tick dao, tarpor → [Phase 1](01-variables-types-io.md)
