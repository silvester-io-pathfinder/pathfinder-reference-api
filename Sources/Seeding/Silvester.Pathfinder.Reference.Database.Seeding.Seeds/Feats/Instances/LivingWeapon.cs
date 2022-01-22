using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("24d23e1a-3680-4d35-b750-3dc0073fcd8f");

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
            yield return new TextBlock { Id = Guid.Parse("92e595de-f030-407e-8b20-2ffb1ffd1dd3"), Type = TextBlockType.Text, Text = $"You've learned to use part of your form as a weapon. When you select this feat, you gain a claws unarmed attack that deals 1d4 slashing damage and has the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} and {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} traits; a horn, jaws, or tusk unarmed attack that deals 1d6 piercing damage and has the {ToMarkdownLink<Models.Entities.Trait>("versatile S", Traits.Instances.Versatile.ID)} trait; or a tail unarmed attack that deals 1d6 bludgeoning damage and has the {ToMarkdownLink<Models.Entities.Trait>("backswing", Traits.Instances.Backswing.ID)} trait. Each of these unarmed attacks is in the brawling weapon group." };
            yield return new TextBlock { Id = Guid.Parse("f77f16b5-2aad-4ae9-94ff-b8078742ac85"), Type = TextBlockType.Text, Text = $"Your features are mutable; you can select this feat at any level, and you can retrain into or out of this feat or change the type of attack you gain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4301891-d47f-42fb-bd3d-592e2bd2ac57"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
