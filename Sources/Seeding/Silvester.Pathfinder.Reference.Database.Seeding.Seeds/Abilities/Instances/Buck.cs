using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Buck : Template
    {
        public static readonly Guid ID = Guid.Parse("4b1fcb3e-561c-4157-9b11-7fea08f9f17b");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Buck",
                Description = "Most monsters that serve as mounts can attempt to buck off unwanted or annoying riders, but most mounts will not use this reaction against a trusted creature unless the mounts are spooked or mistreated.",
                Trigger = "A creature Mounts or uses the Command an Animal action while riding the monster.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("4d5e3f8d-e29a-4c6e-a229-9b9750af9d27"), Text = "The triggering creature must succeed at a Reflex saving throw against the listed DC or fall off the creature and land prone. If the save is a critical failure, the triggering creature also takes 1d6 bludgeoning damage in addition to the normal damage for the fall." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21815880-c1d5-4683-bdf1-f2c871255b21"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
