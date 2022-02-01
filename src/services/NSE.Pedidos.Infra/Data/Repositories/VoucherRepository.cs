using NSE.Core.Data;
using NSE.Pedidos.Domain.Vouchers;

namespace NSE.Pedidos.Infra.Data.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly PedidosContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public VoucherRepository(PedidosContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
