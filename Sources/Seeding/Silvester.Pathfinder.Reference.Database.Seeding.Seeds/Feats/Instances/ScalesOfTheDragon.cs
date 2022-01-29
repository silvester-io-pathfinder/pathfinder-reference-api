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
    public class ScalesOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("6cd41828-b570-46e0-a54c-5f2e63619b5e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scales of the Dragon",
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
            yield return new TextBlock { Id = Guid.Parse("ceb7bb67-6470-4ae4-a8ac-fc2e92d98035"), Type = TextBlockType.Text, Text = $"Scales grow across your body, protecting you against physical and magical threats. When you're unarmored, the scales give you a +2 status bonus to AC with a Dexterity cap of +2. Your resistance from {ToMarkdownLink<Models.Entities.Feat>("Dragon Disciple Dedication", Feats.Instances.DragonDiscipleDedication.ID)} increases to 3 + half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ce8d6c2-7076-4105-99e0-aba39c994e46"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c880c3d0-19d4-4642-a31e-b6d4a7164f4c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
