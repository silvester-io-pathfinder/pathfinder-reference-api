using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyShot : Template
    {
        public static readonly Guid ID = Guid.Parse("bc7b071b-c525-4095-87d9-2f723963b88e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("074ddd1f-833f-441f-9258-0bee8f698d99"), Type = TextBlockType.Text, Text = "You unleash a small surge of magical energy into your weapon, shrouding the bullet with potential energy and granting it the ability to deal energy damage to your foes to exploit their weaknesses. You can (action: Interact) to draw a ranged weapon. On your first three (action: Strikes | Strike) of this encounter with a firearm or crossbow, you deal an additional 1 acid, cold, fire or electricity damage. You choose which damage type to deal as part of making each (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8058a92e-4748-48b1-b245-6fea11a0a2ad"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
