using SistemaVendas.Uteis;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SistemaVendas.Models;

public class LoginModel
{
    [Required(ErrorMessage = "É preciso informar o e-mail para continuar.")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "É preciso informar um e-mail válido para continuar.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "É preciso informar a senha para continuar.")]
    public string Senha { get; set; }

    public bool ValidarLogin()
    {
        string sql = $"SELECT id FROM vendedor WHERE email='{Email}' AND senha='{Senha}'";
        DAL objDAL = new DAL();
        DataTable dt = objDAL.RetDataTable(sql);

        if (dt.Rows.Count == 1)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}
