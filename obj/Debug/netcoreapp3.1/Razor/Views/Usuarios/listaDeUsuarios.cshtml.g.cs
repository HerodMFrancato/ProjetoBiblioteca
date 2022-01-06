#pragma checksum "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bded1ee847a128c1eeb3ede64472e5218bae8ae6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_listaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/listaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bded1ee847a128c1eeb3ede64472e5218bae8ae6", @"/Views/Usuarios/listaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_listaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Usuários cadastrados no sistema</h1>\r\n\r\n    <p class=\"text-danger\"> ");
#nullable restore
#line 4 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                       Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"row\">Nome</th>\r\n                <th scope=\"row\">Login</th>\r\n                <th scope=\"row\">Tipo</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 15 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
             foreach (Usuario u in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 20 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                 if (u.Tipo == Usuario.admin)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 23 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 27 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 770, "\"", 799, 2);
            WriteAttributeValue("", 777, "editarUsuario?id=", 777, 17, true);
#nullable restore
#line 28 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
WriteAttributeValue("", 794, u.Id, 794, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 874, 2);
            WriteAttributeValue("", 851, "ExcluirUsuario?id=", 851, 18, true);
#nullable restore
#line 29 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
WriteAttributeValue("", 869, u.Id, 869, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\herodf\Desktop\Senac\UC07\Biblioteca\Views\Usuarios\listaDeUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
