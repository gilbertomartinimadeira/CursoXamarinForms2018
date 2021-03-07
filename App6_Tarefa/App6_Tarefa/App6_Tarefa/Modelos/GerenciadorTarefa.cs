using System;
using System.Collections.Generic;
using System.Text;

namespace App6_Tarefa.Modelos
{
    public class GerenciadorTarefa
    {
        private readonly List<Tarefa> tarefas;

        public GerenciadorTarefa()
        {
            tarefas = new List<Tarefa>();
        }
        public void Salvar(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
            SalvarNoProperties(tarefas);
            
        }

        public void Remover(Tarefa tarefa)
        {           
            tarefas.Remove(tarefa);
            SalvarNoProperties(tarefas);
        }
        public void Finalizar(int indice, Tarefa tarefa)
        {
            tarefas.RemoveAt(indice);

            tarefas.Add(tarefa);
            SalvarNoProperties(tarefas);
        }
        public List<Tarefa> Listar()
        {
            return ListagemNoProperties();
        }        

        private void SalvarNoProperties(List<Tarefa> tarefas)
        {
            if (App.Current.Properties.ContainsKey("tarefas"))
            {
                App.Current.Properties.Remove("tarefas");
            }

            App.Current.Properties.Add("tarefas", tarefas);
        }

        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("tarefas"))
            {
                return (List<Tarefa>)App.Current.Properties["tarefas"];
            }

            return new List<Tarefa>();
        }
    }
}
