




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
    public class Joins : GeneratedTest {

            public static Table messages = r.db(DbName).table("messages");
            public static Table receivers = r.db(DbName).table("receivers");
            public static Table senders = r.db(DbName).table("senders");
            public static Table tbl = r.db(DbName).table("tbl");
            public static Table tbl2 = r.db(DbName).table("tbl2");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #1
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test3', primary_key='foo') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test3").optArg("primary_key", "foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, joins.yaml, #Templates.YamlTest+DefTest.
             //Original: tbl3 = r.db('test').table('test3')
             
var tbl3 = (Table) (r.db("test").table("test3"));             
             
             //JavaDef, joins.yaml, #Templates.YamlTest+DefTest.
             //Original: ij = tbl.inner_join(tbl2, lambda x,y:x['a'] == y['b']).zip()
             
var ij = (Zip) (tbl.innerJoin(tbl2, (x, y) => x.g("a").eq(y.g("b"))).zip());             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #7
                 /* ExpectedOriginal: 2500 */
                 var expected_ = 2500L;
                 
                 /* Original: ij.count() */
                 var obtained = runOrCatch( ij.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #8
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: ij.filter(lambda row:row['a'] != row['b']).count() */
                 var obtained = runOrCatch( ij.filter(row => row.g("a").ne(row.g("b"))).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, joins.yaml, #Templates.YamlTest+DefTest.
             //Original: oj = tbl.outer_join(tbl2, lambda x,y:x['a'] == y['b']).zip()
             
var oj = (Zip) (tbl.outerJoin(tbl2, (x, y) => x.g("a").eq(y.g("b"))).zip());             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #10
                 /* ExpectedOriginal: 2500 */
                 var expected_ = 2500L;
                 
                 /* Original: oj.count() */
                 var obtained = runOrCatch( oj.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #11
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: oj.filter(lambda row:row['a'] != row['b']).count() */
                 var obtained = runOrCatch( oj.filter(row => row.g("a").ne(row.g("b"))).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #12
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.eq_join('a', tbl2).zip().count() */
                 var obtained = runOrCatch( tbl.eqJoin("a", tbl2).zip().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #13
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: tbl.eq_join('fake', tbl2).zip().count() */
                 var obtained = runOrCatch( tbl.eqJoin("fake", tbl2).zip().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #14
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.eq_join(lambda x:x['a'], tbl2).zip().count() */
                 var obtained = runOrCatch( tbl.eqJoin(x => x.g("a"), tbl2).zip().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #15
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: tbl.eq_join(lambda x:x['fake'], tbl2).zip().count() */
                 var obtained = runOrCatch( tbl.eqJoin(x => x.g("fake"), tbl2).zip().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #16
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: tbl.eq_join(lambda x:null, tbl2).zip().count() */
                 var obtained = runOrCatch( tbl.eqJoin(x => null, tbl2).zip().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #17
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.eq_join(lambda x:x['a'], tbl2).count() */
                 var obtained = runOrCatch( tbl.eqJoin(x => x.g("a"), tbl2).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #18
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.eq_join('a', tbl3).zip().count() */
                 var obtained = runOrCatch( tbl.eqJoin("a", tbl3).zip().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #19
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.eq_join(lambda x:x['a'], tbl3).count() */
                 var obtained = runOrCatch( tbl.eqJoin(x => x.g("a"), tbl3).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, joins.yaml, #Templates.YamlTest+DefTest.
             //Original: left = r.expr([{'a':1},{'a':2},{'a':3}])
             
var left = (MakeArray) (r.expr(r.array(r.hashMap("a", 1L), r.hashMap("a", 2L), r.hashMap("a", 3L))));             
             
             //JavaDef, joins.yaml, #Templates.YamlTest+DefTest.
             //Original: right = r.expr([{'b':2},{'b':3}])
             
var right = (MakeArray) (r.expr(r.array(r.hashMap("b", 2L), r.hashMap("b", 3L))));             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #23
                 /* ExpectedOriginal: [{'b': 2, 'a': 2}, {'b': 3, 'a': 3}] */
                 var expected_ = r.array(r.hashMap("b", 2L).with("a", 2L), r.hashMap("b", 3L).with("a", 3L));
                 
                 /* Original: left.inner_join(right, lambda l, r:l['a'] == r['b']).zip() */
                 var obtained = runOrCatch( left.innerJoin(right, (l, r) => l.g("a").eq(r.g("b"))).zip() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #24
                 /* ExpectedOriginal: [{'a': 1}, {'b': 2, 'a': 2}, {'b': 3, 'a': 3}] */
                 var expected_ = r.array(r.hashMap("a", 1L), r.hashMap("b", 2L).with("a", 2L), r.hashMap("b", 3L).with("a", 3L));
                 
                 /* Original: left.outer_join(right, lambda l, r:l['a'] == r['b']).zip() */
                 var obtained = runOrCatch( left.outerJoin(right, (l, r) => l.g("a").eq(r.g("b"))).zip() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, joins.yaml, #29
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test3') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test3") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
