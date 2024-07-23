using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUserName);
        }
    }
}
