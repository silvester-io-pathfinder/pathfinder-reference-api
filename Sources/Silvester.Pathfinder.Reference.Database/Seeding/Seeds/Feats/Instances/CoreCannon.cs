using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoreCannon : Template
    {
        public static readonly Guid ID = Guid.Parse("0af02e53-8c4b-40ea-9767-0843dfdc5005");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Core Cannon",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad0eead0-c5e2-4f90-9890-d037dee4bc30"), Type = TextBlockType.Text, Text = "Your body transforms into a powerful magical cannon. While immobile as a cannon, you can fire blasts of energy directly from your core, devastating your foes. You become immobilized until you use an (action: Interact) action to revert back to your standard form. While in your cannon form, the only actions you can use are to (action: Strike) with an energy blast unarmed attack or to (action: Interact) to revert back to your standard form. You can remain in your cannon form for up to 1 minute or until you take the action to revert back to your standard form, whichever comes first." };
            yield return new TextBlock { Id = Guid.Parse("427a913d-791f-4447-8d32-591e0638149b"), Type = TextBlockType.Text, Text = "Energy blasts are a special ranged unarmed attack. You can only make energy blast (action: Strikes | Strike) while you’re in your cannon form. Your energy blasts deal 3d8 fire damage and 3d6 force damage, which increases to 4d8 fire damage and 3d6 force damage at level 20. You gain the item bonus to attack rolls with your energy blasts from the highest potency rune on any (item: handwraps of mighty blows) you are wearing or any weapon you are wielding, but striking and property runes have no effect on your energy blasts. Energy blasts have a range increment of 120 feet. On a critical hit with an energy blast, the target takes 10 persistent fire damage. Your energy blast doesn’t add critical specialization effects. If it matters for an effect dependent on weapon damage dice, an energy blast’s number of weapon damage dice is three, or four at level 20." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1a0a3f4-0d1c-4e97-8a4a-aeb52361dc0a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
