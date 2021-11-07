using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SavingSlash : Template
    {
        public static readonly Guid ID = Guid.Parse("bf983ac5-1a82-4dd1-a3ec-3944d73e2d86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Saving Slash",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent critically hits you with a melee attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8234bec-e8ce-4c6f-9fa6-3566bbdc7bb4"), Type = TextBlockType.Text, Text = "You quickly whirl your blade, trying to deflect enough momentum to avoid the worst of the attack. Attempt a DC 16 flat check. If you succeed, the attack becomes a normal hit, instead of a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("113ea07c-fc3d-4a81-be1d-f8e5d9ab9c29"), Feats.Instances.AldoriDuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd37155e-bc07-4454-88f8-d35f86f2a656"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
