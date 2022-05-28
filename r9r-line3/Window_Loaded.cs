using System;
using System.Web;

namespace r9r_line3
{
    public class Window_Loaded : IHttpHandler
    {
        /// <summary>
        /// Vous devrez configurer ce gestionnaire dans le fichier Web.config de votre 
        /// projet Web et l'inscrire auprès des services IIS (Internet Information Services) pour pouvoir l'utiliser. Pour plus d'informations
        /// consultez le lien suivant : https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Membres IHttpHandler

        public bool IsReusable
        {
            // Retourne False si votre gestionnaire managé ne peut pas être réutilisé pour une autre demande.
            // Généralement, cette valeur est False au cas où vous conserveriez des informations d'état pour chaque demande.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //écrivez l'implémentation de votre gestionnaire ici.
        }

        #endregion
    }
}
