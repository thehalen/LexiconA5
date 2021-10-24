using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconA5.Products
{
    public class TestProducts
    {

        public Drink fanta50 = new Drink(20, "Fanta", "A tasty nazi concoction of leftover chemicals and fun colors. 50cl.", "Drink to get your sugar fix.");
        public Drink fanta33 = new Drink(16, "Fanta", "A tasty nazi concoction of leftover chemicals and fun colors. 33cl.", "Drink to get your sugar fix."); //Fanta originated in Germany as a Coca-Cola substitute in 1940 due to the American trade embargo of Nazi Germany which affected the availability of Coca-Cola ingredients.
        public Drink coke = new Drink(15, "Coca-Cola", "This \"Intellectual Beverage\" and Temperance Drink contains the valuable Tonic and Nerve Stimulant " +
                                     "properties of the Coca plant and cola (or Kola) nuts, and makes not only a delicious, exhilarating, refreshing and " +
                                     "invigorating Beverage (dispensed from the soda water fountain or in other carbonated beverages), but a valuable Brain " +
                                     "Tonic and cure for all nervous affections — Sick Head-Ache, Neuralgia, Hysteria, Melancholy, etc..", "Drink to get your sugar fix.");  //https://timesknowledge.wwmindia.com/content/2017/sep/the_creatures_that_time_forgot_1505826658.png

        public Candy coco = new Candy(19, "Coco", "56 grams of chocolate bar, filled with coconut deliciousness.", "Stuff it in your cake-hole to make yourself happier and fatter.");
        public Candy stratos = new Candy(69, "Stratos", "150 grams of norwegian chocolate infused with air bubbles. The most expensive air you'll ever eat, but also the tastiest.", "Stuff it in your cake-hole to make yourself happier and fatter.");
        public Candy lion = new Candy(18, "Lion", "62 grams of chocolate bar, possibly filled with feline apex predator.", "Stuff it in your cake-hole to make yourself happier and fatter.");
        public Candy caramel = new Candy(13, "Caramel", "100 grams of concentrated sugar. Primarily used at Vipeholm to experiment on handicapped people.", "Stuff it in your cake-hole to make yourself happier and fatter.");

        public Bauble globe = new Bauble(123, "Snow Globe", "A classic snow globe featuring the Lady Liberty, forever captured in a mix of plastic flakes, water, anti-freeze and glycerol, for the amusement of children and the elderly.", "Shake it and watch all the fun!");
        public Bauble zippo = new Bauble(57, "Zippo Lighter", "The most metal metal lighter ever conceived. Runs on gasoline and Freedoom", "Open and light in one smooth move, or get a wuss lighter instead.");
        public Bauble fert = new Bauble(1, "500kg of taurid manure", "High octane super-fertilizer. Mostly ethically harvested from debates.", "Apply on agricultural fields or dispose of as hazardous materials.");
        public Bauble massager = new Bauble(36, "Massager", "Use this advanced version of Joseph Mortimer Granville great invention, for purposes including pain relief and the treatment of neuralgia, neurasthenia, morbid irritability, indigestion and constipation.", "Lube it up and relax, unless you become the butt of the joke");
    }
}
