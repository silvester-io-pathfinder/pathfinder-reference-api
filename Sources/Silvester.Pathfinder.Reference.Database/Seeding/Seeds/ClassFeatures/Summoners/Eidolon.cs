using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class Eidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Eidolon", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have a connection with a powerful and usually otherworldly entity called an eidolon, and you can use your life force as a conduit to manifest this ephemeral entity into the mortal world. Magic also flows through this conduit from your eidolon into you, so your eidolon determines the type of spells you cast and the spell list you choose from (as described in Summoner Spellcasting below). Choose a type of eidolon from the options starting on page 59 and other eidolons you have access to. When you choose your eidolon, you also determine its appearance and general form, within the parameters for that particular type of eidolon. Once you establish your eidolon's type and general appearance, these features can't be changed later, except by selecting special evolution feats that can cause your eidolon to develop new features. Your magical connection with your eidolon takes the form of a sigil on each of your bodies. As long as your eidolon is manifested, the sigil glows with light and can't be covered or disguised via any means; it will shine through clothing, appear over cloaks, and remain unaffected by obfuscating magic. This, combined with the way that the two of you clearly act in tandem, makes it readily apparent to an intelligent observer that the two of you are connected in some way, even if the person has never encountered a summoner before. You bring your eidolon into reality with the Manifest Eidolon action." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Gear and your Eidolon" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can't wear or use magic items, except for items with the eidolon trait. An eidolon can have up to two items invested. Your eidolon's link to you means it can benefit from certain magic items invested by you." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon gains item bonuses to Perception and skills from any magical items that you have invested." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon increases its item bonus to AC based on your armor's armor potency rune or bracers of armor. It also gains an item bonus to its saves from the resilient rune on your armor or from your bracers of armor. Other permanent items that grant or increase item bonuses to AC and saves might convey a similar benefit, as determined by the GM." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon's Strikes benefit from the fundamental and property runes on your handwraps of mighty blows. Alternatively, you can Invest a magic weapon (even though magic weapons can't normally be Invested) to share its fundamental and property runes with your eidolon. You share these benefits only while you're holding the weapon, and you can have no more than one weapon invested in this way at a time. In either case, the eidolon gains only the benefits that can apply to its attacks, with the same limitations noted in handwraps of mighty blows." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Lost and Altered Actions" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you or your eidolon becomes slowed, stunned, quickened, or otherwise affected by something that changes the actions you gain at the start of each turn, it affects your shared actions. However, if you are both subject to such an effect, apply only the more severe one. For instance, if you or your eidolon were slowed 1, you would start your turn with one fewer action, but if you were both slowed 1, you would still lose only one action, rather than adding the two slowed effects together. However, if you were slowed 1 and your eidolon slowed 2, you'd have two fewer actions, because that's the more severe effect. If only one of you becomes restricted in how you can spend your actions, that restriction doesn't automatically extend to the other; for example, if your eidolon became immobilized or petrified, it wouldn't be able to move, but you could still use your actions to move. The GM resolves any situation that's unclear." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You, as the player, control both your summoner and your eidolon, and the two are generally considered to cooperate unless you decide for them not to. While a summoner's link with an eidolon is a partnership, ultimately the eidolon is linked to you, not the other way around. If there's ever a conflict of who should act, you win out over your eidolon. This means that if the eidolon comes under an effect that would take its actions out of your control, such as the confused or controlled condition, you can use all of your shared actions so your eidolon doesn't have any actions remaining to cause trouble (as long as you are able to act). However, if you came under such an effect, you would simply use all of your shared actions, preventing your eidolon from acting." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyEidolon(Guid.Parse(""));
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ManifestEidolon.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ActTogether.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ShareSenses.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 52
            };
        }
    }
}
