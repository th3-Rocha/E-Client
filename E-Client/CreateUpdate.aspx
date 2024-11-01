﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateUpdate.aspx.cs" Inherits="E_Client.CreateUpdate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <main aria-labelledby="title">     
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
                <div class="row">
                    <div class="col-lg-8 mx-auto">
                        <div class="card border-0 shadow-lg">
                            <div class="card-body p-5">
                                <asp:Label ID="headerTitle" runat="server" Text="Criar Cliente" CssClass="card-title display-4 mb-4 text-primary" />
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />
                      
                                <div class="mb-3">
                                    <label for="txtNome" class="form-label">Nome:</label>
                                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome"
                                        CssClass="text-danger" ErrorMessage="Nome é obrigatório." Display="Dynamic" />
                                </div>

                                <div class="mb-3">
                                    <label for="txtDataNascimento" class="form-label">Data de Nascimento:</label>
                                    <asp:TextBox ID="txtDataNascimento" runat="server" CssClass="form-control" TextMode="Date" />
                                    <asp:RequiredFieldValidator ID="rfvDataNascimento" runat="server" ControlToValidate="txtDataNascimento"
                                        CssClass="text-danger" ErrorMessage="Data de Nascimento é obrigatória." Display="Dynamic" />
                                </div>

                                <div class="mb-3">
                                    <asp:CheckBox ID="chkAtivo" runat="server"/>
                                    <label for="chkAtivo">Ativo</label>
                                </div>
                  
                            <div class="mt-4 d-flex flex-row justify-content-between p-2 ">
                                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary btn-lg me-2 mt-2" Text="Salvar Cliente" OnClick="btnClient_Save" />
                                <asp:Button ID="btnBack" runat="server" CssClass="btn btn-success btn-lg mt-2" Text="Voltar" OnClick="btnRouter_Back" CausesValidation="false" />
                            </div>

                            </div>
                        </div>
                    </div>
                </div>
          </ContentTemplate>
    </asp:UpdatePanel>
   </main>
</asp:Content>
