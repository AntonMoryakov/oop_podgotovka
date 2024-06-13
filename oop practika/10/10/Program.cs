using _10;

using var context = new TestDbContext();
var testTable = new TestTable { Value = "Abobing" };
context.TestTables.Add(testTable);
context.SaveChanges();