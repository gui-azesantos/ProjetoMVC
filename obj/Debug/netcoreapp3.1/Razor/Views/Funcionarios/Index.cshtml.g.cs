#pragma checksum "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842979d25aa0754758f3a5a8e6936b6d1d670434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
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
#line 1 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\_ViewImports.cshtml"
using ProjetoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\_ViewImports.cshtml"
using ProjetoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842979d25aa0754758f3a5a8e6936b6d1d670434", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9614e30ac05eda474dd37096940e5ebaae5c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoMVC.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h2>Todos os Funcionários</h2>\r\n    <a href=\"/Funcionarios/Cadastrar\" class=\"btn btn-success\">Novo Funcionário</a>\r\n    <hr>\r\n");
#nullable restore
#line 6 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
     foreach (var funcionario in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Nome: ");
#nullable restore
#line 8 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
            Write(funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Salario: ");
#nullable restore
#line 9 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
               Write(funcionario.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>CPF: ");
#nullable restore
#line 10 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
           Write(funcionario.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 365, "\"", 408, 2);
            WriteAttributeValue("", 372, "/Funcionarios/Editar/", 372, 21, true);
#nullable restore
#line 11 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 393, funcionario.Id, 393, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 456, "\"", 500, 2);
            WriteAttributeValue("", 463, "/Funcionarios/Deletar/", 463, 22, true);
#nullable restore
#line 12 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 485, funcionario.Id, 485, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n        <hr>\r\n");
#nullable restore
#line 14 "C:\Users\GEDO\Desktop\Visual Studio Code\ProjetoMVC\Views\Funcionarios\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoMVC.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
