












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Group : ReqlExpr {

    
    
    
/// <summary>
/// <para>Takes a stream and partitions it into multiple groups based on the
/// fields or functions provided.  Commands chained after <code>group</code> will be
/// called on each of these grouped sub-streams, producing grouped data.</para>
/// </summary>
/// <example><para>Example: What is each player's best game?</para>
/// <code>r.table('games').group('player').max('points').run(conn, callback)
/// </code></example>
        public Group (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Takes a stream and partitions it into multiple groups based on the
/// fields or functions provided.  Commands chained after <code>group</code> will be
/// called on each of these grouped sub-streams, producing grouped data.</para>
/// </summary>
/// <example><para>Example: What is each player's best game?</para>
/// <code>r.table('games').group('player').max('points').run(conn, callback)
/// </code></example>
        public Group (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Takes a stream and partitions it into multiple groups based on the
/// fields or functions provided.  Commands chained after <code>group</code> will be
/// called on each of these grouped sub-streams, producing grouped data.</para>
/// </summary>
/// <example><para>Example: What is each player's best game?</para>
/// <code>r.table('games').group('player').max('points').run(conn, callback)
/// </code></example>
        public Group (Arguments args, OptArgs optargs)
         : base(TermType.GROUP, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR",
///  "multi": "T_BOOL"
///</summary>
        public Group this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Group (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "index": "T_STR",
///  "multi": "T_BOOL"
///</summary>
    public Group this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Group (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "index": "T_STR",
///  "multi": "T_BOOL"
///</summary>
        public Group optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Group (this.Args, newOptArgs);
        }


    

    


    
    }
}
