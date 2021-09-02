using System;
using System.Collections.Generic;
using System.Linq;

namespace linq{
   public  class SimpleQuery{
      private  List<int> numbers=new List<int>() {3,5,4,7,8,6,2,1,9};

      private List<Person> people=new List<Person>(){
          new Person(){id=1,name="john"},
          new Person(){id=2, name="james"},
          new Person(){id=3, name="alex "}
      };

      private List<Employee> employees=new List<Employee>(){
          new Employee(null,"hannan","ray",20),
          new Employee(2,"jayden","rice",33),
          new Employee(3,"liam",null,55)
      };

      private List<Product> products=new List<Product>(){
          new Product(1,"product 1",200),
          new Product(2," product name",300)
      };

        public  void querySyntax(){
        var query= from obj in numbers 
                           where obj > 4 
                           select obj;

        foreach (var item in query) Console.WriteLine("number : {0}",item);

        }

        Action<int> method = (int numb) => Console.WriteLine($"The number: {numb}");

        public void methodSyntax(){
            var query= numbers.Where(obj => obj>3);
            query.ToList().ForEach(method);
            foreach (var item in query) Console.WriteLine("The number : {0}",item);
           
        }
      
      

        public void mixedSyntax(){
            var sum= (from obj in numbers select obj).Sum();
            var maximum= (from obj in numbers select obj).Max();
            Console.WriteLine("the sum is : {0} , and the maximum no is : {1}",sum,maximum);
        }
      
      public void orderby(){
		int[] array={5,7,2,4,3,9};
		var query=array.OrderBy(num => num).ToList();
		foreach (var item in query)
			Console.WriteLine(item);
      }

        public void queryperson(){
            IEnumerable<Person> query= from obj in people 
                                        where obj.id>0 
                                        select obj;

            foreach (var item in query)
                   Console.WriteLine("Person id is {0} and name is {1}",item.id, item.name);
          
        }

        public void methodemployee(){
            IQueryable<Employee> query=employees.AsQueryable();//.Where(obj => obj.id>0);

            foreach (var item in query)
                    Console.WriteLine("Employeeid id is {0} name : {1} fname :{2} age : {3}",item.id,item.name,item.fname,item.age);
           
        }

        public void queryProducts(){
            var query= products.Where((item)=>item.id==1).ToList()[0];
            int x='B';
            Console.WriteLine(x);
              Console.WriteLine("id :{0} name: {1} price : {2}  ", query.id, query.name, query.price);
        }
    }
}
