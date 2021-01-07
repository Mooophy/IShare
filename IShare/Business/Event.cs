﻿using System.Collections.Generic;

namespace Business
{
    public class Event
    {
        private DAL.Event dal = new DAL.Event();

        public IEnumerable<Models.Event> ListEvents()
        {
            return dal.ListEvents();
        }
    }
}