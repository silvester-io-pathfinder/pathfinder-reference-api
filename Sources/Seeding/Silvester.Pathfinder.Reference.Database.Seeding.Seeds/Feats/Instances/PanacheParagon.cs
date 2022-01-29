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
    public class PanacheParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("9c752411-8eac-4a44-a2d4-7105b7916a41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Panache Paragon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9635438e-1c33-4bef-aade-eb594a225be4"), Type = TextBlockType.Text, Text = $"You find opportunities to perform stylish feats in the moments between others' heartbeats and eye blinks. You are permanently quickened. You can use the extra action only to {ToMarkdownLink<Models.Entities.SkillAction>("Tumble Through", SkillActions.Instances.TumbleThrough.ID)} or perform the skill action listed in your swashbuckler's style as one that allows you to gain panache, or other actions that would allow you to gain panache at the GM's discretion." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("68982f0b-09db-4535-ada3-08097d5402e7"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b9fb599-c246-4768-bc5e-fc2edbcec359"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
