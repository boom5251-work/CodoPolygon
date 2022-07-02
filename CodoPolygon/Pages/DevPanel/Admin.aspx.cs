using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Repository;
using System;
using System.Web.Security;
using System.Web.UI;

namespace CodoPolygon.Pages.DevPanel
{
    public partial class Admin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                User user;
                
                using (var userRepository = new UserRepository())
                {
                    user = userRepository.GetByEmail(User.Identity.Name);
                }

                if (user == null)
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
                // TODO: Изменить.
                //else if (user.UserRole != adminRole)
                //{
                //    FormsAuthentication.RedirectToLoginPage();
                //}
            }
        }


        protected void Unnamed_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}