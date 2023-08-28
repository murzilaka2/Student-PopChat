<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="PopChat.profile" %>

<%@ Register TagPrefix="Footer" TagName="Place" Src="~/Parts/Footer.ascx" %>
<%@ Register TagPrefix="Header" TagName="Place" Src="~/Parts/Header.ascx" %>
<%@ Register TagPrefix="NavBar" TagName="Place" Src="~/Parts/NavBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Профайл</title>
    <meta name="description" content="" />
    <Header:Place runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <NavBar:Place runat="server" />

        <section id="services" class="services inner-services">
        <div class="container">
            <div class="services-box">
                <div class="section-title">
                                    <p><a href="../lobby.aspx">Лобби</a> - Профайл</p><br />
                    <h3 runat="server" id="UserLogin">Нет такого персонажа :(</h3>
                </div>
                <div class="services-inner">
                    <div class="row row-aligns">
                        <div class="col-lg-4 col-md-12">
                            <div class="side-service left">
                                <div class="service-item">
                                    <div class="plus-icon">
                                        <i class='bx bx-code-block'></i>
                                    </div>
                                    <div class="service-txt">
                                        <h5>E-Mail адресс</h5>
                                        <p><asp:Label runat="server" ID="Email"></asp:Label></p>
                                    </div>
                                </div>
                                <div class="service-item">
                                    <div class="plus-icon">
                                        <i class='bx bx-donate-heart'></i>
                                    </div>
                                    <div class="service-txt">
                                        <h5>Место проживания</h5>
                                        <p><asp:Label runat="server" ID="Country"></asp:Label></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 d-none d-lg-block">
                            <div class="service-box center">
                                <asp:Image runat="server" ID="UserImage"/>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-12">
                            <div class="side-service right">
                                <div class="service-item">
                                    <div class="plus-icon">
                                        <i class='bx bx-pencil'></i>
                                    </div>
                                    <div class="service-txt">
                                        <h5>Всего сообщений</h5>
                                        <p><asp:Label runat="server" ID="MessageCount"></asp:Label></p>
                                    </div>
                                </div>
                                <div class="service-item">
                                    <div class="plus-icon">
                                        <i class='bx bx-help-circle'></i>
                                    </div>
                                    <div class="service-txt">
                                        <h5>Последний раз в сети</h5>
                                        <p><asp:Label runat="server" ID="Online"></asp:Label></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="second-post">
                <div class="row row-aligns">
                    <div class="col-md-6 order-2 order-md-1">
                        <div class="post-txt">
                            <span class="top-ico co-purple"><i class='bx bx-like'></i></span>
                            <span class="label label-purple">Яркая особенность</span>
                            <h4 class="co-purple">Интересы</h4>
                            <p class="upb"><asp:Label runat="server" ID="Intereses"></asp:Label></p>
                            <span class="dots">
                                <i class="dot dot1"></i>
                                <i class="dot dot2"></i>
                                <i class="dot dot3"></i>
                            </span>
                        </div>
                    </div>
                    <div class="col-md-6 order-1 order-md-2">
                        <div class="post-img">
                            <img class="img-fluid" src="img/undraw_unDraw_1000_gty8.svg" alt="User Profile"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

        <Footer:Place runat="server" />
    </form>
</body>
</html>
