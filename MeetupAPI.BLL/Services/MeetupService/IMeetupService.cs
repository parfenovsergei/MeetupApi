﻿using MeetupAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetupAPI.BLL.Services.MeetupService
{
    public interface IMeetupService
    {
        Task<List<Meetup>> GetAll();
        Task<string> AddMeetup(Meetup meetup, string speakerEmail, string organizerEmail);
        Task<Meetup> GetMeetup(int id);
    }
}