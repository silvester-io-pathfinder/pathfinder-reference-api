﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class AlignmentSeeder : IEntitySeeder<Alignment>
    {
        public IEnumerable<Alignment> GetSeedEntities()
        {
            yield return new Alignment { Id = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Lawful Good", Description = "A lawful good character typically acts with compassion and always with honor and a sense of duty. However, lawful good characters will often regret taking any action they fear would violate their code, even if they recognize such action as being good." };
            yield return new Alignment { Id = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), Name = "Neutral Good", Description = "A neutral good character typically acts altruistically, without regard for or against lawful precepts such as rules or tradition. A neutral good character has no problems with cooperating with lawful officials, but does not feel beholden to them. In the event that doing the right thing requires the bending or breaking of rules, they do not suffer the same inner conflict that a lawful good character would." };
            yield return new Alignment { Id = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44"), Name = "Chaotic Good", Description = "A chaotic good character does what is necessary to bring about change for the better, disdains bureaucratic organizations that get in the way of social improvement, and places a high value on personal freedom, not only for oneself, but for others as well. Chaotic good characters usually intend to do the right thing, but their methods are generally disorganized and often out of sync with the rest of society." };
            yield return new Alignment { Id = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756"), Name = "Chaotic Neutral", Description = "A chaotic neutral character is an individualist who follows their own heart and generally shirks rules and traditions. Although chaotic neutral characters promote the ideals of freedom, it is their own freedom that comes first; good and evil come second to their need to be free." };
            yield return new Alignment { Id = Guid.Parse("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), Name = "Lawful Neutral", Description = "A lawful neutral character typically believes strongly in lawful concepts such as honor, order, rules, and tradition, but often follows a personal code in addition to, or even in preference to, one set down by a benevolent authority. Examples of this alignment include a soldier who always follows orders, a judge or enforcer who adheres mercilessly to the letter of the law, or a disciplined monk." };
            yield return new Alignment { Id = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "True Neutral", Description = "A true neutral character is neutral on both axes and tends not to feel strongly towards any alignment, or actively seeks their balance." };
            yield return new Alignment { Id = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d"), Name = "Lawful Evil", Description = "A lawful evil character sees a well-ordered system as being easier to exploit than to necessarily follow. Examples of this alignment include tyrants, dictators, corrupt officials, or undiscriminating mercenary types who have a strict code of conduct." };
            yield return new Alignment { Id = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), Name = "Neutral Evil", Description = "A neutral evil character is typically selfish and has no qualms about turning on allies-of-the-moment, and usually makes allies primarily to further their own goals. A neutral evil character has no compunctions about harming others to get what they want, but neither will they go out of their way to cause carnage or mayhem when they see no direct benefit for themselves. Another valid interpretation of neutral evil holds up evil as an ideal, doing evil for evil's sake and trying to spread its influence. Examples of the first type are an assassin who has little regard for formal laws but does not needlessly kill, a henchman who plots behind their superior's back, or a mercenary who readily switches sides if made a better offer. An example of the second type would be a masked killer who strikes only for the sake of causing fear and distrust in the community." };
            yield return new Alignment { Id = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b"), Name = "Chaotic Evil", Description = "A chaotic evil character tends to have no respect for rules, other people's lives, or anything but their own desires, which are typically selfish and cruel. They set a high value on personal freedom, but do not have much regard for the lives or freedom of other people. Chaotic evil characters do not work well in groups because they resent being given orders and usually do not behave themselves unless there is no alternative." };
        }
    }
}
