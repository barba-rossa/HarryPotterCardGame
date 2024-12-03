using System.Net.Http; // Necessário para fazer chamadas HTTP
using System.Threading.Tasks; // Necessário para trabalhar com tarefas assíncronas
using System.Collections.Generic; // Necessário para listas
using Newtonsoft.Json; // Usado para trabalhar com JSON
using System.Windows.Forms; // Necessário para o MessageBox


public static class DataFetcher
{
    // Declaração do HttpClient (precisa ser estático e acessível dentro da classe)
    private static readonly HttpClient client = new HttpClient();

    // Método para buscar a lista de personagens da API
    public static async Task<List<HarryPotterCharacter>> GetCharactersAsync()
    {
        try
        {
            // Faz a chamada à API e obtém a resposta como string
            var response = await client.GetStringAsync("https://hp-api.herokuapp.com/api/characters");

            // Desserializa a string JSON em uma lista de personagens
            var characters = JsonConvert.DeserializeObject<List<HarryPotterCharacter>>(response) ?? new List<HarryPotterCharacter>();

            // Garante que os valores padrão sejam definidos
            foreach (var character in characters)
            {
                character.Name ??= "Unknown";
                character.House ??= "Unknown";
                character.Image ??= string.Empty;
                character.Ancestry ??= "Unknown";
                character.Patronus ??= "None";
                character.Wand ??= new Wand();
            }

            return characters; // Retorna a lista de personagens
        }
        catch (Exception ex)
        {
            // Mostra um erro caso algo dê errado
            MessageBox.Show($"Error fetching data: {ex.Message}");
            return new List<HarryPotterCharacter>(); // Retorna uma lista vazia para evitar erros
        }
    }
}
