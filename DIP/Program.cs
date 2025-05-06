// DEPENDENCY INVERSION PRINCIPLE
// constructor injection
// property injection
// method injection

using DIP.IyiYontem;

SqlDatabase sqlDatabase = new SqlDatabase();
OracleDatabase oracleDatabase = new OracleDatabase();

void EkranaYaz(IEnumerable<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

DatabaseManager databaseManager1 = new DatabaseManager(sqlDatabase);
EkranaYaz(databaseManager1.VerileriListele());

// oracle a geçmek istediğimizde;
DatabaseManager databaseManager2 = new DatabaseManager(oracleDatabase);
EkranaYaz(databaseManager2.VerileriListele());

// method injection kullanımı
DatabaseManager databaseManager3 = new DatabaseManager(); // method injection yapmak için oluşturduk. bu şekilde kullanabilmemiz için default ctor da eklememiz lazım
// EkranaYaz(databaseManager3.VerileriListele()); // null referans hatası alırız çünkü databaseManager3'ün veritabanı null
databaseManager3.MethodInjection(oracleDatabase); // oracle database i method injection ile ekliyoruz.
EkranaYaz(databaseManager3.VerileriListele()); // oracle database i ile listeleme yapıyoruz.

// property injection kullanımı
DatabaseManager databaseManager4 = new DatabaseManager();
// EkranaYaz(databaseManager4.VerileriListele()); // null referans hatası alırız çünkü databaseManager4'ün veritabanı null
databaseManager4.PropertyInjection = sqlDatabase; // property injection ile sql database i ekliyoruz.
EkranaYaz(databaseManager4.VerileriListele()); // sql database i ile listeleme yapıyoruz.