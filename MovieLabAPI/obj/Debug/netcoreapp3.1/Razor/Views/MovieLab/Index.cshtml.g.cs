#pragma checksum "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55680f650bf4773d419dd3f2669b0f18168b5f11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieLab_Index), @"mvc.1.0.view", @"/Views/MovieLab/Index.cshtml")]
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
#line 1 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\_ViewImports.cshtml"
using MovieLabAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\_ViewImports.cshtml"
using MovieLabAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55680f650bf4773d419dd3f2669b0f18168b5f11", @"/Views/MovieLab/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816e0d12f1ce4c4ee0c6c83dc8a0757ab893db46", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieLab_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Movies</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Genre</th>\r\n        <th>Runtime</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
           Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
           Write(movie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 357, "\"", 397, 2);
            WriteAttributeValue("", 364, "MovieLab/DeleteMovie?id=", 364, 24, true);
#nullable restore
#line 18 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
WriteAttributeValue("", 388, movie.Id, 388, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete ");
#nullable restore
#line 18 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
                                                                                     Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 470, "\"", 508, 2);
            WriteAttributeValue("", 477, "MovieLab/MovieForm?id=", 477, 22, true);
#nullable restore
#line 19 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
WriteAttributeValue("", 499, movie.Id, 499, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Edit ");
#nullable restore
#line 19 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"
                                                                               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\kenny\Documents\Grand Circus\Assignments\Week15\MovieLabAPI2\MovieLabAPI\MovieLabAPI\Views\MovieLab\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<td><a href=\"MovieLab/MovieForm\" class=\"btn btn-dark\">Add</a></td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
