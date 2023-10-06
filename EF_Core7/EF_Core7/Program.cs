
#region Package Manager Console
// to open package manager console window :-
// go to View -> Other Windows -> Package Manager Console 
// install EF Package : on Nuget.org website search about the package and the version wanted
#endregion

#region 4 Ways For Mapping
// there is 4 ways for mapping classes to database (EF Core Code First)

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

#endregion

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

// there 4 ways to map objects to storage tables
// 1- the class Follow EF rules
// 2- using Data Annontation
// 3- using Fluent API (in Context Class on OnConfigration Function)
// 4- using Configration Class ( seprate configration class )

// if the class don't created yet , then must use one of the functions that ensure the creation of database
// 1- Database.EnsureCreated() ->
// if there is change on structure of database and must use of the function that drop and create database
// 1- EnsureDeleted() -> but if there any data will be dropped
// ---------->> and on any run for the app will drop data

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

#region EF & LINQ Statments to Sql Code
// --> to see the sql code of ef statments :
// open Sql Server Profiler -> New Trace -> connect ot sql server ->  Run 
#endregion


using EF_Core7.Contexts;

UniversityContext context = new UniversityContext();
context.Students.Add(new EF_Core7.Entites.Student()
{
    FullName = "Hassan Tawfik",
    Age = 25,
    Address = "Giza"
});

context.SaveChanges();
