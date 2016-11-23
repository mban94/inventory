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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Tasks\Transfer\New.cshtml"
    using Frapid.ApplicationState.Cache;
    
    #line default
    #line hidden
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.Inventory;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Transfer/New.cshtml")]
    public partial class _Views_Tasks_Transfer_New_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Transfer_New_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tasks\Transfer\New.cshtml"
  
    ViewBag.Title = "Inventory";
    Layout = ViewBag.InventoryLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"ui attached page segment\"");

WriteLiteral(" style=\"min-height: 100%;padding:3em;display:none;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Inventory Transfer</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"inline fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"small field\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"ValueDateTextBox\"");

WriteLiteral(">Value Date</label>\r\n                <input");

WriteLiteral(" id=\"ValueDateTextBox\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"small field\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"BookDateTextBox\"");

WriteLiteral(">Book Date</label>\r\n                <input");

WriteLiteral(" id=\"BookDateTextBox\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"small field\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"ReferenceNumberInputText\"");

WriteLiteral(">Ref#</label>\r\n                <input");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" maxlength=\"24\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <table");

WriteLiteral(" id=\"TransferGridView\"");

WriteLiteral(" class=\"ui table segment\"");

WriteLiteral(" style=\"min-width:1000px;max-width:2000px;\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th");

WriteLiteral(" style=\"width:150px\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"TransactionTypeSelect\"");

WriteLiteral(">Type</label>\r\n                    </th>\r\n                    <th");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"StoreSelect\"");

WriteLiteral(">Store</label>\r\n                    </th>\r\n                    <th");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"ItemCodeInputText\"");

WriteLiteral(">Item Code</label>\r\n                    </th>\r\n                    <th>\r\n        " +
"                <label");

WriteLiteral(" for=\"ItemSelect\"");

WriteLiteral(">Item Name</label>\r\n                    </th>\r\n                    <th");

WriteLiteral(" style=\"width:200px;\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"UnitSelect\"");

WriteLiteral(">Unit</label>\r\n                    </th>\r\n                    <th");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"QuantityInputText\"");

WriteLiteral(">Quantity</label>\r\n                    </th>\r\n                    <th>Action</th>" +
"\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n            " +
"    <tr");

WriteLiteral(" class=\"footer-row ui form\"");

WriteLiteral(">\r\n                    <td>\r\n                        <select");

WriteLiteral(" class=\"ui fluid dropdown\"");

WriteLiteral(" id=\"TransactionTypeSelect\"");

WriteLiteral(">\r\n                            <option");

WriteLiteral(" value=\"Cr\"");

WriteLiteral(">OUT</option>\r\n                            <option");

WriteLiteral(" value=\"Dr\"");

WriteLiteral(">IN</option>\r\n                        </select>\r\n                    </td>\r\n     " +
"               <td>\r\n                        <select");

WriteLiteral(" id=\"StoreSelect\"");

WriteLiteral(" class=\"ui fluid dropdown\"");

WriteLiteral("></select>\r\n                    </td>\r\n                    <td>\r\n                " +
"        <input");

WriteLiteral(" id=\"ItemCodeInputText\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <" +
"select");

WriteLiteral(" id=\"ItemSelect\"");

WriteLiteral(" class=\"ui fluid dropdown\"");

WriteLiteral("></select>\r\n                    </td>\r\n                    <td>\r\n                " +
"        <select");

WriteLiteral(" id=\"UnitSelect\"");

WriteLiteral(" class=\"ui fluid dropdown\"");

WriteLiteral("></select>\r\n                    </td>\r\n                    <td>\r\n                " +
"        <input");

WriteLiteral(" id=\"QuantityInputText\"");

WriteLiteral(" class=\"text-right integer\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <" +
"input");

WriteLiteral(" id=\"AddButton\"");

WriteLiteral(" value=\"Add\"");

WriteLiteral(" class=\"ui small red button\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n      " +
"  </table>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"ErrorLabel\"");

WriteLiteral(" class=\"big error vpad16\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(" style=\"width:290px;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"small field\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"StatementReferenceTextArea\"");

WriteLiteral(">Statement Reference</label>\r\n            <textarea");

WriteLiteral(" id=\"StatementReferenceTextArea\"");

WriteLiteral(" rows=\"4\"");

