using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeflectingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("438c5ba2-5ce0-4fe0-a733-b671e8dabca6");

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
            yield return new TextBlock { Id = Guid.Parse("38800ae7-19a7-4b76-a746-90dda42c520c"), Type = TextBlockType.Text, Text = $"You're always ready to take a quick shot to deflect a weapon or distract a foe enough to render them off target. The ally gains a +2 circumstance bonus to their AC against the triggering attack. You use this reaction after the result of the attack roll is revealed, so you know whether the +2 will make a sufficient difference." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1a3a663-0a5b-4412-9498-bc21a30a4c80"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
