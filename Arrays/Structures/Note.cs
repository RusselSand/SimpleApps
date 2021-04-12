using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    struct Note
    {
        #region Fields
        private int id;
        private DateTime date;
        public string name;
        public string text;
        public string attachmentFolder;
        #endregion

        #region Constructor

        public Note(int id, DateTime date, string name, string text, string attachmentFolder)
        {
            this.id = id;
            this.date = date;
            this.name = name;
            this.text = text;
            this.attachmentFolder = attachmentFolder;
        }

        #endregion
        #region Methods
        /// <summary>
        /// Print data about note in console
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.id} — {this.date} — {this.name}: {this.text}/{this.attachmentFolder}";
        }




        #endregion
    }
}
