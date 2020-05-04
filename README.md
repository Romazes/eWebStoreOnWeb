# WebStore
Top Gun Lab - .NET edition - Final Project
https://github.com/v4dev/WebStore/

Team:
1. Roman Yavnikov (https://github.com/Romazes/)
2. Yana Kovalenko (https://github.com/YanaKovalenko/ https://github.com/Alexsaio/)
3. Vladimir Tonkopryad (https://github.com/v4dev/)

Online Tea Shop final project features Asp.NET Core MVC 3.1 implementation and the following functionality:

1. Multi-layered solution setup<br>
1.1. Create multi-layered project structure<br>
1.1.1. UI project<br>
1.1.2. Infrastructure project<br>
1.1.3. Core project<br>
1.2. Configure project references<br>
1.3. Nuget package dependencies are resolved via packages.config<br>

2. Dependency Injection - Repository Pattern Implementation<br>
2.1. Introduced models<br>
2.2. Introduced repository interfaces<br>
2.3. Introduced mocks<br>
2.4. Configured Startup<br>
2.5. Configured sample Controller<br>
2.6. Configured sample View and ViewModel<br>

3. Configured Entity Framework Core<br>
3.1. Added EF Core related Nuget packages<br>
3.1.1. Microsoft.EntityFrameworkCore.SqlServer<br>
3.1.2. Microsoft.EntityFrameworkCore.Tools<br>
3.2. Added DBContext file and updated its content<br>
3.3. Setup the connection string<br>
3.4. Updated Startup with the database connection string<br>
3.5. Introduced repositories and registered them in Startup<br>
3.6. Performed database initialization and migration<br>
3.7. Configured and performd the DB seeding<br>

4. Front-end setup<br>
4.1. Configured layout, viewstart and viewimports<br>
4.2. Configured bootstrap and jquery support<br>
4.3. Partial views<br>
4.4. Routing<br>
4.5. Navigation menu<br>
4.6. Created home page<br>
4.7. Enabled ViewComponents<br>
4.8. Added custom tag helpers<br>

5. Added additional web application functionality<br>
5.1. Details form<br>

6. Added Shopping Cart functionality<br>
6.1. Entity<br>
6.2. Repository<br>
6.3. Controller<br>
6.4. ViewModel<br>
6.5. View<br>
6.6. Shopping Cart item removal<br>

7. Added Order form functionality<br>
7.1. Entity<br>
7.2. Repository<br>
7.3. Controller<br>
7.4. ViewModel<br>
7.5. View<br>
7.6. Model binding<br>
7.7. Form validation<br>
7.8. Product search<br>

8. Enabled Security - Part 1: User Authentication and User Administration<br>
8.1. Utilized ASP.NET Core identity API<br>
8.2. Added authentication functionality<br>
8.3. Enforced authentication request for user to place an order<br>
8.4. Enabled User Management<br>
