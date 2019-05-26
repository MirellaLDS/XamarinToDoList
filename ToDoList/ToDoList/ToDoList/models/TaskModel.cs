using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.models
{
    [Table("TaskModel")]
    public class TaskModel
    {
        [PrimaryKey(), AutoIncrement()]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("endDate")]
        public string EndDate { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
