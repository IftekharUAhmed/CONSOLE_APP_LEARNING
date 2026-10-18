# Phase 1 — Variables, Data Types, Input/Output

> ⏱️ Relax mode: 3–4 din. Protiti section er code nije type kore chalao.
> Ekhon theke amra **top-level statements** use korbo (Program.cs e class/Main chara sorasori code).

**Setup**: `Program.cs` er shob kichu muche shudhu nicher example gula likhe try koro.
(Ba notun project banao "Do not use top-level statements" **untick** kore.)

## 🎯 Ei phase shesh e tumi parba
- Variable declare, assign, use korte
- Kon data er jonno kon type — bujhe choose korte (taka r jonno `decimal` keno!)
- User theke input nite ar safely number e convert korte
- ShopConsole v0.1 banate: price × quantity = total

---

## 1. Variable

### What
Variable holo memory te ekta **named box** jekhane data rakha jay.
```
   ┌──────────┐
   │    25    │  ← value
   └──────────┘
      age        ← nam (identifier)
      int        ← box er type (ki dhoroner jinish rakha jabe)
```

### Why
Data ek bar niye bar bar use korte, change korte. `25` bar bar likhar cheye `age` likha
porte sohoj, ar change korte hole ek jaygay korlei hoy.

### How
```csharp
int age;          // DECLARE  — box banalam (type + nam)
age = 25;         // ASSIGN   — box e value rakhlam
int year = 2026;  // INITIALIZE — declare + assign ek sathe (best practice)

age = 26;         // value change kora jay
Console.WriteLine(age);   // 26
```
Syntax: `type nam = value;`

⚠️ C# **statically typed** — `int` box e text rakha jabe na:
```csharp
int age = "twenty";   // ❌ compile error CS0029 — run er agei dhora porbe (eta bhalo jinish!)
```

---

## 2. Built-in Data Types

| Type | Ki rakhe | Example | Kokhon use |
|------|----------|---------|------------|
| `int` | Purno shongkha (±2.1 billion) | `int qty = 5;` | Count, quantity, age — **default choice** |
| `long` | Boro purno shongkha | `long views = 9_000_000_000L;` | `int` e na dhorle |
| `double` | Doshomik (approx) | `double km = 3.75;` | Science, measurement |
| `decimal` | Doshomik (**exact**) | `decimal price = 99.50m;` | 💰 **Taka-poisa — shob shomoy** |
| `bool` | `true` / `false` | `bool inStock = true;` | Yes/No condition |
| `char` | Ekta character | `char grade = 'A';` | Single quote `' '` |
| `string` | Text | `string name = "Pen";` | Double quote `" "` |

### 🔥 Taka r jonno `decimal` KENO? (Why)
```csharp
double a = 0.1 + 0.2;
Console.WriteLine(a == 0.3);   // False 😱  (a = 0.30000000000000004)

decimal b = 0.1m + 0.2m;
Console.WriteLine(b == 0.3m);  // True ✅
```
`double` binary te store hoy, tai 0.1 exact rakhte pare na. Shop e 1 poisa bhul = bug.
`m` suffix = "eta decimal literal". `m` na dile compiler `double` dhore → error.

> 💡 `9_000_000` — underscore shudhu porar shubidhar jonno, value te kono effect nai.

---

## 3. `var` — Type Inference

```csharp
var qty = 5;          // compiler dekhe → int
var name = "Pen";     // → string
var price = 99.5m;    // → decimal
```
**What**: Compiler right side dekhe type nije bujhe nay.
**⚠️ Important**: Eta **still statically typed**! `qty` ekhon chirodin `int`. JavaScript er `var` er moto na.
```csharp
var qty = 5;
qty = "five";   // ❌ error — qty int
var x;          // ❌ error — value chara compiler type bujhbe kivabe?
```
**Kokhon use**: Type right side e already clear thakle (`var list = new List<int>();`).
Shuru te explicit type (`int`, `string`) likho — type gula mathay boshbe.

## 4. `const` — Constant
```csharp
const decimal vatRate = 0.15m;
vatRate = 0.20m;   // ❌ error — const change kora jay na
```
**Why**: Je value kokhono change hobe na (VAT rate, shop name) — bhul kore change howa thekay,
ar "magic number" (code e hothat `0.15` — eta ki?) er bodle meaningful nam.

## 5. Naming Conventions (C# community standard)
| Ki | Style | Example |
|----|-------|---------|
| Local variable, parameter | **camelCase** | `unitPrice`, `customerName` |
| Method, Class, Property, class-level const | **PascalCase** | `CalculateTotal`, `Product`, `VatRate` |
| Local const (method / top-level er bhitore) | **camelCase** (amader `.editorconfig` er rule) | `vatRate`, `shopName` |
| Private field | `_camelCase` | `_stock` (Phase 7) |

