using MongoDB.Bson;
using System;

namespace TesteMongoDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Service _service = new Service();

            Console.WriteLine("Removendo todos itens da coleção do mongo...");
            _service.RemoveAll();

            Console.WriteLine("Criando dois objetos 'chumbados' para salvar no mongo...");

            ObjTeste t1 = new ObjTeste()
            {
                //Id = ObjectId.GenerateNewId().ToString(),
                Name = "testando obj 1"
            };
            _service.Create(t1);

            ObjTeste t2 = new ObjTeste()
            {
                //Id = ObjectId.GenerateNewId().ToString(),
                Name = "testando obj 2"
            };
            _service.Create(t2);

            Console.WriteLine("Listando os objetos criados...");
            var listaMongo = _service.Get();

            foreach (var item in listaMongo)
            {
                Console.WriteLine("");
                Console.WriteLine($"Item ID: {item.Id} - Name: {item.Name} ");
            }

            Console.ReadKey();
        }
    }
}
