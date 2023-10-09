
#region Package Manager Console
// to open package manager console window :-
// go to View -> Other Windows -> Package Manager Console 
// install EF Package : on Nuget.org website search about the package and the version wanted
#endregion

#region EF & LINQ Statments to Sql Code
// --> to see the sql code of ef statments :
// open Sql Server Profiler -> New Trace -> connect ot sql server ->  Run 
#endregion

#region 4 Ways For Mapping
// there is 4 ways for mapping classes to database (EF Core Code First)
// there 4 ways to map objects to storage tables
// 1- the class Follow EF rules ( by convension)
// 2- using Data Annontation
// 3- using Fluent API (in Context Class on OnConfigration Function)
// 4- using Configration Class ( seprate configration class )

#region By Convension
// 1-> By Convension ( default behaviour )
// ----->> the Primary Key : public property called Id or TableNameID and it will be identity
// ----->> Each datatype allow null will allow null on database [Optional]
// ----->> Each datatype not allow null will not allow null on databsae [Required]
// ------------>> there is Nullable<int> or int? to make it allow the null 
// ----->> Each property of datatype string is convert to nvarchar(max)
// ----->> Each property of datatype decimal is convert to decimal(18,2)
#endregion

#region Data Annotation
// 2-> By Data Annotation
// set of attributes used for data vaildation
// not all of data annotation convert into sql in database
// -- but it will work on front end validation

//[Key] // to make that property table primary key
//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//(1,1) to make it identity
//                                                     //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]// to disable identity
//public int StdID { get; set; }

//[Required]// to make it mandatory
//[Column(TypeName = "varchar")]// to convert string to varchar insteatd of nvarchar
//[MaxLength(100)] //to make the max count of chars in that property 100 instead of Max
//[MinLength(5)] // to make the min count of chars in that property 5 instead of 0 or 1
//[StringLength(50, MinimumLength = 5)]// max count : 50 and min count : 5
//public string? FullName { get; set; }

//[Range(16, 25)]
//public int? Age { get; set; }
//public string? Address { get; set; }

//[Column(TypeName = "money")]
//[DataType(DataType.Currency)]
//public decimal Salary { get; set; }// will converted to decimal(18,2)

//[EmailAddress]
//[DataType(DataType.EmailAddress)]
//public string Email { get; set; }

//[Phone]
//[DataType(DataType.PhoneNumber)]
//public int PhoneNumebr { get; set; }

//[DataType(DataType.Password)]
//public string Password { get; set; } 
#endregion

#region Fluent APIs
// The Third Way : Fluent APIs :
// the first way to use it :
// ---> there is scenario can not applied it by Convension or Data Annontation
// ---------->> like compoiste PK
// ---------->> like default values
// the second way is :
// ---> you don't have the source code of the class
// ---->> on DBContext class -> override OnModelCreating(){} Method
// the other way is :
// ---> to convert class to View or Function 
#endregion

#region Configration Class
// the fourth way is to make configration class per entity : organization for the thrid way:
// -> create configration classs that implement the IEntityTypeConfiguration<classname> Interface
// -> put the fluent APIs configrations on it
// -> on the DbContext -> on OnModelCreation method 
// ----->>> there is function to apply the configration class that take object of it (configration class)
// ----->>> modelBuilder.ApplyConfiguration(new ConfigClass()) 
#endregion


#endregion

#region Mapping Principles
// each class will be mapped to a table

// and each table must have primary key
// --> by default any property with name ID or TableNameID will mapped as the primary key
// --> or before the property set the attribute of [PrimaryKey]
// --> that key by default is identity ( auto increment )

// to make any column allows null
// --> any refernce type by defualt allows null
// --> make of type of data is nullable like :
// ----------> int? age , Nullable<int> age 
// ----------> or before the property of it set the attribute [AllowNull]

// to make any column does not allow null
// --> any value type by defualt does not allow null
// --> any refernce type set before the property the attribute [Required]

// to make compiste attribute on sql { that consist of more one attribute }
// ---> create class that does not have any primay key
// ---> and must there is at least on class that use it

// to make relation between two classes :-
// --> if the relation One-to-Many :-
// ------->> on the class that is the One side : create ICollection (or List,..) of the class that is many side
// ------->> on the class that is the many side : create property of type the class is the one side

// if the class don't created yet , then must use one of the functions that ensure the creation of database
// 1- Database.EnsureCreated() ->
// if there is change on structure of database and must use of the function that drop and create database
// 1- EnsureDeleted() -> but if there any data will be dropped
// ---------->> and on any run for the app will drop data 
#endregion

#region Migration
// if we want to use Migration
// -> it must install EF tools on the project
// -> on the Package manager Console 
// ---> install-package Microsoft.EntityFrameworkCore.tools
// -> then add the migration
// ---> Add-migration InitialCreate { name of migration and can be edited on the project }
// ---> the first migration should be called "InitialCreate" 
// ---> the class has two methods or functions :
// -------->>> 1- Up() : to do the edites on tables and database
// ---------------------->>> to apply it :
// ---------------------------->>> a- Package-Manager Console : Update-Database
// ---------------------------->>> b- create object of context and context.database.Migrate()
// -------->>> 2- Down() : to remove the thoses edits from database
// --------------------->>> to apply it :
// ---------------------------->>> P-M C : Update-database -Migration "Pervious-Miigration Name"
// ---------------------------->> and can remove it by : Remove-Migration {will remove the last migration }
// ----->>> to rollback the first migration ( apply Function Down() on the first migration } :
// ------------>>> Update-Database 0 
// ------------>>> Remove-Migration 
#endregion

