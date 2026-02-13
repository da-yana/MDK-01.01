using ModelViewLib.Model;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Presenters
{
    public class UserPresenter
    {
        private IUsersModel model_;
        private IUsersView view_;

        public UserPresenter(IUsersModel model, IUsersView view)
        {
            model_ = model;
            view_ = view;
            List <User> usersModel = model_.UpUserData();
            view_.ShowUsers(usersModel);

        }

    }
}
