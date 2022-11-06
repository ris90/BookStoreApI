using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Data
{
    
    public class Books
    {

        [Key]
        public int BookId { get; set; }
      
        public string Title { get; set; }
       
        public string Description { get; set;}
    }
}
