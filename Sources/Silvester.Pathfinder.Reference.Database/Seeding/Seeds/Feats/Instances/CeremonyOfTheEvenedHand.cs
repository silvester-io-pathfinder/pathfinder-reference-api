using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfTheEvenedHand : Template
    {
        public static readonly Guid ID = Guid.Parse("ca3cbe93-de8c-4cdf-887d-1d0a5d8d81ea");

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
            yield return new TextBlock { Id = Guid.Parse("ae6963a4-ef7f-4618-a5bd-a3b48f918ae4"), Type = TextBlockType.Text, Text = "You have cultivated your exoskeleton’s form for close combat, using knots, whorls, and reinforced branches. When you select this feat, you gain a claws unarmed attack that deals 1d4 slashing damage and has the (trait: agile) and (trait: finesse) traits or a branch unarmed attack that deals 1d6 bludgeoning damage and has the (trait: backswing) trait. Each of these unarmed attacks is in the brawling weapon group and uses one of your hands." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c09d2f7-2fd8-41f3-a22c-410dbd20b8d3"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
