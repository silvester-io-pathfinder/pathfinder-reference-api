using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScalesOfTheDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("5b1972ab-4273-4161-82fd-551beb70eb86");

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
            yield return new TextBlock { Id = Guid.Parse("8f7bf615-c461-4fb5-90bd-7c062bcf34e4"), Type = TextBlockType.Text, Text = "Scales grow across your body, protecting you against physical and magical threats. When you’re unarmored, the scales give you a +2 status bonus to AC with a Dexterity cap of +2. Your resistance from (feat: Dragon Disciple Dedication) increases to 3 + half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2d2285ad-55d2-43af-921f-44dd52a2f8c6"), Feats.Instances.DragonDiscipleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("863f9c42-87f8-4f3c-a5ce-561aed2e1157"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
