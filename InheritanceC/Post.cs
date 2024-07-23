
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Post
    {
        private static int CurrentPostID {  get; set; }
        protected int ID { get; set; }
        protected string Title {  get; set; }
        protected string SendByUserName {  get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Giorgi - El Kumi - Shamiani";
        }

        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }
        public int GetNextID()
        {
            return ++CurrentPostID;
        }

        public void UpdatePost(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }
    }
}
