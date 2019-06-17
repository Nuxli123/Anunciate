#pragma checksum "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea09e9630d09aae74da64280d347ddaecb2d50e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Pager), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MvcGrid/_Pager.cshtml", typeof(AspNetCore.Views_Shared_MvcGrid__Pager))]
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
#line 1 "C:\ProyectosPersonales\@nunciate\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\ProyectosPersonales\@nunciate\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#line 1 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea09e9630d09aae74da64280d347ddaecb2d50e1", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGridPager>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
  
    Int32 totalPages = Model.TotalPages;
    Int32 currentPage = Model.CurrentPage;
    Int32 firstDisplayPage = Model.FirstDisplayPage;

#line default
#line hidden
            BeginContext(195, 10, true);
            WriteLiteral("\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 205, "\"", 245, 2);
            WriteAttributeValue("", 213, "mvc-grid-pager", 213, 14, true);
#line 9 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue(" ", 227, Model.CssClasses, 228, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(246, 23, true);
            WriteLiteral(" data-show-page-sizes=\"");
            EndContext();
            BeginContext(270, 19, false);
#line 9 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                                                   Write(Model.ShowPageSizes);

#line default
#line hidden
            EndContext();
            BeginContext(289, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 10 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
     if (totalPages > 0)
    {
        if (currentPage > 1)
        {

#line default
#line hidden
            BeginContext(367, 102, true);
            WriteLiteral("        <button type=\"button\" data-page=\"1\">&#171;</button>\r\n        <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(471, 15, false);
#line 15 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                     Write(currentPage - 1);

#line default
#line hidden
            EndContext();
            BeginContext(487, 20, true);
            WriteLiteral("\">&#8249;</button>\r\n");
            EndContext();
#line 16 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(543, 157, true);
            WriteLiteral("        <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#171;</button>\r\n        <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#8249;</button>\r\n");
            EndContext();
#line 21 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        for (Int32 page = firstDisplayPage; page <= totalPages && page < firstDisplayPage + Model.PagesToDisplay; page++)
        {
            if (page == currentPage)
            {

#line default
#line hidden
            BeginContext(898, 56, true);
            WriteLiteral("        <button type=\"button\" class=\"active\" data-page=\"");
            EndContext();
            BeginContext(956, 4, false);
#line 26 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                                    Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(961, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(965, 4, false);
#line 26 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                                             Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(970, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 27 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1029, 41, true);
            WriteLiteral("        <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1072, 4, false);
#line 30 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                     Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1081, 4, false);
#line 30 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                              Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 31 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
            }
        }
        if (currentPage < totalPages)
        {

#line default
#line hidden
            BeginContext(1173, 41, true);
            WriteLiteral("        <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1216, 15, false);
#line 35 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                     Write(currentPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1232, 61, true);
            WriteLiteral("\">&#8250;</button>\r\n        <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1294, 10, false);
#line 36 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                    Write(totalPages);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 19, true);
            WriteLiteral("\">&#187;</button>\r\n");
            EndContext();
#line 37 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1359, 157, true);
            WriteLiteral("        <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#8250;</button>\r\n        <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#187;</button>\r\n");
            EndContext();
#line 42 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        if (Model.ShowPageSizes)
        {

#line default
#line hidden
            BeginContext(1572, 43, true);
            WriteLiteral("        <div class=\"mvc-grid-page-sizes\">\r\n");
            EndContext();
#line 46 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
         if (Model.PageSizes.Count > 0)
        {

#line default
#line hidden
            BeginContext(1667, 50, true);
            WriteLiteral("            <select class=\"mvc-grid-pager-rows\">\r\n");
            EndContext();
#line 49 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
             foreach (KeyValuePair<Int32, String> size in Model.PageSizes)
            {
                if (Model.RowsPerPage == size.Key)
                {

#line default
#line hidden
            BeginContext(1879, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1895, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea09e9630d09aae74da64280d347ddaecb2d50e110446", async() => {
                BeginContext(1931, 10, false);
#line 53 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                              Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 53 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1950, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2012, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2028, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea09e9630d09aae74da64280d347ddaecb2d50e112968", async() => {
                BeginContext(2055, 10, false);
#line 57 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                                     Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 57 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2074, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2110, 23, true);
            WriteLiteral("            </select>\r\n");
            EndContext();
#line 61 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2169, 46, true);
            WriteLiteral("            <input class=\"mvc-grid-pager-rows\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2215, "\"", 2241, 1);
#line 64 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2223, Model.RowsPerPage, 2223, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2242, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 65 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }

#line default
#line hidden
            BeginContext(2258, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 67 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2310, 56, true);
            WriteLiteral("        <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2366, "\"", 2392, 1);
#line 70 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2374, Model.RowsPerPage, 2374, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2393, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 71 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2433, 56, true);
            WriteLiteral("        <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2489, "\"", 2515, 1);
#line 75 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2497, Model.RowsPerPage, 2497, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2516, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 76 "C:\ProyectosPersonales\@nunciate\Web\Views\Shared\MvcGrid\_Pager.cshtml"
    }

#line default
#line hidden
            BeginContext(2528, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGridPager> Html { get; private set; }
    }
}
#pragma warning restore 1591