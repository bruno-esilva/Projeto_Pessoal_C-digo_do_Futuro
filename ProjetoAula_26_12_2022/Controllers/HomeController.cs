using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using ProjetoAula_26_12_2022.Data;
using ProjetoAula_26_12_2022.Models;
using System.Data.Common;
using System.Diagnostics;

namespace ProjetoAula_26_12_2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static string? connectionString = "server=localhost;database=codigo_do_futuro;user=root;password=root";
        public static int SomarEstoque()
        {
            int soma;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(QtdEstoque) FROM codigo_do_futuro.produto;";
                MySqlCommand command = new MySqlCommand(query, connection);
                var result = command.ExecuteScalar();
                soma = Convert.ToInt32(result);
            }
            return soma;
        }

        public static int VencTresDias()
        {
            int vencendo;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(QtdEstoque) FROM codigo_do_futuro.produto WHERE DataValidade <= DATE_ADD(NOW(), INTERVAL 3 DAY);";
                MySqlCommand command = new MySqlCommand(query, connection);
                var result = command.ExecuteScalar();
                vencendo = Convert.ToInt32(result);
            }
            return vencendo;
        }

        public static int ProdVencidos()
        {
            int vencidos;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(QtdEstoque) FROM codigo_do_futuro.produto WHERE DATE(DataValidade) < DATE(now());";
                MySqlCommand command = new MySqlCommand(query, connection);
                var result = command.ExecuteScalar();
                vencidos = Convert.ToInt32(result);
            }
            return vencidos;
        }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        

    }
}