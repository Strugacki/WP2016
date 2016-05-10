using SOIAF.Model;
using System;
using System.Windows.Input;
using System.Diagnostics;
namespace SOIAF.ViewModel
{
    class CharactersViewModel
    {
        public CharactersViewModel()
        {

        }

        Characters characters = new Characters();

        public Characters Characters
        {
            get
            {
                return characters;
            }

            set
            {
                characters = value;
            }
        }


    }
}
