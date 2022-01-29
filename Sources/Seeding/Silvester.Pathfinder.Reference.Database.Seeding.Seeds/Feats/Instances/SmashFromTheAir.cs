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
    public class SmashFromTheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("1c7f3b46-6c95-4137-80c4-28e59aa3e991");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smash from the Air",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0dc0d64e-3a19-44fb-bb7c-f5bc56f56307"), Type = TextBlockType.Text, Text = $"Your expertise enables you to knock away spells. You can use {ToMarkdownLink<Models.Entities.Feat>("Cut from the Air", Feats.Instances.CutFromTheAir.ID)} against ranged spell attack rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("faca5cff-4c78-4aba-b646-fc5f96d401ff"), Feats.Instances.CutFromTheAir.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2decbdf6-04f7-4a79-b242-bf934fc0dc49"), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6319974-5404-40ed-874b-3bc5390c65b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
