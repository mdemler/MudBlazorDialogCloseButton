using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorApp5.Pages
{
    public partial class UserDialog
    {
        private bool _emailAddressReadOnly;
        private UserModel? _model;

        [Parameter]
        public Guid AccountId { get; set; }

        [CascadingParameter]
        MudDialogInstance? DialogInstance { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        [Parameter]
        public List<Role>? Roles { get; set; }

        [Parameter]
        public User? User { get; set; }

        private void OnCancel()
        {
            DialogInstance!.Cancel();
        }

        protected override void OnParametersSet()
        {
            if (_model == null)
            {
                _model = new UserModel(User!, Roles!, _localizer);
            }
        }

        private void OnRoleCheckChanged(UserRole userRole, bool isChecked)
        {
        }

        private async Task OnValidSubmitAsync()
        {
            DialogInstance!.Close();
        }
    }
}