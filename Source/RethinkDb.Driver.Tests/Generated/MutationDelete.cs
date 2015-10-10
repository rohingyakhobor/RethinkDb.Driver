




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
    public class MutationDelete : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #1
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':100}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 100L);
                 
                 /* Original: tbl.insert([{'id':i} for i in xrange(100)]) */
                 var obtained = runOrCatch( tbl.insert(EnumerableLRange(0, 100L).Select(i => r.hashMap("id", i)).ToList()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #2
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #3
                 /* ExpectedOriginal: ({'deleted':1,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 1L).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).delete() */
                 var obtained = runOrCatch( tbl.get(12L).delete() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #4
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Durability option `wrong` unrecognized (options are "hard" and "soft").', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Durability option `wrong` unrecognized (options are \"hard\" and \"soft\").", r.array(0L));
                 
                 /* Original: tbl.skip(50).delete(durability='wrong') */
                 var obtained = runOrCatch( tbl.skip(50L).delete().optArg("durability", "wrong") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #5
                 /* ExpectedOriginal: ({'deleted':49,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 49L).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.skip(50).delete(durability='soft') */
                 var obtained = runOrCatch( tbl.skip(50L).delete().optArg("durability", "soft") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #6
                 /* ExpectedOriginal: ({'deleted':50,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 50L).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.delete(durability='hard') */
                 var obtained = runOrCatch( tbl.delete().optArg("durability", "hard") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #7
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type SELECTION but found DATUM:', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type SELECTION but found DATUM:", r.array(0L));
                 
                 /* Original: r.expr([1, 2]).delete() */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).delete() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
