<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CRUD_Simples_new.Index" EnableEventValidation="false" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" />
    <title>Clientes</title>

</head>
<body style="background-color: #F2E3D5;">
    <form id="frmCadastroCliente" runat="server">

        <div class="container p-5" style="background-color: #012E40 !important; border-radius: 10px; color: white !important; margin-top: 70px;">
            <h1 class="text-center mb-3" style="color: white;">CADASTRO DE CLIENTES </h1>
            <!-- BOTÕES -->
            <div class="row mb-4">
                <div class="col-6">

                    <button class="btn mt-4 btn-info" title="Novo Registro" id="tsbNovo" name="tsbNovo" style="color: white; font-size: 2em;" runat="server" onserverclick="tsbNovo_Click">
                        <i class="bi bi-file-earmark-plus-fill"></i>
                    </button>

                    <button class="btn mt-4 ms-2 btn-success" title="Salvar" id="tsbSalvar" name="tsbSalvar" style="color: white; font-size: 2em;" runat="server" onserverclick="tsbSalvar_Click">
                        <i class="bi bi-floppy-fill"></i>
                    </button>

                    <button class="btn mt-4 ms-2 btn-danger" title="Cancelar" id="tsbCancelar" name="tsbCancelar" style="color: white; font-size: 2em;" runat="server" onserverclick="tsbCancelar_Click">
                        <i class="bi bi-x-square-fill"></i>
                    </button>

                    <button class="btn mt-4 ms-2 btn-warning" title="Excluir" id="tsbExcluir" name="tsbExcluir" style="color: white; font-size: 2em;" runat="server" onserverclick="tsbExcluir_Click">
                        <i class="bi bi-trash-fill"></i>
                    </button>
                </div>
                <div class="col-6" runat="server">
                    <div class="row">
                        <div class="col-2">
                            <h5 class="text-center pt-3">Buscar por ID: </h5>
                        </div>
                        <div class="col-6 mt-4">
                            <input class="form-control" name="tsbBuscaPorId" id="txt_bucarId" type="text" runat="server" />
                        </div>
                        <div class="col-1" runat="server">
                            <button class="btn btn-primary mt-4" id="tsbBuscar" name="tsbBuscar" style="font-size: 1em;" runat="server" onserverclick="tsbBuscar_Click"><i class="bi bi-search"></i></button>                            
                        </div>
                    </div>
                </div>
            </div>


            <!-- FORMULARIO -->
            <div class="row mb-4">
                <div class="col-2">
                    <asp:Label ID="lbl_ID" runat="server" Text="ID"></asp:Label>
                    <input id="txtId" type="text" class="form-control" readonly="true" runat="server" />
                </div>
                <div class="col-10">
                    <asp:Label ID="lbl_Nome" runat="server" Text="Nome"></asp:Label>
                    <input id="txtNome" type="text" class="form-control" maxlength="50" runat="server" />
                </div>
            </div>

            <div class="row mb-4">

                <div class="col-md-12">
                    <asp:Label ID="Label1txtEndereco" runat="server" Text="Endereço"></asp:Label>
                    <input id="txtEndereco" name="txtEndereco" type="text" class="form-control" maxlength="50" runat="server" />
                </div>
            </div>
            <div class="row mb-4">
                <div class="col-2">
                    <asp:Label ID="lbl_CEP" runat="server" Text="CEP"></asp:Label>
                    <input id="mskCep" name="mskCep" placeholder="_____-___" type="text" class="form-control" runat="server" />
                </div>
                <div class="col-4">
                    <asp:Label ID="lbl_Bairro" runat="server" Text="Bairro"></asp:Label>
                    <input id="txtBairro" name="txtBairro" type="text" class="form-control" maxlength="50" runat="server" />
                </div>
                <div class="col-4">
                    <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
                    <input id="txtCidade" name="txtCidade" type="text" class="form-control" maxlength="50" runat="server" />
                </div>
                <div class="col-2">
                    <asp:Label ID="Label4" runat="server" Text="UF"></asp:Label>
                    <input id="txtUf" name="txtUf" type="text" class="form-control" maxlength="2" runat="server" />
                </div>
            </div>
            <div class="row mb-4">
                <div class="col-2">
                    <asp:Label ID="lbl_Telefone" runat="server" Text="Telefone"></asp:Label>
                    <input id="mskTelefone" name="mskTelefone" placeholder="( _ _ ) 9 _ _ _ _ - _ _ _ _" type="tel" class="form-control" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
