# 🧮 Windows Forms Calculator in C#

A simple calculator application built with Windows Forms in C# (.NET Framework). This project demonstrates basic arithmetic operations, user input handling, and GUI event handling using WinForms.

## 🚀 Features

- Basic Arithmetic: Addition, Subtraction, Multiplication, Division
- Modulus (%) Operation
- Decimal Point Support
- Negative Number Toggle
- Clear Entry (`CE`) and Clear All (`C`)
- Input via Buttons (0–9, Dot, Operators)
- Input validation (prevents multiple decimal points)

## 🖼️ UI

The calculator features:
- A main display (`textBox1`) for entering numbers and showing results
- A secondary display (`textBox2`) for showing current operation
- Buttons for digits, operators, and special functions

## 🛠️ Technologies Used

- C#
- Windows Forms (.NET Framework)

## 📂 Project Structure

Calculator/
├── Form1.cs // Main logic for the calculator
├── Form1.Designer.cs // UI layout (auto-generated)
├── Program.cs // App entry point
├── Calculator.csproj // Project file


## 🔧 How to Run

1. Clone this repository:
   ```bash
   https://github.com/ajaysengar2005/Windows-Calculator-
Open the project in Visual Studio.

Build the solution (Ctrl + Shift + B).

Run the project (F5 or click Start).

🧠 Logic Overview
Each number button appends its value to the textBox1 unless the display is 0.

Operator buttons store the first number and chosen operator, then clear the input field.

Pressing = calculates the result based on the selected operator.

Error handling is included for division by zero.

📌 Notes
This is an offline calculator with no external dependencies.

You can expand it by adding advanced operations (e.g., square root, power, memory functions).
