# CPRG 200 Lab Assignment 1

## Overview
In this lab assignment, you will develop a C# application that accepts a lunch order from the user, calculates the order subtotal, and computes the total with a 5% tax added. You are encouraged to discuss your approach with other students or seek advice if you encounter difficulties, but all code must be developed independently. You may utilize any previously developed code or code shared in this course.

## Objectives
- Work with various form controls.
- Write code for conditional processing.
- Create a method for calculations.

## Problem Description
Create a C# application that allows users to place a lunch order. The application should include the following main courses and add-ons:

### Main Courses and Prices
| Main Course  | Price  | Add-ons Available                     | Add-on Price |
|--------------|--------|---------------------------------------|--------------|
| Hamburger    | 6.95   | Lettuce, tomato, and onions           | 0.75         |
|              |        | Ketchup, mustard, and mayo            |              |
|              |        | French Fries                          |              |
| French fries | 5.95   | Pepperoni                             | 0.50         |
| Pizza        |        | Sausage                               |              |
|              |        | Olives                                |              |
| Salad        | 4.95   | Croutons                              | 0.25         |
|              |        | Bacon bits                            |              |
|              |        | Bread sticks                          |              |

### Application Behavior
- At startup, **Hamburger** is selected as the main course, and no add-ons are chosen.
- Users can select no add-ons or multiple add-ons.
- When the user clicks the **Place Order** button, the application displays:
  - Subtotal
  - Tax amount (5% of the subtotal)
  - Order total (subtotal plus tax amount)
- When the user clicks the **Reset** button, the application resets to the initial state (Hamburger selected, no add-ons, and all outputs cleared).
- The **Exit** button terminates the application.

### Button Functionality
- Each button has an Alt-key defined.
- The form has **PlaceOrder** as the Accept button and **Reset** as the Cancel button.

## Code Requirements
- No hardcoded values: All fixed values (e.g., 6.95, 0.50) should be declared as constants with meaningful names.
- Tax amount and order total calculations should be performed in a separate programmer-defined method. This method should accept the subtotal as a parameter and use out parameters and/or a return statement to return the tax amount and order total.

## General Requirements
- The appearance of the form is up to you. The provided screenshot is just an example; feel free to personalize it. A professional look and clarity will be considered in the marking.
- Required comments in the code:
  - A top block comment explaining the purpose of the application, the date created (at least month and year), and the author’s name.
  - Each method (button click handlers and programmer-defined methods) should have a comment explaining its purpose.
  - Each variable should have a comment explaining its meaning.
  - Each group of statements performing a single task should have a comment explaining the task's goal.

---

