<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MessageSettings.ascx.cs" Inherits="PopChat.Settings_Parts.MessageSettings" %>
<div class="col-xl-8 col-lg-8 order-2 order-lg-1">
    <div class="side-description-form">
        <div class="job-description">
            <p><a href="../lobby.aspx">Лобби</a> - <a href="../settings.aspx">Настройки</a> - Настройки чата</p>
            <div class="box-details">
                <h5>Настройки чата</h5>
                <br />
                <asp:Label runat="server" ID="Error_Label"></asp:Label>               
                <div class="floating-label-wrap">
                    <input runat="server" ID="ColorText" type="color" value="#ff0000" class="floating-label-field floating-label-field--s3">
                    <asp:Label runat="server" ID="ColorLabel" AssociatedControlID="ColorText" CssClass="floating-label">Цвет пользователя</asp:Label>
                </div><br />               
                <div class="form-buttons bc">
                    <asp:Button runat="server" ID="Sumbit" Text="Сохранить" OnClick="Sumbit_Click" />
                </div>
            </div>
        </div>
    </div>
</div>
