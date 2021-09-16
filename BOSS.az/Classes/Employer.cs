﻿using System;
using System.Collections.Generic;
using BOSS.az.Abstract_Classes;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS.az.Classes
{
    public class Employer : User
    {
        public List<Announcement> Announcements = new List<Announcement>();
        public List<Notification> notesFromJobOffers = new List<Notification>();
        public Employer(in string userName, in string password, in string name, in string surname, in string age, in string city, in string phone)
            : base(userName, password, name, surname, age, city, phone)
        {
        }

        public bool IsAnnouncementNotNull(Announcement announcement)
        {
            return announcement != null;
        }

        public bool IsRemoveCorrectly(int id)
        {
            if (id > 0)
            {
                Announcement removedAnnouncement = Announcements.Find(a => a.ID == id);
                if (removedAnnouncement == null)
                    throw new InvalidOperationException($"There is no ID {id} Announcement exists in your portfolio.");

                return true;
            }

            throw new InvalidOperationException("Id must be more than 0.");
        }

        public bool IsAnnouncementExist()
        {
            return Announcements.Count > 0;
        }

        public void ShowLessAnnouncements()
        {
            if (!IsAnnouncementExist())
                MessageBox.Show("There is no announcement", "BOSS.az", MessageBoxButtons.OK);
            else
            {
                foreach (var a in Announcements)
                {
                    a.ShowLess();
                }
            }
        }

        public void ShowMoreAnnouncements()
        {
            if (!IsAnnouncementExist())
                MessageBox.Show("There is no announcement", "BOSS.az", MessageBoxButtons.OK);
            else
            {
                foreach (var a in Announcements)
                {
                    a.ShowMore();
                }
            }
        }
    }
}
