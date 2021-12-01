using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();
        public int Total { get; set;}

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
            this.Total = 0;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
            this.Total = this.Total + item.SubTotal;
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
            this.Total = this.Total - item.SubTotal;
        }
    }
}