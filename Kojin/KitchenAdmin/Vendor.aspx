<%@ Page Title="" Language="C#" MasterPageFile="~/KitchenAdmin/KitchenMain.Master" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="Kojin.KitchenAdmin.Vendor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h1>Vendor Creation
                </h1>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Vendor Code</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtVendorCode" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtVendorCode"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Vendor Name</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtVendoreName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtVendoreName"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Address</label>
                    <div class="col-sm-5">
                        <div class="form-group">
                            <asp:TextBox ID="txtAddress1" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress1"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label"></label>
                    <div class="col-sm-5">
                        <div class="form-group">
                            <asp:TextBox ID="txtAddress2" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddress2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label"></label>
                    <div class="col-sm-5">
                        <div class="form-group">
                            <asp:TextBox ID="txtAddress3" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                        <%--    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtAddress3"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">City</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCity" runat="server" class="form-control" AutoPostBack="true"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="drpCity"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">State</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpState" runat="server" class="form-control" AutoPostBack="true"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="drpState"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Country</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCountry" runat="server" class="form-control" AutoPostBack="true"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="drpCountry"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Pincode</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtPinCode" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtPinCode"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Phone</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtPhone" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhone"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Email-Id</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtEmailId" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmailId"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreation"></asp:RequiredFieldValidator>
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
                        <asp:Button ID="btnCreation" runat="server" class="btn btn-success" Text="Create" ValidationGroup="btnCreation" OnClick="btnCreation_Click"></asp:Button>
                        &nbsp; &nbsp; &nbsp;
				        <asp:Button ID="btnReset" runat="server" class="btn btn-info" Text="Reset" OnClick="btnReset_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnCreation" />
        </Triggers>
    </asp:UpdatePanel>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive">
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>Code</th>
                                    <th>Vendor Name</th>
                                    <th>Address1</th>
                                    <th>Address2</th>
                                    <th>Address3</th>
                                    <th>City</th>
                                    <th>State</th>
                                    <th>Country</th>
                                    <th>PinCode</th>
                                    <th>Phone</th>
                                    <th>Email-Id</th>
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
                                    <asp:LinkButton ID="lnkVen_Code" runat="server" Text='<%#Eval("Ven_Code") %>'></asp:LinkButton>
                                </td>
                                <td><%#Eval("Ven_Name") %></td>
                                <td><%#Eval("Ven_Address1") %></td>
                                <td><%#Eval("Ven_Address2") %></td>
                                <td><%#Eval("Ven_Address3") %></td>
                                <td><%#Eval("Ven_City") %></td>
                                <td><%#Eval("Ven_State") %></td>
                                <td><%#Eval("Ven_Country") %></td>
                                <td><%#Eval("Ven_Pincode") %></td>
                                <td><%#Eval("Ven_Phone") %></td>
                                <td><%#Eval("Ven_Email") %></td>
                                <td><%#Eval("Ven_Status") %></td>
                                <td><%#Eval("Ven_DateTime","{0:dd/MM/yyyy}") %></td>
                                <td><%#Eval("Ven_DateTime" ,"{0:hh:mm tt}") %></td>
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
