using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    [SQLite.Table("Students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("_id")]
        public int Id { get; set; }

        public int IdGroup { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DateOfBirthday { get; set; }
    }
}
