﻿using DataAccess.Repository.NoteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.NoteRepository
{
    public class NoteManager:INoteService
    {
        private readonly INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }
    }
}
