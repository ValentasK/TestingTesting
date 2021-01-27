using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavePhotoToFolderAPI.Models
{
    public class Photo
    {
        public string UserName { get; set; }
        public string PhotoID { get; set; }
        public bool Resized { get; set; }
        public int PhotoWidth { get; set; }
        public int PhotoHeight { get; set; } // nu kas dbr ? 
    }
}
