using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace TesteMongoDocker
{
    public class Service
    {
        private readonly IMongoCollection<ObjTeste> _objTestes;

        public Service()
        {
            //var client = new MongoClient("mongodb://admin:mongopass123@localhost:27020");  //caso queira conectar com usuário e senha
            var client = new MongoClient("mongodb://basemongo");
            var database = client.GetDatabase("DataBaseMongo");

            _objTestes = database.GetCollection<ObjTeste>("CollectionTeste");
        }

        public List<ObjTeste> Get() =>
            _objTestes.Find(obj => true).ToList();

        public ObjTeste Get(string id) =>
            _objTestes.Find<ObjTeste>(obj => obj.Id == id).FirstOrDefault();

        public ObjTeste Create(ObjTeste obj)
        {
            _objTestes.InsertOne(obj);
            return obj;
        }

        public void Update(string id, ObjTeste objIn) =>
            _objTestes.ReplaceOne(obj => obj.Id == id, objIn);

        public void Remove(ObjTeste objIn) =>
            _objTestes.DeleteOne(obj => obj.Id == objIn.Id);

        public void Remove(string id) =>
            _objTestes.DeleteOne(obj => obj.Id == id);

        public void RemoveAll() => _objTestes.DeleteMany(obj => true);
    }
}
