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
    public class CastDown : Template
    {
        public static readonly Guid ID = Guid.Parse("839f0405-5b9c-41ab-944b-07e82711a622");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cast Down",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2e5d420-c1fa-4832-8079-1f91855d493c"), Type = TextBlockType.Text, Text = $"The sheer force of your faith can bring a foe crashing down. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} to damage one creature, the target is knocked prone if it takes any damage from the spell. If the target critically fails its save against the spell, it also takes a -10-foot status penalty to its Speed for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("907c6403-1a72-46f3-8696-57aca94092af"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("dd9ed3aa-2b62-485f-8a7f-91216a61daac"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("3b25cf12-f6ce-47fe-843d-37f2bfd6bab6"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("663dab61-c8e4-407e-a6a7-60e6f98a0654"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
