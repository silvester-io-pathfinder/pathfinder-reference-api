using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrnateTattoo : Template
    {
        public static readonly Guid ID = Guid.Parse("f768dd78-f227-4835-8587-ada039d14779");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ornate Tattoo",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69eec209-4b80-49c6-909a-b1c12379f771"), Type = TextBlockType.Text, Text = "You expand your tattoos to encompass greater magic. Choose a 1st-level arcane spell from the same school as your (feat: Arcane Tattoos), either a common spell or another to which you have access. You can cast that spell once per day as an innate arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1017c3f1-a192-46a9-a6de-8aa047ac1db4"), Feats.Instances.ArcaneTattoos.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6eab1af4-6f36-482b-a8b5-b703e2989093"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
