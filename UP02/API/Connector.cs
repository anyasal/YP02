﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP02.API {
    internal class Connector {

        public Connector() {
        }

        public List<Advertisment> GetAddList() {
            return Entities.GetContext().Advertisments.ToList();
        }

        public List<Advertisment> GetSortedAddList(
            int AdStatus = -1, 
            int City = -1, 
            int Category = -1,
            int AdType = -1,
            string AdName = "",
            User User = null
            ) {

            var Adds = Entities.GetContext().Advertisments.ToList();
            if(Adds == null || Adds.Count() == 0) return null;

            if(AdStatus > -1) {
                Adds = Adds.Where(x => x.AdStatus == AdStatus).ToList();
            }

            if(City > -1) {
                Adds = Adds.Where(x => x.City == City).ToList();
            }

            if(Category > -1) {
                Adds = Adds.Where(x => x.Category == Category).ToList();
            }

            if(AdType > -1) {
                Adds = Adds.Where(x => x.AdType == AdType).ToList();
            }

            if(!string.IsNullOrEmpty(AdName)) {
                Adds = Adds.Where(x => x.AdName.StartsWith(AdName)).ToList();
            }

            if(User != null) {
                Adds = Adds.Where(x => x.AdOwner == User.Id).ToList();
            }

            return Adds;
        }
    
        public List<City> GetCityList() {
            return Entities.GetContext().Cities.ToList();
        }

        public List<AdType> GetTypeList() {
            return Entities.GetContext().AdTypes.ToList();
        }

        public List<Category> GetCategoryList() {
            return Entities.GetContext().Categories.ToList();
        }

        public List<Status> GetStatusList() {
            return Entities.GetContext().Statuses.ToList();
        }

        public double CountProfit(User Owner) {
            double res = (double)GetAddList().Where(x => x.AdStatus == 1 && x.AdOwner == Owner.Id).ToList().Select(x => x.Price).Sum();
            return res;
        }

        public User GetUser(string Login, string Password) {
            try {
                User user = Entities.GetContext().Users.ToList().Where(x => x.UserLogin == Login && x.UserPassword == Password).ToList().First();
                return user;
            }
            catch {
                return null;
            }
        }

    }


}
