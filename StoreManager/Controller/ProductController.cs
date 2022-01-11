using StoreManager.Model;
using System;
using System.Collections.Generic;

namespace StoreManager.Controller
{
    public class ProductController
    {
        private readonly FileController fileController = new FileController();

        private readonly string path = ".....";

        public List<Product> Get()
        {
            // var lines = fileController.ReadLines(path);
            // prelucrati liniile si returnati new List<Product> citite din fisier 
        }

        public void Create(Product product)
        {
            // add new product to file 
        }

        public void Update(Product product)
        {
            // update product to file 
        }

        public void Delete(int id)
        {
            // search product in file by Id and delete it from file 
        }
    }
}
