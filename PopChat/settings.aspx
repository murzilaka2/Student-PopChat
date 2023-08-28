<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="PopChat.settings"%>

<%@ Register TagPrefix="Footer" TagName="Place" Src="~/Parts/Footer.ascx" %>
<%@ Register TagPrefix="Header" TagName="Place" Src="~/Parts/Header.ascx" %>
<%@ Register TagPrefix="NavBar" TagName="Place" Src="~/Parts/NavBar.ascx" %>
<%@ Register TagPrefix="ChangePassword" TagName="Place" Src="~/Settings-Parts/ChangePassword.ascx" %>
<%@ Register TagPrefix="ChangeEmail" TagName="Place" Src="~/Settings-Parts/ChangeEmail.ascx"%>
<%@ Register TagPrefix="DefaultInfo" TagName="Place" Src="~/Settings-Parts/Defaultinfo.ascx"%>
<%@ Register TagPrefix="MessageSettings" TagName="Place" Src="~/Settings-Parts/MessageSettings.ascx"%>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Настройки</title>
    <meta name="description" content="" />
    <Header:Place runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <NavBar:Place runat="server" />
        <section id="single-job" class="single-job">
            <div class="container">
                <div class="row">
                    <ChangePassword:Place runat="server" ID="ChangePasswordPlace" Visible="false"/>
                    <ChangeEmail:Place runat="server" ID="ChangeEmailPlace" Visible="false"/>
                    <MessageSettings:Place runat="server" ID="ChangeMessageSettings" Visible="false"/>
                    <DefaultInfo:Place runat="server" ID="DefaultInfoPlace" Visible="false"/>
                    <div class="col-xl-4 col-lg-4 order-1 order-lg-2">
                        <aside class="aside-bar">
                            <div class="job-sidebar">
                                <div class="job-info">                                 
                                    <h6>Список</h6>
                                    <ul class="list-unstyled">
                                        <li>
                                            <asp:LinkButton runat="server" ID="ChangePassword" OnClick="ChangePassword_Click">Изменить пароль</asp:LinkButton></li>
                                        <li>
                                            <asp:LinkButton runat="server" ID="ChangeEmail" OnClick="ChangeEmail_Click">Изменить E-mail</asp:LinkButton></li>
                                        <li>
                                            <asp:LinkButton runat="server" ID="GeneralInfo" OnClick="GeneralInfo_Click">Общая информация</asp:LinkButton></li>
                                        <li>
                                            <asp:LinkButton runat="server" ID="MessageSettings" OnClick="MessageSettings_Click">Настройки чата</asp:LinkButton></li>
                                        <li>
                                            <asp:LinkButton runat="server" ID="CleanHistory">Очистить историю</asp:LinkButton></li>
                                    </ul>
                                </div>
                            </div>
                        </aside>
                    </div>
                </div>
            </div>
        </section>
        <Footer:Place runat="server" />
    </form>
</body>
</html>
