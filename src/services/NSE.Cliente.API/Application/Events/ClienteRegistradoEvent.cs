using NSE.Core.Messages;
using System;

namespace NSE.Clientes.API.Application.Events
{
    public class ClienteRegistradoEvent : Event
    {
        public ClienteRegistradoEvent(Guid id, string nome, string email, string cpf)
        {
            AggregateId = Id;
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
