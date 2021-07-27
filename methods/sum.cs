using System.Collections.Generic;
using System.Linq;

namespace methods{

    class Calculator{

        public int sum(params int[] numbers){
            return numbers.Sum();
        }
    }
}