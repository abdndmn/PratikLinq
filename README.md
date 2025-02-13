# Random Number List Processor

## Description
This C# program generates a list of 10 random numbers between -10 and 30. It then categorizes and processes these numbers based on different conditions, such as even/odd classification, positivity/negativity, and range filtering.

---

## Features

### 1. **Random Number Generation**
- A `List<int>` is used to store 10 randomly generated numbers between -10 and 30.
- The `Random` class is utilized to ensure the numbers are dynamically generated.

### 2. **Number Categorization**
- The program prints:
  - The entire list of generated numbers.
  - Even numbers.
  - Odd numbers.
  - Negative numbers.
  - Positive numbers.
  - Numbers between 15 and 22.

### 3. **Mathematical Operation**
- The program calculates and displays the square of each number in the list.

---

## Output Example
```
Rastgele Sayılardan Oluşan Liste:
5,-3,20,11,-7,15,18,-2,24,6,

Listedeki Çift Sayılar:
20,18,-2,24,6,

Listedeki Tek Sayılar:
5,-3,11,-7,15,

Listedeki Negatif Sayılar:
-3,-7,-2,

Listedeki Pozitif Sayılar:
5,20,11,15,18,24,6,

Listedeki 15'ten büyük ve 22'den küçük sayılar:
20,18,

Listedeki her bir sayının karesi:
25,9,400,121,49,225,324,4,576,36,
```

---

## Technologies Used
- **C#**
- **.NET Core**
- **LINQ (for filtering and selection operations)**

---

## How to Run the Program
1. Copy the source code into a C# console application.
2. Run the program to see randomly generated numbers and their classifications.
3. Each execution will yield different results due to the randomness.

---

## Possible Enhancements
- Allow user input for the number range.
- Store results in a file or database.
- Implement additional statistical analyses on the generated numbers.

---

This program is a great demonstration of **list manipulation, LINQ filtering, and mathematical operations in C#**!

