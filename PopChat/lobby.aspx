<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lobby.aspx.cs" Inherits="PopChat.lobby" %>

<%@ Register TagPrefix="Footer" TagName="Place" Src="~/Parts/Footer.ascx" %>
<%@ Register TagPrefix="Header" TagName="Place" Src="~/Parts/Header.ascx" %>
<%@ Register TagPrefix="NavBar" TagName="Place" Src="~/Parts/NavBar.ascx" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Лобби</title>
    <meta name="description" content="" />
    <Header:Place runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <NavBar:Place runat="server" />
        <section id="faqs-pp" class="faqs-pp">
            <div class="container">
                <div class="row mbminus">
                    <!-- Зона меню -->
                    <div class="col-xl-3 col-lg-4">
                        <aside class="aside-bar">
                            <div class="faq-control ardc-p">
                                <ul class="list-unstyled">
                                    <li><a href="lobby.aspx"><i class='bx bx-globe'></i>Общий чат</a></li>
                                    <li><a><i class="bx bx-lock"></i>Личные чаты</a></li>
                                    <li><a href="../settings.aspx"><i class="bx bx-money"></i>Настройки</a></li>
                                </ul>
                            </div>
                        </aside>
                    </div>
                    <!-- Зона меню конец -->
                    <!-- Зона окна чата -->
                    <div class="col-xl-9 col-lg-8">
                        <div class="faq-question">
                            <div id="faq-general" class="accordion-box">
                                <h4><span><i class='bx bx-globe'></i>Общий чат</span></h4>
                                <div id="accordion" class="accordion-faq">
                                    <div class="card ardc">
                                        <div class="collapse show scroll" id="wrapp" style="height: 1000px">
                                            <asp:PlaceHolder runat="server" ID="Messages"></asp:PlaceHolder>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Зона окна чата конец -->
                </div>
                <div class="box-application">
                    <CKEditor:CKEditorControl ID="CKEditor1" BasePath="/ckeditor/" runat="server"></CKEditor:CKEditorControl><br />
                    <div class="form-buttons bc">
                        <asp:Button runat="server" ID="SendMessage" Text="Отправить" OnClick="SendMessage_Click" />
                    </div>
                </div>
            </div>
        </section>
        <script>var wrapp = document.getElementById('wrapp');
            wrapp.scrollTop = wrapp.scrollHeight;</script>
        <Footer:Place runat="server" />
    </form>
</body>
</html>
