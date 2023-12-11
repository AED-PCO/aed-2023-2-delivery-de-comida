using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Classes
{
    internal class ProductManager
    {
        public static int MaxProductAmount = 8;
        public static int MaxExtrasAmount = 10;

        private static Product[] AllProducts;
        private static Product[] AllExtras;

        private static string normal_path = Program.root_path + "\\Arquivos\\produtos.txt";
        private static string extras_path = Program.root_path + "\\Arquivos\\extras.txt";
        public ProductManager()
        {
            FetchAllProducts();
        }

        public static void FetchAllProducts()
        {
            FetchProducts();
            FetchExtras();
        }

        private static void FetchExtras()
        {
            if (AllExtras != null) { return; }

            string[] productsData = File.ReadAllLines(extras_path);

            AllExtras = new Product[MaxExtrasAmount];

            int index = 0;
            foreach (var data in productsData)
            {
                if (index >= AllExtras.Length) { break; }

                Product novo_obj = new Product();

                novo_obj.FillByString(data);

                AllExtras[index++] = novo_obj;
            }
        }

        private static void FetchProducts()
        {
            if (AllProducts != null) { return; }

            string[] productsData = File.ReadAllLines(normal_path);

            AllProducts = new Product[MaxProductAmount];

            int index = 0;
            foreach (var data in productsData)
            {
                if (index >= AllProducts.Length) { break; }

                Product novo_obj = new Product();

                novo_obj.FillByString(data);

                AllProducts[index++] = novo_obj;
            }
        }

        public static Product[] GetAllProducts()
        {
            if (AllProducts == null) { FetchProducts(); }
            return (Product[])AllProducts.Clone();
        }

        public static Product[] GetAllExtras()
        {
            if (AllExtras == null) { FetchExtras(); }
            return (Product[])AllExtras.Clone();
        }

        public static ProductLinkedList GetListByIds(string ids, bool extras = false)
        {

            ProductLinkedList newList = new ProductLinkedList();

            if (ids == String.Empty) { return newList; }

            Product[] current = (extras == false) ? AllProducts : AllExtras;
            string[] arrayIds = ids.Split(',');

            for (int i = 0; i < arrayIds.Length; i++)
            {
                int index = ProductSearch.Search(current, int.Parse(arrayIds[i]));
                if (index != -1)
                {
                    newList.AddLast(current[index]);
                }
            }
            return newList;
        }
    }

    internal class ProductSearch
    {
        public static int Search(Product[] arr, int Id)
        {
            return InternalSearch(arr, Id, 0, arr.Length - 1);
        }
        private static int InternalSearch(Product[] arr, int targetId, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid].Id == targetId)
                {
                    return mid; // Encontrou o elemento
                }
                else if (arr[mid].Id < targetId)
                {
                    return InternalSearch(arr, targetId, mid + 1, right); // Buscar na metade direita
                }
                else
                {
                    return InternalSearch(arr, targetId, left, mid - 1); // Buscar na metade esquerda
                }
            }

            return -1; // Elemento não encontrado
        }
    }
}
