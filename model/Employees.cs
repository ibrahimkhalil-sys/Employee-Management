using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketiscileri.model
{
    public class Employees
    {
       
        public string name { get; set; }
        public string surname { get; set; }
        public int passportNum { get; set; }
        public string position { get; set; }
        public string salary { get; set; }

        public string username { get; set; }
        public String password { get; set; }

        public Employees()
        {

        }

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
    }
}