#region RelationShips
// Relations between classes 

#region One-To-Many
// One-to-Many
// on the One side Class : create list of class that are in many side
// one the many side Class : create object of the one side
//--> and create forign key of One Side Key
// --> to make property Forign key :
// --------------> By Convension : to make the name of property TableNamePKName like DepartmentDeptID
// --------------> By Data Annontation : To make [ForeignKey("navigationPropertyName")]
// --------------> By Fluent APIs : to make : ->
//modelBuilder.Entity<Employee>()
//    .HasOne(E => E.Department)
//    .WithMany(D => D.Employees)
//    .HasForeignKey(E => E.DepartmentID)
//    .OnDelete(DeleteBehavior.Cascade);  
#endregion

#region Many-To-Many
// Many-To-Many Relation
// if there is no extra data on relation
// -> on each class create list of the other class
// -> or by Fluent APIs
//// create the relation many to many
//modelBuilder.Entity<Student>()
//    .HasMany(S => S.Courses)
//    .HasMany(C => C.Students)
// ----->
// if there is extra data on the relation
// -> should create new class :
// ----->>> the forign key of each class
// ----->>> on each class of relation create list of newClass
// ----->>> to create the compoiste PK of newClass only on Fluent APIs 
#endregion

#region Two RelationShips between Two Classes : Manage & Work
// if two classes has two relationships 
// we should use [InverseProperty("NavigationalPropertyOnOtherClassName")] on each class of them : 
// --> and give it the name of navigational property name of the other class 
#endregion

#endregion

#region Inheritance Mapping
// Inheritance Class

#region Table per Concrete Class
// -> if the classes inherit from a perent class
// -> we can map the child classes only :
// ---> by making DbSet<childClass> on the DbContext class
// -> it called table per concrete class  
#endregion

#region Table Per Hierarchy
// table per hierarchy
// if there is classes inherite from parent class
// and we need to map the thoses to an one table
// can only do that by Fluent APIs :
// --> it will map all properties to one table
// ----> and another column called Discriminator : that have the type of child class
// we can create two DbSet<> to the child classes or create one DbSet<> for the parent class 
// ---> we can access the properties on the childs class by objectParenClass.OfType<ChildClass>()
#endregion

#endregion

#region Make EF accept Date Only
// to use DateOnly and TimeOnly on mapping 
// need to install nuget package 
// and on the connection string give it the property of package :
// --> optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UniversityDB;Integrated Security=true;TrustServerCertificate=True",X => X.UseDateOnlyTimeOnly()); 
#endregion

#region Close Connection Context.Dispose
// after using the context ( open the connection to database)
// it should close the connection ( dispose the context)
// we can do that by :
// ---> to make the code in try and finally
// ---> to make the create context by keyword using and the code between Scope {} -> using(context){}
// ------------>>> and the context will be disposed auto on end of scope
// ---> to make the create of context after keyword using and don't use scope -> using context;
// --> the best way is the last way 
#endregion


using EF_Core7.Contexts;
using EF_Core7.Entites;
using System.Runtime.CompilerServices;

UniversityContext context = new UniversityContext();

#region The First Way to Dispose the context after using it
try
{
    Student std01 = new Student()
    {
        FullName = "Hassan Khalaf",
        Age = 25,
        Address = "Sohag"
    };

    #region State of Object ( added or no )
    // to  know the state of object related to databse
    // we can use context.Entry(object).State
    // it is Enum have 5 labels :
    // ----->>> Detached = 0
    // ----->>> Unchanged = 1
    // ----->>> Deleted = 2
    // ----->>> Modifies = 3
    // ----->>> Added = 4 
    #endregion

    Console.WriteLine(context.Entry(std01).State); // detached not related to database

    #region Add object to database
    // we can add the object by different ways :
    // ---> 
    //context.Students.Add(std01);
    //context.Set<Student>().Add(std01);
    //context.Add(std01);
    //context.Entry(std01).State = Microsoft.EntityFrameworkCore.EntityState.Added; 
    #endregion

    context.Students.Add(std01);

    Console.WriteLine(context.Entry(std01).State); //Added

    // but still the object not added to databse , it added locally
    // to add it to database we use saveChanges()

    context.SaveChanges();

    Console.WriteLine(context.Entry(std01).State); // Unchanged

    var std = context.Students.Where(S => S.StudentID == 2);// this will return list of one item
    var std2 = context.Students.Where(S => S.StudentID == 2).FirstOrDefault(); // this will return one item

    Console.WriteLine(std2?.FullName??"NA");
}
finally
{
    context.Dispose();
}
#endregion

#region The Second Way to Dispose the context
//using(UniversityContext context2 = new UniversityContext())
//{
//    context2.SaveChanges();
//} 
#endregion