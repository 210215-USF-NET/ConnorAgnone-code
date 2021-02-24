using System;

namespace ToHModels
{
    // <summary>
    /// Data structure used for modeling a hero.
    /// </summary>
    public class Hero
    {
        private string heroName;

        public string HeroName
        {
            get { return heroName; }
            set
            {
                if (value == null || value.Equals(""))
                { //TODO: throw exception 
                    throw new ArgumentNullException("Hero name can't be empty or null");
                }
                heroName = value;

            }
        }
        public int HP { get; set; }
        public Element ElementType { get; set; }
        public SuperPower SuperPower { get; set; }

        public override string ToString() => $"Hero Details: \n\t name: {this.HeroName} \n\t hp: {this.HP} \n\t element: {this.ElementType} \n\t superpower: {this.SuperPower.ToString()}";
    }
}
