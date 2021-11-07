using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoNoICreatedYou : Template
    {
        public static readonly Guid ID = Guid.Parse("a9e0b129-c12c-4f80-905d-418ebee22df9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No! No! I Created You!",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your construct companion would become confused or controlled.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c7bda73-dbf0-4037-8227-e8a3b914d8f4"), Type = TextBlockType.Text, Text = "You appeal to your construct companion’s bond with its creator to have it break free of a controlling effect. Attempt to counteract the effect that confused or controlled your construct companion, using your Crafting modifier for the counteract check and half your level rounded up for the counteract level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("b3ce1591-0dc9-4363-9405-53e152124c67"), Innovations.Instances.Construct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a067b580-118f-427f-b9af-e1d30871bec4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
