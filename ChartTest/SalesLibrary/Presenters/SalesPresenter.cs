using SalesLibrary.Analysis;
using SalesLibrary.Models;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;

namespace SalesLibrary.Presenters
{
    public class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();
        private List<ISalesView> views_;
        public SalesPresenter(List<ISalesView> views)
        {
            views_ = views;

            model_.Load();
        }

        public void ShowSalesByItem(string itemName)
        {
            List<Sale> sales = model_.LoadSalesForItem(itemName);
            foreach(ISalesView view in views_)
            {
                view.Show(sales);
            }
        }

        /// <summary>
        /// с помощью этого метода можно получить список всех продаваемых
        /// элементов в системе (товаров, услуг, .....)
        /// </summary>
        /// <returns>Список элементов</returns>
        public List<Item> GetAllItems()
        {
            return model_.GetAllItems();
        }

        public double GetProfitPercentByItem(Item selectedItem)
        {
            return ProfitAnalyzer.CalculateProfitPercentByItem(selectedItem.Name,
                                                               model_);
        }
    }
}
