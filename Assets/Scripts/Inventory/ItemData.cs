using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string _name = "";
        string _description = "";
        int _amount = 0;
        int _value = 0;
        ItemType _type = ItemType.Food;
        string _icon = "";
        string _mesh = "";
        int _damage = 0;
        int _armour = 0;
        int _heal = 0;
        switch(itemID)
        {
            #region Ingredient 0 -99
            case 0:
                _name = "Brown Mushroom";
                _description = "Good for stew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/0";
                _mesh = "0";
                _damage = 1;
                _armour = 0;
                _heal = 1;
                break;
            case 1:
                _name = "Oak Leaf";
                _description = "Good for stew";
                _amount = 5;
                _value = 3;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/1";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 2:
                _name = "Lute";
                _description = "Not good for stew";
                _amount = 1;
                _value = 5;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/2";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion

            #region Potions 100 -199
            case 100:
                _name = "Potion of Nightvision";
                _description = "Good for stew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Potion;
                _icon = "Potion/100";
                _mesh = "";
                _damage = 1;
                _armour = 0;
                _heal = 1;
                break;
            case 101:
                _name = "Potion of Illumination";
                _description = "Good for stew";
                _amount = 5;
                _value = 3;
                _type = ItemType.Potion;
                _icon = "Potion/101";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 102:
                _name = "Lute";
                _description = "Not good for stew";
                _amount = 1;
                _value = 5;
                _type = ItemType.Potion;
                _icon = "Potion/102";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion

            #region Scrolls 200 -209
            case 200:
                _name = "Scroll of Inferno";
                _description = "Good for stew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Scroll;
                _icon = "Scrolls/200";
                _mesh = "";
                _damage = 1;
                _armour = 0;
                _heal = 1;
                break;
            case 201:
                _name = "Scroll of Blizzard ";
                _description = "Not good for stew";
                _amount = 5;
                _value = 3;
                _type = ItemType.Scroll;
                _icon = "Scrolls/201";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 202:
                _name = "Lute";
                _description = "Not good for stew";
                _amount = 1;
                _value = 5;
                _type = ItemType.Scroll;
                _icon = "Scrolls/202";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion

            #region Food 300 -399
            case 300:
                _name = "Apple";
                _description = "Good for stew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Food;
                _icon = "Food/300";
                _mesh = "";
                _damage = 1;
                _armour = 0;
                _heal = 1;
                break;
            case 301:
                _name = "Meat";
                _description = "Good for stew";
                _amount = 5;
                _value = 3;
                _type = ItemType.Food;
                _icon = "Food/301";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 302:
                _name = "Lute";
                _description = "A lute";
                _amount = 1;
                _value = 5;
                _type = ItemType.Food;
                _icon = "Food/302";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion

            #region Armour 400 -499
            case 400:
                _name = "Helmet";
                _description = "Not good for stew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Armour;
                _icon = "Armour/400";
                _mesh = "Armour/Helmet";
                _damage = 1;
                _armour = 0;
                _heal = 1;
                break;
            case 401:
                _name = "Tunic";
                _description = "Not good for stew";
                _amount = 5;
                _value = 3;
                _type = ItemType.Armour;
                _icon = "Armour/401";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 402:
                _name = "Lute";
                _description = "Not good for stew";
                _amount = 1;
                _value = 5;
                _type = ItemType.Armour;
                _icon = "Armour/402";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion

            #region Weapon 500 -599
            case 500:
                _name = "Axe";
                _description = "Not good for stew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Weapon;
                _icon = "Weapon/500";
                _mesh = "Weapons/Axe";
                _damage = 1;
                _armour = 0;
                _heal = 1;
                break;
            case 501:
                _name = "Bow";
                _description = "Not good for stew";
                _amount = 5;
                _value = 3;
                _type = ItemType.Weapon;
                _icon = "Weapon/501";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 2;
                break;
            case 502:
                _name = "Lute";
                _description = "Good for stew";
                _amount = 1;
                _value = 5;
                _type = ItemType.Weapon;
                _icon = "Weapon/502";
                _mesh = "";
                _damage = 0;
                _armour = 0;
                _heal = 3;
                break;
            #endregion
        }
        Item temp = new Item
        {
            ID = itemID,
            Name = _name,
            Description = _description,
            Amount = _amount,
            Value = _value,
            Type = _type,
            Icon = Resources.Load("Icons/" + _icon) as Texture2D,
            ItemMesh = Resources.Load("Mesh/" + _mesh) as GameObject,
            Damage = _damage,
            Armour = _armour,
            Heal = _heal
        };
        return temp;
    }
}
