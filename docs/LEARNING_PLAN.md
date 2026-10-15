# 🗺️ C# Learning Plan — Zero to 100

> Project: **ShopConsole** (mini shop console app, dhire dhire boro hobe)
> Tools: **Visual Studio 2026**, **.NET 10**, **C# 14**
> Rule: protiti topic e **What → Why → How** + Exercise + Interview Qs

Legend: `[ ]` baki · `[~]` cholche · `[x]` shesh

---

## 🟢 LEVEL 1 — FOUNDATION (Syntax ar basic jinish)

### Phase 0 — Setup & .NET ki jinish  → [lesson](phases/00-setup-and-dotnet.md)
- [x] .NET, SDK, Runtime, CLR, IL, JIT — ki, keno
- [x] C# vs .NET er parthokko
- [x] Visual Studio 2026 e Console App project banano
- [x] Solution (`.slnx`) vs Project (`.csproj`)
- [x] `Program.cs` — top-level statements vs classic `Main` method
- [x] `namespace`, `using`, `class`, statement, `;`, `{ }`, comments
- [x] `Console.WriteLine` ke tukro tukro kore bojha (namespace → class → method)
- [x] Build vs Run vs Debug (Ctrl+Shift+B, Ctrl+F5, F5)

### Phase 1 — Variables, Data Types, Input/Output  → [lesson](phases/01-variables-types-io.md)
- [ ] Variable ki, declare vs assign vs initialize
- [ ] Built-in types: `int`, `long`, `double`, `decimal`, `bool`, `char`, `string`
- [ ] `var` (type inference), `const`
- [ ] Naming conventions (camelCase, PascalCase)
- [ ] `Console.ReadLine()`, `Console.Write` vs `WriteLine`
- [ ] String interpolation `$"..."`, concatenation
- [ ] Type conversion: implicit, explicit cast, `Parse`, `TryParse`, `Convert`
- [ ] Operators: arithmetic, comparison, logical, assignment, `++`/`--`
- [ ] 🛒 ShopConsole v0.1: product price × quantity = total

