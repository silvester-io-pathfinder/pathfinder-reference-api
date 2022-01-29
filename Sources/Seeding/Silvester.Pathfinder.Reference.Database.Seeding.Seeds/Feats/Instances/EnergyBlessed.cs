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
    public class EnergyBlessed : Template
    {
        public static readonly Guid ID = Guid.Parse("f5188063-34c0-4fd8-a09d-e65acb2bd79b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Blessed",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e35a2f7-4f40-42a3-bf43-7959be42300a"), Type = TextBlockType.Text, Text = $"Energy runs through your blood more powerfully. When you use {ToMarkdownLink<Models.Entities.Feat>("Energy Emanation", Feats.Instances.EnergyEmanation.ID)}, you can create an emanation of 5 feet, 10 feet, or 15 feet. The damage increases to 6d6 plus an additional 1d6 for every level you have above 9th, instead of 1d6 plus an additional 1d6 for every 2 levels above 1st." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("9913b62b-0aee-49eb-88f8-8a0c5d10fe72"), Heritages.Instances.ElementalHeartDwarf.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("151c39db-c88c-4ee2-b255-ea9ec4eac8c7"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
