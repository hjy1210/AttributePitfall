# Blazor app and Attribute

## Problem
1. Set debug point at line 14 of Counter.razor
2. F5 to debug, browse to Counter page, click `Click Me`, DO NOT hit the break point.
3. At this moment, inspect line 14 of Counter.razor, a hollow round cicle with exclamation mark appeared, with message `Unbound breakpoint`

## Walkaround
1. comment out following two lines of attributes about Id property of MyModel.cs in subdirectory Models
 ```
   //[BsonId]
   //[BsonRepresentation(BsonType.ObjectId)]
```
2. Clean project, rebuild project
3. F5 to debug, every thing is OK now.

## Question
**What is the limitation of Blazor app about attributes?**

**Where is the documentation about this issue?**


