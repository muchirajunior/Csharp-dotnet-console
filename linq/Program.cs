﻿using System;

namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {
            var query = new SimpleQuery();
            query.querySyntax();
            query.methodSyntax();
            query.mixedSyntax();
            query.orderby();
            query.queryperson();
            query.methodemployee();
            query.queryProducts();
        }
    }
}
