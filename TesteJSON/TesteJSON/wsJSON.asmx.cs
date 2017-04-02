using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TesteJSON.Models;
namespace TesteJSON
{
    /// <summary>
    /// Summary description for wsJSON
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsJSON : System.Web.Services.WebService
    {

        [WebMethod]
        public Pessoa TestePessoa(Pessoa pessoa)
        {

            Pessoa teste = new Pessoa();

            teste = pessoa;


            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.idade);

            pessoa.nome = "Sujão";

            return pessoa;
        }
    }
}