### Phase 2 — Control Flow (decision ar loop)
- [ ] `if`, `else if`, `else`, nested if
- [ ] Ternary operator `? :`
- [ ] `switch` statement vs `switch` expression (modern C#)
- [ ] Pattern matching basics (`is`, relational patterns)
- [ ] Loops: `for`, `while`, `do-while`, `foreach` — kokhon konta
- [ ] `break`, `continue`, `return`
- [ ] 🛒 ShopConsole v0.2: menu loop (1. Add 2. Show 3. Exit)

### Phase 3 — Methods (function) — SHOB KICHU
- [ ] Method ki, keno lage (DRY er prothom step)
- [ ] **Method vs Function** — C# e parthokko ki
- [ ] Syntax: access modifier, return type, name, parameters
- [ ] `void` vs return value
- [ ] Parameters vs Arguments
- [ ] Optional parameters, named arguments
- [ ] Method overloading
- [ ] `ref`, `out`, `in` — kokhon konta
- [ ] `params` keyword
- [ ] Expression-bodied method `=>`
- [ ] Local functions
- [ ] `static` method vs instance method (intro)
- [ ] Scope (variable kothay "beche" thake)
- [ ] Recursion (basic)
- [ ] 🛒 ShopConsole v0.3: logic gula method e bhag kora

### Phase 4 — Built-in Classes & Methods (BCL)
- [ ] Built-in method ki, kotha theke ashe (.NET Base Class Library)
- [ ] `string` methods: `Length`, `ToUpper`, `Trim`, `Split`, `Contains`, `Replace`, `Substring`, `IsNullOrWhiteSpace`...
- [ ] String immutability + `StringBuilder` — keno
- [ ] `Math` class: `Round`, `Max`, `Min`, `Abs`, `Pow`, `Sqrt`
- [ ] `DateTime`, `DateOnly`, `TimeSpan` — format kora
- [ ] `Random`, `Guid`
- [ ] Number/currency formatting (`ToString("C")`, `"N2"`)
- [ ] Microsoft docs kivabe porte hoy (sobcheye important skill!)
- [ ] 🛒 ShopConsole v0.4: invoice print with date, formatted price

### Phase 5 — Collections & Generics intro
- [ ] Array (single, multi-dimensional), limitation
- [ ] `List<T>` — Add, Remove, Find, Count, Sort
- [ ] `Dictionary<TKey, TValue>`
- [ ] `HashSet<T>`, `Queue<T>`, `Stack<T>`
- [ ] Generics `<T>` ki — intro
- [ ] Kon situation e kon collection
- [ ] 🛒 ShopConsole v0.5: product list, search, remove

### Phase 6 — Error Handling & Debugging
- [ ] Exception ki, program keno crash kore
- [ ] `try`, `catch`, `finally`
- [ ] Specific vs general exception catch
- [ ] `throw`, re-throw (`throw;` vs `throw ex;`)
- [ ] Custom exception class
- [ ] Exception vs `TryParse` — kokhon konta (performance + design)
- [ ] VS debugging: breakpoint, Step Over (F10), Step Into (F11), Watch, Locals
- [ ] 🛒 ShopConsole v0.6: wrong input e crash na kora

---

## 🟡 LEVEL 2 — OOP (Object Oriented Programming) — PURA CLEAR

### Phase 7 — Class & Object, Encapsulation
- [ ] Class vs Object (blueprint vs real jinish)
- [ ] Fields, Properties (`get; set;`, auto-property, `init`, `required`)
- [ ] Constructor (default, parameterized, overloading, chaining `this(...)`)
- [ ] Primary constructor (C# 12+)
- [ ] `this` keyword
- [ ] Access modifiers: `public`, `private`, `protected`, `internal`, `protected internal`, `private protected`
- [ ] **Encapsulation** — what, why, how
- [ ] `static` members vs instance members (deep)
- [ ] Object initializer syntax
- [ ] 🛒 ShopConsole v1.0: `Product`, `CartItem`, `Cart` class

### Phase 8 — Inheritance, Polymorphism, Abstraction, Interface
- [ ] **Inheritance** — `: BaseClass`, `base` keyword
- [ ] `virtual`, `override`, `new` (method hiding)
- [ ] `sealed`
- [ ] **Polymorphism** — compile-time (overloading) vs runtime (overriding)
- [ ] **Abstraction** — `abstract` class & method
- [ ] **Interface** — ki, keno, kivabe; multiple interface
- [ ] Abstract class vs Interface (top interview question)
- [ ] Default interface methods
- [ ] `object` class — `ToString`, `Equals`, `GetHashCode`
- [ ] Composition vs Inheritance ("has-a" vs "is-a")
- [ ] 🛒 ShopConsole v1.1: `PhysicalProduct`, `DigitalProduct`, `IDiscount`

### Phase 9 — Types Deep Dive
- [ ] Value type vs Reference type (stack vs heap — sohoj bhabe)
- [ ] `struct` vs `class`
- [ ] `record`, `record struct` — immutability, `with`
- [ ] `enum`
- [ ] `null`, nullable value types `int?`, nullable reference types
- [ ] Null operators: `?.`, `??`, `??=`, `!`
- [ ] Boxing / Unboxing
- [ ] `==` vs `.Equals()`
- [ ] 🛒 ShopConsole v1.2: `OrderStatus` enum, `Money` record

---

## 🟠 LEVEL 3 — INTERMEDIATE C#

### Phase 10 — Generics, Delegates, Lambda, Events
- [ ] Generic class, generic method, constraints (`where T : ...`)
- [ ] Delegate ki (method er "pointer")
- [ ] `Func<>`, `Action<>`, `Predicate<>`
- [ ] Lambda expression `x => x * 2`
- [ ] Anonymous methods
- [ ] Events & `EventHandler` (publisher/subscriber)
- [ ] Extension methods
- [ ] 🛒 ShopConsole v1.3: generic `Repository<T>` (preview), `OrderPlaced` event

### Phase 11 — LINQ
- [ ] LINQ ki, keno (loop vs LINQ)
- [ ] `Where`, `Select`, `OrderBy`, `First/FirstOrDefault`, `Any`, `All`, `Count`, `Sum`, `GroupBy`
- [ ] Method syntax vs Query syntax
- [ ] Deferred execution (`IEnumerable` lazy)
- [ ] `IEnumerable` vs `List` vs `IQueryable` (intro)
- [ ] 🛒 ShopConsole v1.4: search, filter by price, sort, reports

### Phase 12 — File I/O & JSON
- [ ] `File`, `Directory`, `Path` class
- [ ] `StreamReader` / `StreamWriter`, `using` statement & `IDisposable`
- [ ] JSON serialize/deserialize (`System.Text.Json`)
- [ ] 🛒 ShopConsole v1.5: products/orders file e save & load

### Phase 13 — Async / Await
- [ ] Synchronous vs Asynchronous
- [ ] `Task`, `Task<T>`, `async`, `await`
- [ ] `async void` keno kharap
- [ ] Async file I/O
- [ ] 🛒 ShopConsole v1.6: async save/load

---

## 🔵 LEVEL 4 — DESIGN PRINCIPLES & PATTERNS

### Phase 14 — Design Principles
- [ ] **DRY** — Don't Repeat Yourself
- [ ] **KISS** — Keep It Simple, Stupid
- [ ] **YAGNI** — You Aren't Gonna Need It
- [ ] **SOLID**:
  - [ ] **S** — Single Responsibility Principle
  - [ ] **O** — Open/Closed Principle
  - [ ] **L** — Liskov Substitution Principle
  - [ ] **I** — Interface Segregation Principle
  - [ ] **D** — Dependency Inversion Principle
- [ ] Separation of Concerns, Composition over Inheritance
- [ ] Code smell chena, refactoring
- [ ] 🛒 ShopConsole v2.0: puro code SOLID onujayi refactor

### Phase 15 — Design Patterns
- [ ] Pattern ki, keno (GoF categories: Creational, Structural, Behavioral)
- [ ] **Creational**: Simple Factory, Factory Method, Abstract Factory, Builder, Singleton
- [ ] **Structural**: Adapter, Decorator, Facade
- [ ] **Behavioral**: Strategy, Observer, Command
- [ ] **Data access**: Repository, Unit of Work
- [ ] Kon pattern kokhon — ar kokhon USE KORBO NA (over-engineering)
- [ ] 🛒 ShopConsole v2.1: `ProductFactory`, `IPaymentStrategy` (Cash/Card/bKash), `OrderBuilder`

---

## 🟣 LEVEL 5 — ARCHITECTURE (Professional project structure)

### Phase 16 — Layered Architecture: Repo, Interface, DTO, Service, Controller
- [ ] Layered architecture ki, keno (Presentation → Business → Data)
- [ ] **Entity / Model** — domain object
- [ ] **DTO** (Data Transfer Object) — keno entity direct expose kori na
- [ ] Mapping (Entity ↔ DTO), manual mapping
- [ ] **Interface** diye contract — `IProductRepository`, `IProductService`
- [ ] **Repository** layer — data access lukano
- [ ] **Service** layer — business logic
- [ ] **Controller** — user input handle (console e banabo, pore Web API te)
- [ ] **Dependency Injection** — manual DI → `Microsoft.Extensions.DependencyInjection`
- [ ] Service lifetimes: Transient, Scoped, Singleton
- [ ] Configuration (`appsettings.json`), Logging (`ILogger`)
- [ ] Multiple projects in one solution (class library)
- [ ] Validation, Result pattern
- [ ] 🛒 ShopConsole v3.0: full layered architecture

### Phase 17 — Unit Testing
- [ ] Testing keno, unit vs integration test
- [ ] xUnit — Fact, Theory, Assert
- [ ] Arrange-Act-Assert
- [ ] Mocking (Moq/NSubstitute) — interface keno test e kaje lage
- [ ] 🛒 ShopConsole: service layer er test

### Phase 18 — Bridge to Real World (e-commerce er dike)
- [ ] ASP.NET Core Web API — console controller → real `[ApiController]`
- [ ] HTTP basics (GET/POST/PUT/DELETE), routing
- [ ] Entity Framework Core intro (DbContext, migrations)
- [ ] Same Service/Repository layer reuse kora — layered architecture er asol magic
- [ ] 🎯 Next: Full e-commerce platform

---

## 📝 Progress Log

| Date | Phase | Ki shikhlam / Note |
|------|-------|--------------------|
| 2026-10-15 | — | Docs ar roadmap toiri holo. Phase 0 diye shuru. |
| 2026-10-15 | 0 | Project chalalam, Main/namespace/Console.WriteLine bujhlam. Fix korlam: runtime ≠ compile time, IL thake .dll er bhitore, cross-platform = IL + OS-specific runtime/JIT. |
