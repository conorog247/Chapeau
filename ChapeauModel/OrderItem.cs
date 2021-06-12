﻿using System;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int Order_Number { get; set; }
        public MenuItem MenuItemID { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public OrderStatus Order_Status { get; set; }
        public Table Table_Number { get; set; }
        public DateTime Order_Time { get; set; }

        public OrderItem(int orderItemID, int orderNumber, MenuItem menuitemID, int quantity, string comment, OrderStatus orderStatus, Table tableNumber, DateTime Ordertime)
        {
            OrderItemID = orderItemID;
            Order_Number = orderNumber;
            MenuItemID = menuitemID;
            Quantity = quantity;
            Comment = comment;
            Order_Status = orderStatus;
            Table_Number = tableNumber;
            Order_Time = Ordertime;
        }

        public OrderItem()
        {

        }
    }
}
