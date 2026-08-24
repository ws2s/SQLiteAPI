using SQLiteAPI.Models;

namespace SQLiteAPI.Data.Services;
public class AppData
{
    public string CompID { get; set; }
    public string BaseUri { get; set; }
    
    public bool PageInitialized { get; set; }
    public bool isSubmitting { get; set; }
    public HttpResponseMessage HttpResponse { get; set; }
    
    public List<PizzaSpecial> specials { get; set; } = new List<PizzaSpecial>();
    
}