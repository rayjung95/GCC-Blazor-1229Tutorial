#pragma checksum "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a454d55b053612849d4fc47d0449f011be97bcf"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "ul");
#nullable restore
#line 6 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "li");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
                                          todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
                          todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "placeholder", "Something todo");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
                                           newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Ray\Desktop\GCC\New folder\TodoList\Pages\Todo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
