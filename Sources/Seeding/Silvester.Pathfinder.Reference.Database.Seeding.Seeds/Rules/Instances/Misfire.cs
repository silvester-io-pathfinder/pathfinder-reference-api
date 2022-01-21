using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rules.Instances
{
    public class Misfire : Template
    {
        public static readonly Guid ID = Guid.Parse("dae3f294-da1b-4f17-838c-a86f63176c59");
        
        protected override Rule GetRule()
        {
            return new Rule
            {
                Id = ID, 
                Name = "Misfire",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f8f3e256-ce61-4071-97ae-0ca63a548441"), Type = TextBlockType.Text, Text = "Firearms that are improperly maintained or subjected to unusual strain can misfire. If you attempt to fire a firearm that was fired the previous day or earlier and hasn�t been cleaned since, roll a DC 5 flat check before making your attack roll. If you fail this misfire check, the weapon misfires and jams. The attack is an automatic critical failure, and you must use an Interact action to clear the jam before the weapon can be reloaded and fired again. Once you�ve spent at least an hour cleaning a weapon, you don�t need to roll for a misfire until the next day unless an effect says otherwise. You can clean multiple firearms during this hour, up to a reasonable limit as determined by the GM (typically no more than five)." };
            yield return new TextBlock { Id = Guid.Parse("64bbbcb7-c01f-4f09-ba3b-bfc48255ed9d"), Type = TextBlockType.Text, Text = "Some abilities cause a weapon to misfire as a part of their effects. If such a misfire happens as a result of an attack (due to an action that causes a misfire on a failed attack, for example), it retroactively makes the attack a critical failure." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10882254-94f7-430c-b0a0-7e32c85d23a3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 108
            };
        }
    }
}
