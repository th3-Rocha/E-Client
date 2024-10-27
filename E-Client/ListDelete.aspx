<%@ Page Title="Lista de Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDelete.aspx.cs" Inherits="E_Client.ListDelete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <main aria-labelledby="title">     
      <div class="row">
          <div class="col-lg-10 mx-auto">
              <div class="card border-0 shadow-lg">
                <div class="card-body">
                    <h1 class="card-title h2 mb-4 text-primary">Lista de Clientes</h1>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />
                    <div class="table-responsive">
                        <asp:GridView AutoGenerateColumns="False" ID="gvClientes" runat="server" CssClass="table table-hover table-striped">
                            <Columns>
                                <asp:BoundField DataField="CLI_ID" HeaderText="Id do Cliente" />
                                <asp:BoundField DataField="CLI_NOME" HeaderText="Nome" />
                                <asp:BoundField DataField="CLI_DATANASCIMENTO" HeaderText="Data de Nascimento" DataFormatString="{0:dd/MM/yyyy}" />
                                <asp:BoundField DataField="CLI_ATIVO" HeaderText="Ativo" />
                                <asp:TemplateField HeaderText="Ações">
                                    <ItemTemplate>
                                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-outline-primary btn-sm" />
                                        <asp:Button ID="btnDelete" runat="server" Text="Deletar" CssClass="btn btn-outline-danger btn-sm" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
              </div>
          </div>
      </div>
  </main>
</asp:Content>