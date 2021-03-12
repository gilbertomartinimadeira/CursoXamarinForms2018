using System.Collections.Generic;
using System.Threading.Tasks;
using App09_Vagas.Modelos;
using SQLite;
using Xamarin.Essentials;

namespace App09_Vagas.Banco
{
    public class VagaRepository
    {
        private SQLiteConnection _connection;

        public VagaRepository()
        {
            var libFolder = FileSystem.AppDataDirectory;
            var dbPath = System.IO.Path.Combine(libFolder, "db.sql");
            
            _connection = new SQLiteConnection(dbPath);            
        }

        public void CreateDataBase()
        {
            var result = _connection.CreateTable<Vaga>();
            System.Console.WriteLine(result);
        }

        public List<Vaga> Consultar()
        {
            return _connection.Table<Vaga>().ToList();
        }

        public Vaga ObterVagaPorId(int id)
        {
            return _connection.Table<Vaga>().FirstOrDefault(Vaga => Vaga.Id == id);
        }

        public List<Vaga> Pesquisar(string palavra)
        {
            return  _connection.Table<Vaga>().Where(v => v.Nome.Contains(palavra)).ToList();
        }
        public void Cadastro(Vaga vaga)
        {
             _connection.Insert(vaga);
        }

        public void Atualizacao(Vaga vaga)
        {
            _connection.Update(vaga);
        }


        public void  Exclusao(Vaga vaga)
        {
            _connection.Delete(vaga);
        }

    }
}
