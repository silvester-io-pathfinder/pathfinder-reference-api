using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class SpellstrikeSpecifics : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though the base Spellstrike rules cover most spells, various modifications apply to more complicated spells when loaded into your fist, blade, or other attack." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "One Target: The spell targets only the target of your Strike, even if it normally allows more targets. Some feats let you affect more creatures." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Reach: The coupled spell affects the target using the reach of the weapon or unarmed attack you make your Spellstrike with. For instance, shocking grasp would affect a creature beyond the reach of your hand if you used a weapon with reach, and ray of frost would affect only a creature in your weapon's reach, even though the spell's range is longer." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ancillary Effects: Your spell still has any non-targeted effects that might affect creatures other than the target, as well as any ongoing effects starting from the moment you hit with the Strike. For example, acid splash would still deal its splash damage to creatures other than the target and tanglefoot's circumstance penalty would last for its normal duration. The spell takes effect after the Strike deals damage; if the Strike has other special effects, the GM determines whether they happen before or after the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Multiple Defenses: Any additional rolls after the initial spell attack still happen normally, such as the Fortitude save attempted by the target of a disintegrate spell. Similarly, a spell that allows you to attack with it again on subsequent rounds would only combine a Strike with its initial attack roll, not with any later ones." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Invalid or Immune Target: If the target you hit wouldn't be a valid target for the spell, the spell is still expended but doesn't affect the target. If the target is immune to your attack but not the spell, it can still be affected by the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Variable Actions: Some spells have different effects based on the number of actions you spend to cast them. You choose whether to use the effects of the 1- or 2-action version of the spell when you use Spellstrike. A spell has to take exactly 1 or 2 actions; you can't use Spellstrike with a spell that takes a free action, reaction, or 3 or more actions." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Metamagic: You typically can't use metamagic with Spellstrike because metamagic requires the next action you take to be Cast a Spell, and Spellstrike is a combined activity that doesn't qualify." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 37
            };
        }
    }
}
