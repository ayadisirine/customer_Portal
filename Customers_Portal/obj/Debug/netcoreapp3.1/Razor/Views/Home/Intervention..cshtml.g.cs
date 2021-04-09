#pragma checksum "C:\Users\HP\source\repos\Customers_Portal\Customers_Portal\Views\Home\Intervention..cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bb5c428a9e44b3714fd6aaf4eed2cbc347817a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Intervention_), @"mvc.1.0.view", @"/Views/Home/Intervention..cshtml")]
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
#line 1 "C:\Users\HP\source\repos\Customers_Portal\Customers_Portal\Views\_ViewImports.cshtml"
using Customers_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\Customers_Portal\Customers_Portal\Views\_ViewImports.cshtml"
using Customers_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bb5c428a9e44b3714fd6aaf4eed2cbc347817a", @"/Views/Home/Intervention..cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a535f361c3e20f7d1c7f9e0306dac0dd04d3ac6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Intervention_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("<%= params[:controller] %>"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- WRAPPER -->\r\n<div id=\"wrapper\">\r\n    <div id=\"header\" class=\"navbar-toggleable-md sticky header-md clearfix\">\r\n        <!-- TOP NAV -->\r\n        <header id=\"topNav\">\r\n        </header>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bb5c428a9e44b3714fd6aaf4eed2cbc347817a3724", async() => {
                WriteLiteral(@"
        <!-- wrapper : wrapping in the container -->
        <div id=""wrapper"">
            <section id=""author"">
                <div class=""container"">
                    <header class=""text-center mb-40"">
                        <h2>INTERVENTION</h2>
                    </header>
                    i
                    <div class=""row"">
                        <!-- FORM -->
                        <div class=""col-md-8 col-sm-8"">
                            <fieldset>
                                <input type=""hidden"" name=""action"" value=""author_send"" />
                                <%# Author  %>
                                <div class=""row"" style=""margin-left: 1px"">
                                    <div class=""col-md-8"">
                                        <%= form.label :Author %>
                                        <!-- options_from_collection_for_select(collection, value_method, text_method, selected = nil) -->
                                        <!-- inclu");
                WriteLiteral(@"de_blank : for first itme -->
                                        <!-- The output will be : select name=""employee"" id=""employee"" : This will serves to manage value change in intervention.js-->
                                        <%= form.select :employee, options_from_collection_for_select(Employee.all, ""id"", ""first_name""), include_blank: ""----"" %>
                                    </div>
                                </div>


                                <%# customer  %>
                                <div class=""row"" style=""margin-left: 1px"">
                                    <div class=""col-md-8"">
                                        <%= form.label :customer %>
                                        <!--select(object, method, choices = nil, options = {}, html_options = {}, &block)-->
                                        <!--Create a select tag and a series of contained option tags for the provided object and method.
                                     The option curre");
                WriteLiteral(@"ntly held by the object will be selected, provided that the object is available.-->
                                        <!-- The output will be : select name=""employee"" id=""employee"" : This will serves to manage value change in intervention.js-->
                                        <%= form.select(:customer, Customer.all.collect {|c| [c.company_name, c.id]}.sort_by(&:first), {prompt: ""----""}, {class: 'form-control'}) %>

                                    </div>
                                </div>

                                <%# building  %>
                                <div class=""building-class"">
                                    <div class=""col-md-8"">
                                        <%= form.label :building %>
                                        <!--select(object, method, choices = nil, options = {}, html_options = {}, &block)-->
                                        <!--Create a select tag and a series of contained option tags for the provided object and met");
                WriteLiteral(@"hod.
                                     The option currently held by the object will be selected, provided that the object is available.-->
                                        <!-- The output will be : select name=""building"" id=""building"" : This will serves to manage value change in intervention.js-->
                                        <%= form.select(:building, Building.all.collect {|b| [b.id, b.customer_id ]}, {prompt: ""id""},  {class: 'form-control'}) %>
                                    </div>
                                </div>

                                <%# batteries  %>
                                <div class=""battery-class"">
                                    <div class=""col-md-8"">
                                        <%= form.label :battery %>
                                        <!--select(object, method, choices = nil, options = {}, html_options = {}, &block)-->
                                        <!--Create a select tag and a series of contained optio");
                WriteLiteral(@"n tags for the provided object and method.
                                     The option currently held by the object will be selected, provided that the object is available.-->
                                        <!-- The output will be : select name=""battery"" id=""battery"" : This will serves to manage value change in intervention.js-->
                                        <%= form.select(:battery, Battery.all.collect {|d| [d.id, d.building_id ]}, {prompt: ""id""}, {class: 'form-control'}) %>
                                    </div>
                                </div>

                                <%# columns  %>
                                <div class=""column-class"">
                                    <div class=""col-md-8"">
                                        <%= form.label :column %>
                                        <!--select(object, method, choices = nil, options = {}, html_options = {}, &block)-->
                                        <!--Create a select tag an");
                WriteLiteral(@"d a series of contained option tags for the provided object and method.
                                     The option currently held by the object will be selected, provided that the object is available.-->
                                        <!-- The output will be : select name=""column"" id=""column"" : This will serves to manage value change in intervention.js-->
                                        <%= form.select(:column, Column.all.collect {|c| [c.id, c.battery_id ]}, {prompt: ""id""}, {class: 'form-control'}) %>
                                    </div>
                                </div>

                                <%# elevators  %>
                                <div class=""elevator-class"">
                                    <div class=""col-md-8"">
                                        <%= form.label :elevator %>
                                        <!--select(object, method, choices = nil, options = {}, html_options = {}, &block)-->
                                    ");
                WriteLiteral(@"    <!--Create a select tag and a series of contained option tags for the provided object and method.
                                     The option currently held by the object will be selected, provided that the object is available.-->
                                        <!-- The output will be : select name=""elevator"" id=""elevator"" : This will serves to manage value change in intervention.js-->
                                        <%= form.select(:elevator, Elevator.all.collect {|e| [e.id, e.column_id ]}, {prompt: ""id""}, {class: 'form-control'}) %>
                                    </div>
                                </div>



                                <%# Description field to submit intervention %>
                                <div class=""col-md-12"">
                                    <%= form.label :Description%>
                                    <%= form.text_area :report, class: 'form-control', rows: '6' %>
                                </div>
                  ");
                WriteLiteral(@"      </div>




                    </div>
                    <!-- /FORM -->
                    <!-- INFO -->
                    <div class=""col-md-8 col-md-8"">

                        <!-- SUBMIT BUTTON -->
                        <div class=""toggle-transparent toggle-bordered-full clearfix"">
                            <div class=""toggle active"">


                                <hr>
                                <div class=""actions"">
                                    <%= form.submit class: 'btn btn-primary danger', value: 'Save', :onclick => ""alert('Information about your intervention saved !')""%>

                                </div>
                            </div>
                        </div>

                        <!-- /SUBMIT BUTTON  -->





                    </div>


                </div>

        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>


<script>
    if ($('#interventions').length) {
        //Get the anchor part of the url 
        var _hash = window.location.hash;

        //Hide building, battery, column and elevator sections 
        $("".building-class, .battery-class, .column-class, .elevator-class"").hide();

        // Show and hide buildings for customer 
        // second dropdown is disabled while first dropdown is empty
        $(""#building"").prop(""disabled"", true);
        //on customer value change 
        $(""#customer"").change(function () {
            //get customer value 
            var customer = $(this).val();
            //check customer value to enabled or not building pop-down 
            if (customer == """") {
                $(""#building"").prop(""disabled"", true);
            } else {
                $(""#building"").prop(""disabled"", false);
            }
            //call ajax function to get corresponding building to the selected customer 
            $.ajax({
                //ca");
            WriteLiteral(@"ll get_building method defined in the controller 
                url: ""/interventions/get_building"",
                method: ""GET"",
                dataType: ""json"",
                //send customer id as parameter 
                data: { customer: customer },

                //error: The error function is executed if the server responds with a HTTP error.
                //XHR object will give you all of the information that you need to know about the error that just occurred
                //status: The HTTP status code that the server returned. 
                error: function (xhr, status, error) {
                    console.error(""AJAX Error: "" + status + error);
                },
                //success: The success function is called if the Ajax request is completed successfully.
                success: function (response) {
                    console.log(response);
                    var buildings = response[""buildings""];
                    //empty the building, battery, co");
            WriteLiteral(@"lumn and elevator pop-down if customer change 
                    $(""#building"").empty();
                    $(""#battery"").empty();
                    $(""#column"").empty();
                    $(""#elevator"").empty();
                    //fill them with the default values 
                    $(""#building"").append(""<option>Select Building</option>"");
                    $(""#battery"").append(""<option>Select Battery</option>"");
                    $(""#column"").append(""<option>-None-</option>"");
                    $(""#elevator"").append(""<option>-None-</option>"");

                    //fill the pop-down with corresponding buildings to the selected customer 
                    for (var i = 0; i < buildings.length; i++) {
                        $(""#building"").append(
                            '<option value=""' +
                            buildings[i][""id""] +
                            '"">' +
                            buildings[i][""customer_id""] +
                            ""</option");
            WriteLiteral(@">""
                        );
                    }
                }
            });
        });

        // on change building value 
        $(""#building"").change(function () {
            //get building value 
            var building = $(this).val();
            //check building value 
            if (building == """") {
                $(""#battery"").prop(""disabled"", true);
            } else {
                $(""#battery"").prop(""disabled"", false);
            }
            //call ajax function which call get_battery in interventions_controller.rb 
            $.ajax({
                url: ""/interventions/get_battery"",
                method: ""GET"",
                dataType: ""json"",
                data: { building: building },
                error: function (xhr, status, error) {
                    console.error(""AJAX Error: "" + status + error);
                },
                success: function (response) {
                    var batteries = response[""batteries""];
       ");
            WriteLiteral(@"             $(""#battery"").empty();

                    $(""#battery"").append(""<option>Select Battery</option>"");
                    for (var i = 0; i < batteries.length; i++) {
                        $(""#battery"").append(
                            '<option value=""' +
                            batteries[i][""id""] +
                            '"">' +
                            batteries[i][""building_id""] +
                            ""</option>""
                        );
                    }
                }
            });
        });

        // on change battery  
        $(""#battery"").change(function () {
            //get battery value 
            var battery = $(this).val();
            //check battery value 
            if (battery == """") {
                $(""#column"").prop(""disabled"", true);
            } else {
                $(""#column"").prop(""disabled"", false);
            }
            //call ajax
            $.ajax({
                //call get_column method d");
            WriteLiteral(@"efined in interventions_controller 
                url: ""/interventions/get_column"",
                method: ""GET"",
                dataType: ""json"",
                data: { battery: battery },
                //error case 
                error: function (xhr, status, error) {
                    console.error(""AJAX Error: "" + status + error);
                },
                //success case 
                success: function (response) {
                    var columns = response[""columns""];
                    $(""#column"").empty();
                    //fill the drop down menu 
                    $(""#column"").append(""<option>-None-</option>"");
                    for (var i = 0; i < columns.length; i++) {
                        $(""#column"").append(
                            '<option value=""' +
                            columns[i][""id""] +
                            '"">' +
                            columns[i][""battery_id""] +
                            ""</option>""
           ");
            WriteLiteral(@"             );
                    }
                }
            });
        });

        // On change column 
        $(""#column"").change(function () {
            //get column value 
            var column = $(this).val();
            //check column value 
            if (column == """") {
                $(""#elevator"").prop(""disabled"", true);
            } else {
                $(""#elevator"").prop(""disabled"", false);
            }
            //call ajax 
            $.ajax({
                //call get_elevator method defined in interventions_controller 
                url: ""/interventions/get_elevator"",
                method: ""GET"",
                dataType: ""json"",
                data: { column: column },
                //treat error case 
                error: function (xhr, status, error) {
                    console.error(""AJAX Error: "" + status + error);
                },
                //treat success 
                success: function (response) {
            ");
            WriteLiteral(@"        var elevators = response[""elevators""];
                    $(""#elevator"").empty();
                    //fill elevator drop down 
                    $(""#elevator"").append(""<option>-None-</option>"");
                    for (var i = 0; i < elevators.length; i++) {
                        $(""#elevator"").append(
                            '<option value=""' +
                            elevators[i][""id""] +
                            '"">' +
                            elevators[i][""id""] +
                            ""</option>""
                        );
                    }
                }
            });
        });
        // Customer drop down menu
        $(document).ready(function () {
            var choice = document.getElementById(""customer"");
            //Add listeners
            choice.addEventListener(""change"", customer);
            choice.addEventListener(""change"", clear);
        });

        var customer = function () {
            //if user choose a custom");
            WriteLiteral(@"er => unhide building 
            var choice = document.getElementById(""customer"").value;
            if (choice != 0) {
                $("".building-class"").show();
            }
        };

        // Building drop down menu
        $(document).ready(function () {
            var choice = document.getElementById(""building"");
            //Add listeners 
            choice.addEventListener(""change"", building);
            choice.addEventListener(""change"", clear);
        });

        var building = function () {
            var choice = document.getElementById(""building"").value;
            //if user choose a building => unhide battery 
            if (choice != 0) {
                $("".battery-class"").show();
            }
        };

        // Battery drop down menu
        $(document).ready(function () {
            var choice = document.getElementById(""battery"");
            //Add listeners
            choice.addEventListener(""change"", battery);
            choice.addEventLi");
            WriteLiteral(@"stener(""change"", clear);
        });

        var battery = function () {
            var choice = document.getElementById(""battery"").value;
            //if user choose a battery => unhide column
            if (choice != 0) {
                $("".column-class"").show();
            }
        };

        // Column drop down menu
        $(document).ready(function () {
            var choice = document.getElementById(""column"");
            //Add listeners
            choice.addEventListener(""change"", column);
            choice.addEventListener(""change"", clear);
        });

        var column = function () {
            var choice = document.getElementById(""column"").value;
            //if user choose a column => unhide elevator
            if (choice != 0) {
                $("".elevator-class"").show();
            }
        };

        // Function that reset all inputs 
        var clear = function () {
            $("".form-control-1, .form-control-2, .form-control-3, .form-contro");
            WriteLiteral("l-4\").each(\r\n                function () {\r\n                    $(this).val(\"\");\r\n                }\r\n            );\r\n        };\r\n\r\n        jQuery(_hash).show();\r\n\r\n    };\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
