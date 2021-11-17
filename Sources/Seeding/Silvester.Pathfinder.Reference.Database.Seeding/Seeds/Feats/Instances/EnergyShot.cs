using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyShot : Template
    {
        public static readonly Guid ID = Guid.Parse("add07fd8-4f80-4220-a148-1f51454704e2");

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
            yield return new TextBlock { Id = Guid.Parse("7107a88c-aea2-4daa-b28a-acee1a6e04dc"), Type = TextBlockType.Text, Text = "You unleash a small surge of magical energy into your weapon, shrouding the bullet with potential energy and granting it the ability to deal energy damage to your foes to exploit their weaknesses. You can (action: Interact) to draw a ranged weapon. On your first three (action: Strikes | Strike) of this encounter with a firearm or crossbow, you deal an additional 1 acid, cold, fire or electricity damage. You choose which damage type to deal as part of making each (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("692ffc8d-9e8d-4bae-9d75-6af0fdb5ac94"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
