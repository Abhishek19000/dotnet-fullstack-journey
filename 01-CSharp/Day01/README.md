# Day 01 — C# Types & Parameters

## Topics

- Value types
- Reference types
- ref
- out
- in
- Boxing
- Unboxing
- Class vs Struct

## Key Takeaways

### Value Type

A value-type variable contains the actual value.

### Reference Type

A reference-type variable contains a reference to an object.

### ref

Used when we want the method to work with the original variable.

### out

Used when the method needs to return a value through a parameter.

## Practice

See `Program.cs`.

## Interview Questions

1. What is the difference between value and reference types?
2. Are reference types passed by reference?
3. What is the difference between ref and out?
4. What is boxing and unboxing?


VALUE TYPE
→ Contains the value.
→ Assignment copies the value.
→ int, bool, struct, enum.

REFERENCE TYPE
→ Contains a reference to an object.
→ Assignment copies the reference.
→ class, array, object.

PARAMETERS
→ C# passes parameters by value by default.
→ For reference types, the reference itself is copied.

ref
→ Passed by reference.
→ Variable must already be initialized.
→ Method can read and modify it.

out
→ Passed by reference.
→ Variable doesn't need initialization.
→ Method must assign it before returning.

in
→ Passed by reference.
→ Read-only parameter.

BOXING
→ Value type → object/interface.

UNBOXING
→ Boxed object → value type.

CLASS
→ Reference type.

STRUCT
→ Value type.