✅ Meaningful nam: `totalPrice` · ❌ `tp`, `x1`, `data`
Rules: number diye shuru hobe na, space hobe na, keyword (`int`, `class`) hobe na.

---

## 6. Output: `Write` vs `WriteLine`
```csharp
Console.Write("Name: ");     // print, cursor ekoi line e thake
Console.WriteLine("Pen");    // print + new line
// Output: Name: Pen
```

### String banano — 3 way
```csharp
string item = "Pen";
decimal price = 10.5m;

// 1. Concatenation (+) — purono, onek + hole kharap dekhay
Console.WriteLine("Item: " + item + ", Price: " + price);

// 2. String interpolation ($) — ✅ RECOMMENDED
Console.WriteLine($"Item: {item}, Price: {price}");

// 3. Format specifier shoho
Console.WriteLine($"Price: {price:N2}");   // 10.50  (2 decimal)
Console.WriteLine($"Total: {price * 3}");  // { } er bhitore expression o chole
```
Escape characters: `\n` new line, `\t` tab, `\"` quote, `\\` backslash.

---

## 7. Input: `Console.ReadLine()`
```csharp
Console.Write("Tomar nam: ");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
```
- `ReadLine()` user Enter na deya porjonto wait kore, tarpor pura line **`string`** hishebe dey.
- `string?` — `?` mane "null o hote pare" (input stream bondho thakle). Phase 9 e detail. Ekhon shudhu jano warning bondho korte `?` dei.

### 🔥 Boro trap: ReadLine SHOB SHOMOY string dey
```csharp
Console.Write("Quantity: ");
string? input = Console.ReadLine();   // user likhlo 5 → input = "5" (text, number na!)
int qty = input;                      // ❌ error — string ke int e rakha jay na
```
Tai **conversion** lage 👇

---

## 8. Type Conversion

### a) Implicit (automatic) — data harabar risk nai
```csharp
int small = 100;
long big = small;       // ✅ choto box → boro box, auto
double d = small;       // ✅
```

### b) Explicit (cast) — data harate pare, tai tumi nije bolo
```csharp
double price = 9.99;
int whole = (int)price;   // 9 — doshomik kete fele (round kore na!)
```

### c) `Parse` — string → number (input valid hole)
```csharp
int qty = int.Parse("5");          // 5
decimal p = decimal.Parse("99.5"); // 99.5
int bad = int.Parse("abc");        // 💥 CRASH — FormatException
```

### d) `TryParse` — ✅ user input er jonno BEST
```csharp
Console.Write("Quantity: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int qty))
{
    Console.WriteLine($"Tumi {qty} ta nile");
}
else
{
    Console.WriteLine("Eta valid number na!");
}
```
**What**: Convert *try* kore. Parle `true` return kore ar value `qty` te rakhe; na parle `false`, crash kore na.
**Why**: User je kono kichu type korte pare — "abc", khali Enter. Program crash kora chalbe na.
**How**: `out int qty` — "result ta ei notun variable e rakho" (`out` Phase 3 e detail).
(`if/else` Phase 2 e detail — ekhon shudhu structure ta dekho.)

### e) `Convert` class
```csharp
int a = Convert.ToInt32("42");
int b = Convert.ToInt32(null);   // 0 (Parse hole crash korto)
```

| Method | Invalid input e | Kokhon |
|--------|-----------------|--------|
| `(int)x` | — | Number → number (doshomik katte) |
| `int.Parse` | 💥 Exception | Input 100% valid jodi jano |
| `int.TryParse` | `false` return | **User input** ✅ |
| `Convert.ToInt32` | Exception (null → 0) | Different type theke convert |

---

## 9. Operators

```csharp
// Arithmetic
int a = 17, b = 5;
Console.WriteLine(a + b);   // 22
Console.WriteLine(a - b);   // 12
Console.WriteLine(a * b);   // 85
Console.WriteLine(a / b);   // 3   ⚠️ int / int = int (doshomik baad!)
Console.WriteLine(a % b);   // 2   (remainder / bhagshesh)
Console.WriteLine(17.0 / 5);  // 3.4 — ekta double hole result double

// Assignment shortcut
int stock = 10;
stock += 5;   // stock = stock + 5  → 15
stock -= 3;   // 12
stock++;      // 13  (+1)
stock--;      // 12  (-1)

// Comparison → result bool
Console.WriteLine(5 > 3);    // True
Console.WriteLine(5 == 5);   // True   (== compare, = assign!)
Console.WriteLine(5 != 5);   // False

// Logical
bool inStock = true, hasMoney = false;
Console.WriteLine(inStock && hasMoney);  // False  — AND: dutoi true lage
Console.WriteLine(inStock || hasMoney);  // True   — OR: ekta true holei
Console.WriteLine(!inStock);             // False  — NOT: ulta
```
`%` er use: number jor/bijor (`n % 2 == 0`), proti 3rd item e discount, etc.

