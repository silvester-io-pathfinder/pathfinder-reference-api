using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("c35ba64d-4a41-4b6d-bb07-1e30c1ad4649");

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
            yield return new TextBlock { Id = Guid.Parse("3294c280-f3bf-4b4a-8a22-3d67df684079"), Type = TextBlockType.Text, Text = "You divert a portion of the spell's magical power and keep it cycling through your body and weapon using specialized forms, breathing, or footwork. While you're in the stance, your melee (action: Strikes | Strike) deal 1 extra damage. This damage increases to 2 if you have weapon specialization and 3 if you have greater weapon specialization. Any (action: Strike) that benefits from this damage gains the arcane trait, making it magical." };
            yield return new TextBlock { Id = Guid.Parse("74d6c431-fb42-4f72-9f74-b2d1e10426d5"), Type = TextBlockType.Text, Text = "If your most recent spell before entering the stance was one that can deal damage, the damage from the stance is the same type that spell could deal (or one type of your choice if the spell could deal multiple types of damage). If the spell couldn't deal damage, this stance's bonus damage depends on the spell's school." };
            yield return new TextBlock { Id = Guid.Parse("bad42089-91cf-40ad-9829-cc5ec91ff927"), Type = TextBlockType.Enumeration, Text = " Abjuration or Evocation: force" };
            yield return new TextBlock { Id = Guid.Parse("93343055-7e24-481c-8a06-4064cd935521"), Type = TextBlockType.Enumeration, Text = " Conjuration or Transmutation: same type as your weapon or unarmed attack" };
            yield return new TextBlock { Id = Guid.Parse("50562bc3-21cc-4cb3-94ad-30adcd0e8763"), Type = TextBlockType.Enumeration, Text = " Divination, Enchantment, or Illusion: mental" };
            yield return new TextBlock { Id = Guid.Parse("a29d3eab-7920-4ce3-ba05-5d99a06741f2"), Type = TextBlockType.Enumeration, Text = " Necromancy: negative" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19fb14e9-6f10-442b-bed3-1d64fe41c523"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
