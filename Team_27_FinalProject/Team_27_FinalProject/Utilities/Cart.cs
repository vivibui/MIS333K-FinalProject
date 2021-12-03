using Team_27_FinalProject.DAL;
using System;
using System.Linq;
using Team_27_FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace Team_27_FinalProject.Utilities
{
    public static class Cart
    {
        public static Order GetCart(AppDbContext _context, String email, Property property)
        {
            Order order = _context.Orders
                .Include(o => o.Reservations)
                .Include(o => o.AppUser)
                .ThenInclude( o => o.Properties)
                .FirstOrDefault(o => o.AppUser.Email == email && o.OStatus == Order.OrderStatus.Pending);

            if (order == null)
            {
                order = new Order()
                {
                    //Set Order Date
                    OrderDate = DateTime.Now,
                    //Set order status to Pending
                    OStatus = Order.OrderStatus.Pending,
                };
                //Associate the registration with the logged-in customer

                order.AppUser = _context.Users.FirstOrDefault(u => u.UserName == email);
                _context.Add(order);
                _context.SaveChanges();
            }
            return order;   
        }

    }
}