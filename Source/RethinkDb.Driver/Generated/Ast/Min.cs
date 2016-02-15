












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

    public partial class Min : ReqlExpr {

    
    
    
/// <summary>
/// <para>Finds the minimum element of a sequence.</para>
/// </summary>
/// <example><para>Example: Return the minimum value in the list <code>[3, 5, 7]</code>.</para>
/// <code>r.expr([3, 5, 7]).min().run(conn, callback);
/// </code></example>
        public Min (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Finds the minimum element of a sequence.</para>
/// </summary>
/// <example><para>Example: Return the minimum value in the list <code>[3, 5, 7]</code>.</para>
/// <code>r.expr([3, 5, 7]).min().run(conn, callback);
/// </code></example>
        public Min (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Finds the minimum element of a sequence.</para>
/// </summary>
/// <example><para>Example: Return the minimum value in the list <code>[3, 5, 7]</code>.</para>
/// <code>r.expr([3, 5, 7]).min().run(conn, callback);
/// </code></example>
        public Min (Arguments args, OptArgs optargs)
         : base(TermType.MIN, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public Min this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Min (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
    public Min this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Min (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "index": "T_STR"
///</summary>
        public Min optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Min (this.Args, newOptArgs);
        }


    

    


    
    }
}
