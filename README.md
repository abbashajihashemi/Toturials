# 🧠 .NET Multithreading & Concurrency Tutorials

This repository contains practical tutorials and examples that demonstrate multithreading, asynchronous programming, and concurrency in C# (.NET), with a strong focus on ASP.NET Core WebAPI.
---

## 🎯 Project Goal

To deeply understand:

- How the .NET Thread Pool works
- How async/await really behaves under load
- How to write scalable WebAPI endpoints
- How to avoid common multithreading mistakes
- How to detect and fix concurrency bugs

This repository evolves step-by-step following a structured multithreading roadmap.

---

## 📚 Learning Roadmap Covered in This Repository

### 1️⃣ Fundamentals
- Thread vs Task
- Thread Pool behavior
- Blocking vs Non-blocking operations
- Understanding scalability in WebAPI

### 2️⃣ Async / Await Deep Dive
- IO-bound vs CPU-bound work
- Why blocking kills throughput
- When (and when NOT) to use Task.Run
- Common async anti-patterns

### 3️⃣ Thread Safety
- Race conditions
- Shared mutable state problems
- Locking strategies
- Deadlock scenarios

### 4️⃣ Synchronization & Locks
- lock keyword
- Monitor
- Interlocked
- Proper lock design

### 5️⃣ Concurrent Collections
- ConcurrentDictionary
- ConcurrentQueue
- BlockingCollection
- Producer/Consumer pattern

### 6️⃣ Parallel Programming
- Parallel.For / Parallel.ForEach
- Degree of Parallelism
- When parallelism improves performance

### 7️⃣ Cancellation & Exception Handling
- CancellationToken usage
- Cooperative cancellation
- Exception handling in Tasks

### 8️⃣ ASP.NET Core WebAPI Patterns
- Thread starvation
- Scalability under load
- Background processing patterns
- Performance testing techniques

---

## 🚀 Getting Started

Clone the repository:

```bash
git clone https://github.com/abbashajihashemi/Toturials.git
```

Open the solution in IDE.

Run the WebAPI project and test endpoints under load using tools like:

- Bombardier
- Postman Runner
- JMeter

Example load test:

```bash
bombardier -c 100 -n 1000 http://localhost:5601/api/thread/async
```

Observe:
- Response times
- Throughput
- Behavior differences between sync and async endpoints

---

## 🛠 Philosophy of This Repository

This project is designed to:

- Be practical, not theoretical
- Simulate real production problems
- Help understand performance behavior under stress
- Teach how to think about concurrency, not just how to code it

Each section contains focused examples aligned with the multithreading roadmap.

---

## 🧭 Suggested Study Order

1. Basics
2. Async/Await
3. Thread Safety
4. Locks & Synchronization
5. Concurrent Collections
6. Parallel Processing
7. Cancellation
8. Performance & Anti-Patterns

---

## ⚠️ Important

This repository intentionally includes:
- Blocking examples
- Bad patterns
- Anti-patterns

These are included for educational purposes to demonstrate what NOT to do and why.

---

## 📌 Audience

This repository is intended for:

- Backend developers working with ASP.NET Core
- Developers who want to understand scalability
- Engineers preparing for technical interviews
- Anyone who wants practical knowledge of multithreading in .NET

---

## 📄 License

Free to use for learning and educational purposes.
