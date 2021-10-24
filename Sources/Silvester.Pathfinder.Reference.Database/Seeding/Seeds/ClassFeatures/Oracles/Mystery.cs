using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class Mystery : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Mystery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An oracle wields divine power, but not from a single divine being. This power could come from a potent concept or ideal, the attention of multiple divine entities whose areas of concern all touch on that subject, or a direct and dangerous conduit to raw divine power. This is the oracle's mystery, a source of divine magic not beholden to any deity." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose the mystery that empowers your magic. Your mystery grants you special spells called revelation spells and might later grant you divine domain spells. It dictates the effects of your oracular curse, adds an additional cantrip to your repertoire, and gives you one or more trained skills. Drawing insight and power from the collective divine influences that fuel your magic also provides you with a special benefit." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Revelation Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The powers of your mystery manifest in the form of revelation spells, which are a type of focus spell. Casting a revelation spell costs 1 Focus Point and increases the effects of your oracular curse. You start with a focus pool of 2 Focus Points. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to reconcile the conflicting or unconventional nature of your divine mystery." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Focus spells don't require spell slots, and you can't cast them using spell slots (see Divine Spellcasting). Taking feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. " };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Revelation spells have the cursebound trait, unlike other focus spells. This trait means they increase the severity of your oracular curse (see below) when cast. You can't cast a cursebound spell if you don't have an oracular curse." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You learn two revelation spells at 1st level. The first is an initial revelation spell determined by your mystery. The second is an initial domain spell you select from one of the domains associated with your mystery, which you cast as a revelation spell, causing it to gain the cursebound trait." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Oracle Curse" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Drawing on multiple disparate sources of power inevitably places an incredible stress on your body, manifesting as a supernatural curse. The more revelation spells you cast, the worse the effects of your curse, but these increasingly conflicting energies can also provide you with divine benefits." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The specific effects of your curse are tied to your mystery, but all curses follow the same progression. A curse continually gives you a mild but constant reminder that you carry otherworldly power. As you cast revelation spells, your curse intensifies, first to a minor effect and then to a moderate effect." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your curse progresses to its minor stage the first time you finish casting a revelation spell after your daily preparations. Once your minor curse has manifested, it remains in effect until you rest for 8 hours and again make your daily preparations. If you cast a revelation spell while your minor curse is in effect, you progress to the moderate curse effect immediately after you finish Casting the Spell. The minor effect continues to affect you, though some moderate curse effects might alter the specifics of your minor curse. At higher levels, you can cast more revelation spells, progressing your curse to its major stage and then an extreme stage; these stronger curses are cumulative with the effects of the lower stages and can alter them. When you Refocus while under the effects of your moderate or stronger curse, you reduce your curse's severity to minor in addition to regaining a Focus Point." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Drawing upon your mystery's power while your curse is at its worst causes an irreconcilable conflict between you and the sources of your power. Immediately after casting a revelation spell while under the moderate effect of your curse, you are overwhelmed. While overwhelmed, you can't Cast or Sustain any revelation spells— you effectively lose access to those spells. You can still Refocus to reduce the effects of your curse and regain a Focus Point, but doing so doesn't allow you to cast further revelation spells. These effects last until you rest for 8 hours and make your daily preparations, at which point your curse returns to its basic state. At higher levels, you can grow to withstand your curse's major and even extreme effects, enabling you to cast more revelation spells without becoming overwhelmed." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your curse has the curse, divine, and necromancy traits. You can't mitigate, reduce, or remove the effects of your oracular curse by any means other than Refocusing and resting for 8 hours. For example, if your curse makes creatures concealed from you, you can't negate that concealed condition through a magic item or spell, such as true strike (though you would still benefit from the other effects of that item or spell). Likewise, remove curse and similar spells don't affect your curse at all." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMystery(Guid.Parse(""));
            builder.GainFocusPoolPoint(Guid.Parse(""));
            builder.GainFocusPoolPoint(Guid.Parse(""));
            builder.GainAnyTraitSpell(Guid.Parse(""), Traits.Instances.Cursebound.ID, level: 1);
            builder.GainChosenMysteryDomainSpell(Guid.Parse(""), level: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 69
            };
        }
    }
}
