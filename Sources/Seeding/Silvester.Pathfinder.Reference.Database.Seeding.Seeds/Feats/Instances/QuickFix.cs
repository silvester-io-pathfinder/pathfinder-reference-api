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
    public class QuickFix : Template
    {
        public static readonly Guid ID = Guid.Parse("011af2f7-8dee-41b4-aef5-dea739b7b844");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Fix",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("166ee52d-3ca8-4599-a304-fdfb71167105"), Type = TextBlockType.Text, Text = $"You can attach a talisman using only a bit of glue and some string. You gain the {ToMarkdownLink<Models.Entities.Feat>("Rapid Affixture", Feats.Instances.RapidAffixture.ID)} skill feat, even if you don't meet the prerequisites. When you use it, you can affix or remove up to four talismans in 1 minute instead of just one." };
            yield return new TextBlock { Id = Guid.Parse("905c2edf-c54d-48c5-ad77-1f14324c0217"), Type = TextBlockType.Text, Text = $"You gain the ability to {ToMarkdownLink<Models.Entities.Action>("Affix a Talisman", Actions.Instances.AffixATalisman.ID)} as a 3-action activity from that feat at 12th level, regardless of your Crafting proficiency." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("27c981df-b29c-4048-bc3e-8b8b948e2659"), Feats.Instances.TalismanDabblerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17a6ad4c-24f8-4b24-a2a0-459f262ab14e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
