using System.ComponentModel.DataAnnotations;
namespace  linq
{
    public class Employee
    {
        public int? id {get; set;}
        [Required]
        public string name {get; set;}
        [MaxLength(5)]
        public string fname {get; set;}
        public int age {get; set;}

        public Employee(int? id,string name, string fname, int age ){
            this.id=id;
            this.name=name;
            this.fname=fname;
            this.age=age;
        } 
        
    }
    
}