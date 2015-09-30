




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class Range : GeneratedTest {



        [Test]
        public void YamlTest(){

             
             {
                 //JavaQuery, range.yaml, #1
                 //ExpectedOriginal: STREAM
                 var expected = "STREAM";
                 
                 //Original: r.range().type_of()
                 var obtained = runOrCatch( r.range().typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #2
                 //ExpectedOriginal: [0, 1, 2, 3]
                 var expected = Arrays.asList(0, 1, 2, 3);
                 
                 //Original: r.range().limit(4)
                 var obtained = runOrCatch( r.range().limit(4) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #3
                 //ExpectedOriginal: [0, 1, 2, 3]
                 var expected = Arrays.asList(0, 1, 2, 3);
                 
                 //Original: r.range(4)
                 var obtained = runOrCatch( r.range(4) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #4
                 //ExpectedOriginal: [2, 3, 4]
                 var expected = Arrays.asList(2, 3, 4);
                 
                 //Original: r.range(2, 5)
                 var obtained = runOrCatch( r.range(2, 5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #5
                 //ExpectedOriginal: []
                 var expected = Arrays.asList();
                 
                 //Original: r.range(0)
                 var obtained = runOrCatch( r.range(0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #6
                 //ExpectedOriginal: []
                 var expected = Arrays.asList();
                 
                 //Original: r.range(5, 2)
                 var obtained = runOrCatch( r.range(5, 2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #7
                 //ExpectedOriginal: [-5, -4, -3]
                 var expected = Arrays.asList(-5, -4, -3);
                 
                 //Original: r.range(-5, -2)
                 var obtained = runOrCatch( r.range(-5, -2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #8
                 //ExpectedOriginal: [-5, -4, -3, -2, -1, 0, 1]
                 var expected = Arrays.asList(-5, -4, -3, -2, -1, 0, 1);
                 
                 //Original: r.range(-5, 2)
                 var obtained = runOrCatch( r.range(-5, 2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #10
                 //ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", [])
                 var expected = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", Arrays.asList());
                 
                 //Original: r.range("foo")
                 var obtained = runOrCatch( r.range("foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #11
                 //ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer \\(>2\\^53\\). 9007199254740994", [])
                 var expected = err_regex("ReqlQueryLogicError", "Number not an integer \\(>2\\^53\\). 9007199254740994", Arrays.asList());
                 
                 //Original: r.range(9007199254740994)
                 var obtained = runOrCatch( r.range(9007199254740994.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #12
                 //ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer \\(<-2\\^53\\). -9007199254740994", [])
                 var expected = err_regex("ReqlQueryLogicError", "Number not an integer \\(<-2\\^53\\). -9007199254740994", Arrays.asList());
                 
                 //Original: r.range(-9007199254740994)
                 var obtained = runOrCatch( r.range(-9007199254740994.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #13
                 //ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer. 0\\.5", [])
                 var expected = err_regex("ReqlQueryLogicError", "Number not an integer. 0\\.5", Arrays.asList());
                 
                 //Original: r.range(0.5)
                 var obtained = runOrCatch( r.range(0.5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #14
                 //ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", [])
                 var expected = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", Arrays.asList());
                 
                 //Original: r.range().count()
                 var obtained = runOrCatch( r.range().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #15
                 //ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", [])
                 var expected = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", Arrays.asList());
                 
                 //Original: r.range().coerce_to("ARRAY")
                 var obtained = runOrCatch( r.range().coerceTo("ARRAY") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #16
                 //ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", [])
                 var expected = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", Arrays.asList());
                 
                 //Original: r.range().coerce_to("OBJECT")
                 var obtained = runOrCatch( r.range().coerceTo("OBJECT") ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             
             
             {
                 //JavaQuery, range.yaml, #17
                 //ExpectedOriginal: 4
                 var expected = 4;
                 
                 //Original: r.range(4).count()
                 var obtained = runOrCatch( r.range(4).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected, obtained);
             }
             

        }
    }
}