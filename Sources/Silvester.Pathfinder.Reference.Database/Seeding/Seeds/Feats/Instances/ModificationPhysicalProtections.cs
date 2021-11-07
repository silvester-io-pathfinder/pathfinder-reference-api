using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationPhysicalProtections : Template
    {
        public static readonly Guid ID = Guid.Parse("630c26d1-8f18-453d-87c0-a4d770f96840");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Physical Protections",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36f6bfb9-e743-4198-b3f5-460a3371fc11"), Type = TextBlockType.Text, Text = "Your armor has so many adjustments and precautions that it can guard against all physical damage. While wearing your armor, you gain resistance to all physical damage (bludgeoning, piercing, and slashing damage, as well as persistent bleed damage) equal to half your level. You must have the (feat: dense plating | Modification - Dense Plating), (feat: layered mesh | Modification - Layered Mesh), or (feat: tensile absorption | Modification - Tensile Absorption) breakthrough modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e7be60f-1e37-42ae-927d-16940796c2e4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
