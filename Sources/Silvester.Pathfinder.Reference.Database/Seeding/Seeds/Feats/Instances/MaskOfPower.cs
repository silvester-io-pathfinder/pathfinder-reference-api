using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskOfPower : Template
    {
        public static readonly Guid ID = Guid.Parse("c3bacefd-8ccf-49c3-aa90-ab3e14b569a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask of Power",
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
            yield return new TextBlock { Id = Guid.Parse("42d792fc-e4b2-426a-a92f-70a755f89fc6"), Type = TextBlockType.Text, Text = "Your warmask sharpens your connection to the source of your mask’s power. During your daily preparations, choose (spell: fear), (spell: phantom pain), or (spell: true strike). Until your next daily preparations, you can cast this spell as a 1st-level innate spell once per day; the spell’s tradition is determined by the tradition tied to your warmask. You must be wearing your warmask to (action: Cast the Spell | Cast a Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("02bb0425-8ffa-4458-8678-48ea55d09efd"), Feats.Instances.OrcWarmask.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9f6b6fa-c963-4380-81a3-931c2574170b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
