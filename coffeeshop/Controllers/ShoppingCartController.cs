﻿using coffeeshop.Models.Interface;
using Microsoft.AspNetCore.Mvc;


namespace coffeeshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartRepository shoppingCartRepository;
        private IProductRepository productRepository;
        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;

        }

        public IActionResult Index()
        {
            var items = shoppingCartRepository.GetAllShoppingCartItems();
            shoppingCartRepository.shopingcartItems = items;
            ViewBag.TotalCart = shoppingCartRepository.GetShoppingCartTotal();
            return View(items);
        }

        public RedirectToActionResult AddToShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id ==
pId);
            if (product != null)
            {
                shoppingCartRepository.AddToCart(product);
                int cartCount = shoppingCartRepository.GetAllShoppingCartItems().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id ==
pId);
            if (product != null)
            {
                shoppingCartRepository.RemoveFromCart(product);
                int cartCount = shoppingCartRepository.GetAllShoppingCartItems().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }
    }
}
