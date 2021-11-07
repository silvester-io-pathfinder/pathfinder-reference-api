using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiWeaponAptitude : Template
    {
        public static readonly Guid ID = Guid.Parse("e9d1b439-cfed-4373-a56c-8fb4b67c97e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Weapon Aptitude",
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
            yield return new TextBlock { Id = Guid.Parse("15901ddc-31cf-4af5-8f92-6fa7c8aa355c"), Type = TextBlockType.Text, Text = "You become familiar with using your weapons both in and out of water. Whenever you critically hit using an azarketi weapon or one of the weapons listed in (feat: Azarketi Weapon Familiarity), you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a0c7dfbc-3443-4738-9561-2986896b3ba3"), Feats.Instances.AzarketiWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b1ae397-1536-4c76-a2f3-dd8be16a8edf"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
