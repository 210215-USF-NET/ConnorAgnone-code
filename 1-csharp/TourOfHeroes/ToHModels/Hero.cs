using System;

namespace ToHModels
{
    public class Hero
    {
        /// <summary>
        /// Data structure used for modeling a hero.
        /// </summary>
        private string heroName;
        private int hP;
        public string HeroName 
        { 
            get{return heroName;} 
            set
            {
                if(value.Equals(null)){ } //TODO: throw exception
                heroName = value;
            } 
        }
        public int HP { get; set; }

        public Element ElementType { get; set; }
        public SuperPower SuperPower { get; set; }
        public override string ToString() => $"Hero Details: \n\t name: {this.HeroName} \n\t hp: {this.HP} \n\t element: {this.ElementType} \n\t superpower: {this.SuperPower.ToString()}";
    }
}
