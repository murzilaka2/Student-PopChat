<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.ascx.cs" Inherits="PopChat.Setting_Parts.ChangePassword" %>
<div class="col-xl-8 col-lg-8 order-2 order-lg-1">
    <div class="side-description-form">
        <div class="job-description">
            <p><a href="../lobby.aspx">Лобби</a> - <a href="../settings.aspx">Настройки</a> - Изменить пароль</p>
            <div class="box-details">
                <h5>Изменить пароль</h5>
                <br />
                <asp:Label runat="server" ID="Error_Label"></asp:Label><br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="PasswordOld" CssClass="floating-label-field floating-label-field--s3" required="true" TextMode="Password"></asp:TextBox>
                    <asp:Label runat="server" ID="PasswordOldLabel" AssociatedControlID="PasswordOld" CssClass="floating-label">Введите старый пароль</asp:Label>
                </div>
                <br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Password" CssClass="floating-label-field floating-label-field--s3" required="true" TextMode="Password"></asp:TextBox>
                    <asp:Label runat="server" ID="LabelPassword" AssociatedControlID="Password" CssClass="floating-label">Введите новый пароль</asp:Label>
                </div>
                <br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="PasswordAgain" CssClass="floating-label-field floating-label-field--s3" required="true" TextMode="Password"></asp:TextBox>
                    <asp:Label runat="server" ID="LabelPasswordAgain" AssociatedControlID="PasswordAgain" CssClass="floating-label">Потвердите новый пароль</asp:Label>
                </div>
                <br />
                <div class="form-buttons bc">
                    <asp:Button runat="server" ID="Sumbit" Text="Сохранить" OnClick="Sumbit_Click" />
                </div>
            </div>
        </div>
    </div>
</div>
