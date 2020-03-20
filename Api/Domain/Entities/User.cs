using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Backend.Domain.Entities
{
    public class User : Entity
    {
        public User(string login, string name, string email, string position, string Image, string role)
        {
            ValidateLogin(login);
            ValidateName(name);
            ValidateEmail(email);
        }
        [Key]
        public int Login { get; set; }
        public int Name { get; set; }
        public int Email { get; set; }
        public int Position { get; set; }
        public string Password { get; set; }
        public string Image {get; set; }
        public string Role {get; set; }

        public static void ValidateLogin(string login)
        {
            if (String.IsNullOrEmpty(login))
                throw new Exception("Login deve ser informado");

            if (login.Length < 3 || login.Length > 20)
                throw new Exception("Login deve conter entre 3 e 20 caracteres");
        }
        public static void ValidateName(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("Nome deve ser informado");
        }
        public static void ValidateEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                throw new Exception("E-mail deve ser informado");

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
                throw new Exception("E-mail inválido");
        }

        public static void ValidaRole(string role)
        {
            if (String.IsNullOrEmpty(role))
                role = "user";
        }
    }
}