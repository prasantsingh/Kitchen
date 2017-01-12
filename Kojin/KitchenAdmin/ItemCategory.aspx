<%@ Page Title="" Language="C#" MasterPageFile="~/KitchenAdmin/KitchenMain.Master" AutoEventWireup="true" CodeBehind="ItemCategory.aspx.cs" Inherits="Kojin.KitchenAdmin.ItemCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h1>Item Category
                </h1>
            </div>

            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Item Category Name</label>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtItemCategoryName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtItemCategoryName"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Description</label>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtDescription1" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDescription1"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Description2</label>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtDescription2" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDescription2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Description3</label>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtDescription3" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                         <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDescription3"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3"></div>
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Font-Bold="true" CssClass="col-sm-4 control-label"></asp:Label>
                    <div class="col-sm-3"></div>
                </div>
                <div class="clearfix form-actions">

                    <div class="col-md-offset-3 col-md-9">
                        <asp:Button ID="btnCreate" runat="server" class="btn btn-success" Text="Create" ValidationGroup="btnCreate" OnClick="btnCreate_Click" ></asp:Button>
                        &nbsp; &nbsp; &nbsp;
				        <asp:Button ID="btnReset" runat="server" class="btn btn-info" Text="Reset" OnClick="btnReset_Click" ></asp:Button>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnCreate" />
        </Triggers>
    </asp:UpdatePanel>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive">
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered table-hover" style="width: 100%;">
                            <thead>
                                <tr>
                                     <th>ItemCat Id</th>
                                    <th>Item Category Name</th>
                                    <th>Description</th>
                                    <th>Description2</th>
                                    <th>Description3</th>
                                    <th>Status</th>
                                    <th>Date</th>
                                    <th>Time</th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>                                
                                <td>
                                    <asp:LinkButton ID="lnkItem_Cat_id" runat="server" Text='<%#Eval("Item_Cat_id") %>'></asp:LinkButton>
                                </td>
                                <td><%#Eval("Item_Cat_Name") %></td>
                                <td><%#Eval("Item_Cat_Desc1") %></td>
                                <td><%#Eval("Item_Cat_Desc2") %></td>
                                <td><%#Eval("Item_Cat_Desc3") %></td>
                                <td><%#Eval("Item_Cat_Status") %></td>
                                <td><%#Eval("Item_Cat_DateTime","{0:dd/MM/yyyy}") %></td>
                                <td><%#Eval("Item_Cat_DateTime","{0:hh:ss tt}") %></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>    
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
