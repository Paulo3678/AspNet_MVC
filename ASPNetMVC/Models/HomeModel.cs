namespace ASPNetMVC.Models;

public class HomeModel
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public List<HomeModel> GetAll()
    {
        HomeModel item;
        List<HomeModel> list = new List<HomeModel>();
        item = new HomeModel();
        item.Id = 1;
        item.Nome = "Filipe";
        list.Add(item);

        item.Id = 2;
        item.Nome = "Aluno";
        list.Add(item);

        return list;
    }
}