---

## 🛒 ShopConsole v0.1 — Mini Project

**Requirement** (nije age try koro, tarpor niche dekho!):
1. Shop er nam print koro (`const` use kore)
2. Customer er nam nao
3. Product er nam, unit price, quantity nao
4. Subtotal, VAT (15%), Grand total hishab koro
5. Sundor kore print koro

**Sample output**:
```
===== Welcome to Rahim Store =====
Your name: Karim
Product name: Notebook
Unit price: 45.50
Quantity: 3

Hi Karim, here is your bill:
Notebook x 3
Subtotal : 136.50
VAT (15%): 20.48
Total    : 156.98
```

<details>
<summary>💡 Hint (atke gele khulo)</summary>

- `const string shopName = "...";`, `const decimal vatRate = 0.15m;`
- Price er jonno `decimal.Parse(...)` (ekhon Parse e thik ache; Phase 2 e TryParse + loop diye safe korbo)
- `{value:N2}` diye 2 decimal
- `Math.Round(x, 2)` diye round
</details>

<details>
<summary>✅ Solution (age nije try korecho to? 😄)</summary>

```csharp
const string shopName = "Rahim Store";
const decimal vatRate = 0.15m;

Console.WriteLine($"===== Welcome to {shopName} =====");

Console.Write("Your name: ");
string? customerName = Console.ReadLine();

Console.Write("Product name: ");
string? productName = Console.ReadLine();

Console.Write("Unit price: ");
decimal unitPrice = decimal.Parse(Console.ReadLine()!);

Console.Write("Quantity: ");
int quantity = int.Parse(Console.ReadLine()!);

decimal subtotal = unitPrice * quantity;
decimal vat = Math.Round(subtotal * vatRate, 2);
decimal total = subtotal + vat;

Console.WriteLine();
Console.WriteLine($"Hi {customerName}, here is your bill:");
Console.WriteLine($"{productName} x {quantity}");
Console.WriteLine($"Subtotal : {subtotal:N2}");
Console.WriteLine($"VAT (15%): {vat:N2}");
Console.WriteLine($"Total    : {total:N2}");
```
`!` (null-forgiving) — compiler ke bola "ami jani eta null na". Ekhon temporary;
Phase 2 e TryParse diye properly handle korbo.

`decimal * int` keno chole? `int` automatically `decimal` e implicit convert hoy (Section 8a).
</details>

**Test koro**: Quantity te `abc` dile ki hoy? 💥 Crash! → Eta e Phase 2 te fix korbo (loop + TryParse).

---

## ⚠️ Common Mistakes
- `decimal price = 9.99;` → error, `m` lage: `9.99m`
- `5 / 2` = `2` (int division) — `5 / 2.0` = `2.5`
- `=` (assign) ar `==` (compare) gulano
- `char` e double quote: `char c = "A";` ❌ → `'A'`
- ReadLine er result sorasori number variable e rakha

## 🏋️ Extra Exercise
1. User theke 2 ta number niye +, −, ×, ÷, % shob result print koro. `int` ar `double` duita diye try koro — parthokko note koro.
2. Celsius input niye Fahrenheit e convert koro: `F = C × 9 / 5 + 32`. (`int` diye korle ki bhul hoy? Keno?)
3. Total second input niye ghonta:minute:second e dekhao (hint: `/` ar `%`). `3725` → `1h 2m 5s`
4. `int.MaxValue + 1` print kore dekho ki hoy 🤯 (overflow — Google koro "C# checked keyword")

## 🎤 Interview Questions
1. `var` ki dynamic typing? (Na! Keno?)
2. `decimal` vs `double` — kokhon konta? Keno?
3. `Parse` vs `TryParse` vs `Convert` parthokko?
4. Implicit vs explicit conversion?
5. `const` ki? (Bonus: `const` vs `readonly` — Phase 7 e dekhbo)
6. `int` ar `Int32` er parthokko? (Hint: kono parthokko nai — `int` holo `System.Int32` er alias)
7. `string` vs `String`? (same — alias)
8. `7 / 2` ar `7 % 2` er result?

✅ Shesh hole Phase 1 tick dao → Phase 2 (Control Flow) — Claude ke bolo lesson banate.
