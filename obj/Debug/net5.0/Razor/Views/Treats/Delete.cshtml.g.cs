#pragma checksum "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16148167cb7d1bf719315189e30e0f1c001a1794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Delete), @"mvc.1.0.view", @"/Views/Treats/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16148167cb7d1bf719315189e30e0f1c001a1794", @"/Views/Treats/Delete.cshtml")]
    public class Views_Treats_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n<p>");
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
                                                Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <button type=\"submit\">Delete</button>\n");
#nullable restore
#line 14 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Treats/Delete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
