﻿using SuperShop.Data.Entities;
using SuperShop.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        /// <summary>
        /// all of the orders of that user
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>table of orders</returns>
        Task<IQueryable<Order>> GetOrderAsync(string userName);

       
        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);

        Task AddItemToOrderAsync(AddItemViewModel model, string userName);

        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

        Task DeleteDatailTempAsync(int id);

        Task<bool> ConfirmOrderAsync(string userName);

        Task DeliverOrder(DeliveryViewModel model);

        Task<Order> GetOrderAsync(int id);
    }
}
