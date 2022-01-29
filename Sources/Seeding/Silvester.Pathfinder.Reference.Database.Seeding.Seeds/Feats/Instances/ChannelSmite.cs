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
    public class ChannelSmite : Template
    {
        public static readonly Guid ID = Guid.Parse("b0245191-3ad7-4c8b-9f06-1a7950cd2f3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Channel Smite",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bff34980-cb09-46b8-87ac-fa949c9ed336"), Type = TextBlockType.Text, Text = $"You siphon the destructive energies of positive or negative energy through a melee attack and into your foe. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and add the spell's damage to the Strike's damage. This is negative damage if you expended a {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell or positive damage if you expended a {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell." };
            yield return new TextBlock { Id = Guid.Parse("167a8c1b-a1e1-42b5-8b5d-cf6e3302b805"), Type = TextBlockType.Text, Text = $"The spell is expended with no effect if your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} fails or hits a creature that isn't damaged by that energy type (such as if you hit a non-undead creature with a heal spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("59e5d12d-7540-4989-a670-ddffafc6d583"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("b08fef4f-775e-4442-9ac3-8994ad75dd80"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("b8e20e4b-3477-4eae-b558-6bc475d724d4"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("912e998e-8bad-4b3d-88ee-5c4730d98720"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
