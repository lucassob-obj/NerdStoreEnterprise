using FluentValidation.Results;
using NSE.Core.Data;
using System.Threading.Tasks;

namespace NSE.Core.Messages
{
    public abstract class CommandHandler
    {
        public CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected ValidationResult ValidationResult;

        protected void AdicionaErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork uow)
        {
            if (!await uow.Commit()) AdicionaErro("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}
