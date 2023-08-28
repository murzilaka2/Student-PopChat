<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChangeEmail.ascx.cs" Inherits="PopChat.Setting_Parts.ChangeEmail" %>
<div class="col-xl-8 col-lg-8 order-2 order-lg-1">
    <div class="side-description-form">
        <div class="job-description">
            <p><a href="../lobby.aspx">Лобби</a> - <a href="../settings.aspx">Настройки</a> - Изменить E-Mail</p>
            <div class="box-details">
                <h5>Изменить E-Mail</h5>
                <br />
                <asp:Label runat="server" ID="Error_Label"></asp:Label>
                <p>Для подтверждения смены E-Mail, получите код подтверждения на текущий E-Mail адрес.</p>
                <br />
                <div class="floating-label-wrap">
                    <asp:TextBox runat="server" ID="Email" CssClass="floating-label-field floating-label-field--s3" TextMode="Email"></asp:TextBox>
                    <asp:Label runat="server" ID="EmailLabel" AssociatedControlID="Email" CssClass="floating-label">Введите новый E-MAIL</asp:Label>
                </div>
                <asp:PlaceHolder runat="server" ID="PlaceCode"></asp:PlaceHolder>
                <br />
                <div class="form-buttons bc">
                    <asp:Button runat="server" ID="Sumbit" Text="Отправить" OnClick="Sumbit_Click" />
                    <asp:Button runat="server" ID="SaveEmail" Text="Изменить" OnClick="SaveEmail_Click" Visible="false"/>
                </div>
            </div>
        </div>
    </div>
</div>
