﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    abstract class SystemComponentBaseEntity<T>: BaseEntity<T> where T: SystemComponentBaseEntity<T>
    {
        public string Title
        { get; set; }

        public int Price
        { get; set; }

        public SystemComponentBaseEntity(string title, int price): base()
        {
            this.Title = title;
            this.Price = price;
        }
    }
}
