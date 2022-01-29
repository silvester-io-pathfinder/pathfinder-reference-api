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
    public class SoothingMist : Template
    {
        public static readonly Guid ID = Guid.Parse("5ed73f2f-7207-4269-b638-2c9273b0377e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soothing Mist",
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
            yield return new TextBlock { Id = Guid.Parse("735e5dc7-d0b9-4b79-92b8-3cc51a4e0a6f"), Type = TextBlockType.Text, Text = $"You have a connection to the healing properties of nature and can produce a magical mist to heal damage and stop burning or bleeding. You gain the {ToMarkdownLink<Models.Entities.Spell>("soothing mist", Spells.Instances.SoothingMist.ID)} warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("e3610b2e-f8a6-4462-88b9-781f2cff7c80"), Classes.Instances.Ranger.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64682b6d-749c-4412-b5e4-ca1b31aa3ee9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
