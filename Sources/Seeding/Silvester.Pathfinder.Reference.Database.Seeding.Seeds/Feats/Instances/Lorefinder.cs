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
    public class Lorefinder : Template
    {
        public static readonly Guid ID = Guid.Parse("868256b8-c6b4-40f1-8c66-94eaf60d0ae2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lorefinder",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30523902-a5eb-45ab-a03a-26e7d7e7e5f7"), Type = TextBlockType.Text, Text = $"You know that fate sometimes conspires to keep dangerous knowledge or items from the eyes of those most able to understand them. You deny fate the ability to conceal truths from you. You can cast {ToMarkdownLink<Models.Entities.Spell>("locate", Spells.Instances.Locate.ID)} as an innate occult spell once per day. When you reach 14th level, this spell is heightened to 5th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("caf66842-6655-4d92-a32e-2d481c567bfa"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("667c6c89-c947-4831-826b-d2209c9beee1"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
