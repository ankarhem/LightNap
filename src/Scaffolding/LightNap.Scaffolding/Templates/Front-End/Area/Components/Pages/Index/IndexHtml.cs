﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace LightNap.Scaffolding.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class IndexHtml : LightNap.Scaffolding.Templates.BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
<p-card header=""All"">
  <div class=""flex gap-1 mb-1"">
    <p-button [routerLink]=""['create']"" severity=""success"" icon=""pi pi-plus"" label=""Create"" />
  </div>

  <api-response [apiResponse]=""searchResults$"" errorMessage=""Error loading items"" loadingMessage=""Loading items..."">
    <ng-template #success let-searchResults>
      <p-table
        [value]=""searchResults.data""
        [paginator]=""true""
        [rows]=""pageSize""
        [totalRecords]=""searchResults.totalCount""
        [lazy]=""true""
        (onLazyLoad)=""onLazyLoad($event)""
      >
        <ng-template pTemplate=""header"">
          <tr>
            <th></th>
            <th>");
            
            #line 25 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.IdProperty.Name));
            
            #line default
            #line hidden
            this.Write("</th>\r\n");
            
            #line 26 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
      foreach (var property in Parameters.GetProperties) { 
            
            #line default
            #line hidden
            this.Write("            <th>");
            
            #line 27 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("</th>\r\n");
            
            #line 28 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
      } 
            
            #line default
            #line hidden
            this.Write("          </tr>\r\n        </ng-template>\r\n        <ng-template pTemplate=\"body\" le" +
                    "t-");
            
            #line 31 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write(">\r\n          <tr>\r\n            <td>\r\n              <p-button [routerLink]=\"[");
            
            #line 34 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 34 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.IdProperty.CamelName));
            
            #line default
            #line hidden
            this.Write("]\" icon=\"pi pi-eye\" />\r\n            </td>\r\n            <td>{{");
            
            #line 36 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 36 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.IdProperty.CamelName));
            
            #line default
            #line hidden
            this.Write("}}</td>\r\n");
            
            #line 37 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
      foreach (var property in Parameters.GetProperties) { 
            switch (property.BackEndType) {
				case "DateTime": 
            
            #line default
            #line hidden
            this.Write("            <td>{{");
            
            #line 40 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 40 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(" | date : \'long\'}}</td>\r\n");
            
            #line 41 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
                  break;
				case "int":
                case "long":
                case "double":
                case "float":
                case "decimal":
                case "short":
                case "byte":
                case "ushort":
                case "uint":
                case "ulong": 
            
            #line default
            #line hidden
            this.Write("            <td>{{");
            
            #line 52 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 52 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(" | number}}</td>\r\n");
            
            #line 53 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
                  break;
				default: 
            
            #line default
            #line hidden
            this.Write("            <td>{{");
            
            #line 55 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 55 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write("}}</td>\r\n");
            
            #line 56 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Index\IndexHtml.tt"
                  break;
            }
        } 
            
            #line default
            #line hidden
            this.Write(@"          </tr>
        </ng-template>
        <ng-template pTemplate=""emptymessage"">
          <tr>
            <td colspan=""100%"">There are no items.</td>
          </tr>
        </ng-template>
      </p-table>
    </ng-template>
  </api-response>
</p-card>
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}