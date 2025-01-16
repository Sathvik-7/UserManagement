namespace UserManagement.BackEnd.Core.DTO.Message
{
    public class GetMessageDTO
    {
        public Guid Id { get; set; }

        public string SenderUserName { get; set; }

        public string ReceiverUserName { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
