using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Coffee
    {
        protected ingredient ingredient;
        public void setIngredient(ingredient i)
        {
            this.ingredient = i;
        }
        public abstract void show();
    }
}
