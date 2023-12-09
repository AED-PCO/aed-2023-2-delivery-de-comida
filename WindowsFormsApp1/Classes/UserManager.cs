using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
    internal class UserManager
    {

        private static UserLinkedList AllUsers;

        private string _file_path = Program.root_path + "\\Arquivos\\users.txt";

        public UserManager() {
            this.FetchAllUsers();
        }

        /* Retorno da função de login
         * 0 -> Usuário encontrado e senha correta, login feito!
         * 1 -> Usuário encontrado e senha incorreta, login falho!
         * 2 -> Usuário não encontrado no arquivo, login falho!
        */
        public int Login(string email, string password)
        {
            User logginUser = AllUsers.FindByEmail(email);

            if (logginUser == null) { return 2; }

            return 0;
        }

        public int Logout()
        {
            return 0;
        }

        public int Cadastrar(User newUser)
        {
            return 0;
        }

        private void FetchAllUsers()
        {
            if (AllUsers != null) { return; } 

            AllUsers = new UserLinkedList();

            string[] userData = File.ReadAllLines(this._file_path);

            foreach (string data in userData) // Percorrendo usuarios
            {
                this.SetUserData(data);
            }
        }

        private void SetUserData(string uData)
        {
            Type userType = typeof(User);
            User newUser = new User();
            string[] tuplas = uData.Split(';');

            foreach (string tupla in tuplas) // Percorrendo propriedades dos usuarios
            {
                string[] values = tupla.Split('=');

                if (values.Length != 2) { continue; }

                PropertyInfo pInfo = userType.GetProperty(values[0]);

                if (pInfo != null)
                {
                    pInfo.SetValue(newUser, values[1]);
                }
            }

            AllUsers.AddLast(newUser);
        }
    }
}
