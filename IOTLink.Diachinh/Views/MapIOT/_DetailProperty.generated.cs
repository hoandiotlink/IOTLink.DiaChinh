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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MapIOT/_DetailProperty.cshtml")]
    public partial class _Views_MapIOT__DetailProperty_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_MapIOT__DetailProperty_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"InforThuaDat\"");

WriteLiteral(" class=\"detail-property1 detail-property-collapse\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"loading-map-infoThuaDat\"");

WriteLiteral(" class=\"loading-map\"");

WriteLiteral(" style=\"display: none;background-color: #0000;\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 194), Tuple.Create("\"", 227)
, Tuple.Create(Tuple.Create("", 200), Tuple.Create<System.Object, System.Int32>(Href("~/Images/MapIOT/loading.gif")
, 200), false)
);

WriteLiteral(" />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"toggle-detail-property\"");

WriteLiteral(">\r\n        <span><i");

WriteLiteral(" class=\"fa fa-times-circle\"");

WriteLiteral(" title=\"Đóng\"");

WriteLiteral(" onclick=\"RemoveUrlToThua()\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"detail-property-header\"");

WriteLiteral(">\r\n        <span>Thông tin thửa đất</span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"detail-property-body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"detail-property-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"toa-nha\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"section section-info\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Số hiệu tờ bản đồ:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"SoToBD\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Số thửa:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"SoThuaBD\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Tờ bản đồ cũ:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"SoToOld\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Thửa cũ:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"SoThuaOld\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Diện tích:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"DientichBD\"");

WriteLiteral(">0</span> <span");

WriteLiteral(" class=\"DientichBDDonVi\"");

WriteLiteral(">m<sup>2</sup></span></span>\r\n                        </div>\r\n                   " +
"     <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Diện tích pháp lý:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"DientichPL\"");

WriteLiteral(">0</span> <span");

WriteLiteral(" class=\"DientichPLDonVi\"");

WriteLiteral(">m<sup>2</sup></span></span>\r\n                        </div>\r\n                   " +
"     <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Ký hiệu MDSD:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"MucDichSuDung\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        ");

WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Ký hiệu đối tượng:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"KHDTC\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Tên chủ:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"TenChu\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Địa chỉ:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"DiaChi\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"form-group col-md-12 form-common-infor\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">Mã hành chính xã:</label>\r\n                            <span");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral("><span");

WriteLiteral(" class=\"MaXa\"");

WriteLiteral(">0</span></span>\r\n                        </div>\r\n                    </div>\r\n\r\n " +
"                   <div");

WriteLiteral(" class=\"row tool-map\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"title1\"");

WriteLiteral(">Công cụ bản đồ</h3>\r\n                        ");

WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-export-file\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file-archive-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Trích xuất file</label>\r\n                        </div>\r\n   " +
"                     <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-update-file\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-upload\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Nhập dữ liệu từ textfile</label>\r\n                        </" +
"div>\r\n                        <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-update-shape\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-pencil-square-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Cập nhập thuộc tính thửa đất</label>\r\n                      " +
"  </div>\r\n                        <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-edit-mode-3d\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-cubes\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Biên tập không gian 3D</label>\r\n                        </di" +
"v>\r\n                        <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-bien-tap\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-object-group\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Biên tập</label>\r\n                        </div>\r\n          " +
"              <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-chinh-sua-thua-dat\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-object-group\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Chỉnh sửa tọa độ đỉnh thửa</label>\r\n                        " +
"</div>\r\n                        <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-tach-thua\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-map-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>Tách thửa</label>\r\n                        </div>\r\n         " +
"               <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-select-trich-luc\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-leaf\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>In trích lục</label>\r\n                        </div>\r\n      " +
"                  <div");

WriteLiteral(" class=\"tool-map-button\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-select-hskt\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-leaf\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i></button><label>In ấn hồ sơ kỹ thuật</label>\r\n                        </div>" +
"\r\n                        ");

WriteLiteral("\r\n                        ");

WriteLiteral("\r\n\r\n                        <div>\r\n                            <hr />\r\n          " +
"                  <h3>Hợp thửa đất</h3>\r\n                        </div>\r\n       " +
"                 <div");

WriteLiteral(" class=\"tool-map-button group-hop-thua\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary btn-hop-thua\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-map-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>Hợp thửa</button>\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success btn-save-hop-thua\"");

