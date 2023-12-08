using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entities.Concrete;
using MvcUI.Infrastructure.Extensions;

namespace MvcUI.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession Session { get; set; }

        public static Cart GetCart(IServiceProvider provider)
        {
            ISession? session = provider.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;
            SessionCart cart = session?.GetJson<SessionCart>("cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        public override void CreateItem(Model model, DateTime startDate, DateTime endDate)
        {
            base.CreateItem(model, startDate, endDate);
            Session?.SetJson<SessionCart>("cart", this);
        }
    }
}