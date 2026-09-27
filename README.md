# List Basics in C#

A console demo of `List<T>`: read a variable number of values into a list, then
reverse it.

```
ListBasics/
├── ListBasics.sln
├── ListBasics.csproj
├── Program.cs
└── .gitignore
```

## What it demonstrates

| Concept | Where |
|---|---|
| Declaring a generic list — `List<int>` | `Program.cs` |
| `Add` inside a loop | `Program.cs` |
| Knowing the count up front to drive the loop — `i <= n` | `Program.cs` |
| **`List<T>.Reverse()`** | `Program.cs` |
| `foreach` over a collection | output |
| `Convert.ToInt32` for input parsing | `Program.cs` |

The difference from a plain array is the point of the exercise: the list grows on
demand, so there is no need to know the size before starting.

```csharp
List<int> numbers = new List<int>();
for (int i = 1; i <= n; i++)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}

numbers.Reverse();
```

An older version of the `Add` call is left commented out, showing the explicit
two-step version — read a `string`, then convert it:

```csharp
/* string input = Console.ReadLine();
   numbers.Add(Convert.ToInt32(input));*/
```

## Running it

```bash
dotnet run
```

Sample session:

```
how many numbers
Please write number1:
Please write number2:
Please write number3:
Please write number4:
40,30,20,10,
```

(entered `4`, then `10 20 30 40`)

## Notes

Originally named `Sort numbers with List`, which was misleading — the list is
reversed, not sorted. Renamed to `ListBasics`.

---

<div dir="rtl">

## کار با لیست در C#

یک برنامه کنسولی که با `List<T>` کار می‌کند: تعدادی عدد را می‌خواند و در انتها
لیست را برعکس می‌کند.

**مفاهیمی که نشان می‌دهد:**

- **تعریف لیست جنریک** — `List<int>`
- **افزودن با `Add`** داخل حلقه
- **`List<T>.Reverse()`** — برعکس کردن لیست
- **حلقه `foreach`** برای چاپ خروجی

تفاوت لیست با آرایه همین نکته اصلی است: **لیست در حین اجرا بزرگ می‌شود** و لازم
نیست قبل از شروع، اندازه آن را بدانیم.

**اجرا:**

```bash
dotnet run
```

</div>
