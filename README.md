# aspDotNetEFCodeFirstAppOne

## ASP.NET Core Web API with EF Core Code-First Approach
 - working with the EF Core Code-First approach, we create the classes for our domain entities first. Later, we’ll create the database from our code by using migrations.
In the EF Core Code-First approach, we have full control over the code and the database is just a store without any logic. This approach is helpful in situations where we are starting with the development of a new project and we don’t have a clear picture of how our database should look like yet.

We don’t have to worry about creating and updating the database. We can just make the changes in our code and then sync everything easily with the database. The important thing to note is that the manual changes that we make to the database could be lost during migration. So we should make changes to the code only.

add-migration

initialCreate

update-database

add-migration -context datacontext
update-database -context datacontext
