#pragma checksum "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aace0ef57a722d3388f2a6039cae73ee7fb0b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinations_Details), @"mvc.1.0.view", @"/Views/Destinations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Destinations/Details.cshtml", typeof(AspNetCore.Views_Destinations_Details))]
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
#line 3 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
using TravelClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aace0ef57a722d3388f2a6039cae73ee7fb0b63", @"/Views/Destinations/Details.cshtml")]
    public class Views_Destinations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelClient.Models.Destination>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
            BeginContext(25, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(93, 5, true);
            WriteLiteral("\n<h5>");
            EndContext();
            BeginContext(99, 36, false);
#line 6 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(135, 16, true);
            WriteLiteral("</h5>\n<li>City: ");
            EndContext();
            BeginContext(152, 36, false);
#line 7 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
     Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(188, 23, true);
            WriteLiteral("</li>\n    <li>Country: ");
            EndContext();
            BeginContext(212, 39, false);
#line 8 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
            Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(251, 30, true);
            WriteLiteral("</li>\n    <li>Overall Rating: ");
            EndContext();
            BeginContext(282, 41, false);
#line 9 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
                   Write(Html.DisplayFor(model => model.AvgRating));

#line default
#line hidden
            EndContext();
            BeginContext(323, 24, true);
            WriteLiteral("</li>\n<h6>Reviews:</h6>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
 foreach(var review in ViewBag.reviews)
{

#line default
#line hidden
            BeginContext(389, 164, true);
            WriteLiteral("    <div class = \"card\" style = \"padding-left: 5px; padding-top: 5px; background-color: lightgrey; width: 50%;\">\n        <h3>Author</h3>\n        <p class = \"deets\">");
            EndContext();
            BeginContext(554, 13, false);
#line 15 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
                      Write(review.Author);

#line default
#line hidden
            EndContext();
            BeginContext(567, 56, true);
            WriteLiteral("</p>\n        <h3>Review</h3>\n        <p class = \"deets\">");
            EndContext();
            BeginContext(624, 17, false);
#line 17 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
                      Write(review.ReviewText);

#line default
#line hidden
            EndContext();
            BeginContext(641, 86, true);
            WriteLiteral("</p>\n        <h3>Rating</h3>\n        <h5 class = \"deets\" style = \"margin-left: 20px;\">");
            EndContext();
            BeginContext(728, 13, false);
#line 19 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
                                                    Write(review.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(741, 26, true);
            WriteLiteral("</h5>\n    </div>\n    <br>\n");
            EndContext();
#line 22 "/Users/Guest/Desktop/TravelClient/Views/Destinations/Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelClient.Models.Destination> Html { get; private set; }
    }
}
#pragma warning restore 1591
