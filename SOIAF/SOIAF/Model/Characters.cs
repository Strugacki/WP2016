namespace SOIAF.Model
{
    using System;
    using System.ComponentModel;

    public class Characters : INotifyPropertyChanged
    {
        private String name;
		private String culture;
		private String born;
		private String died;
        private String[] titles;
        private String[] aliases;
        private String father;
        private String mother;
        private String[] allegiances;
		private String[] tvSeries;
		private String[] playedBy;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Culture
        {
            get
            {
                return culture;
            }

            set
            {
                culture = value;
                OnPropertyChanged("Culture");
            }
        }

        public string Born
        {
            get
            {
                return born;
            }

            set
            {
                born = value;
                OnPropertyChanged("Born");
            }
        }

        public string Died
        {
            get
            {
                return died;
            }

            set
            {
                died = value;
                OnPropertyChanged("Died");
            }
        }

        public string[] Titles
        {
            get
            {
                return titles;
            }

            set
            {
                titles = value;
                OnPropertyChanged("Titles");
            }
        }

        public string[] Aliases
        {
            get
            {
                return aliases;
            }

            set
            {
                aliases = value;
                OnPropertyChanged("Aliases");
            }
        }

        public string Father
        {
            get
            {
                return father;
            }

            set
            {
                father = value;
                OnPropertyChanged("Father");
            }
        }

        public string Mother
        {
            get
            {
                return mother;
            }

            set
            {
                mother = value;
                OnPropertyChanged("Mother");
            }
        }

        public string[] Allegiances
        {
            get
            {
                return allegiances;
            }

            set
            {
                allegiances = value;
                OnPropertyChanged("Allegiances");
            }
        }

        public string[] TvSeries
        {
            get
            {
                return tvSeries;
            }

            set
            {
                tvSeries = value;
                OnPropertyChanged("TvSeries");
            }
        }

        public string[] PlayedBy
        {
            get
            {
                return playedBy;
            }

            set
            {
                playedBy = value;
                OnPropertyChanged("PlayedBy");
            }
        }

        public Characters(string name, string culture, string born, string died, string[] titles, string[] aliases, string father, string mother, string[] allegiances, string[] tvSeries, string[] playedBy)
        {
            this.name = name;
            this.culture = culture;
            this.born = born;
            this.died = died;
            this.titles = titles;
            this.aliases = aliases;
            this.father = father;
            this.mother = mother;
            this.allegiances = allegiances;
            this.tvSeries = tvSeries;
            this.playedBy = playedBy;
        }

        

        #region INotifyPropertyChanged Members;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
