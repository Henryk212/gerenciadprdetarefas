// See https://aka.ms/new-console-template for more information


TarefaClass primeiraTarefa = new TarefaClass("Estudar C#", "Estudar C# para melhorar minhas habilidades"); 
TarefaClass segundaTarefa = new TarefaClass("Estudar java", "Pelo menos uma vez na semana"); 

ListaDeTarefas listaDeTarefas = new ListaDeTarefas();

        // Adiciona as tarefas à lista
        listaDeTarefas.AdicionarTarefa(primeiraTarefa);
        listaDeTarefas.AdicionarTarefa(segundaTarefa);

        // Lista as tarefas
        Console.WriteLine("Tarefas:");
        listaDeTarefas.ListarTarefas();

       
        primeiraTarefa.MarcarConcluida();

       
        listaDeTarefas.RemoverTarefa(segundaTarefa);

       
        Console.WriteLine("\nTarefas após a remoção:");
        listaDeTarefas.ListarTarefas();
