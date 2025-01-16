namespace UserManagement.BackEnd.Core.Entities
{
    public class Message : BaseEntity<Guid>
    {
        public string SenderUserName { get; set; }

        public string ReceiverUserName {  get; set; }

        public string Text { get; set; }
    }
}
