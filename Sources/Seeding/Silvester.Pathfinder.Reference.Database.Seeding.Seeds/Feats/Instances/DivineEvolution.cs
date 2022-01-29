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
    public class DivineEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("e10245db-2839-437b-9ae1-fa7b1ffeee44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Evolution",
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
            yield return new TextBlock { Id = Guid.Parse("dd1251a8-30e1-416e-8359-fa118ae2301d"), Type = TextBlockType.Text, Text = $"The divine might provided by your bloodline flows through you. You gain an additional spell slot of your highest level, which you can use only to cast your choice of {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} or {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)}. You can cast either of these spells using that spell slot, even if they aren't in your spell repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("6c5ad0c3-49cf-42e0-8135-d6d4382100b7"), MagicTraditions.Instances.Divine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31ffec9d-0aae-4158-b1c6-a75d624ad687"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
