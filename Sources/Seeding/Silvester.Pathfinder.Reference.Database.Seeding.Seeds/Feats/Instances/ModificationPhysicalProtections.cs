using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationPhysicalProtections : Template
    {
        public static readonly Guid ID = Guid.Parse("b399c72b-4dc0-40a1-95a6-9d561423a1b0");

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
            yield return new TextBlock { Id = Guid.Parse("b94ab1ff-ec11-4591-a9e5-00e8ce9bb3b6"), Type = TextBlockType.Text, Text = $"Your armor has so many adjustments and precautions that it can guard against all physical damage. While wearing your armor, you gain resistance to all physical damage (bludgeoning, piercing, and slashing damage, as well as persistent bleed damage) equal to half your level. You must have the {ToMarkdownLink<Models.Entities.Feat>("dense plating", Feats.Instances.ModificationDensePlating.ID)}, {ToMarkdownLink<Models.Entities.Feat>("layered mesh", Feats.Instances.ModificationLayeredMesh.ID)}, or {ToMarkdownLink<Models.Entities.Feat>("tensile absorption", Feats.Instances.ModificationTensileAbsorption.ID)} breakthrough modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96e40767-27d2-4a95-ad8d-7e709e2219b5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
