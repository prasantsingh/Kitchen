<%@ Page Title="" Language="C#" MasterPageFile="~/KitchenAdmin/KitchenMain.Master" AutoEventWireup="true" CodeBehind="CellVsItem.aspx.cs" Inherits="Kojin.KitchenAdmin.CellVsItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h1>Cell Vs Item Mapping
                </h1>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Customer Id</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCustomerId" runat="server" AutoPostBack="true" class="chosen-select form-control" OnSelectedIndexChanged="drpCustomerId_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="drpCustomerId"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Kitchen Id</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtkitchenId" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpKitchen" runat="server" AutoPostBack="true" class="chosen-select form-control" OnSelectedIndexChanged="drpKitchen_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtkitchenId"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Tray Id</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpTrayId" runat="server" AutoPostBack="true" class="chosen-select form-control" OnSelectedIndexChanged="drpTrayId_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="drpTrayId"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Cell Id</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCellId" runat="server" AutoPostBack="true" class="chosen-select form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="drpCellId"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Item Category</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpItemCategory" runat="server" AutoPostBack="true" class="chosen-select form-control" OnSelectedIndexChanged="drpItemCategory_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="drpItemCategory"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Item Code</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpItemCode" runat="server" AutoPostBack="true" class="chosen-select form-control" OnSelectedIndexChanged="drpItemCode_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="drpItemCode"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Item Details</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtItemDetails" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Unit of Measure</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtUnitofMeasure" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Minimum Qty</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtMinimumQty" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Max Qty</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtMaxQty" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Re- order Qty</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtReorderQty" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Default SMB Vendor</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpDefaultSMBVendor" runat="server" AutoPostBack="true" class="chosen-select form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Max Valu for SMB Vendor</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtMaxValuforSMBVendor" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Default Big Retailor</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpDefaultBigRetailor" runat="server" AutoPostBack="true" class="chosen-select form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Min Value for Big Retailor</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtDefaultBigRetailor" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCell2"
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
                        <asp:Button ID="btnCreate" runat="server" class="btn btn-success" Text="Create" ValidationGroup="btnCreate" OnClick="btnCreate_Click"></asp:Button>
                        &nbsp; &nbsp; &nbsp;
				        <asp:Button ID="btnReset" runat="server" class="btn btn-info" Text="Reset" OnClick="btnReset_Click"></asp:Button>
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
                        <table class="table table-striped table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>Cust Id</th>
                                    <th>Kitchen Id</th>
                                    <th>Tray Id</th>
                                    <th>Cell Id</th>
                                    <th>Item Category Code</th>
                                    <th>Item Code</th>
                                    <th>Item</th>
                                    <th>UOM</th>
                                    <th>Min Order Qty</th>
                                    <th>Max Order Qty</th>
                                    <th>Re Order Qty</th>
                                    <th>Default SMB</th>
                                    <th>Max SMB Value</th>
                                    <th>Default B Retailor</th>
                                    <th>Min B Value</th>
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
                                    <asp:Literal ID="litID" runat="server" Text='<%# Eval("Sno")%>' Visible="false">
                                    </asp:Literal>
                                    <asp:LinkButton ID="lnkCust_Id" runat="server" Text='<%#Eval("Cust_Id") %>'></asp:LinkButton>
                                </td>
                                <td><%#Eval("Kit_Id") %></td>
                                <td><%#Eval("Tray_Id") %></td>
                                <td><%#Eval("Cell_Id") %></td>
                                <td><%#Eval("Item_Cate") %></td>
                                <td><%#Eval("Item_Code") %></td>
                                <td><%#Eval("Item_Details") %></td>
                                <td><%#Eval("Unit_Of_Measure") %></td>
                                <td><%#Eval("Min_Qty") %></td>
                                <td><%#Eval("Max_Qty") %></td>
                                <td><%#Eval("Re_Order_Qty") %></td>
                                <td><%#Eval("DSMB_Vendor") %></td>
                                <td><%#Eval("Max_V_SMB_Vendor") %></td>
                                <td><%#Eval("D_Big_Ret") %></td>
                                <td><%#Eval("Min_V_Big_Ret") %></td>
                                <td><%#Eval("CI_Status") %></td>
                                <td><%#Eval("CI_DateTime","{0:dd/MM/yyyy}") %></td>
                                <td><%#Eval("CI_DateTime" ,"{0:hh:mm tt}") %></td>
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
