use below to run migrate 
dotnet ef migrations add InitialCreate --startup-project ../API --project ../DAL
dotnet ef database update --startup-project ../API --project ../DAL
