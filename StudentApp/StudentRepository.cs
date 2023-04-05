using SQLite;
using StudentApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    public class StudentRepository
    {
        SQLiteConnection database;
        public StudentRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Student>();
            database.CreateTable<Group>();
        }
        public IEnumerable<Student> GetItemsStudent()
        {
            return database.Table<Student>().ToList();
        }
        public IEnumerable<Group> GetItemsGroup()
        {
            return database.Table<Group>().ToList();
        }
        public Student GetItemStudent(int id)
        {
            return database.Get<Student>(id);
        }
        public Group GetItemGroup(int id)
        {
            return database.Get<Group>(id);
        }
        public int DeleteItemStudent(int id)
        {
            return database.Delete<Student>(id);
        }
        public int DeleteItemGroup(int id)
        {
            return database.Delete<Group>(id);
        }
        public int SaveItemStudent(Student item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public int SaveItemGroup(Group item)
        {
            if (item.IdGroup != 0)
            {
                database.Update(item);
                return item.IdGroup;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
