using System;
namespace MyTamagotchiAPI.Models
{
    public class Scolding
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.Now;
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}