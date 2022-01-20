namespace BlazorApp5.Pages
{
    public class User
    {
        public Guid Id
        {
            get;
            set;
        }

        public string? Email
        {
            get;
            set;
        }

        public string? Name
        {
            get;
            set;
        }

        public List<Guid>? RoleIds
        {
            get;
            set;
        }

        public int Status { get; internal set; }
    }
}
