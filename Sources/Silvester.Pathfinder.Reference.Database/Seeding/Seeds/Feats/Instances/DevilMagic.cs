using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevilMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("52288030-28b2-4f2e-b195-6bcba9b07e0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devil Magic",
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
            yield return new TextBlock { Id = Guid.Parse("e655c44b-25dd-4af9-9874-eaabedc2661f"), Type = TextBlockType.Text, Text = "Drawing on the infernal power of your sinister forbears, you mislead your foes with magical deception. You can cast (spell: invisibility) and (spell: misdirection) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a2f05ec3-be73-473f-9c7f-ebbb8d38fd12"), Feats.Instances.Hellspawn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("798a124d-124b-43f5-b5d6-c1449b2ee452"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
