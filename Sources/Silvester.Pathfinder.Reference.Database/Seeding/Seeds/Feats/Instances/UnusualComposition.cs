using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnusualComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("77555ac1-b344-44ef-b35b-123b4c8d2f46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unusual Composition",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1b5c946-b1d9-4be2-bba3-6f452398ee1f"), Type = TextBlockType.Text, Text = "You can translate the emotion and power of a composition to other mediums. If your next action is to cast a (trait: composition) spell, you can use a different kind of performance than usual for the composition to change any of its somatic components to verbal components or vice versa. As usual for (trait: composition) spells, this changes whether the composition is (trait: auditory) or (trait: visual)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("474710e3-1c46-47c7-86e2-cf9c5877e245"), Muses.Instances.Polymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c5680d0-aa63-4d3f-985c-9f5d13fab138"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
