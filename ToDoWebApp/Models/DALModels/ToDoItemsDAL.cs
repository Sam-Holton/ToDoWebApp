using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWebApp.Models.DALModels
{
    public class ToDoItemsDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public string ItemDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime ItemDueDate { get; set; }
        public bool ItemCompleted { get; set; }

        public int ToDoUsersDAL { get; set; }

    }
}
