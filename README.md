# Unit Testing 101 (C#)

---

### Introduction

See [here](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test) 
for more info. We are using xUnit with C# for writing unit tests.


Getting the project setup is a bit cumbersome, but it's worth it in the end. 

From your C# folder (where your other projects are) run the following:

	dotnet new sln -o TestNameTestTestBlah (This can be whatever you like)
	cd TestNameTestTestBlah
	dotnet new classlib -o MyClassName
	dotnet sln add ./MyClassName/MyClassName.csproj
	dotnet new xunit -o MyClassName.Tests
	dotnet add ./MyClassName.Tests/MyClassName.Tests.csproj reference ./MyClassName/MyClassName.csproj
	dotnet sln add ./MyClassName.Tests.csproj

This should get you up and running. From here you would just want to rename the .cs files 
in both projects. We've essentially created a solution with two projects, and a reference 
from the one to the other, so we can refer to our class in the tests project.


---


 
	
