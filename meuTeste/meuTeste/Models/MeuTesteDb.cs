using MongoDB.Driver;

namespace meuTeste.Models
{
    public class MeuTesteDb
    {

        public MongoDatabase Database;
        const string DataBaseName = "local";
        string conexaoMongoDB = "mongodb://root:MongoDB2019!@localhost:27017";

        public MeuTesteDb()
        {

            var cliente = new MongoClient(conexaoMongoDB);
            var server = cliente.GetServer();
            Database = server.GetDatabase(DataBaseName);

        }

        public MongoCollection<MeuTeste> MeuTestesCollection
        {
            get
            {
                return Database.GetCollection<MeuTeste>("MeuTeste");
            }
        }
    }
}
