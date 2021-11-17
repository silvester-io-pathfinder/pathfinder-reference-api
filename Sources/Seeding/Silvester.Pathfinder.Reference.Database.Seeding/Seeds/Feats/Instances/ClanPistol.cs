using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClanPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("f4bde609-bfa9-475e-b137-9c17015f8c46");

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
            yield return new TextBlock { Id = Guid.Parse("e6fdc4cc-5bf3-4618-9c0d-64ef24fdd584"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("fa7ad2b0-5855-41e3-ba56-54867818c758"), Type = TextBlockType.Text, Text = "Raised in the ancient halls of Dongun Hold or the surrounding region, you display your lineage with a clan pistol, rather than a clan dagger. You get one (item: clan pistol) of your clan for free, as it was given to you at birth. This replaces your (item: clan dagger). Selling this pistol is a terrible taboo and earns you the disdain of other dwarves. You are trained with the (item: clan pistol). In addition, when your (item: clan pistol) is visible, you gain a +1 circumstance bonus on checks to (action: Gather Information) or (action: Make an Impression) when interacting with citizens of Alkenstar, Dongun Hold, or their allies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ea58df2-9201-40a7-85bc-4b3df03fddbf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
