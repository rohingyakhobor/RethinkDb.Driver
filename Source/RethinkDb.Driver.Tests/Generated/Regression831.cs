




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
    public class Regression831 : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/831.yaml, #1
                 /* ExpectedOriginal: ({'first_error':'Expected type OBJECT but found BOOL.', 'skipped':0, 'deleted':0, 'unchanged':0, 'errors':2, 'replaced':0, 'inserted':0}) */
                 var expected_ = r.hashMap("first_error", "Expected type OBJECT but found BOOL.").with("skipped", 0L).with("deleted", 0L).with("unchanged", 0L).with("errors", 2L).with("replaced", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.insert([True, True]) */
                 var obtained = runOrCatch( tbl.insert(r.array(true, true)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
