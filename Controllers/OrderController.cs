using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PayPal.Api;
using SmallShopIT.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SmallShopIT.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly IConfiguration _configuration;
        private readonly PayPalConfig _payPalConfig;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, IConfiguration configuration)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _configuration = configuration;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Models.Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Twój koszyk jest pusty");
            }

            if (ModelState.IsValid)
            {
                order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
                
                var apiContext = GetApiContext();

                Payment payment = GetPaymentData(order);

                var createdPayment = payment.Create(apiContext);

                var approvalUrl =
                    createdPayment.links.FirstOrDefault(
                        x => x.rel.Equals("approval_url", StringComparison.OrdinalIgnoreCase));
                order.PayPalReference = createdPayment.id;
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return Redirect(approvalUrl.href);
            }
            return View(order);
        }

        public IActionResult Return(string payerId, string paymentId)
        {
            var apiContext = GetApiContext();

            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };

            var payment = new Payment()
            {
                id = paymentId
            };

            payment.Execute(apiContext, paymentExecution);

            return RedirectToAction("Thankyou");
        }

        public IActionResult Cancel()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        private Payment GetPaymentData(Models.Order model)
        {
            return new Payment
            {

                experience_profile_id = "XP-ZSTY-5XWP-P6V5-W33M",
                intent = "sale",
                payer = new Payer
                {
                    payment_method = "paypal"
                },
                transactions = new List<Transaction>
                    {
                        new Transaction
                        {
                            description = $"SallShopIT Item for {model.OrderId}",
                            amount = new Amount
                            {
                                currency = "PLN",
                                total = model.OrderTotal.ToString("N2",CultureInfo.CreateSpecificCulture("en-GB")),
                            },
                            item_list = new ItemList()
                            {
                                items = new List<Item>()
                                {
                                    new Item()
                                    {
                                        description = $"SallShopIT Item for {model.OrderId}",
                                        currency = "PLN",
                                        quantity = "1",
                                        price = model.OrderTotal.ToString("N2",CultureInfo.CreateSpecificCulture("en-GB")),
                                    }
                                }
                            }
                        }
                    },
                redirect_urls = new RedirectUrls
                {
                    return_url = Url.Action("Return", "Order", null, Request.Scheme),
                    cancel_url = Url.Action("Cancel", "Order", null, Request.Scheme)
                }
            };
        }

        private APIContext GetApiContext()
        {
            var config = _configuration.GetSection("PayPal").GetChildren()
                  .ToDictionary(x => x.Key, x => x.Value);
            var accessToken = new OAuthTokenCredential(config).GetAccessToken();
            var apiContext = new APIContext(accessToken);
            return apiContext;
        }
    }
}
