﻿using System.Collections.Generic;
using appv1.DAL.Contexts;
using appv1.DAL.Models;

namespace appv1.Interfaces
{
    public interface IObslugaBazyDanych
    {
        public SklepContext Context { get; set; }


        public void DodajProduct(Products product);



        public List<Products> GetProducts();
    }
}