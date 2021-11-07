using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationIntegratedGauntlet : Template
    {
        public static readonly Guid ID = Guid.Parse("9c257121-085f-4280-ab13-8dcac51fdccf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Integrated Gauntlet",
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
            yield return new TextBlock { Id = Guid.Parse("b284e3d9-62b6-420e-92de-c41b3d60ba1b"), Type = TextBlockType.Enumeration, Text = "*One-Handed Weapon Only; Can’t Have the (trait: Two-Hand) Trait**" };
            yield return new TextBlock { Id = Guid.Parse("7fceea83-8cad-411c-89d3-cea5a12515c5"), Type = TextBlockType.Text, Text = "Combining your weapon with a gauntlet, you make it so you can quickly switch between attacking with your weapon and tinkering using your hands. Your innovation gains the (trait: free-hand) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60be6062-e367-4eac-8ce8-c553c44cfdef"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
