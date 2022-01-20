using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorApp5.Pages
{
    public partial class Users
    {
        private Guid _accountId;
        private List<UserSummary>? _model = new List<UserSummary>
        {
        };
        private List<Role>? _roles = new List<Role>
        {
            new Role { Id = Guid.NewGuid(), Name = "Role1" }
        };
        private string? _searchString;

        [Inject]
        private IDialogService? DiaglogService { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        private async Task DeleteAsync(UserSummary summaryUser)
        {
        }

        private async Task NewAsync()
        {
            var user = new User
            {
                RoleIds = new List<Guid>(),
                Status = 1
            };

            var result = await ShowUserDialogAsync(user!);
        }

        private async Task RefreshAsync()
        {
        }

        private async Task ResendAsync(UserSummary summaryUser)
        {
        }

        private bool Search(UserSummary user)
        {
            if (string.IsNullOrEmpty(_searchString))
            {
                return true;
            }

            if (user.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }

            if (user.Email!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (user.StatusText.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        private async Task<DialogResult> ShowUserDialogAsync(User user)
        {
            var parameters = new DialogParameters
            {
                { nameof(UserDialog.AccountId), _accountId },
                { nameof(UserDialog.Roles), _roles },
                { nameof(UserDialog.User), user }
            };
            
            var options = new DialogOptions
            {
                CloseButton = true,
                DisableBackdropClick = true,
                FullWidth = true,
                MaxWidth = MaxWidth.Small
            };

            var dialog = DiaglogService!.Show<UserDialog>(null, parameters, options);

            return await dialog.Result;
        }

        private async Task ViewOrEditAsync(UserSummary summaryUser)
        {
        }
    }
}