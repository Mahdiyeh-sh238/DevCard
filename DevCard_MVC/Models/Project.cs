using System;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Client{ get; set; }
        public String Image { get; set; }

        public Project(long id, string name, string title, string description, string client, string image)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;
            Client = client;
            Image = image;
        }
    }

}
