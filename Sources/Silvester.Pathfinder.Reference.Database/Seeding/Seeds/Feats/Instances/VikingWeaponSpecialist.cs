using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VikingWeaponSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("0464c498-d11d-4c83-93d5-c0e9b82d4a01");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Weapon Specialist",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32e457c3-1a16-4967-8301-eae5f99798ce"), Type = TextBlockType.Text, Text = "You are even more skilled in the weapons of your people. You gain the critical specialization effects of the (item: battle axe), (item: hatchet), (item: longsword), and (item: shortsword). Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in the above four weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c9ea3bba-6e5d-4c44-a61c-4e3e8b853c6d"), Feats.Instances.VikingWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4b29a38-b704-4996-9c2f-56e053c1d629"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
