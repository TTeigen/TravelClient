#pragma checksum "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9970cdc3240c612163bc8a43a5305613358b7ff7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Create), @"mvc.1.0.view", @"/Views/Reviews/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Create.cshtml", typeof(AspNetCore.Views_Reviews_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9970cdc3240c612163bc8a43a5305613358b7ff7", @"/Views/Reviews/Create.cshtml")]
    public class Views_Reviews_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelClient.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(63, 45, true);
            WriteLiteral("    <input name=\"DestinationId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 108, "\"", 138, 1);
#line 5 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
WriteAttributeValue("", 116, ViewBag.DestinationId, 116, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(139, 2, true);
            WriteLiteral(">\n");
            EndContext();
            BeginContext(145, 27, true);
            WriteLiteral("    <label>Reviews</label>\n");
            EndContext();
            BeginContext(177, 42, false);
#line 8 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
Write(Html.TextBoxFor(model => model.ReviewText));

#line default
#line hidden
            EndContext();
            BeginContext(226, 36, false);
#line 10 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
Write(Html.LabelFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(268, 38, false);
#line 11 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
Write(Html.TextBoxFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(313, 36, false);
#line 13 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
Write(Html.LabelFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(355, 38, false);
#line 14 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
Write(Html.TextBoxFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(395, 64, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add\" class=\"btn btn-primary\" />\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
} 

#line default
#line hidden
            BeginContext(463, 89, false);
#line 18 "/Users/Guest/Desktop/TravelClient/Views/Reviews/Create.cshtml"
Write(Html.ActionLink("Cancel", "Details", "Destinations", new { id = @ViewBag.DestinationId }));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelClient.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591