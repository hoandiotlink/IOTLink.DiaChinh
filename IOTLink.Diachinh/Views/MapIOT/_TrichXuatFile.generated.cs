﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FIOLIS.Modules.Map;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MapIOT/_TrichXuatFile.cshtml")]
    public partial class _Views_MapIOT__TrichXuatFile_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_MapIOT__TrichXuatFile_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"modal fade modal-trich-xuat\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"myLargeModalLabel\"");

WriteLiteral(" data-backdrop=\"static\"");

WriteLiteral(" data-keyboard=\"false\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" role=\"document\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close close-modal-iotlink\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">Trích xuất nhiều thửa đất</h4>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <form>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Lớp dữ liệu</label>\r\n                        <s" +
"elect");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                            <option>Thửa đất</option>\r\n                       " +
" </select>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Mã xã <span");

WriteLiteral(" style=\"color:red\"");

WriteLiteral(">*</span></label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"MaXa\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" disabled>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Số hiệu tờ bản đồ</label>\r\n                    " +
"    <div");

WriteLiteral(" class=\"common-so soto\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"VungSoTo\"");

WriteLiteral(" >\r\n                                <option");

WriteLiteral(" value=\"1\"");

WriteLiteral(">=</option>\r\n                                <option");

WriteLiteral(" value=\"2\"");

WriteLiteral("><=</option>\r\n                                <option");

WriteLiteral(" value=\"2\"");

WriteLiteral(">>=</option>\r\n                            </select>\r\n                            " +
"<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"SoTo\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(">\r\n                        </div>\r\n\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Số thứ tự thửa</label>\r\n                       " +
" <div");

WriteLiteral(" class=\"common-so sothua\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"VungSoThua\"");

WriteLiteral(">\r\n                                <option");

WriteLiteral(" value=\"1\"");

WriteLiteral(">=</option>\r\n                                <option");

WriteLiteral(" value=\"2\"");

WriteLiteral("><=</option>\r\n                                <option");

WriteLiteral(" value=\"2\"");

WriteLiteral(">>=</option>\r\n                            </select>\r\n                            " +
"<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"SoThua\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Định dạng file</label>\r\n                       " +
" <select");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                            <option>*.shapefile</option>\r\n                    " +
"    </select>\r\n                    </div>\r\n                </form>\r\n            " +
"</div>\r\n            <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary btn-download-file\"");

WriteLiteral(">Tải file</button>\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(@">Thoát</button>
            </div>
        </div>
    </div>
</div>
<style>
    .modal-trich-xuat .common-so{
        display:flex;
    }
    .modal-trich-xuat .common-so select{
        width:30%;
        margin-right:10px;
    }

    /*.modal-trich-xuat .common-so input{
        width:30%;
        margin-right:10px;
    }*/

</style>");

        }
    }
}
#pragma warning restore 1591
