using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingWeaponHornsJawsOrTusk : Template
    {
        public static readonly Guid ID = Guid.Parse("cc32cfb5-9d04-4efc-a33f-9b322548878b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Weapon - Horns Jaws or Tusk",
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
            yield return new TextBlock { Id = Guid.Parse("985a84ec-d2e9-4e02-a997-a58bd8922f7c"), Type = TextBlockType.Text, Text = "You gain a horns, jaws, or tusk unarmed attack that deals 1d6 piercing damage and has the (trait: versatile S) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbecc75c-5e62-4603-ac05-22bb5858f8e7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
