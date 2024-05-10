using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(float height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothes(string clothes);
        ICharacterBuilder SetInventory(List<string> inventory);
        Character Build();
    }
}
