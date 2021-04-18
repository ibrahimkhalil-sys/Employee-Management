using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.model
{
    public class Employees
    {
        #region PROPERTIES
        public string name { get; set; }
        public string surname { get; set; }
        public int passportNum { get; set; }

        /// <summary>
        /// staf bide manager olur
        /// staf girende ferqli ekran acilir
        /// manager girende ferqli ekran acilir
        /// </summary>
        public string position { get; set; }
        public string salary { get; set; }

        public string username { get; set; }
        public String password { get; set; }
        #endregion

        public Employees()
        {

        }

        /// <summary>
        /// constraktor iscinin melumatlari qeyd eliyr
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="passportNum"></param>
        /// <param name="position"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="salary"></param>
        public Employees(string name,string surname, int passportNum,string position,string username, string password, string salary = "")
        {
            this.name = name;
            this.surname = surname;
            this.passportNum = passportNum;
            this.position = position;
            this.username = username;
            this.password = password;
            this.salary = salary;
            
        }

        #region GET SET PROPERTIES
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setsurname(string surname)
        {
            this.surname = surname;
        }
        public string getsurname()
        {
            return this.surname;
        }
        public void setpassportNum()
        {
            this.passportNum = passportNum;
        }
        public int getpassportNum()
        {
            return this.passportNum;
        }
        public void setposition(string position)
        {
            this.position = position;
        }
        public string getposition()
        {
            return this.position;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public string getUsername()
        {
            return this.username;
        }
        public void setPassword(string password) {
            this.password = password;
        }
        public string getPassword() {
            return  this.password;
        }
        public override string ToString()
        {
            return "name-surname :" + this.name + "" + this.surname;
        }
        #endregion
    }
}
