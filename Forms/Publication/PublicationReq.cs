using DreamCar.Data;
using DreamCar.Models;
using System.Collections.Generic;
using System.Linq;

namespace DreamCar.Forms.Publication
{
    public class PublicationReq
    {
        public PublicationReq()
        {

        }

        public static List<Models.Publication> GetPublications(DreamCarContext context, string currentUserUsername)
        {
            return context.Publications.Where(x => x.PublishAuthor == currentUserUsername).ToList();
        }

        public static void AddNewCar(DreamCarContext context, string currentUserUsername, Car carToAdd)
        {
            var currentUserPublishCount = context.Publications.Where(x => x.PublishAuthor == currentUserUsername).Count();
            context.Cars.Add(carToAdd);
            context.SaveChanges();
        }
    }
}
