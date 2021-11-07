using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Lavasoul : Template
    {
        public static readonly Guid ID = Guid.Parse("b8686691-8e93-4206-bf34-2ae30dd6bd34");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lavasoul",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("688c1f04-7d89-4a1d-a327-8217a3329ab2"), Type = TextBlockType.Text, Text = "Your elemental lineage manifests as magma and molten rock, and you can focus the magma into your hand to attack your foes. You gain a magma spike unarmed attack, which requires a free hand to use. This is an (trait: agile), (trait: finesse), unarmed attack in the brawling weapon group that deals 1d4 piercing damage, as well as 1 additional fire damage. Instead of the normal critical specialization effect, the target takes 1d6 persistent fire damage; you gain a bonus on this persistent damage equal to your item bonus to attack rolls on unarmed attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39ba3137-d0a7-43a5-8f78-66154e8498b0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
