using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAproject1
{
    class TeacherInfo
    {
            public int ID { set; get; }
            public string Teachername { set; get; }
            public string Clas { set; get; }
            public string Section { set; get; }

        public TeacherInfo(int ID, string Teachername, string Clas, string Section)
        {
            this.ID = ID;
            this.Teachername = Teachername;
            this.Clas = Clas;
            this.Section = Section;
        }
    }
}