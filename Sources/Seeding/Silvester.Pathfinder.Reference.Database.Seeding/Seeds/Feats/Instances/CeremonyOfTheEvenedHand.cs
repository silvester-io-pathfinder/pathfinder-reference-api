using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfTheEvenedHand : Template
    {
        public static readonly Guid ID = Guid.Parse("23f1cb15-143f-4ed1-84b5-1a6d11633b77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of the Evened Hand",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat twice, choosing the other unarmed attack the second time you take it.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9445740-80de-4b5c-bb43-0ff4df7e988f"), Type = TextBlockType.Text, Text = "You have cultivated your exoskeleton's form for close combat, using knots, whorls, and reinforced branches. When you select this feat, you gain a claws unarmed attack that deals 1d4 slashing damage and has the (trait: agile) and (trait: finesse) traits or a branch unarmed attack that deals 1d6 bludgeoning damage and has the (trait: backswing) trait. Each of these unarmed attacks is in the brawling weapon group and uses one of your hands." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65553e5a-ea12-4448-804a-ef6b9369f09a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
