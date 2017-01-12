<%@ Page Title="" Language="C#" MasterPageFile="~/KitchenAdmin/KitchenMain.Master" AutoEventWireup="true" CodeBehind="KitchenId.aspx.cs" Inherits="Kojin.KitchenAdmin.KitchenId" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h1>Kitchen
                </h1>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Customer Id</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:TextBox ID="txtCustomerId" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <asp:DropDownList ID="drpCustomer" runat="server" AutoPostBack="true" class="chosen-select form-control" OnSelectedIndexChanged="drpCustomer_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerId"
                                Display="Dynamic" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Kitchen Location 1</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpKitchenLoaction1" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Metro" Value="Metro"></asp:ListItem>
                                <asp:ListItem Text="B Class City" Value="B Class City"></asp:ListItem>
                                <asp:ListItem Text="C Class City" Value="C Class City"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="drpKitchenLoaction1"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Kitchen Location 2</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpKitchenLoaction2" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Flate" Value="Flate"></asp:ListItem>
                                <asp:ListItem Text="Kothi" Value="Kothi"></asp:ListItem>
                                <asp:ListItem Text="Normal Home" Value="Normal Home"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="drpKitchenLoaction2"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Kitchen Type</label>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:DropDownList ID="drpKitchenType" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Modular" Value="Modular"></asp:ListItem>
                                <asp:ListItem Text="Plane" Value="Plane"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="drpKitchenType"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label"><b>Vassel Requirement (Approx.)</b></label>
                    <div class="col-sm-3">
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Small (upto 500 gm)</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpSmall" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                <asp:ListItem Text="200" Value="200"></asp:ListItem>
                                <asp:ListItem Text="300" Value="300"></asp:ListItem>
                                <asp:ListItem Text="400" Value="400"></asp:ListItem>
                                <asp:ListItem Text="500" Value="500"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="drpSmall"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Meduim (1 Kg to 2 Kg)</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpMeduim" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="drpMeduim"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Large (2 kg to 5 kg)</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpLarge" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="drpLarge"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Extra Large (10 kg to 20 kg)</label>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <asp:DropDownList ID="drpExtraLarge" runat="server" AutoPostBack="true" class="chosen-select form-control">
                                <asp:ListItem Text="-Select-" Value="0"></asp:ListItem>
                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                <asp:ListItem Text="20" Value="20"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="drpExtraLarge"
                                InitialValue="0" ErrorMessage="Required" ForeColor="#CC0000" SetFocusOnError="True"
                                ValidationGroup="btnSubmit"></asp:RequiredFieldValidator>
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
                        <asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" ValidationGroup="btnSubmit" OnClick="btnSubmit_Click"></asp:Button>
                        &nbsp; &nbsp; &nbsp;
				        <asp:Button ID="btnReset" runat="server" class="btn btn-info" Text="Reset" OnClick="btnReset_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSubmit" />
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
                                    <th>Cust Id</th>
                                    <th>Kitchen Id</th>
                                    <th>K Location1</th>
                                    <th>K Location2</th>
                                    <th>K Type</th>
                                    <th>App Small V</th>
                                    <th>Act Small V</th>
                                    <th>App Medium V</th>
                                    <th>Act Medium V</th>
                                    <th>App Large V</th>
                                    <th>Act Large V</th>
                                    <th>App Extra L V</th>
                                    <th>Act Extra L V</th>
                                    <th>Status</th>
                                    <th>Date</th>
                                    <th>Time</th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td><%#Eval("Cust_id") %></td>
                                <td>
                                    <asp:LinkButton ID="lnkKit_id" runat="server" Text='<%#Eval("Kit_id") %>'></asp:LinkButton>
                                </td>

                                <td><%#Eval("Kit_Loc1") %></td>
                                <td><%#Eval("Kit_Loc2") %></td>
                                <td><%#Eval("Kit_Type") %></td>
                                <td><%#Eval("App_Small_V") %></td>
                                <td><%#Eval("Act_Small_V") %></td>
                                <td><%#Eval("App_Meduim_V") %></td>
                                <td><%#Eval("Act_Meduim_V") %></td>
                                <td><%#Eval("App_Larger_V") %></td>
                                <td><%#Eval("Act_Larger_V") %></td>
                                <td><%#Eval("App_Extra_LV") %></td>
                                <td><%#Eval("Act_Extra_LV") %></td>
                                <td><%#Eval("Kit_Status") %></td>
                                <td><%#Eval("Kit_DateTime","{0:dd/MM/yyyy}") %></td>
                                <td><%#Eval("Kit_DateTime","{0:hh:mm tt}") %></td>
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
