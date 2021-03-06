using GloboTicket.TicketManagement.Application.Abstractions.Messaging;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommand : ICommand<CreateCategoryCommandResponse>
{
    public string? Name { get; set; }
}