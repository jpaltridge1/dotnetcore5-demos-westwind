#pragma checksum "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2dae071e4db97daef580e133573143b0572bcc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WestWindWeb.Pages.Pages_Query), @"mvc.1.0.razor-page", @"/Pages/Query.cshtml")]
namespace WestWindWeb.Pages
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
#line 1 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\_ViewImports.cshtml"
using WestWindWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2dae071e4db97daef580e133573143b0572bcc2", @"/Pages/Query.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb3f8a4f1562209b788c73dbb25dd79b2acbb03", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Query : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>ButtonPressed=<span>");
#nullable restore
#line 5 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                  Write(Model.ButtonPressed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dae071e4db97daef580e133573143b0572bcc24019", async() => {
                WriteLiteral(@"
    <input type=""hidden"" id=""ButtonPressed"" name=""buttonPressed"">
    <button type=""submit"" onclick=""return myFunction(1)"" name=""myButtonPressed"" value=""1"">Button1</button>
    <button type=""submit"" onclick=""return myFunction(2)"" name=""myButtonPressed"" value=""2"">Button2</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
function myFunction(button) {
    if(button == 1){
        document.getElementById(""ButtonPressed"").setAttribute(""value"", ""1"");
    } else {
        document.getElementById(""ButtonPressed"").setAttribute(""value"", ""2"");
    }
    let temp = """);
#nullable restore
#line 20 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
           Write(Model.MyTest1());

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    console.log(temp);\r\n  return true;\r\n}\r\n</script>\r\n\r\n<h5>Query Page</h5>\r\n\r\n");
#nullable restore
#line 28 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
 if(!string.IsNullOrEmpty(Model.ErrorMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:red; font-weight: bold;\">");
#nullable restore
#line 30 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                        Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
 if(!string.IsNullOrEmpty(Model.SuccessMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:green; font-weight: bold;\">");
#nullable restore
#line 35 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                          Write(Model.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dae071e4db97daef580e133573143b0572bcc27881", async() => {
                WriteLiteral("\r\n    <div>\r\n        <i>Partial Recording Mark</i>\r\n        <input type=\"search\" placeholder=\"Partial Name/ID\" id=\"PartialRecordingMark\" \r\n            name=\"partialRecordingMark\"");
                BeginWriteAttribute("value", " value=\"", 1298, "\"", 1333, 1);
#nullable restore
#line 42 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
WriteAttributeValue("", 1306, Model.PartialRecordingMark, 1306, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("        <button type=\"submit\" formaction=\"/Query\" \r\n            name=\"buttonPressed\" value=\"SearchByPartialRecordingMark\">Search</button>\r\n        <span>The Partial Recording Mark search string is ");
#nullable restore
#line 46 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                                     Write(Model.PartialRecordingMark);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </div>\r\n    <div>\r\n        <i>Rail Car Types</i>\r\n        <select name=\"selectedRailCarTypeId\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dae071e4db97daef580e133573143b0572bcc29391", async() => {
                    WriteLiteral("select ...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
             foreach (var item in Model.SelectListOfRailCarTypes)
            {
                    if (Model.SelectedRailCarTypeId == item.RailCarTypeId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dae071e4db97daef580e133573143b0572bcc211020", async() => {
#nullable restore
#line 56 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                           WriteLiteral(item.RailCarTypeId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dae071e4db97daef580e133573143b0572bcc213533", async() => {
#nullable restore
#line 60 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                           WriteLiteral(item.RailCarTypeId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                    }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>  \r\n    \r\n");
                WriteLiteral("        <button type=\"submit\" formaction=\"/Query\" name=\"buttonPressed\" value=\"SearchByRailCarType\">Search</button>\r\n        <span>The selected Rail Car Type Id is ");
#nullable restore
#line 67 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                          Write(Model.SelectedRailCarTypeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </div>\r\n    <button type=\"submit\" formaction=\"/Crud\">Add New Rolling Stock</button>\r\n");
#nullable restore
#line 70 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
     if(Model.SearchedRollingStocks != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table>
        <thead>
            <tr>
                <th>Action</th>
                <th>ReportingMark</th>
                <th>Owner</th>
                <th>Capacity</th>
                <th>InService</th>
                
            </tr>
        </thead>
");
#nullable restore
#line 83 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
         if(Model.SearchedRollingStocks.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr><td colspan=\"6\"><i>There are no Rolling Stocks available.</i></td></tr>\r\n");
#nullable restore
#line 86 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
         foreach(var item in Model.SearchedRollingStocks)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td><button type=\"submit\" name=\"reportingMark\" formaction=\"/Crud\"");
                BeginWriteAttribute("value", " value=\"", 3381, "\"", 3408, 1);
#nullable restore
#line 90 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
WriteAttributeValue("", 3389, item.ReportingMark, 3389, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</button></td>\r\n                <td>");
#nullable restore
#line 91 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
               Write(item.ReportingMark);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 92 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
               Write(item.Owner);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 93 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
               Write(item.Capacity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><input type=\"checkbox\" disabled");
                BeginWriteAttribute("checked", " checked=\"", 3606, "\"", 3631, 1);
#nullable restore
#line 94 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
WriteAttributeValue("", 3616, item.InService, 3616, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input></td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 98 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    \r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.QueryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.QueryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.QueryModel>)PageContext?.ViewData;
        public MyApp.Namespace.QueryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591