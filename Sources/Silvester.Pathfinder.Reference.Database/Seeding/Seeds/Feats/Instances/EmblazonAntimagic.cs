using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmblazonAntimagic : Template
    {
        public static readonly Guid ID = Guid.Parse("2e0ea07e-5228-48ab-bcf5-34097319e80b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Antimagic",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad295f68-3531-489c-baf6-913fbe738352"), Type = TextBlockType.Text, Text = "Your deity’s symbol protects against offensive magic. When you (action: Emblazon an Armament | Emblazon Armament), you can choose from the following effects instead of the effects listed in that feat." };
            yield return new TextBlock { Id = Guid.Parse("f5578c70-e16c-4288-a54a-584916d24799"), Type = TextBlockType.Text, Text = "These effects have the same restrictions as the base options." };
            yield return new TextBlock { Id = Guid.Parse("5fa16b40-7c75-40de-8681-523223fd03d7"), Type = TextBlockType.Enumeration, Text = " Shield: When the wielder has the shield raised, they gain the shield’s circumstance bonus to saving throws against magic, and they can use (action: Shield Block) against damage from their enemies’ spells." };
            yield return new TextBlock { Id = Guid.Parse("18b0c875-d87e-469b-b3e1-16a75db488c1"), Type = TextBlockType.Enumeration, Text = " Weapon: When the weapon’s wielder critically hits with the weapon, they can attempt to counteract a spell on their target, the counteract level is equal to half your level, rounded up. If they attempt to do so, the emblazoned symbol immediately disappears." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19152030-247a-4389-9322-178e4bed725f"), Feats.Instances.EmblazonArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fa787d6-d2bd-43ca-966e-537892bf13d8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
