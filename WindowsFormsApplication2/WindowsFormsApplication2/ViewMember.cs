using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ViewMember
    {
        this.id = member.id;
            this.Fullname = member.Fullname;
            if (member.Gender == true)
                this.Gender = "Nam";
            else
                this.Gender = "Nu";
            if(member.Birthday.HasValue)
                this.Birthday = String.Format("{0}/{1}/{2}",
                    member.Birthday.Value.Day,
                    member.Birthday.Value.Month,
                    member.Birthday.Value.Year;
                    
            if(member.Status.HasValue)
                this.Status = member.Status.Value == true ? "Living" : "Decreased";
            this.Living = member.Living;
            this.Occupation = member.Occupation;
            var db = new OPCSEntities();
            if(member.Father_id.HasValue)
            {
                var father = db.Members.Find(member.Father_id.Value);
                this.Father = father.Fullname;
            }
            if(member.Spouse_id.HasValue)
            {
                var spouse = db.Members.Find(member.Spouse_id.Value);
                this.Spouse = spouse.Fullname;
            }
        }
        public int id { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Hometown { get; set; }
        public string Living { get; set; }
        public string Occupation { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string Spouse { get; set; }
    
    }
}

    }
}
