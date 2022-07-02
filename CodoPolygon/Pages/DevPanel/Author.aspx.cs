using System;
using System.Web.Security;
using System.Web.UI;

namespace CodoPolygon.Pages.DevPanel
{
    public partial class Author : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckIdentity();
            //InitializeUserData();
            InitializeArticles();
        }



        protected void LogOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }



        private void CheckIdentity()
        {
            if (!User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }



        private void InitializeUserData()
        {
            throw new NotImplementedException();
            // TODO: Реализовать.
        }



        private void InitializeArticles()
        {
            // TODO: Реализовать.
        }
    }
}