using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("f94cd8b6-6828-4dfa-af06-d00aa988ac4a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Cascade",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bc194e4-ae24-4880-a592-09a2f5e33a8a"), Type = TextBlockType.Text, Text = "You divert a portion of the spell’s magical power and keep it cycling through your body and weapon using specialized forms, breathing, or footwork. While you’re in the stance, your melee (action: Strikes | Strike) deal 1 extra damage. This damage increases to 2 if you have weapon specialization and 3 if you have greater weapon specialization. Any (action: Strike) that benefits from this damage gains the arcane trait, making it magical." };
            yield return new TextBlock { Id = Guid.Parse("2ce232ef-57cf-499e-b07a-0799a2ac7914"), Type = TextBlockType.Text, Text = "If your most recent spell before entering the stance was one that can deal damage, the damage from the stance is the same type that spell could deal (or one type of your choice if the spell could deal multiple types of damage). If the spell couldn’t deal damage, this stance’s bonus damage depends on the spell’s school." };
            yield return new TextBlock { Id = Guid.Parse("dc24261d-6a01-4e7d-bc88-2808ee94cfe8"), Type = TextBlockType.Enumeration, Text = " Abjuration or Evocation: force" };
            yield return new TextBlock { Id = Guid.Parse("bc7b4237-adf7-43da-bb50-b51b868c67aa"), Type = TextBlockType.Enumeration, Text = " Conjuration or Transmutation: same type as your weapon or unarmed attack" };
            yield return new TextBlock { Id = Guid.Parse("e85ae7c1-fd70-40bf-8c85-9c97e313bba2"), Type = TextBlockType.Enumeration, Text = " Divination, Enchantment, or Illusion: mental" };
            yield return new TextBlock { Id = Guid.Parse("ba07341d-f06e-401d-a8e3-a00ad42aace9"), Type = TextBlockType.Enumeration, Text = " Necromancy: negative" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89b2feee-b37a-4f4b-8b7a-a1dc8d66c225"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
