using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PristineWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("bafcf5ae-b6b3-421d-951f-c17fd549ed7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pristine Weapon",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea68f338-432d-4654-b4f3-a69e05f45f2e"), Type = TextBlockType.Text, Text = "Your verdant weapon can cut through the resistances of magical creatures. The weapon is treated as cold iron and silver. If you critically hit a creature that has a weakness to cold iron or silver, the target takes 1d6 persistent bleed damage as the primal energies within your weapon slow its natural healing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2cf9006f-9b22-4cd7-8a3f-9fee4e2d4cf4"), Feats.Instances.VerdantWeapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe4ba54c-2404-46be-a4f6-e56e6e6d280a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
