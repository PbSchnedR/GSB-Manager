using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    public class Log
    {

        public int log_id { get; set; }

        public int origin_user_id { get; set; }

        public DateTime date { get; set; }

        public string field { get; set; }

        public int element_id { get; set; }

        public string description { get; set; }

        public string action_type { get; set; }

        public Log()
        { }

        public Log(int log_id, int origin_user_id, DateTime date, string field, int element_id, string description, string action_type)
        {
            this.log_id = log_id;
            this.origin_user_id = origin_user_id;
            this.date = date;
            this.field = field;
            this.element_id = element_id;
            this.description = description;
            this.action_type = action_type;
        }
    }
}
