using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Repository;
using System;
using System.Web.Security;
using System.Web.UI;

namespace CodoPolygon.Pages.DevPanel
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // Авторизация пользователя.
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            User user;

            using (var userRepository = new UserRepository())
            {
                user = userRepository.GetByEmail(emailInput.Text);
            }

            if (user != null && passwordInput.Text == user.Password)
            {
                FormsAuthentication.RedirectFromLoginPage(user.Email, true);
            }
        }
    }
}