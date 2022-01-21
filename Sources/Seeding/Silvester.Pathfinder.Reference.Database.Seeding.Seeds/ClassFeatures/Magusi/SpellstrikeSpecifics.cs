using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class SpellstrikeSpecifics : Template
    {
        public static readonly Guid ID = Guid.Parse("aece8184-91d0-4a33-b148-bffbc7a724b1");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Spellstrike Specifics", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("66168700-ad2c-49e0-9605-77dc8f94944a"), Type = TextBlockType.Text, Text = "Though the base Spellstrike rules cover most spells, various modifications apply to more complicated spells when loaded into your fist, blade, or other attack." };
            yield return new TextBlock { Id = Guid.Parse("455be8b7-b093-4856-89d4-978045e527b4"), Type = TextBlockType.Enumeration, Text = "One Target: The spell targets only the target of your Strike, even if it normally allows more targets. Some feats let you affect more creatures." };
            yield return new TextBlock { Id = Guid.Parse("16bc5704-27f3-4766-b827-491df5f633c9"), Type = TextBlockType.Enumeration, Text = "Reach: The coupled spell affects the target using the reach of the weapon or unarmed attack you make your Spellstrike with. For instance, shocking grasp would affect a creature beyond the reach of your hand if you used a weapon with reach, and ray of frost would affect only a creature in your weapon's reach, even though the spell's range is longer." };
            yield return new TextBlock { Id = Guid.Parse("f9fc9657-e0f8-4695-8d61-1a1d061d70a8"), Type = TextBlockType.Enumeration, Text = "Ancillary Effects: Your spell still has any non-targeted effects that might affect creatures other than the target, as well as any ongoing effects starting from the moment you hit with the Strike. For example, acid splash would still deal its splash damage to creatures other than the target and tanglefoot's circumstance penalty would last for its normal duration. The spell takes effect after the Strike deals damage; if the Strike has other special effects, the GM determines whether they happen before or after the spell." };
            yield return new TextBlock { Id = Guid.Parse("76ff4e68-ffe0-45a5-a4fe-abc1498ddfab"), Type = TextBlockType.Enumeration, Text = "Multiple Defenses: Any additional rolls after the initial spell attack still happen normally, such as the Fortitude save attempted by the target of a disintegrate spell. Similarly, a spell that allows you to attack with it again on subsequent rounds would only combine a Strike with its initial attack roll, not with any later ones." };
            yield return new TextBlock { Id = Guid.Parse("65d2a32f-9f08-4100-af02-aed92adcc34b"), Type = TextBlockType.Enumeration, Text = "Invalid or Immune Target: If the target you hit wouldn't be a valid target for the spell, the spell is still expended but doesn't affect the target. If the target is immune to your attack but not the spell, it can still be affected by the spell." };
            yield return new TextBlock { Id = Guid.Parse("9aaa57a2-82e0-40de-919f-de180f08cbcd"), Type = TextBlockType.Enumeration, Text = "Variable Actions: Some spells have different effects based on the number of actions you spend to cast them. You choose whether to use the effects of the 1- or 2-action version of the spell when you use Spellstrike. A spell has to take exactly 1 or 2 actions; you can't use Spellstrike with a spell that takes a free action, reaction, or 3 or more actions." };
            yield return new TextBlock { Id = Guid.Parse("3838b325-9625-454a-91cb-439016deb158"), Type = TextBlockType.Enumeration, Text = "Metamagic: You typically can't use metamagic with Spellstrike because metamagic requires the next action you take to be Cast a Spell, and Spellstrike is a combined activity that doesn't qualify." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edeb4a71-e761-46e1-a2b6-95f1822a5da8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 37
            };
        }
    }
}