﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    #line 2 "..\..\Pages\DispatchersPage.cshtml"

#line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.3.0")]
    internal partial class DispatchersPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\n");




            
            #line 4 "..\..\Pages\DispatchersPage.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Dispatchers"
        };


            
            #line default
            #line hidden
WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Name</th>\n       " +
"     <th>Type</th>\n            <th>Args</th>\n            <th>Started</th>\n      " +
"  </tr>\n    </thead>\n    <tbody>\n");


            
            #line 22 "..\..\Pages\DispatchersPage.cshtml"
         foreach (var dispatcher in HangFireApi.Dispatchers())
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\n                <td>");


            
            #line 25 "..\..\Pages\DispatchersPage.cshtml"
               Write(dispatcher.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");


            
            #line 26 "..\..\Pages\DispatchersPage.cshtml"
               Write(dispatcher.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td><code>");


            
            #line 27 "..\..\Pages\DispatchersPage.cshtml"
                     Write(dispatcher.Args);

            
            #line default
            #line hidden
WriteLiteral("</code></td>\n                <td>");


            
            #line 28 "..\..\Pages\DispatchersPage.cshtml"
               Write(dispatcher.StartedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\n            </tr>\n");


            
            #line 30 "..\..\Pages\DispatchersPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\n</table>\n");


        }
    }
}
#pragma warning restore 1591
