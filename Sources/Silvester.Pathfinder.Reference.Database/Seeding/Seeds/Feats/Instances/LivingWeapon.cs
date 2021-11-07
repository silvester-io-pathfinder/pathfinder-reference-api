using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("58c70a4a-5037-423b-b1d5-e8de1f2627ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Weapon",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. Each time you do, select a new attack from the options above.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdfd25ed-346b-403f-a753-5d85c2a108c7"), Type = TextBlockType.Text, Text = "You’ve learned to use part of your form as a weapon. When you select this feat, you gain a claws unarmed attack that deals 1d4 slashing damage and has the (trait: agile) and (trait: finesse) traits; a horn, jaws, or tusk unarmed attack that deals 1d6 piercing damage and has the (trait: versatile S) trait; or a tail unarmed attack that deals 1d6 bludgeoning damage and has the (trait: backswing) trait. Each of these unarmed attacks is in the brawling weapon group." };
            yield return new TextBlock { Id = Guid.Parse("91127d76-d477-4247-ac7b-5f347da3d1b6"), Type = TextBlockType.Text, Text = "Your features are mutable; you can select this feat at any level, and you can retrain into or out of this feat or change the type of attack you gain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91658783-9f5a-4117-b4cc-c4a8876e2190"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
