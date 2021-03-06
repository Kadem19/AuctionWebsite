﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AuctionProject.Models
//{
//    public class EfUserRepository : IUserRepository
//    {
//        //   F i e l d s  &  P r o p e r t i e s

//        private AppDbContext context;

//        //   C o n s t r u c t o r s

//        public EfUserRepository(AppDbContext context)
//        {
//            this.context = context;
//        }

//        //   M e t h o d s

//        //   C r e a t e

//        public IdentityUser AddUser(IdentityUser user)
//        {
//            context.Users.Add(user);
//            context.SaveChanges();
//            return user;
//        }

//        //  R e a d
//        public IQueryable<IdentityUser> GetAllUsers()
//        {
//            return context.Users.OrderBy(u => u.Username);
//        }

//        public IdentityUser GetUserByEmail(string email)
//        {
//            return context.Users
//                .FirstOrDefault(u => u.Username == email);
//        }

//        public IdentityUser GetUserById(int id)
//        {
//            return context.Users.FirstOrDefault(u => u.Id == id);
//        }

//        //   U p d a t e

//        public IdentityUser UpdateUser(IdentityUser user)
//        {
//            IdentityUser userToUpdate = GetUserById(user.Id);
//            if (userToUpdate != null)
//            {
//                userToUpdate.Username = user.Username;
//                userToUpdate.Password = user.Password;
//                context.SaveChanges();
//            }
//            return userToUpdate;
//        }

//        //   D e l e t e

//        public bool DeleteUser(int id)
//        {
//            IdentityUser userToDelete = GetUserById(id);
//            if (userToDelete == null)
//            {
//                return false;
//            }
//            context.Users.Remove(userToDelete);
//            context.SaveChanges();
//            return true;
//        }

//        public bool DeleteUser(IdentityUser user)
//        {
//            return DeleteUser(user.Id);
//        }
//    }
//}
