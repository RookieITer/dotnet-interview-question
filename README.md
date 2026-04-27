# C# Backend Engineering Practice

> Building practical C# backend engineering skills through live coding, collection processing, and real-world problem solving.

Hi, I’m **Jasper Du**.

I’m a software engineer with hands-on experience in **production FinTech systems**, working across backend services, distributed systems, reliability improvements, and live issue investigation.

This repository is where I practise and document my **C# live coding, backend problem-solving, and engineering thinking**.

Right now, the focus is on **interview-style C# collection processing and backend coding questions**.  
Over time, this repository will gradually expand into a **step-by-step hands-on learning space for building real C# projects**, from fundamentals to practical backend development.

---

## Why I Created This Repository

I wanted a practice space that feels closer to **real engineering work** than traditional algorithm-only preparation.

A lot of backend and full stack interview questions are not about advanced algorithms.  
They are usually about things like:

- transforming data cleanly
- joining multiple data sources
- grouping and summarising records
- mapping entities into DTOs
- handling nulls and edge cases safely
- writing code that is readable and easy to explain

That is the exact kind of skill I want to keep improving.

This repository is my way of building that skill set in a practical and structured way.

---

## What This Repository Focuses On

At the moment, the main focus areas are:

- **C#**
- **LINQ**
- **list transformation**
- **filtering and sorting**
- **joins**
- **grouping and aggregation**
- **DTO mapping**
- **dictionary / foreach solutions**
- **clean coding style**
- **edge-case handling**

The goal is not just to “get the answer right”, but to write solutions that are:

- correct
- readable
- explainable
- closer to production-style thinking

---

## Repository Structure

```text
DotNetInterviewQuestion/
├── Questions/
│   ├── Q01_FilterActiveUsers.cs
│   ├── Q02_SortOrdersTop3.cs
│   ├── Q03_GroupTransactionsCount.cs
│   ├── ...
│
├── Answers/
│   ├── Q01_FilterActiveUsers.cs
│   ├── Q02_SortOrdersTop3.cs
│   ├── Q03_GroupTransactionsCount.cs
│   ├── ...
│
├── README.md
└── .gitignore
```

### `Questions/`
This folder contains the **starter versions** of each exercise.

Each question usually includes:

- sample input data
- input models
- output DTOs
- a `Solve(...)` method
- a `// Code here` placeholder

This is where I practise solving the question independently.

### `Answers/`
This folder contains my **completed solutions**.

I use it to:

- compare my first attempt with a cleaner version
- revise different approaches
- track improvement over time
- practise rewriting the same problem more clearly

---

## How I Use This Repository

For each question, I usually follow this workflow:

1. Read the question and identify the pattern  
   For example:
   - filter
   - join
   - group by
   - nested DTO transform
   - summary / aggregation

2. Solve it in the `Questions` version first

3. Compare it with the `Answers` version

4. Rewrite it again without looking

5. Practise explaining the solution out loud as if it were a live coding interview

This helps me improve not only coding ability, but also **communication, clarity, and structured problem-solving**.

---

## Question Types Covered

The questions in this repository are designed around common backend-style coding patterns, including:

### Basic collection processing
- `Where`
- `Select`
- `OrderBy`
- `OrderByDescending`
- `Take`
- `Distinct`

### Grouping and aggregation
- `GroupBy`
- `Count`
- `Sum`
- latest item per group
- maximum item per group

### Joins
- inner join
- join + filter
- join + group + summary
- left join

### Data transformation
- entity to DTO mapping
- nested DTO creation
- list-to-list transformation
- list-to-dictionary transformation

### Alternative non-LINQ approach
- `foreach`
- `Dictionary`
- `ContainsKey`
- `TryGetValue`

### Reliability and clean coding
- null handling
- empty input handling
- duplicate key handling
- readable naming
- step-by-step logic

---

## What I’m Building Toward

This repository is not only for interview prep.

My long-term goal is to gradually turn it into a more complete **C# and backend engineering learning space**, including:

- C# syntax fundamentals
- object-oriented programming in C#
- LINQ in real scenarios
- DTOs, entities, models, and ViewModels
- clean project structure
- .NET Web API basics
- service / controller / repository patterns
- unit testing
- small real-world backend projects
- step-by-step walkthroughs for building a C# project from scratch

In other words, this repository starts from **coding questions**, but it will keep growing toward **real project development**.

---

## Future Plan

This repository is intended to grow step by step, not stay as a question-only practice space.

### Short Term
In the short term, I want to keep expanding the interview practice side of this repository by:

- adding more C# live coding questions
- covering more LINQ and collection-processing patterns
- writing both LINQ and `foreach + Dictionary` solutions
- improving code readability and edge-case handling
- practising how to explain each solution clearly in an interview setting

### Mid Term
In the mid term, I want to turn this repository into a more structured C# learning space by gradually adding:

- C# fundamentals and syntax notes
- object-oriented programming examples
- DTO, model, entity, and ViewModel comparisons
- small utility classes and reusable examples
- cleaner folder structure and better code organisation
- unit testing examples for selected exercises

### Long Term
In the long term, I want this repository to evolve into a hands-on learning project for building real C# applications step by step.

That includes:

- creating a C# project from scratch
- introducing .NET project structure
- building simple console applications first
- moving into .NET Web API development
- demonstrating service / repository / controller patterns
- showing how to design small backend features end to end
- documenting the thinking behind project setup, architecture, and clean code decisions

### Personal Goal
The long-term goal of this repository is not only to help me prepare for interviews, but also to build a practical record of my progress as a backend engineer.

I want this repo to reflect a learning path from:

**coding exercises → backend thinking → real C# project development**

so that over time it becomes both:

- a serious practice space for myself
- and a step-by-step reference for anyone who wants to learn practical C# backend development

> This repository is my long-term C# backend engineering playground, built to grow from interview practice into real project development.

---

## Learning Roadmap

This is the direction I plan to expand in:

1. C# interview coding practice  
2. LINQ and collection processing  
3. C# fundamentals and OOP  
4. DTO / model / entity design  
5. .NET project structure  
6. Web API development  
7. Real mini backend projects  
8. Hand-holding tutorials for building C# applications step by step  

---

## A Few Principles I Try to Follow

When solving each question, I try to ask myself:

- What is the input type?
- What is the required output type?
- Is this mainly a filter, join, group, or transform problem?
- Do I need a DTO?
- What are the edge cases?
- Can I explain this solution clearly in under 30 seconds?

If I can both **code it** and **explain it clearly**, I probably understand it well enough.

---

## About Me

I’m currently building my strength in:

- backend engineering
- production system thinking
- reliability-focused coding
- data transformation and validation
- practical C# problem-solving

My broader interest is in becoming a stronger **backend / platform engineer**, especially in environments where correctness, reliability, and business impact matter.

---

## Author

**Jasper Du**

Software Engineer  
Interested in backend engineering, distributed systems, platform reliability, and practical C# development.
