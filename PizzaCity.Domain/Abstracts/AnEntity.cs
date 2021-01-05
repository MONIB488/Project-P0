using System;

namespace PizzaCity.Domain.Abstracts
{
    public abstract class AnEntity
    {
        public long EntityId {get; set;}
    
        protected AnEntity()
        {
            EntityId = DateTime.Now.Ticks;
            
        }
    }

}