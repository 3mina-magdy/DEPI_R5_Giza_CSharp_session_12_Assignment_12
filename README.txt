LINQ Assignment 01 - C# OOP structure

How to run:
1. Extract the ZIP file.
2. Open session_12.csproj in Visual Studio.
3. Ensure DataFiles/Customers.xml and DataFiles/dictionary_english.txt are present.
4. Press Ctrl+F5 to run.

Project organization:
- Models: Product, Customer, Order
- Data: ListGenerator (provided product dataset + XML customer/order loading)
- Services: separate class for each LINQ operator group
- Utilities: dictionary file reader
- Program.cs: entry point that calls the services and displays results

The project uses the provided ListGenerators product data, Customers.xml, and dictionary_english.txt.