WriteLiteral(" disabled><i");

WriteLiteral(" class=\"fa fa-map-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>Lưu lại</button>\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger btn-huy-hop-thua\"");

WriteLiteral(" disabled><i");

WriteLiteral(" class=\"fa fa-map-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>Hủy bỏ</button>\r\n                        </div>\r\n                    </div>\r" +
"\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r" +
"\n\r\n<style>\r\n    .infor-area-item .item {\r\n        padding: 5px 0px;\r\n        bor" +
"der-bottom: none\r\n    }\r\n\r\n        .infor-area-item .item > div {\r\n            p" +
"adding-bottom: 5px;\r\n        }\r\n\r\n    .detail-button {\r\n        position: absolu" +
"te;\r\n        bottom: 1px;\r\n        width: 100%;\r\n    }\r\n\r\n        .detail-button" +
" #btnDetailBuilding, .detail-button #btnDetailShape {\r\n            width: 100%;\r" +
"\n            padding: 0px;\r\n        }\r\n\r\n            .detail-button #btnDetailBu" +
"ilding button, .detail-button #btnDetailShape button {\r\n                width: 1" +
"00%;\r\n                background-color: #fff;\r\n                border-color: #ff" +
"f;\r\n                color: #337ab7;\r\n                font-size: 16px;\r\n         " +
"   }\r\n\r\n    /*.detail-property-body {\r\n        height: calc(100% - 76px);\r\n    }" +
"*/\r\n\r\n    .common-infor-home {\r\n        display: inline-block;\r\n        width: 1" +
"00%;\r\n        padding: 10px;\r\n        margin-bottom: 15px;\r\n        box-shadow: " +
"none;\r\n        background: #FFFFFF;\r\n    }\r\n\r\n        .common-infor-home .item {" +
"\r\n            display: inline-block;\r\n            width: 100%;\r\n            bord" +
"er-top: 1px solid #E0E0E0;\r\n            float: left;\r\n            padding-top: 1" +
"2px;\r\n            padding-bottom: 2px;\r\n        }\r\n\r\n            .common-infor-h" +
"ome .item:first-child {\r\n                border-top: 0px;\r\n            }\r\n\r\n    " +
"        .common-infor-home .item .item-left {\r\n                color: #323958;\r\n" +
"                font-size: 14px;\r\n                font-weight: 600;\r\n           " +
"     padding-left: 15px;\r\n                width: 145px;\r\n                float: " +
"left;\r\n                display: inline-block;\r\n            }\r\n\r\n            .com" +
"mon-infor-home .item .item-right {\r\n                display: inline-block;\r\n    " +
"            width: calc(100% - 145px);\r\n                float: left;\r\n          " +
"      padding-left: 10px;\r\n                color: #7E93A8;\r\n            }\r\n\r\n   " +
" .form-common-infor {\r\n        margin-bottom: 3px;\r\n        padding: 0px;\r\n    }" +
"\r\n\r\n    .section-info .row {\r\n        margin: 0px;\r\n    }\r\n\r\n    .tool-map butto" +
"n {\r\n        width: 50px;\r\n        background-color: #2198F1;\r\n        border-co" +
"lor: #2198F1;\r\n    }\r\n\r\n    .tool-map-button {\r\n        margin-bottom: 5px;\r\n   " +
" }\r\n\r\n        .tool-map-button label {\r\n            margin-left: 10px;\r\n        " +
"}\r\n\r\n        .tool-map-button.group-hop-thua {\r\n            width: 100px;\r\n     " +
"       display: flex;\r\n        }\r\n\r\n            .tool-map-button.group-hop-thua " +
"button {\r\n                width: 100%;\r\n                margin-right: 5px;\r\n    " +
"        }\r\n\r\n            .tool-map-button.group-hop-thua .btn-save-hop-thua {\r\n " +
"               background-color: #00a65a !important;\r\n                border-col" +
"or: #008d4c !important;\r\n            }\r\n\r\n            .tool-map-button.group-hop" +
"-thua .btn-huy-hop-thua {\r\n                background-color: #dd4b39 !important;" +
"\r\n                border-color: #d73925 !important;\r\n            }\r\n</style>\r\n\r\n" +
"");

        }
    }
}
#pragma warning restore 1591
