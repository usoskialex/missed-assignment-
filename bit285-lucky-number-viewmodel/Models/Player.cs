using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        //TODO: Add the properties neededby the Player entity (including Data Annotations)

        [Key]
        public int PlayerID { get; set; } //for player ID

        [Required] 
        public string Name { get; set; } // name 

        [Required]
        [Range(1, 9, ErrorMessage = "Please, enter the number from 1 to 9")] //message for player to enter valid number
        public int Number { get; set; } // number

        [Required]
        public decimal Balance { get; set; } //balance
       
    }
}