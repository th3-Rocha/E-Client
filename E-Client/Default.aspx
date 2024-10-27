<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <main class="container my-5">
          <div class="row">
              <div class="col-lg-8 mx-auto">
                  <div class="card border-0 shadow-lg">
                      <div class="card-body p-5">
                          <h1 class="card-title display-4 mb-4 text-primary">E-Client Manager</h1>
                          <p class="lead text-muted mb-4">Gerencie seus clientes de forma eficiente e profissional com nossa plataforma intuitiva.</p>
            
                          <h2 class="h4 mb-3">O que você gostaria de fazer?</h2>
                          <div class="d-grid gap-3 d-sm-flex justify-content-sm-start">
                              <asp:Button ID="btnIncluirCliente" runat="server" CssClass="btn btn-primary btn-lg px-4 me-sm-3" Text="Novo Cliente" OnClick="btnPutClient_Click" />
                              <asp:Button ID="btnEditarClientes" runat="server" CssClass="btn btn-outline-secondary btn-lg px-4" Text="Gerenciar Clientes" OnClick="btnListClient_Click" />
                          </div>
                      </div>
                  </div>
              </div>
          </div>
      </main>
</asp:Content>
