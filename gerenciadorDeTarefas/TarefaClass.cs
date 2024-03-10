
public class TarefaClass
{
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public bool Concluida { get; private set; }

    public  TarefaClass( string titulo, string descricao){
        Titulo = titulo;
        Descricao = descricao;
        Concluida = false;

    }

    public void MarcarConcluida(){
        Concluida = true;
    }

   
}
 public class ListaDeTarefas
    {
        private List<TarefaClass> tarefas;

        public ListaDeTarefas()
        {
            tarefas = new List<TarefaClass>();
        }

        public void AdicionarTarefa(TarefaClass tarefa)
        {
            tarefas.Add(tarefa);
        }
        public void RemoverTarefa(TarefaClass tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public void ListarTarefas()
        {
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa.Titulo);
            }
        }
    }