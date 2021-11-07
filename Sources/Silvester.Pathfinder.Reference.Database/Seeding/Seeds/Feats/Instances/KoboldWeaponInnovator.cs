using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KoboldWeaponInnovator : Template
    {
        public static readonly Guid ID = Guid.Parse("96665216-b9ba-4a85-be72-97584fcf6aa2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kobold Weapon Innovator",
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
            yield return new TextBlock { Id = Guid.Parse("2ab9c647-aa10-4d3a-adbd-07d3462988c2"), Type = TextBlockType.Text, Text = "You’ve learned devious tactics with your kobold weapons. Whenever you critically hit with a (item: crossbow), (item: greatpick), (item: light pick), (item: pick), (item: spear), or kobold weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("90819b4e-15d3-48db-ba33-d9814cd00a14"), Feats.Instances.KoboldWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("394ecd3d-439a-4f49-8a80-741e21ba90fb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
