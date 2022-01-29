using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Incarnate : Template
    {
        public static readonly Guid ID = Guid.Parse("babf61a7-d441-413f-89e2-4eb09023a59d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Incarnate",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0877bd0a-7599-496a-ae74-fe446b85b73a"), Type = TextBlockType.Text, Text = "A spell with the incarnate trait is similar in theme to spells that summon creatures, but it doesn't conjure a minion with the summoned trait. Instead, when summoned, the incarnate creature takes its Arrive action when you finish Casting the Spell. At the end of your next turn, the incarnate creature can either Step, Stride, or take the action for another movement type it has (such as Climb or Burrow), and then takes its Depart action. The spell then ends. The names of specific Arrive and Depart actions are listed in italics after the word 'Arrive' or 'Depart' respectively, along with any traits." };
            yield return new TextBlock { Id = Guid.Parse("5eb47c1f-33a2-4717-941a-059f2e308abc"), Type = TextBlockType.Text, Text = "A creature summoned by an incarnate spell acts in your interests, directs its effects away from you and your allies as much as possible, and might listen to your requests, but ultimately makes its own decisions. If the spell indicates that the incarnate makes a decision, the GM determines what the incarnate would do. It might even become more inclined to do precisely as you wish over multiple summonings." };
            yield return new TextBlock { Id = Guid.Parse("e3df151d-5d35-4bdb-a8dc-494011f1b5a2"), Type = TextBlockType.Text, Text = "The incarnate is not fully a creature. It can't take any other actions, nor can it be targeted or harmed by Strikes, spells, or other effects unless they would be able to target or end a spell effect (such as dispel magic). It has a size for the purposes of determining its placement for effects, but it doesn't block movement. If applicable, its effects use your spell DCs and spell attack roll modifier." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2016f9fe-917f-4bb2-9479-fa85e895270f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 132
            };
        }
    }
}
