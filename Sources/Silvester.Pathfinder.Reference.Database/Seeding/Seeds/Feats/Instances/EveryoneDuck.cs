using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EveryoneDuck : Template
    {
        public static readonly Guid ID = Guid.Parse("066483ef-a8cb-434d-9424-f05d5c151100");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everyone Duck!",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail, but don't critically fail, an attempt to Disable a Device on a trap.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81d42301-4926-4a61-865c-a0b98ba0c030"), Type = TextBlockType.Text, Text = "You intentionally set off the trap, but you take special precautions to protect yourself and your allies from the trap’s effects. For the next 2 rounds, if the trap rolls a critical success on an attack roll, it gets a normal success instead, and if anyone rolls a critical failure on their saving throw against the trap, they get a normal failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("03e43495-58c2-4d02-9f98-d8cf26e913f9"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94a22982-54ef-470d-a348-3d1c4630c3d5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
