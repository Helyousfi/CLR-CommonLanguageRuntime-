# CLR-CommonLanguageRuntime-
## App Domains
An app domain is a logically isolated container in which .NET code runs.

## The CLR
The CLR (Common Language Runtime) is the central element of the .NET architecture. The CLR is a software layer that handles the execution of .NET application code. 
Here's what the CLR is doing (a non-exhaustive list): 
- Exceptions handling : The CLR manages the handling of exceptions in .NET applications. When unexpected errors or exceptional situations occur during the execution of code, the CLR is responsible for catching and managing these exceptions.
- Compilation and execution of CIL : .NET languages, such as C# or VB.NET, are compiled into an intermediate language called Common Intermediate Language (CIL) or Microsoft Intermediate Language (MSIL). The CLR is responsible for taking this intermediate code and executing it.
- Management of object storage in memory : Managing the allocation and deallocation of memory for objects created during the runtime. (garbage collection).

