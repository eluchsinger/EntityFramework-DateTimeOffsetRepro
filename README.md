# EntityFramework-DateTimeOffsetRepro

This is a reproduction for an issue first described [here](https://stackoverflow.com/questions/72156907/ef-core-datetimeoffset).

To trigger the issue, run the following commands in the folder `EF.Demo.SqlProvider`:

```
dotnet tool restore
dotnet ef migrations add ChangeDateTimeToDateTimeOffset
```

This will result in the following error:

```
System.InvalidOperationException: The property 'SomeDbModel.CreateDate' is of type 'DateTimeOffset' 
which is not supported by the current database provider. Either change the property CLR type, or ignore 
the property using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'.
```
