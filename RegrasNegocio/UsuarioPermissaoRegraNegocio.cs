using AcessoBancoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegrasNegocio
{
    public class UsuarioPermissaoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, UsuarioPermissao usuarioPermissao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuarioPermissao.Usuario.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@ExportarBackup", usuarioPermissao.ExportarBackup);
                acessoDadosSqlServer.AdicionarParametros("@ImportarBackup", usuarioPermissao.ImportarBackup);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlteracao", LoginSistema.UsuarioLogin.Codigo);
                var codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioPermissao").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public UsuarioPermissao ConsultarPorCodigoUnico(string codigo)
        {
            try
            {
                var usuario = new UsuarioPermissao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Usuario", codigo);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioPermissaoConsultar");
                foreach (DataRow usuarioLinha in dataTable.Rows)
                {
                    usuario.Usuario = new Usuario
                    {
                        Codigo = Convert.ToInt32(usuarioLinha["CodigoUsuario"]),
                        Secretariado = Convert.ToBoolean(usuarioLinha["TipoSecretariado"]),
                        Administrador = Convert.ToBoolean(usuarioLinha["TipoAdministrador"]),
                        IdUsuario = Convert.ToInt32(usuarioLinha["IdUsuario"]),
                        NomeUsuario = Convert.ToString(usuarioLinha["NomeUsuario"]),
                        NomeReal = Convert.ToString(usuarioLinha["NomeReal"])
                    };
                    usuario.ExportarBackup = Convert.ToBoolean(usuarioLinha["ExportarBackup"]);
                    usuario.ImportarBackup = Convert.ToBoolean(usuarioLinha["ImportarBackup"]);
                }
                return usuario;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta do usuário por código. Detalhes: " + exception.Message);
            }
        }
    }
}
   
        