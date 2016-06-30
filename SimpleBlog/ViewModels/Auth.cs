using System.ComponentModel.DataAnnotations; // Anntation: a note by way of explanation or comment added to a text or diagram.

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        [Required] // this is another annotation
        public string Username { get; set; }

        
        [Required, DataType(DataType.Password)] // this here is how we tell the view that the html.EditorFor contains password data. This is called
        // data annotation and we must import the namespace with the using key word.
        public string Password { get; set; } 
        


    }
}