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
    public class PlentifulSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("8aa0cc47-f3a3-4c0f-8ae0-27c44d200751");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plentiful Snares",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dfbf88f4-f761-44ad-ab94-ed87d6c4cd11"), Type = TextBlockType.Text, Text = $"You can prepare incredible numbers of snares each day out of simple ingredients. Double the number of prepared snares granted by {ToMarkdownLink<Models.Entities.Feat>("Snarecrafter Dedication", Feats.Instances.SnarecrafterDedication.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("146ce88d-960b-479f-b2bc-c1a3e5dd4a13"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ace76976-78ff-47f3-b6cd-9633efc93061"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
