# e-commerce-kata

## Overview
A company wants to sell the following products online:

### Products
- **T-Shirts:**
  - 150 Classic T-Shirts at **30€** each
  - 100 Longsleeve T-Shirts at **50€** each
- **Caps:**
  - 200 Classic Caps at **10€** each
  - 50 Premium Caps at **20€** each

### Promotions
Several promotions can be applied to the user's cart:

1. **Buy One, Get One Free** → If the cart contains 2 items of the same product, only 1 is charged. If there are 4 items, only 2 are charged, and so on.
2. **10€ Discount per 200€ Spent** → For every 200€ in the cart, a 10€ reduction is applied.
3. **Premium Cap Bonus** → Buying 2 premium caps grants one free classic T-shirt (if a T-shirt is already in the cart).
4. **10% Discount on All T-Shirts** → A 10% discount is applied to all T-shirts.

## Goal
Design and implement the following operations:

1. **Add products to the cart:**
   - 10 Classic T-Shirts
   - 5 Longsleeve T-Shirts
   - 5 Classic Caps
   - 2 Premium Caps

2. **Display the total price of the cart.**

3. **Apply promotions over multiple days:**
   - **Day 1:** Apply Promo 1
   - **Day 2:** Apply Promo 2 + Promo 3
   - **Day 3:** Apply Promo 4

4. **Display the stock state and total cart price for each day.**
