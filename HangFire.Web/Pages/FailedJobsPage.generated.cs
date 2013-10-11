﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
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
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Pages\FailedJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class FailedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





            
            #line 5 "..\..\Pages\FailedJobsPage.cshtml"
  
    Layout = new LayoutPage { Title = "Failed Jobs" };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.FailedCount())
    {
        BasePageUrl = Request.LinkTo("/failed")
    };

    var failedJobs = JobStorage.FailedJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 21 "..\..\Pages\FailedJobsPage.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-success\">\r\n        You have no failed jobs at the mom" +
"ent.\r\n    </div>\r\n");


            
            #line 26 "..\..\Pages\FailedJobsPage.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Pages\FailedJobsPage.cshtml"
Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Pages\FailedJobsPage.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table failed-table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Failed at</th>
                <th>Queue</th>
                <th>Type</th>
                <th></th>
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
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a href=\"" +
"");


            
            #line 47 "..\..\Pages\FailedJobsPage.cshtml"
                            Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 48 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <t" +
"d data-moment=\"");


            
            #line 51 "..\..\Pages\FailedJobsPage.cshtml"
                                Write(JobHelper.ToStringTimestamp(job.Value.FailedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 51 "..\..\Pages\FailedJobsPage.cshtml"
                                                                                        Write(job.Value.FailedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");


            
            #line 52 "..\..\Pages\FailedJobsPage.cshtml"
                   Write(HtmlHelper.QueueLabel(job.Value.Queue));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td class=\"expand-exception\">\r\n                       " +
" <div>\r\n                            ");


            
            #line 55 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(HtmlHelper.JobType(job.Value.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div style=\"color: #888" +
";\">\r\n                            ");


            
            #line 58 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(job.Value.ExceptionMessage);

            
            #line default
            #line hidden
WriteLiteral(" <span class=\"caret\"></span>\r\n                        </div>\r\n                   " +
" </td>\r\n                    <td>\r\n                        <div class=\"pull-right" +
"\">\r\n                            <button class=\"btn btn-primary btn-sm\" data-ajax" +
"=\"");


            
            #line 63 "..\..\Pages\FailedJobsPage.cshtml"
                                                                         Write(Request.LinkTo("/failed/retry/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral(@""" data-loading-text=""Retrying..."">
                                <span class=""glyphicon glyphicon-repeat""></span>
                                Retry
                            </button>

                            <button class=""btn btn-danger btn-sm"" data-ajax=""");


            
            #line 68 "..\..\Pages\FailedJobsPage.cshtml"
                                                                        Write(Request.LinkTo("/failed/remove/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"Deleting...\">\r\n                                <span class=\"" +
"glyphicon glyphicon-remove\"></span>\r\n                            </button>\r\n    " +
"                    </div>\r\n                    </td>\r\n                </tr>\r\n");



WriteLiteral("                <tr style=\"");


            
            #line 74 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(index++ > 0 ? "display: none;" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <td colspan=\"5\" class=\"failed-job-details\">\r\n            " +
"            <h4>");


            
            #line 76 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(job.Value.ExceptionType);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                        <p>\r\n                            ");


            
            #line 78 "..\..\Pages\FailedJobsPage.cshtml"
                       Write(job.Value.ExceptionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </p>\r\n                        \r\n");


            
            #line 81 "..\..\Pages\FailedJobsPage.cshtml"
                         if (!String.IsNullOrEmpty(job.Value.ExceptionDetails))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <pre class=\"stack-trace\">");


            
            #line 83 "..\..\Pages\FailedJobsPage.cshtml"
                                                Write(HtmlHelper.MarkupStackTrace(job.Value.ExceptionDetails));

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n");


            
            #line 84 "..\..\Pages\FailedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral(@"
                        <h4>Job Arguments</h4>
                        <table class=""table table-bordered table-striped table-condensed"">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>Value</th>
                                </tr>
                            </thead>
                            <tbody>
");


            
            #line 95 "..\..\Pages\FailedJobsPage.cshtml"
                                 foreach (var arg in job.Value.Args)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <tr>\r\n                                       " +
" <td>");


            
            #line 98 "..\..\Pages\FailedJobsPage.cshtml"
                                       Write(arg.Key);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                        <td><code>");


            
            #line 99 "..\..\Pages\FailedJobsPage.cshtml"
                                             Write(arg.Value);

            
            #line default
            #line hidden
WriteLiteral("</code></td>\r\n                                    </tr>\r\n");


            
            #line 101 "..\..\Pages\FailedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </tbody>\r\n                        </table>\r\n         " +
"           </td>\r\n                </tr>\r\n");


            
            #line 106 "..\..\Pages\FailedJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 109 "..\..\Pages\FailedJobsPage.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 110 "..\..\Pages\FailedJobsPage.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 110 "..\..\Pages\FailedJobsPage.cshtml"
                                        
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
