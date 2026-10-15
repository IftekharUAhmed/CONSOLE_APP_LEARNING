# 📖 Glossary — Technical shobdo, sohoj bhashay

> Notun kono shobdo dekhle ekhane khujo. Na pele Claude ke bolo add korte.
> (Jei phase e shobdo ta detail e ashbe, seta bracket e deya ache)

## .NET & Tools
| Shobdo | Mane |
|--------|------|
| **.NET** | Microsoft er platform — program banano ar chalanor jonno shob kichu (runtime + library + tools). (P0) |
| **C#** | Ekta programming *language*. .NET platform er upor chole. Language ≠ Platform. (P0) |
| **SDK** | Software Development Kit — code *likhte ar build korte* ja lage (compiler, `dotnet` CLI). Developer der lage. (P0) |
| **Runtime** | Build kora program *chalate* ja lage. User der shudhu eta holei hoy. (P0) |
| **CLR** | Common Language Runtime — .NET er "engine", tomar program chalay, memory manage kore. (P0) |
| **IL** | Intermediate Language — C# compile hoye prothome ei majhamajhi code e convert hoy. (P0) |
| **JIT** | Just-In-Time compiler — run er shomoy IL ke machine code e convert kore. (P0) |
| **BCL** | Base Class Library — .NET er built-in class gula (`Console`, `Math`, `List<T>`...). (P0, P4) |
| **Garbage Collector (GC)** | Automatic memory cleaner — je object ar kaje lagbe na, seta muche fele. (P9) |
| **Solution** | Onek gula project ke ek sathe rakhar "folder"/container. File: `.slnx` / `.sln`. (P0) |
| **Project** | Ekta app ba library. File: `.csproj`. (P0) |
| **NuGet** | .NET er package manager — onner banano library install korar jaiga. (P16) |

## Syntax basics
| Shobdo | Mane |
|--------|------|
| **Statement** | Ekta instruction, sheshe `;` thake. Jemon `int x = 5;` (P0) |
| **Expression** | Ja ekta value toiri kore. Jemon `5 + 3`, `x > 2` (P1) |
| **Keyword** | C# er reserved shobdo — `int`, `class`, `if`, `return` — egula variable er nam deya jay na. (P1) |
| **Identifier** | Tumi je nam dao — variable, method, class er nam. (P1) |
| **Variable** | Data rakhar named "box". (P1) |
| **Data type** | Box e ki dhoroner data thakbe — number, text, true/false. (P1) |
| **Literal** | Code e sorasori lekha value: `42`, `"hello"`, `true`, `9.99m` (P1) |
| **Namespace** | Class gula ke group/organize korar "folder" er moto nam. `System`, `System.Collections.Generic` (P0) |
| **`using` directive** | File er upore likhe namespace "import" kora, jeno pura nam bar bar likhte na hoy. (P0) |
| **Top-level statements** | `Main` method na likhe sorasori `Program.cs` e code lekha (C# 9+). (P0) |

## Methods
| Shobdo | Mane |
|--------|------|
| **Method** | Class er bhitore thaka named code block ja ekta kaj kore. C# e *shob* function e kono na kono class/struct er bhitore thake, tai C# e amra "method" boli. (P3) |
| **Function** | General programming term — input niye kaj kore output dey. C# e "function" bolle mainly method / local function / lambda bojhay. (P3) |
| **Parameter** | Method *define* korar shomoy je variable likhi: `void Greet(string name)` → `name` (P3) |
| **Argument** | Method *call* korar shomoy je asol value pathai: `Greet("Rahim")` → `"Rahim"` (P3) |
| **Return type** | Method kaj shesh kore ki dhoroner value ferot dey. Kichu na dile `void`. (P3) |
| **Signature** | Method er nam + parameter er type/order. Overloading er jonno important. (P3) |
| **Overloading** | Same nam, alada parameter — multiple method. (P3) |
| **Built-in method** | .NET nije je method diye rakhse — `Console.WriteLine`, `Math.Max`, `"abc".ToUpper()` (P4) |

## OOP
| Shobdo | Mane |
|--------|------|
| **Class** | Blueprint / naksha. Jemon "Product" er naksha — nam, dam thakbe. (P7) |
| **Object / Instance** | Class theke banano asol jinish. `new Product()` (P7) |
| **Field** | Class er bhitore variable (shadharonoto `private`). (P7) |
| **Property** | Field e controlled access deyar way (`get`/`set`). (P7) |
| **Constructor** | Object toirir shomoy automatically chola special method. (P7) |
| **Encapsulation** | Data lukiye rakha, shudhu control kora rasta diye access dewa. (P7) |
| **Inheritance** | Ek class arek class er gun "uttoradhikar" sutre pay. (P8) |
| **Polymorphism** | Ek nam, onek rup — same method call, alada object e alada kaj. (P8) |
| **Abstraction** | "Ki kore" dekhano, "kivabe kore" lukano. (P8) |
| **Interface** | Contract — "ei method gula thaktei hobe", kivabe seta implementing class thik korbe. (P8) |

## Architecture
| Shobdo | Mane |
|--------|------|
| **Entity / Model** | Business er core object — `Product`, `Order`. (P16) |
| **DTO** | Data Transfer Object — layer theke layer e data pathanor halka object, shudhu dorkari field. (P16) |
| **Repository** | Data kothay/kivabe save hoy (file, DB) seta lukiye rakhe — `GetAll()`, `Add()`. (P15, P16) |
| **Service** | Business logic er jaiga — "stock na thakle order hobe na". (P16) |
| **Controller** | User/request theke input niye service ke dey, result dekhay. (P16) |
| **Dependency Injection (DI)** | Class nije dependency `new` na kore, baire theke pay. (P16) |
| **Design Principle** | Bhalo code lekhar general niyom — DRY, KISS, SOLID. (P14) |
| **Design Pattern** | Common shomossha r proven solution template — Factory, Strategy. (P15) |
