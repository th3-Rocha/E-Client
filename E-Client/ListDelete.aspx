<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDelete.aspx.cs" Inherits="E_Client.ListDelete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <main aria-labelledby="title">     
      <div class="row">
          <div class="col-lg-8 mx-auto">
              <div class="card border-0 shadow-lg">
                  <div class="card-body p-5">
                      <h1 class="card-title display-4 mb-4 text-primary">Lista de Clientes</h1>
                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />
    
                  </div>
              </div>
          </div>
      </div>
  </main>
</asp:Content>
