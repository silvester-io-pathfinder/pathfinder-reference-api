using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationIntegratedGauntlet : Template
    {
        public static readonly Guid ID = Guid.Parse("5c99babc-dd62-419a-b2cf-7bde888676b7");

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
            yield return new TextBlock { Id = Guid.Parse("a2502fd1-b4b3-4b96-9451-ceead8634925"), Type = TextBlockType.Enumeration, Text = "*One-Handed Weapon Only; Can’t Have the (trait: Two-Hand) Trait**" };
            yield return new TextBlock { Id = Guid.Parse("f46ec083-d30f-4842-b71b-4c5343b762e0"), Type = TextBlockType.Text, Text = "Combining your weapon with a gauntlet, you make it so you can quickly switch between attacking with your weapon and tinkering using your hands. Your innovation gains the (trait: free-hand) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1ba92a5-75bf-4762-8378-529e0c9701cf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
