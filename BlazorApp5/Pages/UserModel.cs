using Microsoft.Extensions.Localization;

namespace BlazorApp5.Pages
{
    public class UserModel : User
    {
        public List<UserRole> Roles { get; private set; }

        public string StatusText { get; set; }

        public UserModel(User user, List<Role> roles, IStringLocalizer<Resources.Administration> localizer)
        {
            base.Email = user.Email;
            base.Id = user.Id;
            base.Name = user.Name;
            base.RoleIds = user.RoleIds;
            base.Status = user.Status;

            Roles = roles.Select(i => new UserRole(i, user.RoleIds!.Contains(i.Id))).ToList();

            StatusText = "Status Text";
        }
    }
}
