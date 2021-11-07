using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BouncyGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("bf457398-eae0-4650-acf8-b2d20aa8d523");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bouncy Goblin",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e753c45d-5485-4487-b8c3-c45bd9b410fa"), Type = TextBlockType.Text, Text = "You have a particular elasticity that makes it easy for you to bounce and squish. You gain the trained proficiency rank in Acrobatics (or another skill of your choice, if you were already trained in Acrobatics). You also gain a +2 circumstance bonus to Acrobatics checks to (action: Tumble Through) a foe’s space." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("68df6c72-ba64-4682-b238-c7c8adf1f83d"), Heritages.Instances.UnbreakableGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85f2a3b8-b8a0-42fd-99f0-f54e21fd2cdb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
