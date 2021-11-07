using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationRunicKeystone : Template
    {
        public static readonly Guid ID = Guid.Parse("6b3bd319-e337-4088-a597-2277a3c645d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Runic Keystone",
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
            yield return new TextBlock { Id = Guid.Parse("3f1557e4-842c-4c2a-b688-bcdb1e41534a"), Type = TextBlockType.Text, Text = "You’ve incorporated a device similar to a runestone into your innovation, allowing it to hold a property rune, even though it isn’t a weapon or suit of armor. An armor property rune affects your innovation itself if it would affect the wearer of the armor. A weapon property rune grants whatever properties it would normally grant to a weapon to your innovation’s unarmed attacks, following all the requirements as normal (for instance, a (item: vorpal | Vorpal Runestone) rune would only apply to slashing melee unarmed attacks); if the rune affects only ranged attacks, it has no effect unless your innovation has a built-in ranged attack (from the projectile launcher initial modification, for example). If the rune would affect the physical shape or appearance of the weapon or armor itself, like (item: glamered | Glamered Runestone), the rune has no effect when etched into your construct." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afa1b363-3397-4452-8c25-870bf371b0f2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
