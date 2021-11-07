using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AllInMyHead : Template
    {
        public static readonly Guid ID = Guid.Parse("159d602d-3d75-4e82-b208-bfdfd1ffb201");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "All in my Head",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take damage from a Strike or spell that doesn't have the death trait or otherwise cause instant death (such as disintegrate).",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf77a83c-b862-496b-bc79-3407f7cb9438"), Type = TextBlockType.Text, Text = "Using your occult connections and incredible powers of persuasion, you convince yourself that the triggering damage is a figment of your imagination. The damage changes from its usual damage type to mental damage, and the damaging effect gains the (trait: nonlethal) trait. You can’t use this reaction if you are immune to mental effects or mental damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25c1df4e-6e22-448b-9f0f-034369f7b074"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
