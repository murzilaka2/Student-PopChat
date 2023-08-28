<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavBar.ascx.cs" Inherits="PopChat.Parts.NavBar" %>

<header id="header" class="header">
    <!-- Start Navbar -->
    <nav class="navbar navbar-expand-lg navbar-light fixed-top">
        <div class="container">
            <a class="navbar-brand" href="../index.aspx">
                <!-- Logo -->
                <img src="img/main-logo.png" alt="Pop Chat" title="Pop Chat">
            </a><h4 class="co-purple">&nbsp;Pop Chat</h4>
            <button class="navbar-toggler" type="button" data-toggle="collapse"
                data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false"
                aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse justify-content-md-center" id="navbarSupportedContent">

                <ul class="navbar-nav nav-buttons ml-auto list-unstyled">
                   <%-- <li class="nav-lang nav-item dropdown js-dropdown-links">
                        <a class="nav-link dropdown-toggle" href="#" role="button"
                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">RU
                        </a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item dropdown-link" href="#">
                                <div class="link-ico">
                                    <span class="flag-icon flag-icon-us"></span>
                                    <span class="title">English</span>
                                </div>
                            </a>
                            <a class="dropdown-item dropdown-link" href="#">
                                <div class="link-ico">
                                    <span class="flag-icon flag-icon-ru"></span>
                                    <span class="title">Русский</span>
                                </div>
                            </a>
                            <span class="bg-gray hover-state js-hover-state"></span>
                        </div>
                    </li>--%>
                    <asp:PlaceHolder runat="server" ID="UserPlace"></asp:PlaceHolder>
                    <li class="nav-item nav-trial navbar-user">
                        <asp:Image runat="server" ID="UserImage" Visible="false" Width="30px" AlternateText="User Image" ImageUrl="~/img/lobby/defaultuser.png" />
                    </li>
                    <li class="nav-item nav-trial">
                        <asp:LinkButton runat="server" ID="UserInfo" CssClass="nav-link" PostBackUrl="../login.aspx" >Авторизация</asp:LinkButton>
                    </li>
                    <li class="nav-item nav-trial" runat="server" id="RegistrationButton">
                        <a class="nav-link" href="../registration.aspx">Регистрация</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- End Navbar -->
</header>
