




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
    public class GeoGeojson : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #1
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, 0], 'type':'Point'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 0L)).with("type", "Point");
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "Point")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #2
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[0,0], [0,1]], 'type':'LineString'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L))).with("type", "LineString");
                 
                 /* Original: r.geojson({'coordinates':[[0,0], [0,1]], 'type':'LineString'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(r.array(0L, 0L), r.array(0L, 1L))).with("type", "LineString")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #3
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[[[0,0], [0,1], [1,0], [0,0]]], 'type':'Polygon'}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)))).with("type", "Polygon");
                 
                 /* Original: r.geojson({'coordinates':[[[0,0], [0,1], [1,0], [0,0]]], 'type':'Polygon'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(r.array(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 0L), r.array(0L, 0L)))).with("type", "Polygon")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #4
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found ARRAY.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found ARRAY.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[[], 0], 'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(r.array(), 0L)).with("type", "Point")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #5
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type ARRAY but found BOOL.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type ARRAY but found BOOL.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':true, 'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", true).with("type", "Point")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #6
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'No attribute `coordinates` in object:', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "No attribute `coordinates` in object:", r.array(0L));
                 
                 /* Original: r.geojson({'type':'Point'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("type", "Point")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #7
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'No attribute `type` in object:', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "No attribute `type` in object:", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0]}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #8
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Unrecognized GeoJSON type `foo`.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Unrecognized GeoJSON type `foo`.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'foo'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "foo")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #9
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Unrecognized field `foo` found in geometry object.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Unrecognized field `foo` found in geometry object.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'Point', 'foo':'wrong'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "Point").with("foo", "wrong")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #10
                 /* ExpectedOriginal: ({'$reql_type$':'GEOMETRY', 'coordinates':[0, 0], 'type':'Point', 'crs':null}) */
                 var expected_ = r.hashMap("$reql_type$", "GEOMETRY").with("coordinates", r.array(0L, 0L)).with("type", "Point").with("crs", null);
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'Point', 'crs':null}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "Point").with("crs", null)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/geojson.yaml, #12
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'GeoJSON type `MultiPoint` is not supported.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "GeoJSON type `MultiPoint` is not supported.", r.array(0L));
                 
                 /* Original: r.geojson({'coordinates':[0, 0], 'type':'MultiPoint'}) */
                 var obtained = runOrCatch( r.geojson(r.hashMap("coordinates", r.array(0L, 0L)).with("type", "MultiPoint")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
