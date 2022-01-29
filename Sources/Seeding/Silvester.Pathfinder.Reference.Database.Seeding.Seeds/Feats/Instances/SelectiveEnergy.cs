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
    public class SelectiveEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("cd25eded-1667-4f73-9baa-ce96b9318f1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Selective Energy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36c7fb19-6d90-4d6a-8b4a-2a9ea6f56f14"), Type = TextBlockType.Text, Text = $"As you call down divine power, you can prevent some enemies from benefiting or some allies from being hurt. When you cast a version of {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} that has an area, you can designate a number of creatures equal to your Charisma modifier (minimum 1) that are not targeted by the spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04b67945-8513-43d2-8238-061f84467aa4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
