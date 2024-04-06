﻿namespace CookiesCookbook.Recipes.Ingredients
{
    internal interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }
        Ingredient GetById(int id);
    }
}