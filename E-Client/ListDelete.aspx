<%@ Page Title="Lista de Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListDelete.aspx.cs" Inherits="E_Client.ListDelete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <main aria-labelledby="title">    
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
          <div class="row">
              <div class="col-lg-10 mx-auto">
                  <div class="card border-0 shadow-lg">
                    <div class="card-body">
                        <h1 class="card-title h2 mb-4 text-primary">Lista de Clientes</h1>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />
                        <div class="table-responsive">
                            <asp:GridView 
                                AutoGenerateColumns="False" 
                                ID="CLIList" 
                                runat="server" 
                                CssClass="table table-hover table-striped"  
                                DataKeyNames="CLI_ID"
                                OnRowCommand="CLIList_RowCommand" 
                                AllowPaging="True" 
                                PageSize="7"
                                OnPageIndexChanging="CLIList_PageIndexChanging" 
                                PagerStyle-CssClass="pagination"
                                > 
                                <Columns>
                                    <asp:BoundField DataField="CLI_ID" HeaderText="Id do Cliente" />
                                    <asp:BoundField DataField="CLI_NOME" HeaderText="Nome" />
                                    <asp:BoundField DataField="CLI_DATANASCIMENTO" HeaderText="Data de Nascimento" DataFormatString="{0:dd/MM/yyyy}" />
                                    <asp:TemplateField HeaderText="Ativo">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkAtivo" runat="server" Checked='<%# Eval("CLI_ATIVO") %>' Enabled="false" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Ações">
                                        <ItemTemplate>
                                            <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-outline-primary btn-sm" CommandName="Edit_CLI" CommandArgument='<%# Container.DataItemIndex %>'/>
                                            <asp:Button ID="btnDelete" runat="server" Text="Deletar" CssClass="btn btn-outline-danger btn-sm"  CommandName="Delete_CLI" CommandArgument='<%# Container.DataItemIndex %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                  </div>
              </div>
          </div>
         </ContentTemplate>
      </asp:UpdatePanel>
  </main>
</asp:Content>