












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

    public partial class Delete : ReqlExpr {

    
    
    
/// <summary>
/// <para>Delete one or more documents from a table.</para>
/// </summary>
/// <example><para>Example: Delete a single document from the table <code>comments</code>.</para>
/// <code>r.table("comments").get("7eab9e63-73f1-4f33-8ce4-95cbea626f59").delete().run(conn, callback)
/// </code></example>
        public Delete (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Delete one or more documents from a table.</para>
/// </summary>
/// <example><para>Example: Delete a single document from the table <code>comments</code>.</para>
/// <code>r.table("comments").get("7eab9e63-73f1-4f33-8ce4-95cbea626f59").delete().run(conn, callback)
/// </code></example>
        public Delete (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Delete one or more documents from a table.</para>
/// </summary>
/// <example><para>Example: Delete a single document from the table <code>comments</code>.</para>
/// <code>r.table("comments").get("7eab9e63-73f1-4f33-8ce4-95cbea626f59").delete().run(conn, callback)
/// </code></example>
        public Delete (Arguments args, OptArgs optargs)
         : base(TermType.DELETE, args, optargs) {
        }


    



    
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ]
///</summary>
        public Delete this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Delete (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ]
///</summary>
    public Delete this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Delete (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ]
///</summary>
        public Delete optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Delete (this.Args, newOptArgs);
        }


    

    


    
    }
}
