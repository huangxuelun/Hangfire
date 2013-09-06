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
    
    #line 2 "..\..\Pages\FailedJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
#line 3 "..\..\Pages\FailedJobsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
#line 4 "..\..\Pages\FailedJobsPage.cshtml"

#line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.3.0")]
    internal partial class FailedJobsPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






            
            #line 6 "..\..\Pages\FailedJobsPage.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Failed Jobs"
        };


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"alert alert-info\">\r\n    HangFire записывает все проваленные задания" +
" в очередь <code>hangfire:failed</code>. \r\n</div>\r\n\r\n");


            
            #line 18 "..\..\Pages\FailedJobsPage.cshtml"
  
    var failedJobs = HangFireApi.FailedJobs();


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 22 "..\..\Pages\FailedJobsPage.cshtml"
 if (failedJobs.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-success\">\r\n        Список проваленных заданий пуст.\r\n" +
"    </div>\r\n");


            
            #line 27 "..\..\Pages\FailedJobsPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table failed-table"">
        <thead>
            <tr>
                <th>Type</th>
                <th>Queue</th>
                <th>Args</th>
                <th>Exception</th>
                <th>Failed at</th>
                <th>Latency</th>
            </tr>
        </thead>
        <tbody>
");


            
            #line 42 "..\..\Pages\FailedJobsPage.cshtml"
               var index = 0; 

            
            #line default
            #line hidden

            
            #line 43 "..\..\Pages\FailedJobsPage.cshtml"
             foreach (var job in failedJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");


            
            #line 46 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td><span class=\"label label-primary\">");


            
            #line 47 "..\..\Pages\FailedJobsPage.cshtml"
                                                     Write(job.Queue);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                    <td>\r\n                        <code>\r\n         " +
"                   ");


            
            #line 50 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(String.Join(", ", job.Args.Select(x => String.Format("{0}: \"{1}\"", x.Key, x.Value))));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </code>\r\n                    </td>\r\n                   " +
" <td class=\"expand-exception\">\r\n                        ");


            
            #line 54 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.ExceptionMessage);

            
            #line default
            #line hidden
WriteLiteral(" <span class=\"caret\"></span>\r\n                    </td>\r\n                    <td>" +
"");


            
            #line 56 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.FailedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");


            
            #line 57 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.Latency);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");



WriteLiteral("                <tr style=\"");


            
            #line 59 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(index++ > 0 ? "display: none;" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <td colspan=\"6\">\r\n                        ");


            
            #line 61 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.ExceptionType);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <br/>\r\n                        ");


            
            #line 63 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.ExceptionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <br />\r\n                        ");


            
            #line 65 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(job.ExceptionStackTrace);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");


            
            #line 68 "..\..\Pages\FailedJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 71 "..\..\Pages\FailedJobsPage.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
