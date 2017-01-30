<%@ Page Title="" Language="C#" MasterPageFile="~/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="ProductReport.aspx.cs" Inherits="Kojin.Customer.ProductReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
            <div class="infobox infobox-red">
                <div class="infobox-icon">
                    <i class="ace-icon fa fa-flask"></i>
                </div>

                <div class="infobox-data">
                    <span class="infobox-data-number">
                        <asp:LinkButton ID="lnkId" runat="server" Text='SUGAR' CommandName="LoadCell1"></asp:LinkButton></span>
                    <div class="infobox-content"><%#Eval("LoadCell1") %>Kg</div>

                </div>
                <div class="progress pos-rel" data-percent="<%#Eval("Per1") %>">
                    <div class="progress-bar" style="width: <%#Eval("Per1") %>;"></div>
                </div>
            </div>

            <div class="infobox infobox-red">
                <div class="infobox-icon">
                    <i class="ace-icon fa fa-flask"></i>
                </div>

                <div class="infobox-data">
                    <span class="infobox-data-number">
                        <asp:LinkButton ID="LinkButton1" runat="server" Text='PULSE' CommandName="LoadCell2"></asp:LinkButton></span>
                    <div class="infobox-content"><%#Eval("LoadCell2") %>Kg</div>
                </div>
                <div class="progress pos-rel" data-percent="<%#Eval("Per2") %>">
                    <div class="progress-bar" style="width: <%#Eval("Per2") %>;"></div>
                </div>


            </div>
            <div class="infobox infobox-red">
                <div class="infobox-icon">
                    <i class="ace-icon fa fa-flask"></i>
                </div>

                <div class="infobox-data">
                    <span class="infobox-data-number">
                        <asp:LinkButton ID="LinkButton2" runat="server" Text='AATA' CommandName="LoadCell3"></asp:LinkButton></span>
                    <div class="infobox-content"><%#Eval("LoadCell3") %>Kg</div>
                </div>
                <div class="progress pos-rel" data-percent="<%#Eval("Per3") %>">
                    <div class="progress-bar" style="width: <%#Eval("Per3") %>;"></div>
                </div>
            </div>
            <div class="infobox infobox-red">
                <div class="infobox-icon">
                    <i class="ace-icon fa fa-flask"></i>
                </div>

                <div class="infobox-data">
                    <span class="infobox-data-number">
                        <asp:LinkButton ID="LinkButton3" runat="server" Text='RAJMA' CommandName="LoadCell4"></asp:LinkButton></span>
                    <div class="infobox-content"><%#Eval("LoadCell4") %>Kg</div>
                </div>
                <div class="progress pos-rel" data-percent="<%#Eval("Per4") %>">
                    <div class="progress-bar" style="width: <%#Eval("Per4") %>;"></div>
                </div>
            </div>
            <div class="infobox infobox-red">
                <div class="infobox-icon">
                    <i class="ace-icon fa fa-flask"></i>
                </div>

                <div class="infobox-data">
                    <span class="infobox-data-number">
                        <asp:LinkButton ID="LinkButton4" runat="server" Text='RICE' CommandName="LoadCell2"></asp:LinkButton></span>
                    <div class="infobox-content"><%#Eval("LoadCell5") %>Kg</div>
                </div>
                <div class="progress pos-rel" data-percent="<%#Eval("Per5") %>">
                    <div class="progress-bar" style="width: <%#Eval("Per5") %>;"></div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <br />
    <br />
    <br />
    <br />
    <div class="row">

        <div class="col-sm-3"></div>
        <div class="col-sm-6">
            <div class="widget-box">
                <div class="widget-header">
                    <h4 class="smaller">
                        <asp:Label ID="lblProduct" runat="server"></asp:Label></h4>
                </div>

                <div class="widget-body">
                    <div class="widget-main">
                        <asp:Repeater ID="Repeater2" runat="server">
                            <HeaderTemplate>
                                <table id="simple-table" class="table  table-bordered table-hover">
                                    <thead>
                                        <tr>
                                            <th class="detail-col">Product</th>
                                            <th>Temprature</th>
                                            <th>TrDateTime</th>
                                        </tr>
                                    </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                    <tr>
                                        <td><%#Eval("Product") %></td>
                                        <td><%#Eval("Temprature") %></td>
                                        <td><%#Eval("TrDateTime") %></td>
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
        </div>
        <!-- /.col -->
    </div>
    <div class="col-sm-3"></div>
</asp:Content>
