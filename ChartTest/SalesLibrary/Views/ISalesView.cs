using System.Collections.Generic;

namespace SalesLibrary.Views
{
    public interface ISalesView
    {
        void Show(List<Sale> sales);
    }
}