WriteLiteral("></textarea>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"ui buttons\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" id=\"SaveButton\"");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n                Save\r\n            </button>\r\n            <a");

WriteLiteral(" href=\"/dashboard/inventory/tasks/inventory-transfers\"");

WriteLiteral(" class=\"ui blue button\"");

WriteLiteral(">Back</a>            \r\n        </div>\r\n    </div>\r\n\r\n    <input");

WriteLiteral(" id=\"ItemIdHidden\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(">\r\n</div>\r\n\r\n<script>\r\n    var addButton = $(\"#AddButton\");\r\n    var dateTextBox " +
"= $(\"#DateTextBox\");\r\n    var errorLabel = $(\"#ErrorLabel\");\r\n    var itemIdHidd" +
"en = $(\"#ItemIdHidden\");\r\n    var itemCodeInputText = $(\"#ItemCodeInputText\");\r\n" +
"    var itemSelect = $(\"#ItemSelect\");\r\n    var quantityInputText = $(\"#Quantity" +
"InputText\");\r\n    var saveButton = $(\"#SaveButton\");\r\n    var storeSelect = $(\"#" +
"StoreSelect\");\r\n    var transactionTypeSelect = $(\"#TransactionTypeSelect\");\r\n  " +
"  var transferGridView = $(\"#TransferGridView\");\r\n    var unitSelect = $(\"#UnitS" +
"elect\");\r\n    var storeServiceUrl = \"/api/forms/inventory/stores/display-fields\"" +
";\r\n\r\n    var url = \"\";\r\n    var data = \"\";\r\n\r\n    $(document).ready(function () " +
"{\r\n        loadStores();\r\n        loadItems();\r\n    });\r\n\r\n    addButton.click(f" +
"unction () {\r\n        addRow();\r\n    });\r\n\r\n    var addRow = function () {\r\n    " +
"    itemCodeInputText.val(itemSelect.getSelectedValue());\r\n\r\n        var tranTyp" +
"e = transactionTypeSelect.getSelectedValue();\r\n        var storeName = storeSele" +
"ct.getSelectedText();\r\n        var itemCode = itemCodeInputText.val();\r\n        " +
"var itemName = itemSelect.getSelectedText();\r\n        var unitName = unitSelect." +
"getSelectedText();\r\n        var quantity = parseInt(quantityInputText.val() || 0" +
");\r\n\r\n        if (transactionTypeSelect.length) {\r\n            if (window.isNull" +
"OrWhiteSpace(tranType) || tranType === \"Select\") {\r\n                window.makeD" +
"irty(transactionTypeSelect);\r\n                return;\r\n            };\r\n        }" +
";\r\n\r\n        if (window.isNullOrWhiteSpace(storeName) || storeName === \"Select\")" +
" {\r\n            window.makeDirty(storeSelect);\r\n            return;\r\n        };\r" +
"\n\r\n        if (window.isNullOrWhiteSpace(itemCode)) {\r\n            window.makeDi" +
"rty(itemCodeInputText);\r\n            return;\r\n        };\r\n\r\n        if (window.i" +
"sNullOrWhiteSpace(itemName) || itemName === \"Select\") {\r\n            window.make" +
"Dirty(itemSelect);\r\n            return;\r\n        };\r\n\r\n        if (window.isNull" +
"OrWhiteSpace(unitName) || unitName === \"Select\") {\r\n            window.makeDirty" +
"(unitSelect);\r\n            return;\r\n        };\r\n\r\n        if (quantity <= 0) {\r\n" +
"            window.makeDirty(quantityInputText);\r\n            return;\r\n        }" +
";\r\n\r\n        window.removeDirty(transactionTypeSelect);\r\n        window.removeDi" +
"rty(storeSelect);\r\n        window.removeDirty(itemCodeInputText);\r\n        windo" +
"w.removeDirty(itemSelect);\r\n        window.removeDirty(unitSelect);\r\n        win" +
"dow.removeDirty(quantityInputText);\r\n\r\n        appendToTable(tranType, storeName" +
", itemCode, itemName, unitName, quantity);\r\n        itemCodeInputText.val(\"\");\r\n" +
"        quantityInputText.val(\"\");\r\n\r\n        if (transactionTypeSelect.length) " +
"{\r\n            transactionTypeSelect.focus();\r\n            return;\r\n        };\r\n" +
"\r\n        storeSelect.attr(\"disabled\", \"disabled\");\r\n        itemCodeInputText.f" +
"ocus();\r\n    };\r\n\r\n    function appendToTable(tranType, storeName, itemCode, ite" +
"mName, unitName, quantity) {\r\n        var rows = transferGridView.find(\"tbody tr" +
":not(:last-child)\");\r\n        var match = false;\r\n        var html;\r\n\r\n        i" +
"f (transactionTypeSelect.length) {\r\n            rows.each(function () {\r\n       " +
"         var row = $(this);\r\n                if (window.getColumnText(row, 0) !=" +
"= tranType &&\r\n                    window.getColumnText(row, 1) === storeName &&" +
"\r\n                    window.getColumnText(row, 2) === itemCode) {\r\n            " +
"        $.notify(\"Duplicate entry\");\r\n\r\n                    window.makeDirty(ite" +
"mSelect);\r\n                    match = true;\r\n                };\r\n\r\n            " +
"    if (window.getColumnText(row, 0) === tranType &&\r\n                    window" +
".getColumnText(row, 1) === storeName &&\r\n                    window.getColumnTex" +
"t(row, 2) === itemCode &&\r\n                    window.getColumnText(row, 4) === " +
"unitName) {\r\n                    window.setColumnText(row, 5, window.getFormatte" +
"dNumber(window.parseFloat2(window.getColumnText(row, 5)) + quantity));\r\n\r\n      " +
"              window.addDanger(row);\r\n                    match = true;\r\n       " +
"             return;\r\n                }\r\n            });\r\n\r\n            if (!mat" +
"ch) {\r\n                html = \"<tr class=\'grid2-row\'><td>\" + tranType + \"</td><t" +
"d>\" + storeName + \"</td><td>\" + itemCode + \"</td><td>\" + itemName + \"</td><td>\" " +
"+ unitName + \"</td><td class=\'text-right\'>\" + getFormattedNumber(quantity) + \"</" +
"td>\"\r\n                    + \"</td><td><a class=\'pointer\' onclick=\'removeRow($(th" +
"is));\'><i class=\'ui delete icon\'></i></a><a class=\'pointer\' onclick=\'toggleDange" +
"r($(this));\'><i class=\'ui pointer check mark icon\'></a></i><a class=\'pointer\' on" +
"click=\'toggleSuccess($(this));\'><i class=\'ui pointer thumbs up icon\'></i></a></t" +
"d></tr>\";\r\n                transferGridView.find(\"tr:last\").before(html);\r\n     " +
"       };\r\n\r\n            return;\r\n        };\r\n\r\n        rows.each(function () {\r" +
"\n            var row = $(this);\r\n            if (window.getColumnText(row, 0) ==" +
"= storeName &&\r\n                window.getColumnText(row, 1) === itemCode) {\r\n  " +
"              $.notify(\"Duplicate Entry\");\r\n\r\n                window.makeDirty(i" +
"temSelect);\r\n                match = true;\r\n            };\r\n\r\n            if (wi" +
"ndow.getColumnText(row, 0) === storeName &&\r\n                window.getColumnTex" +
"t(row, 1) === itemCode &&\r\n                window.getColumnText(row, 3) === unit" +
"Name) {\r\n                window.setColumnText(row, 4, window.getFormattedNumber(" +
"window.parseFloat2(window.getColumnText(row, 4)) + quantity));\r\n\r\n              " +
"  window.addDanger(row);\r\n                match = true;\r\n                return;" +
"\r\n            }\r\n        });\r\n\r\n        if (!match) {\r\n            html = \"<tr c" +
"lass=\'grid2-row\'><td>\" + storeName + \"</td><td>\" + itemCode + \"</td><td>\" + item" +
"Name + \"</td><td>\" + unitName + \"</td><td class=\'text-right\'>\" + getFormattedNum" +
"ber(quantity) + \"</td>\"\r\n                + \"</td><td><a class=\'pointer\' onclick=" +
"\'removeRow($(this));\'><i class=\'ui delete icon\'></i></a><a class=\'pointer\' oncli" +
"ck=\'toggleDanger($(this));\'><i class=\'ui pointer check mark icon\'></a></i><a cla" +
"ss=\'pointer\' onclick=\'toggleSuccess($(this));\'><i class=\'ui pointer thumbs up ic" +
"on\'></i></a></td></tr>\";\r\n            transferGridView.find(\"tr:last\").before(ht" +
"ml);\r\n        };\r\n    };\r\n\r\n    saveButton.click(function () {\r\n        function" +
" request(model) {\r\n            var url = \"/dashboard/inventory/tasks/inventory-t" +
"ransfers\";\r\n            var data = JSON.stringify(model);\r\n            return wi" +
"ndow.getAjaxRequest(url, \"POST\", data);\r\n        };\r\n\r\n        function getModel" +
"() {\r\n            function getDetails() {\r\n                var model = [];\r\n    " +
"            var rows = $(\"#TransferGridView tbody tr:not(:last-child)\");\r\n\r\n    " +
"            $.each(rows, function() {\r\n                    var row = $(this);\r\n " +
"                   var transferType = row.find(\"td:nth-child(1)\").html();\r\n     " +
"               var storeName = row.find(\"td:nth-child(2)\").html();\r\n            " +
"        var itemCode = row.find(\"td:nth-child(3)\").html();\r\n                    " +
"var itemName = row.find(\"td:nth-child(4)\").html();\r\n                    var unit" +
"Name = row.find(\"td:nth-child(5)\").html();\r\n                    var quantity = w" +
"indow.parseFloat2(row.find(\"td:nth-child(6)\").html());\r\n\r\n                    mo" +
"del.push({\r\n                        ItemCode: itemCode,\r\n                       " +
" ItemName: itemName,\r\n                        Quantity: quantity,\r\n             " +
"           StoreName: storeName,\r\n                        TransferTypeEnum: tran" +
"sferType,\r\n                        UnitName: unitName\r\n                    });\r\n" +
"                });\r\n\r\n                return model;\r\n            };\r\n\r\n        " +
"    var valueDate = window.parseLocalizedDate($(\"#ValueDateTextBox\").val());\r\n  " +
"          var bookDate = window.parseLocalizedDate($(\"#BookDateTextBox\").val());" +
"\r\n            var referenceNumber = $(\"#ReferenceNumberInputText\").val();\r\n     " +
"       var statementReference = $(\"#StatementReferenceTextArea\").val();\r\n       " +
"     var details = getDetails();\r\n\r\n            if (!window.isDate(valueDate)) {" +
"\r\n                window.makeDirty($(\"#ValueDateTextBox\"));\r\n                err" +
"orLabel.html(\"Invalid date!\");\r\n                return false;\r\n            };\r\n\r" +
"\n            if (!window.isDate(bookDate)) {\r\n                window.makeDirty($" +
"(\"#BookDateTextBox\"));\r\n                errorLabel.html(\"Invalid date!\");\r\n     " +
"           return false;\r\n            };\r\n\r\n            if (!details || details." +
"length === 0) {\r\n                errorLabel.html(\"Nothing to transfer!\");\r\n     " +
"           return false;\r\n            };\r\n\r\n            return {\r\n              " +
"  ValueDate: valueDate,\r\n                BookDate: bookDate,\r\n                Re" +
"ferenceNumber: referenceNumber,\r\n                StatementReference: statementRe" +
"ference,\r\n                Details: details\r\n            };\r\n        };\r\n\r\n      " +
"  \r\n\r\n        errorLabel.html(\"\");\r\n\r\n        if (transferGridView.find(\"tr\").le" +
"ngth === 2) {\r\n            errorLabel.html(\"Gridview is empty!\");\r\n            r" +
"eturn false;\r\n        };\r\n\r\n        var model = getModel();\r\n        var ajax = " +
"request(model);\r\n\r\n        ajax.success(function(response) {\r\n            var ur" +
"l = \"/dashboard/inventory/tasks/transfers/checklist/\" + response;\r\n            d" +
"ocument.location = url;\r\n        });\r\n\r\n        ajax.fail(function (xhr) {\r\n    " +
"        window.logAjaxErrorMessage(xhr);\r\n        });\r\n    });\r\n\r\n    itemSelect" +
".change(function () {\r\n        itemCodeInputText.val(itemSelect.getSelectedValue" +
"());\r\n        loadUnits();\r\n    });\r\n\r\n    itemSelect.blur(function () {\r\n      " +
"  itemCodeInputText.val(itemSelect.getSelectedValue());\r\n        loadUnits();\r\n " +
"   });\r\n\r\n    itemCodeInputText.blur(function () {\r\n        if (!window.isNullOr" +
"WhiteSpace(itemCodeInputText.val())) {\r\n            itemSelect.val(itemCodeInput" +
"Text.val());\r\n        };\r\n    });\r\n\r\n    function loadStores() {\r\n        window" +
".displayFieldBinder(storeSelect, \"/api/forms/inventory/stores/display-fields\");\r" +
"\n    };\r\n\r\n\r\n    function loadItems() {\r\n        function request() {\r\n         " +
"   var url = \"/dashboard/inventory/items/stockable\";\r\n            return window." +
"getAjaxRequest(url);\r\n        };\r\n\r\n        var ajax = request();\r\n        ajax." +
"success(function (response) {\r\n            var options = \"<option>Select</option" +
">\";\r\n\r\n            $.each(response, function () {\r\n                var option = " +
"\"<option value=\'{key}\'>{value}</option>\";\r\n                option = option.repla" +
"ce(\"{key}\", this.ItemCode);\r\n                option = option.replace(\"{value}\", " +
"this.ItemName);\r\n\r\n                options += option;\r\n            });\r\n\r\n      " +
"      itemSelect.html(options);\r\n        });\r\n    };\r\n\r\n    function loadUnits()" +
" {\r\n        function request(itemCode) {\r\n            var url = \"/dashboard/inve" +
"ntory/get-associated-units/{*itemCode}\";\r\n            url = url.replace(\"{*itemC" +
"ode}\", itemCode);\r\n\r\n            return window.getAjaxRequest(url);\r\n        };\r" +
"\n\r\n        var itemCode = itemCodeInputText.val();\r\n        var ajax = request(i" +
"temCode);\r\n        ajax.success(function (response) {\r\n            var options =" +
" \"<option>Select</option>\";\r\n\r\n            $.each(response, function () {\r\n     " +
"           var option = \"<option value=\'{key}\'>{value}</option>\";\r\n             " +
"   option = option.replace(\"{key}\", this.UnitId);\r\n                option = opti" +
"on.replace(\"{value}\", this.UnitName);\r\n\r\n                options += option;\r\n   " +
"         });\r\n\r\n            unitSelect.html(options);\r\n        });\r\n    };\r\n\r\n  " +
"  function removeLoaderInstance() {\r\n        removeLoader(transferGridView);\r\n  " +
"  };\r\n\r\n    //Check if ItemPopup window has updated the hidden field.\r\n    funct" +
"ion ajaxDataBindCallBack(targetControl) {\r\n        if (targetControl.is(itemSele" +
"ct)) {\r\n            var itemId = parseInt(itemIdHidden.val() || 0);\r\n\r\n         " +
"   itemIdHidden.val(\"\");\r\n\r\n            if (itemId > 0) {\r\n                var t" +
"argetControls = $([]);\r\n                targetControls.push(itemCodeInputText);\r" +
"\n                targetControls.push(itemSelect);\r\n\r\n                url = itemI" +
"dQuerySericeUrl;\r\n                data = appendParameter(\"\", \"itemId\", itemId);\r" +
"\n                data = getData(data);\r\n\r\n                ajaxUpdateVal(url, dat" +
"a, targetControls);\r\n            }\r\n        };\r\n    };\r\n\r\n    shortcut.add(\"F4\"," +
" function () {\r\n        url = itemPopupUrl;\r\n        showWindow(url);\r\n    });\r\n" +
"\r\n    shortcut.add(\"CTRL+ENTER\", function () {\r\n        addButton.trigger(\'click" +
"\');\r\n    });\r\n\r\n    //$(\"select\").dropdown();\r\n    window.overridePath = \"/dashb" +
"oard/inventory/tasks/inventory-transfers\";\r\n\r\n    var visible = false;\r\n\r\n    $(" +
"document).ajaxStop(function () {\r\n        setTimeout(function () {\r\n            " +
"if (!visible) {\r\n                visible = true;\r\n\r\n                $(\".page.seg" +
"ment\").fadeIn(300);\r\n            };\r\n        }, 200);\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591