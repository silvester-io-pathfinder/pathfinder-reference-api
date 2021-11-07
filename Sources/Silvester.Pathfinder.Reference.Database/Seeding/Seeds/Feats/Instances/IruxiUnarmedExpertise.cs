using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IruxiUnarmedExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("ff7f9d40-013b-48bc-a170-261ff46b18ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iruxi Unarmed Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a29166d-7bff-4e44-8750-d5c6c5850bcf"), Type = TextBlockType.Text, Text = "Your unarmed attacks blend tradition and training. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in the claw and unarmed attacks you gained from lizardfolk ancestry feats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3f82e21a-24a5-4db6-abd3-2d4e398c8873"), Feats.Instances.IruxiUnarmedCunning.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18d89efc-9ed4-4fc0-9cb7-a869851218dc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
