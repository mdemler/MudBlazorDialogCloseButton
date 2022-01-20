namespace BlazorApp5.Pages
{
    public class UserRole
    {
        public bool Active { get; set; }
        public string Name { get { return Role.Name!; } }
        public Role Role { get; private set; }

        public UserRole(Role role, bool active)
        {
            Active = active;
            Role = role;
        }
    }
}
