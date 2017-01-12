<%@ Page Title="" Language="C#" MasterPageFile="~/KitchenAdmin/KitchenMain.Master" AutoEventWireup="true" CodeBehind="TrayVsCell.aspx.cs" Inherits="Kojin.KitchenAdmin.TrayVsCell" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h1>Tray Vs Cell Id Mapping
                </h1>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Kitchen Id</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpKitchenId" runat="server" AutoPostBack="true" class="chosen-select form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="drpKitchenId"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Tray ID</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtTrayID" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTrayID"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">No.Of Cells</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpNoOfCell" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                <asp:ListItem Text="15" Value="15"></asp:ListItem>

                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="drpNoOfCell"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Cell 1</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtCell1" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCell1"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Cell 2</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtCell2" runat="server" class="form-control"></asp:TextBox>
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
                    <label class="col-sm-3 control-label">Cell 3</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtCell3" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                        <%--    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCell3"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>
                  <div class="form-group">
                    <label class="col-sm-3 control-label">Cell 4</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtCell4" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                        <%--    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCell3"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Cell 5</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtCell5" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtCell5"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnCreate"></asp:RequiredFieldValidator>--%>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Temp Cell</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:TextBox ID="txtTempCell" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                          <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtTempCell"
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
                                    <th>Kitchen Id</th>
                                    <th>Tray ID</th>
                                    <th>NoOfCell</th>
                                    <th>Cell1 Id</th>
                                    <th>Cell2 Id</th>
                                    <th>Cell3 Id</th>
                                    <th>Cell4 Id</th>
                                    <th>Cell5 Id</th>
                                    <th>Temp Id</th>
                                    <th>Status</th>
                                    <th>Date</th>
                                    <th>Time</th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td><%#Eval("Kit_id") %></td>
                                <td>
                                    <asp:LinkButton ID="lnkTray_Id" runat="server" Text='<%#Eval("Tray_Id") %>'></asp:LinkButton>
                                </td>
                                <td><%#Eval("No_Of_Cell") %></td>
                                <td><%#Eval("D_Cell_1") %></td>
                                <td><%#Eval("D_Cell_2") %></td>
                                <td><%#Eval("D_Cell_3") %></td>
                                <td><%#Eval("D_Cell_4") %></td>
                                <td><%#Eval("D_Cell_5") %></td>
                                <td><%#Eval("D_Temp_1") %></td>
                                <td><%#Eval("D_Status") %></td>
                                <td><%#Eval("D_DateTime","{0:dd/MM/yyyy}") %></td>
                                 <td><%#Eval("D_DateTime","{0:hh:ss tt}") %></td>
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
