<%@ Page Title="" Language="C#" MasterPageFile="~/KitchenAdmin/KitchenMain.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Kojin.KitchenAdmin.Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h1>Customer Id
                </h1>
            </div>

            <div class="form-horizontal">

                <div class="form-group">
                    <label class="col-sm-2 control-label">Customer Name</label>
                    <div class="col-sm-10">
                        <div class="form-inline">
                            <div class="form-group">
                                <asp:TextBox ID="txtFName" runat="server" placeholder="First Name" class="form-control"></asp:TextBox>&nbsp;
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFName"
                             Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                             ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtMName" runat="server" placeholder="Middle Name" class="form-control"></asp:TextBox>&nbsp;                       
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtLName" runat="server" placeholder="Last Name" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtLName"
                                    Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                    ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Gender</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpGender" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="drpGender"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-2 control-label">Address</label>
                    <div class="col-sm-7">
                        <div class="form-group">
                            <asp:TextBox ID="txtAddress1" runat="server" class="form-control" placeholder="Address1"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAddress1"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-2"></div>
                    <div class="col-sm-7">
                        <div class="form-group">
                            <asp:TextBox ID="txtAddress2" runat="server" class="form-control" placeholder="Address2"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtAddress2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-2"></div>
                    <div class="col-sm-7">
                        <div class="form-group">
                            <asp:TextBox ID="txtAddress3" runat="server" class="form-control" placeholder="Address3"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtAddress3"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-2 control-label">City</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCity" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="drpCity"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-2 control-label">State</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpState" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="drpState"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-2 control-label">Country</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCountry" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="drpCountry"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Pincode</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtPinCode" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtPinCode"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">UserType</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpUserType" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Soft User" Value="Soft User"></asp:ListItem>
                                <asp:ListItem Text="Hard User" Value="Hard User"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="drpUserType"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-3"></div>
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" CssClass="col-sm-6 control-label"></asp:Label>
                    <div class="col-sm-3"></div>
                </div>
                <div class="clearfix form-actions">
                    <div class="col-md-offset-3 col-md-9">
                        <asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" ValidationGroup="btnSubmit" OnClick="btnSubmit_Click"></asp:Button>
                        &nbsp; &nbsp; &nbsp;
				        <asp:Button ID="btnReset" runat="server" class="btn btn-info" Text="Reset" OnClick="btnReset_Click"></asp:Button>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="table-responsive">
                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                            <HeaderTemplate>
                                <table class="table table-striped table-bordered table-hover">
                                    <thead>
                                        <tr>
                                            <th>Cust Id</th>
                                            <th>Gender</th>
                                            <th>Name1</th>
                                            <th>Name2</th>
                                            <th>Name3</th>
                                            <th>Address1</th>
                                            <th>Address2</th>
                                            <th>Address3</th>
                                            <th>City</th>
                                            <th>State</th>
                                            <th>Country</th>
                                            <th>PinCode</th>
                                            <th>UserType</th>
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
                                            <asp:LinkButton ID="lnkCust_Id" runat="server" Text='<%#Eval("Cust_id") %>'></asp:LinkButton>
                                        </td>
                                        <td><%#Eval("Gender") %></td>
                                        <td><%#Eval("Name1") %></td>
                                        <td><%#Eval("Name2") %></td>
                                        <td><%#Eval("Name3") %></td>
                                        <td><%#Eval("Address1") %></td>
                                        <td><%#Eval("Address2") %></td>
                                        <td><%#Eval("Address3") %></td>
                                        <td><%#Eval("City") %></td>
                                        <td><%#Eval("State") %></td>
                                        <td><%#Eval("Country") %></td>
                                        <td><%#Eval("PinCode") %></td>
                                        <td><%#Eval("UserType") %></td>
                                        <td><%#Eval("Status") %></td>
                                        <td><%#Eval("DateTime","{0:dd/MM/yyyy}") %></td>
                                        <td><%#Eval("DateTime" ,"{0:hh:mm tt}") %></td>
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
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSubmit" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
