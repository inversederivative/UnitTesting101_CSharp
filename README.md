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

### .NET Testing Note

Don't forget, we declared our class as a library. There is no Main method, and we simply are
just using the class in the test cases. Because of this from our class folder, when we run:

	dotnet build

And then: 

	dotnet run

We will get an error (again from the PersonService folder), because we cannot run a library.

Similarly, if from the tests folder we do:

	dotnet build

And then: 
	
	dotnet run

We will get no output at all. This is effectively showing that there were no problems. If we
want to see the result of the tests being run we do:

	dotnet test

(again from the tests folder, i.e. PersonService.Tests)


---

 
	
