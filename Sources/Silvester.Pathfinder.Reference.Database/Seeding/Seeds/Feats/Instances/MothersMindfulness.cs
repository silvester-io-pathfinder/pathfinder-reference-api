using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MothersMindfulness : Template
    {
        public static readonly Guid ID = Guid.Parse("dfb90ad3-56b4-467d-acec-cc5e35842fe2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mother's Mindfulness",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent ally is hit by an attack.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a4123b9-3652-489e-8269-f3103db4ca0d"), Type = TextBlockType.Text, Text = "You have the protective instinct your own mother lacks and will gladly suffer in another’s place. You interpose yourself in the attack’s path. You become the target of the triggering attack and are automatically hit by the attack (or critically hit if the ally was critically hit), suffering the full effects in your ally’s place." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c353d6f-f9cb-4264-816e-bd669ad4f6e9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
