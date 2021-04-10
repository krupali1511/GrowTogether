<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fileupload.aspx.cs" Inherits="UploadFile.Fileupload" %>

<!DOCTYPE html>    
    
<html xmlns="http://www.w3.org/1999/xhtml">    
<head runat="server">    
    
    <meta charset="utf-8">    
  <meta name="viewport" content="width=device-width, initial-scale=1">    
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">    
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>    
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>    
        
    
    <title></title>    
</head>    
<body>    
    <form id="form1" runat="server">    
    
        <div class="container">    
            <div class="page-header">    
                <h3>File Uploading File</h3>    
    
            </div>    
        </div>    
    
        <table>    
            <thead>    
                    
                    
                    <tr>    
                        <th>               </th>    
                        <th>               </th>    
                            
                        <th><asp:FileUpload ID="myFile" runat="server" CssClass="btn btn-warning" /></th>    
                        <th>               </th>    
                        <th><asp:Button  ID="btnUpload" Text="upload" runat="server" CssClass="btn btn-success"  OnClick="uploadData"/></th>    
                    </tr>    
           
    
                    
            </thead>    
         </table>    
        <hr />    
        <div>    
            <asp:GridView ID="fileGridview" UseAccessibleHeader="true" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" EmptyDataText="No Files Uploaded">    
                <Columns>    
                    <asp:BoundField DataField="Text" HeaderText="File Name"/>    
                     <asp:TemplateField>    
                        <ItemTemplate>    
    
                            <asp:LinkButton ID="DownloadLink" runat="server" Text="Download" OnClick="DownloadData" CommandArgument='<%# Eval("Value") %>'><img src="Images/download.png" height=30 width=30/></asp:LinkButton>    
                        </ItemTemplate>    
    
                    </asp:TemplateField>    
    
                    <asp:TemplateField>    
                        <ItemTemplate>    
    
                            <asp:LinkButton ID="DeleteLink" runat="server" Text="Delete" OnClick="DeleteData" CommandArgument=' <%# Eval("value") %>'><img src="Images/del.png" height=30 width=30 /></asp:LinkButton>    
                        </ItemTemplate>    
    
                    </asp:TemplateField>    
    
                </Columns>    
    
            </asp:GridView>    
            <script type="text/javascript">    
    
            $(document).ready(function() {    
                                        $('#fileGridview').DataTable();    
                                         } );    
            </script>    
        </div>    
    </form>    
</body>    
</html>     