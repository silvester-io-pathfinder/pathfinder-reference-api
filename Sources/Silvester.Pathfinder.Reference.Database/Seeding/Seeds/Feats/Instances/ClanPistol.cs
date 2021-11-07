using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClanPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("c6804c9c-f3f0-47d3-ab53-6b62c8a2f5d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clan Pistol",
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
            yield return new TextBlock { Id = Guid.Parse("a2f6ad05-0eb8-483e-a5a7-a6005c332615"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("72d8528d-8eb7-474a-86ea-2127937a9d0c"), Type = TextBlockType.Text, Text = "Raised in the ancient halls of Dongun Hold or the surrounding region, you display your lineage with a clan pistol, rather than a clan dagger. You get one (item: clan pistol) of your clan for free, as it was given to you at birth. This replaces your (item: clan dagger). Selling this pistol is a terrible taboo and earns you the disdain of other dwarves. You are trained with the (item: clan pistol). In addition, when your (item: clan pistol) is visible, you gain a +1 circumstance bonus on checks to (action: Gather Information) or (action: Make an Impression) when interacting with citizens of Alkenstar, Dongun Hold, or their allies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b213d619-22e0-41ac-9a8d-07b8f44e3741"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
