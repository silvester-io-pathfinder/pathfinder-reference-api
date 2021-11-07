using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchNails : Template
    {
        public static readonly Guid ID = Guid.Parse("fa51a4e4-1984-4266-98ea-38969fbf08f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Nails",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df791f67-f3e3-46da-b5c9-973417b1790f"), Type = TextBlockType.Text, Text = "Your nails are supernaturally long and sharp. You gain a nails unarmed attack that deals 1d6 slashing damage. Your nails are in the brawling group and have the (trait: agile) and (trait: unarmed) traits. You can etch your nails with runes with the same cost and restrictions as for etching runes onto (item: handwraps of mighty blows); runes etched onto your nails apply to nails unarmed attacks with both hands but not to other unarmed attacks." };
            yield return new TextBlock { Id = Guid.Parse("bdd7fc12-efbe-4e20-946a-593563b8c2da"), Type = TextBlockType.Text, Text = "You can deliver hexes through your nails. When you successfully cast a non-cantrip hex that requires 2 actions or more to cast and that doesn’t require a spell attack roll, if your target is within your reach, as part of the spellcasting activity you can make a nails (action: Strike) against the foe before applying any effects of the hex. If this (action: Strike) misses, the hex has no effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98788ccb-1a70-4b22-966f-858de378e15f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
