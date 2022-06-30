using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using System;
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace FastDevEng
{ 
    /// <summary>
    /// Painel de tarefas lateral
    /// </summary>
    public class IntegPainelTarefas : ISwAddin
    {
        #region Membros privados
        /// <summary>
        /// Os cookies da instância onde nos estamos  rodando o programa
        /// </summary>
        private int mSwCookie;
        /// <summary>
        /// O "VIEW" no painel de tarefas para adicionar
        /// </summary>
        private TaskpaneView mTaskpaneView;

        /// <summary>
        /// O controle de interface usuário que esta rodando dentro do view painel de tarefas
        /// </summary>
        private PainelTarefasHostUI mTaskpaneHost; // Alterado o nome "TaskpaneHostUI" mantido o objeto
        
        /// <summary>
        /// A instância do solidworks que está em uso
        /// </summary>
        private SldWorks mSolidWorksApplication;
        #endregion
        #region Membros públicos
        /// <summary>
        /// O único id usado para registro no COM
        /// </summary>
        public const string PainelTarefas_PROGID = "KillerBee.SolidWorks.BlankAddin.PainelTarefas";


        #endregion
        #region SolidWorks Add-in Callbacks

        /// <summary>
        /// Chamado quando o SLD carrega o add-in e quando queremos fazer uma conexão logica
        /// </summary>
        /// <param name="ThisSW"> Instância SLD atual </param>
        /// <param name="Cookie"> Cookie ID gerado pela instância SLD atual</param>
        /// <returns></returns>
        public bool ConnectToSW(object ThisSW, int Cookie)
        {
            //Armazenar a referência para a instância atual do SLD
            mSolidWorksApplication = (SldWorks)ThisSW ;
            //Armazenar a id do cookie
            mSwCookie = Cookie;

            //Callback setup inform
            var ok = mSolidWorksApplication.SetAddinCallbackInfo2(0, this, mSwCookie);
            LoadUI();
            return true;

        }


        /// <summary>
        ///  Chamado quando o SLD descarrega o add-in e quando queremos fazer uma desconexão logica
        /// </summary>
        /// <returns></returns>
        public bool DisconnectFromSW()
        {
            // Limpando a Interface do Usuário
            UnloadUI();
            return true;
        }

        
        #endregion
        #region Criando UI
        private void LoadUI()
        {
           //mSolidWorksApplication.CreateTaskpaneView2();
        }
        private void UnloadUI()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
