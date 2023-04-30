<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPortalForm.aspx.cs" Inherits="_220153695_Bosenga_LabEx3.StaffPortalForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UJStaff-Portal</title>
    <link rel="Shortcut Icon" href="University_of_Johannesburg_Logo.ico" type="image/x-icon" />
</head>
<body style="box-sizing:border-box; margin:0px">
    <div style="display:flex; flex-direction:row; background-color:#2E1A46; height:150px;font-family:Arial, Helvetica, sans-serif" >
        <asp:Image id="Image1" runat="server" AlternateText="UJ LOGO" ImageAlign="left" ImageUrl="~/University_of_Johannesburg_Logo.png.png" style="padding-left:230px"></asp:Image>
        <h1 style="padding-left:1050px; color:white; padding-top:85px;" >UJ STAFF PORTAL</h1>
    </div>
    <form id="form1" runat="server">
        <div style="margin-top:50px; margin-left:230px; width:500px; background-color:#eeeeee; border-radius:10px; padding:50px">
            <div>
                <asp:Label runat="server" style="font-size:32px; color:orangered">UJStaffPortal </asp:Label>
                <br />
                <asp:Label runat="server">Please Fill The Form: </asp:Label>
            </div>
            <div style="margin:30px">
                <div style="padding:5px"> 
                    <asp:Label runat="server">Identification Number: </asp:Label>
                    <asp:TextBox ID="txtId" runat="server" MaxLength="10" style="padding:3px" ></asp:TextBox>
                    <%--<asp:Button ID="btncreate" runat="server" Text="Create" OnClick="btnCreate" style="padding:5px; background-color:#2E1A46; color:white"/>--%>
                </div>
                <div style="padding:5px">
                    <asp:Label runat="server">Name: </asp:Label>
                    <asp:TextBox ID="txtName" runat="server" style="margin-left:104px; padding:3px"></asp:TextBox>
                    <%--<asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnSave" />--%>
                </div>
                <div style="padding:5px">
                    <asp:Label runat="server">Surname: </asp:Label>
                    <asp:TextBox ID="txtSurname" runat="server" style="margin-left:86px; padding:3px"></asp:TextBox>
                    <%--<asp:Button ID="btnread" runat="server" Text="Read" OnClick="btnRead" />--%>
                </div>
                <div style="padding:5px">
                    <asp:Label runat="server">Email: </asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" Style="margin-left: 104px; padding:3px" Enabled="False"></asp:TextBox>
                    <%--<asp:Button ID="btnclear" runat="server" Text="Clear" OnClick="btnClear" />--%>
                </div>
                <div style="padding:5px">
                    <asp:Label runat="server">Age: </asp:Label>
                    <asp:TextBox ID="txtAge" runat="server" Style="margin-left: 116px; padding:3px" Enabled="False"></asp:TextBox>
                    <%--<asp:Button ID="btnexit" runat="server" Text="Exit" OnClick="btnExit" />--%>
                </div>
            </div>
           
            <div style="display:flex; flex-direction:row; justify-content:space-evenly; padding-top:10px; padding-bottom:10px">
                <asp:Button ID="Button1" runat="server" Text="Create" OnClick="btnCreate" style="padding:10px; background-color:#2E1A46; color:white; border-radius:5px; width:75px;"/>
                <asp:Button ID="Button2" runat="server" Text="Save" OnClick="btnSave" style="padding:10px; background-color:#2E1A46; color:white; border-radius:5px; width:75px;"/>
                <asp:Button ID="btnread" runat="server" Text="Read" OnClick="btnRead" style="padding:10px; background-color:#2E1A46; color:white; border-radius:5px; width:75px;"/>
                <asp:Button ID="btnclear" runat="server" Text="Clear" OnClick="btnClear" style="padding:10px; background-color:#2E1A46; color:white; border-radius:5px; width:75px;"/>
                <asp:Button ID="btnexit" runat="server" Text="Exit" OnClick="btnExit" style="padding:10px; background-color:#2E1A46; color:white; border-radius:5px; width:75px;"/>
            </div>
        </div>
        <div style="margin-top: 20px; margin-left:230px">
            <asp:ListBox runat="server" ID="ListBox1" Rows="6" Width="600px" SelectionMode="Single"></asp:ListBox>
        </div>
    </form>
</body>
</html>
