using System;

namespace ASafariM.Application.CommandModels
{
    public class UpdateTagCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
    }
}
