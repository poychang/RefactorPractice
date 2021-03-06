﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace RefatorPractice.Ch1Lab
{
    public class Customer
    {
        private List<Rental> _rental = new List<Rental>();

        public string Name { get; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental rental)
        {
            this._rental.Add(rental);
        }

        public string GetStatement()
        {
            var result = "Rental Record for" + this.Name;

            this._rental.ForEach(
                item =>
                {
                    result += $" {item.Movie.Title} {item.GetCharge()}";
                });
            result += $" Amount owed is {this.GetTotalCharege()} ";
            result += $"You earned {this.GetTotalFrequentRenterPoints()} frequent renter points";

            return result;
        }

        public string GetHtmlStatement()
        {
            var result = $@"<h1>Rentals for <EM>{this.Name}</EM></h1><p>\n";
            this._rental.ForEach(
                item =>
                {
                    result += $@"{item.Movie.Title}: {item.GetCharge()}";
                });
            result += $@"<p>You owe<EM>{this.GetTotalCharege()}</EM></p>\n";
            result +=
                $@"On this rental you earned <EM>{this.GetTotalFrequentRenterPoints()}</EM> frequent renter points";
            return result;
        }

        private double GetTotalCharege()
        {
            double result = this._rental.Sum(item => item.GetCharge());
            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int result = this._rental.Sum(item => item.GetFrequentRenterPoints());
            return result;
        }
    }
}