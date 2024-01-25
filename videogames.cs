using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class videogames : IComparable<videogames>
    {
        private string name;
        private string platform;
        private double year;
        public string genre;
        public string publisher;
        private decimal na_sales;
        private decimal eu_sales;
        private decimal jp_sales;
        private decimal other_sales;
        private decimal g_sales;

        #region COnstructors
        public videogames()
        {
            SetName(" ");
            SetPlatform(" ");
            SetYear(0);
            SetGenre(" ");
            SetPublisher(" ");
            SetNA(0);
            SetEU(0);
            SetJP(0);
            SetOther(0);
            SetGlobal(0);
        }

        public videogames(string name, string platform, double year, string genre, string publisher, decimal na_sales, decimal eu_sales, decimal jp_sales, decimal other_sales, decimal g_sales)
        {
            SetName(name);
            SetPlatform(platform);
            SetYear(year);
            SetGenre(genre);
            SetPublisher(publisher);
            SetNA(na_sales);
            SetEU(eu_sales);
            SetJP(jp_sales);
            SetOther(other_sales);
            SetGlobal(g_sales);
        }

        public videogames(videogames existing)
        {
            SetName(existing.GetName());
            SetPlatform(existing.GetPlatform());
            SetYear(existing.GetYear());
            SetGenre(existing.GetGenre());
            SetPublisher(existing.GetPublisher());
            SetNA(existing.GetNA());
            SetEU(existing.GetEU());
            SetJP(existing.GetJP());
            SetOther(existing.GetOther());
            SetGlobal(existing.GetGlobal());
        }


        #endregion
        #region Getters
        public string GetName()
        {
            return name;
        }

        public string GetPlatform()
        {
            return platform;
        }

        public double GetYear()
        {
            return year;
        }

        public string GetGenre()
        {
            return genre;
        }

        public string GetPublisher()
        {
            return publisher;
        }

        public decimal GetNA()
        {
            return na_sales;
        }

        public decimal GetEU()
        {
            return eu_sales;
        }

        public decimal GetJP()
        {
            return jp_sales;
        }

        public decimal GetOther()
        {
            return other_sales;
        }

        public decimal GetGlobal()
        {
            return g_sales;
        }
        #endregion
        #region Setters

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPlatform(string platform)
        {
            this.platform = platform;
        }

        public void SetYear(double year)
        {
            this.year = year;
        }

        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public void SetPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public void SetNA(decimal na_sales)
        {
            this.na_sales = na_sales;
        }

        public void SetEU(decimal eu_sales)
        {
            this.eu_sales = eu_sales;
        }

        public void SetJP(decimal jp_sales)
        {
            this.jp_sales = jp_sales;
        }

        public void SetOther(decimal other_sales)
        {
            this.other_sales = other_sales;
        }

        public void SetGlobal(decimal g_sales)
        {
            this.g_sales = g_sales;
        }
        #endregion
        #region Compare
        
        public int CompareTo(videogames obj)
        {
            return name.CompareTo(obj.name);
        }
        #endregion
        #region override


        public override string ToString()
        {
            string info = " ";

            info += $"{GetName()}, {GetPlatform()}, {GetYear()}, {GetGenre()}, " +
                    $"{GetPublisher()}, {GetNA()}, {GetEU()}, {GetJP()}, " +
                    $"{GetOther()}, {GetGlobal()}";


            return info;
            #endregion
        }

    }


}
