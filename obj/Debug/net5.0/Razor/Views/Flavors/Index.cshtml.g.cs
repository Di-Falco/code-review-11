#pragma checksum "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da76dd4fe963b24bd8d5cb18881031d5e8a135e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Index), @"mvc.1.0.view", @"/Views/Flavors/Index.cshtml")]
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
#line 5 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
using Pierre.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da76dd4fe963b24bd8d5cb18881031d5e8a135e", @"/Views/Flavors/Index.cshtml")]
    public class Views_Flavors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pierre.Models.Flavor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Flavors for ");
#nullable restore
#line 8 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
 if (@Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ul>\n");
#nullable restore
#line 13 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
     foreach(Flavor flavor in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li><a");
            BeginWriteAttribute("href", " href=\'", 217, "\'", 276, 1);
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
WriteAttributeValue("", 224, Url.Action("Details", new { id = flavor.FlavorId }), 224, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\'btn btn-default\'>flavor.Name</button></a></li>\n");
#nullable restore
#line 16 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 18 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No flavors have been added yet!</h3>\n");
#nullable restore
#line 22 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a");
            BeginWriteAttribute("href", " href=\'", 411, "\'", 439, 1);
#nullable restore
#line 24 "/Users/difalcoa/Desktop/epicodus/code-review-11/Views/Flavors/Index.cshtml"
WriteAttributeValue("", 418, Url.Action("Create"), 418, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Add new flavor</button></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pierre.Models.Flavor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
