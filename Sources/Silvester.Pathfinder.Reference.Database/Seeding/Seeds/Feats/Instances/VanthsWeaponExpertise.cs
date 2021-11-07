using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VanthsWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("3030bdad-9506-48f6-ae81-0270fdf69d1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vanth's Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("b2fd48fd-fa58-43c2-a100-99515862690d"), Type = TextBlockType.Text, Text = "Vanths themselves recognize you as an honorary reaper. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in (item: bo staves | bo staff), (item: longbows | longbow), (item: composite longbows | composite longbow), (item: scythes | scythe), and (item: staves | staff)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc27be91-5e35-4bd2-af51-151c1640c4a5"), Feats.Instances.VanthsWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bffbd8c-a14b-4578-8c29-56c27822412e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
