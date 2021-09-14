﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanDomain.Entity
{
    public class Kanban
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public bool IsDeleted { get; set; }
    }
}
