#pragma checksum "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1d79d83517024ef8ccd1251404d12ec1052547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\_ViewImports.cshtml"
using dotnetMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\_ViewImports.cshtml"
using dotnetMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1d79d83517024ef8ccd1251404d12ec1052547", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57efee572bb73a253de5ca6669cd26d3dcd57782", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<dotnetMVC.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Student's list";
    var students = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
        <table class=""table"">
            <tr>
                <th>StudentId</th>
                <th>StudentName</th>
                <th>Birthday</th>
                <th>Class</th>
                <th></th>
            </tr>
");
#nullable restore
#line 15 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
             if(students != null){
                foreach(var student in students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 19 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
                       Write(student.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
                       Write(student.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
                       Write(student.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
                       Write(student.Class.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        <td>\r\n                            <a class =\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 872, "\"", 913, 2);
            WriteAttributeValue("", 879, "/student/detail/", 879, 16, true);
#nullable restore
#line 25 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
WriteAttributeValue("", 895, student.StudentId, 895, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail</a>\r\n                            <a class =\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 982, "\"", 1021, 2);
            WriteAttributeValue("", 989, "/student/edit/", 989, 14, true);
#nullable restore
#line 26 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
WriteAttributeValue("", 1003, student.StudentId, 1003, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                            <a class =\"btn btn-danger\" href=\"/\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\DMX\Desktop\New folder\dotnetMVC\dotnetMVC\Views\Student\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<dotnetMVC.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
