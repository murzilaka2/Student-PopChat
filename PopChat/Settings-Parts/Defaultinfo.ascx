<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Defaultinfo.ascx.cs" Inherits="PopChat.Settings_Parts.Defaultinfo" %>
<div class="col-xl-8 col-lg-8 order-2 order-lg-1">
    <div class="side-description-form">
        <div class="job-description">
            <p><a href="../lobby.aspx">Лобби</a> - <a href="../settings.aspx">Настройки</a> - Общая информация</p>
            <div class="box-details">
                <h5>Общая информация</h5>
                <br />
                <asp:Label runat="server" ID="Error_Label"></asp:Label>
                <p>Расскажите немного о себе.</p><br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Name" CssClass="floating-label-field floating-label-field--s3" Enabled="false" BackColor="#f1f1f1"></asp:TextBox>
                    <asp:Label runat="server" ID="NameLabel" AssociatedControlID="Name" CssClass="floating-label">Ваше имя</asp:Label>
                </div><br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Email" CssClass="floating-label-field floating-label-field--s3" Enabled="false" BackColor="#f1f1f1"></asp:TextBox>
                    <asp:Label runat="server" ID="EmailLabel" AssociatedControlID="Email" CssClass="floating-label">Ваш Email</asp:Label>
                </div><br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Avatar" CssClass="floating-label-field floating-label-field--s3"></asp:TextBox>
                    <asp:Label runat="server" ID="AvatarLabel" AssociatedControlID="Avatar" CssClass="floating-label">Аватар (Ссылка)</asp:Label>
                </div><br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Country" CssClass="floating-label-field floating-label-field--s3"></asp:TextBox>
                    <asp:Label runat="server" ID="CountryLabel" AssociatedControlID="Country" CssClass="floating-label">Страна / Город</asp:Label>
                </div><br />
                <div class="floating-label-wrap">
                    
                    <asp:ListBox runat="server" ID="Age" CssClass="floating-label-field floating-label-field--s3"></asp:ListBox>
                    <asp:Label runat="server" ID="AgeLabel" AssociatedControlID="Age" CssClass="floating-label">Ваш возраст</asp:Label>
                </div><br />
                 <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Interes" CssClass="floating-label-field floating-label-field--s3" Columns="5" Height="200px" TextMode="MultiLine"></asp:TextBox>
                    <asp:Label runat="server" ID="InteresLabel" AssociatedControlID="Interes" CssClass="floating-label">Ваши интересы</asp:Label>
                </div><br />
                <div class="form-buttons bc">
                    <asp:Button runat="server" ID="Sumbit" Text="Сохранить" OnClick="Sumbit_Click" />
                </div>
            </div>
        </div>
    </div>
</div>