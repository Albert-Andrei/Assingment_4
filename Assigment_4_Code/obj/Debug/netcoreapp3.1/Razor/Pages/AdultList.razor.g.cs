#pragma checksum "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2d824873581d6d1174a1e5b4b3f642912a6412"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment_4_Code.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Assigment_4_Code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\_Imports.razor"
using Assigment_4_Code.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
using Assigment_4_Code.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
using Assigment_4_Code.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 xmlns=\"http://www.w3.org/1999/html\">Adult list</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
 if (adultToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
       
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "id", "searchbtn");
            __builder.AddAttribute(6, "class", "search");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                    changeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Advanced search >");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "drop-content");
            __builder.AddAttribute(12, "style", "display:" + " " + (
#nullable restore
#line 25 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                               disply

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Policy", "SecurityLevel3");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((moreThan4) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "p");
                __builder2.AddAttribute(22, "class", "pc");
                __builder2.AddMarkupContent(23, "\r\n                    Filter by User Id: ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "number");
                __builder2.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                                        (arg) => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "style", "width:50px");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "pc");
            __builder.AddMarkupContent(33, "\r\n                Filter by Sex:\r\n                ");
            __builder.OpenElement(34, "select");
            __builder.AddAttribute(35, "class", "form-control selectpicker");
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                                       (arg) => FilterBySex(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "style", "width:70px");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "option");
            __builder.AddContent(40, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "option");
            __builder.AddContent(43, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "option");
            __builder.AddContent(46, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n            ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class", "pc");
            __builder.AddMarkupContent(52, "\r\n                Filter by Age: ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "number");
            __builder.AddAttribute(55, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                                (arg) => FilterByAge(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "p");
            __builder.AddAttribute(64, "class", "pc");
            __builder.AddMarkupContent(65, "\r\n                Filter by Name: ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                               (arg) => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "style", "width:200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n            ");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "pc");
            __builder.AddMarkupContent(74, "\r\n                Filter by Job Title: ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                                    (arg) => FilterByJobTitle(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "style", "width:200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col");
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "p");
            __builder.AddAttribute(86, "class", "pc");
            __builder.AddMarkupContent(87, "\r\n                Filter by Eye color:\r\n                ");
            __builder.OpenElement(88, "select");
            __builder.AddAttribute(89, "class", "form-control selectpicker");
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                                       (arg) => FilterByEyeColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "style", "width:100px");
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "option");
            __builder.AddContent(94, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.OpenElement(96, "option");
            __builder.AddContent(97, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "option");
            __builder.AddContent(100, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "option");
            __builder.AddContent(103, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.OpenElement(105, "option");
            __builder.AddContent(106, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.OpenElement(108, "option");
            __builder.AddContent(109, "Amber");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "option");
            __builder.AddContent(112, "Hazel");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n            ");
            __builder.OpenElement(116, "p");
            __builder.AddAttribute(117, "class", "pc");
            __builder.AddMarkupContent(118, "\r\n                Filter by Hair color:\r\n                ");
            __builder.OpenElement(119, "select");
            __builder.AddAttribute(120, "class", "form-control selectpicker");
            __builder.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                                                       (arg) => FilterByHairColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "style", "width:100px");
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "option");
            __builder.AddContent(125, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "option");
            __builder.AddContent(128, "Blond");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenElement(130, "option");
            __builder.AddContent(131, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "option");
            __builder.AddContent(134, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.OpenElement(136, "option");
            __builder.AddContent(137, "Black");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                    ");
            __builder.OpenElement(139, "option");
            __builder.AddContent(140, "White");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.OpenElement(142, "option");
            __builder.AddContent(143, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                    ");
            __builder.OpenElement(145, "option");
            __builder.AddContent(146, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                    ");
            __builder.OpenElement(148, "option");
            __builder.AddContent(149, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                    ");
            __builder.OpenElement(151, "option");
            __builder.AddContent(152, "Leverpostej");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
            __builder.AddContent(158, "    ");
            __builder.OpenElement(159, "table");
            __builder.AddAttribute(160, "class", "table");
            __builder.AddMarkupContent(161, "\r\n        ");
            __builder.OpenElement(162, "thead");
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.OpenElement(164, "tr");
            __builder.AddMarkupContent(165, "\r\n            ");
            __builder.AddMarkupContent(166, "<th>Name</th>\r\n            ");
            __builder.AddMarkupContent(167, "<th>Eye color</th>\r\n            ");
            __builder.AddMarkupContent(168, "<th>Age</th>\r\n            ");
            __builder.AddMarkupContent(169, "<th>Hair Color</th>\r\n            ");
            __builder.AddMarkupContent(170, "<th>Sex</th>\r\n            ");
            __builder.AddMarkupContent(171, "<th>Job</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(172);
            __builder.AddAttribute(173, "Policy", "SecurityLevel3");
            __builder.AddAttribute(174, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((moreThan3) => (__builder2) => {
                __builder2.AddMarkupContent(175, "\r\n                ");
                __builder2.AddMarkupContent(176, "<th>Remove</th>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(177, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n        ");
            __builder.OpenElement(180, "tbody");
            __builder.AddMarkupContent(181, "\r\n");
#nullable restore
#line 105 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
         foreach (var item in adultToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(182, "            ");
            __builder.OpenElement(183, "tr");
            __builder.AddMarkupContent(184, "\r\n                ");
            __builder.OpenElement(185, "td");
            __builder.AddContent(186, 
#nullable restore
#line 108 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(187, " ");
            __builder.AddContent(188, 
#nullable restore
#line 108 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                ");
            __builder.OpenElement(190, "td");
            __builder.AddContent(191, 
#nullable restore
#line 109 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                ");
            __builder.OpenElement(193, "td");
            __builder.AddContent(194, 
#nullable restore
#line 110 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                ");
            __builder.OpenElement(196, "td");
            __builder.AddContent(197, 
#nullable restore
#line 111 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                ");
            __builder.OpenElement(199, "td");
            __builder.AddContent(200, 
#nullable restore
#line 112 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n");
#nullable restore
#line 113 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                 if (item.JobTitle != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(202, "                    ");
            __builder.OpenElement(203, "td");
            __builder.AddContent(204, 
#nullable restore
#line 115 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                         item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n");
#nullable restore
#line 116 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(206, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(207);
            __builder.AddAttribute(208, "Policy", "SecurityLevel3");
            __builder.AddAttribute(209, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((moreThan3) => (__builder2) => {
                __builder2.AddMarkupContent(210, "\r\n                    ");
                __builder2.OpenElement(211, "td");
                __builder2.AddMarkupContent(212, "\r\n                        ");
                __builder2.OpenElement(213, "button");
                __builder2.AddAttribute(214, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 119 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
                                            () => RemovePerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(215, "\r\n                            <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(216, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(217, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(218, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n");
#nullable restore
#line 125 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(220, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n");
#nullable restore
#line 128 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\User\RiderProjects\Assigment_4\Assigment_4_Code\Pages\AdultList.razor"
       
    private IList<Adult> adultToShow;
    private IList<Adult> allAdults;


    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultServiceA.GetAdultsAsync();
        adultToShow = allAdults;
    }

    private void RemovePerson(int personId)
    {
        Adult adultToRemove = adultToShow.First(t => t.Id == personId);
        AdultServiceA.RemoveAdultsAsync(personId);
        adultToShow.Remove(adultToRemove);
    }

    private int? filterById;
    private int? filterByAge;
    private string jobTitel;
    private string filterBySex;
    private string filterHairColor;
    private string filterEyeColor;
    private string filterByName;

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }

        adultToShow = allAdults.Where(t =>
            (filterById != null && t.Id == filterById || filterById == null)
            ).ToList();
    }

    private void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        filterByAge = null;
        try
        {
            filterByAge = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByJobTitle(ChangeEventArgs args)
    {
        jobTitel = null;
        try
        {
            jobTitel = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByName(ChangeEventArgs args)
    {
        filterByName = null;
        try
        {
            filterByName = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterBySex(ChangeEventArgs args)
    {
        filterBySex = null;
        try
        {
            if (args.Value.ToString() == "All")
            {
                filterBySex = null;
            }
            else
                filterBySex = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByEyeColor(ChangeEventArgs args)
    {
        filterEyeColor = null;
        try
        {
            if (args.Value.ToString() == "All")
            {
                filterEyeColor = null;
            }
            else
                filterEyeColor = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByHairColor(ChangeEventArgs args)
    {
        filterHairColor = null;
        try
        {
            if (args.Value.ToString() == "All")
            {
                filterHairColor = null;
            }
            else
                filterHairColor = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultToShow = allAdults.Where(t =>
            (filterBySex != null && t.Sex.Contains(filterBySex) || filterBySex == null) &&
            (jobTitel != null && t.JobTitle.Contains(jobTitel) || jobTitel == null) &&
            (filterByName != null && t.FirstName.Contains(filterByName) || filterByName != null && t.LastName.Contains(filterByName) || filterByName == null) &&
            (filterByAge != null && t.Age.ToString().Contains(filterByAge.ToString()) || filterByAge == null) &&
            (filterEyeColor != null && t.EyeColor.Contains(filterEyeColor) || filterEyeColor == null) &&
            (filterHairColor != null && t.HairColor.Contains(filterHairColor) || filterHairColor == null)
            ).ToList();
    }

    string disply = "none";

    private void changeColor()
    {
        if (disply == "none")
        {
            disply = "flex";
        }
        else
        {
            disply = "none";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultServiceA AdultServiceA { get; set; }
    }
}
#pragma warning restore 1591