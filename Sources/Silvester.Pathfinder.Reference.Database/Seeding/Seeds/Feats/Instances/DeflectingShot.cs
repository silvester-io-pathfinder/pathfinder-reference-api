using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeflectingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("88579027-17e5-4b8d-813f-fd2b56e2e5ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deflecting Shot",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within the first range increment of your firearm or crossbow is hit by an attack, and you can see the attacker",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4af80eb4-265b-4f68-a634-408479608406"), Type = TextBlockType.Text, Text = "You’re always ready to take a quick shot to deflect a weapon or distract a foe enough to render them off target. The ally gains a +2 circumstance bonus to their AC against the triggering attack. You use this reaction after the result of the attack roll is revealed, so you know whether the +2 will make a sufficient difference." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ae71faa-609e-4883-a98e-c8b649959ff3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
