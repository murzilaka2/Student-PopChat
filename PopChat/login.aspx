<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PopChat.login" %>

<%@ Register TagPrefix="Footer" TagName="Place" Src="~/Parts/Footer.ascx" %>
<%@ Register TagPrefix="Header" TagName="Place" Src="~/Parts/Header.ascx" %>
<%@ Register TagPrefix="NavBar" TagName="Place" Src="~/Parts/NavBar.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Авторизация</title>
    <meta name="description" content="" />
    <Header:Place runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <NavBar:Place runat="server" />
        <section id="signup" class="signup signin parallax">
            <div class="overlay"></div>
            <div class="container">
                <div class="row row-aligns">
                    <div class="col-xl-7 col-md-6">
                        <div class="txt-signup">
                            <h2>See What's happening in the world right now</h2>
                            <ul class="list-unstyled">
                                <li>
                                    <i class='bx bx-check-double'></i>
                                    Follow your interests.
                                </li>
                                <li>
                                    <i class='bx bx-check-double'></i>
                                    Hear what people are talking about.
                                </li>
                                <li>
                                    <i class='bx bx-check-double'></i>
                                    Join the converstion.
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-xl-5 col-md-6">
                        <div class="signup-form">
                            <h3 style="text-align: center">Авторизация</h3>
                            <br />
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <div class="row">
                                        <div class="col-xl-12">
                                            <div class="form-group">
                                                <div class="floating-label-wrap">
                                                    <asp:TextBox runat="server" ID="Login" CssClass="floating-label-field floating-label-field--s3" required="true"></asp:TextBox>
                                                    <asp:Label runat="server" ID="LabelLogin" AssociatedControlID="Login" CssClass="floating-label">Логин</asp:Label>
                                                </div>
                                                <!-- .floating-label-wrap -->
                                            </div>
                                        </div>
                                        <div class="col-xl-12">
                                            <div class="form-group">
                                                <div class="floating-label-wrap">
                                                    <asp:TextBox runat="server" ID="Password" CssClass="floating-label-field floating-label-field--s3" TextMode="Password" required="true"></asp:TextBox>
                                                    <asp:Label runat="server" ID="LabelPassword" AssociatedControlID="Password" CssClass="floating-label">Пароль</asp:Label>
                                                </div>
                                                <!-- .floating-label-wrap -->
                                            </div>
                                        </div>

                                        <div class="col-xl-12">
                                            <div class="form-buttons bc">
                                                <asp:Button runat="server" ID="Auth_Button" Text="Войти" OnClick="Auth_Button_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <div class="account-link">
                                <br />
                                <a href="#">Забыли Пароль?</a><br />
                                <a href="../registration.aspx">Регистрация</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Background Shape-->
                <div class="background-shapes">
                    <div class="box1"></div>
                    <div class="box2"></div>
                    <div class="box3"></div>
                    <div class="dot1"></div>
                    <div class="dot2"></div>
                    <div class="heart1"><i class='bx bx-message-square'></i></div>
                    <div class="heart2"><i class='bx bx-heart'></i></div>
                    <div class="circle2"></div>
                </div>
            </div>
        </section>
        <Footer:Place runat="server" />
    </form>
</body>
</html>
