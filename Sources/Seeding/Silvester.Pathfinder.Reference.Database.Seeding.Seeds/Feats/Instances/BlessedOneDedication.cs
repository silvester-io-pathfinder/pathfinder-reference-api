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
    public class BlessedOneDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d79b8a01-763b-449e-a412-5b5bfc37005b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed One Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the blessed one archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b916410f-1412-44f9-8bee-ade0f0668a0e"), Type = TextBlockType.Text, Text = $"You are touched by a deity and gifted with the ability to alleviate the suffering of others. You gain the {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)} devotion spell. It costs 1 Focus Point to cast a focus spell. This feat grants a focus pool of 1 Focus Point that you can recover using the {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} activity. You can {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} by meditating, whether you reflect on the deity granting the blessing or not, allowing your blessing to refill your focus pool. Your devotion spells from the blessed one archetype are divine spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16d2141d-6db1-464e-b934-5862dcd258c8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
