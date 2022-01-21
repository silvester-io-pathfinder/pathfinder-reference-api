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
        public static readonly Guid ID = Guid.Parse("e22050be-e318-411d-8a84-e23f28455c59");

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
            yield return new TextBlock { Id = Guid.Parse("dc6f2139-92b8-4f1c-9f13-99b90929781d"), Type = TextBlockType.Text, Text = "An oracle wields divine power, but not from a single divine being. This power could come from a potent concept or ideal, the attention of multiple divine entities whose areas of concern all touch on that subject, or a direct and dangerous conduit to raw divine power. This is the oracle's mystery, a source of divine magic not beholden to any deity." };
            yield return new TextBlock { Id = Guid.Parse("1a7446d8-0459-42a6-980d-aecec0057215"), Type = TextBlockType.Text, Text = "Choose the mystery that empowers your magic. Your mystery grants you special spells called revelation spells and might later grant you divine domain spells. It dictates the effects of your oracular curse, adds an additional cantrip to your repertoire, and gives you one or more trained skills. Drawing insight and power from the collective divine influences that fuel your magic also provides you with a special benefit." };
            yield return new TextBlock { Id = Guid.Parse("9a9953f1-d214-45a3-a142-f410fb5a827c"), Type = TextBlockType.Heading, Text = "Revelation Spells" };
            yield return new TextBlock { Id = Guid.Parse("890af086-7b37-44f3-ae66-77bf2813e13c"), Type = TextBlockType.Text, Text = "The powers of your mystery manifest in the form of revelation spells, which are a type of focus spell. Casting a revelation spell costs 1 Focus Point and increases the effects of your oracular curse. You start with a focus pool of 2 Focus Points. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to reconcile the conflicting or unconventional nature of your divine mystery." };
            yield return new TextBlock { Id = Guid.Parse("69abf53e-cb65-447f-a330-9642dceec970"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Focus spells don't require spell slots, and you can't cast them using spell slots (see Divine Spellcasting). Taking feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. " };
            yield return new TextBlock { Id = Guid.Parse("64a2250e-2d4c-4ec5-b2f8-86416496353f"), Type = TextBlockType.Text, Text = "Revelation spells have the cursebound trait, unlike other focus spells. This trait means they increase the severity of your oracular curse (see below) when cast. You can't cast a cursebound spell if you don't have an oracular curse." };
            yield return new TextBlock { Id = Guid.Parse("db24f02e-adfa-4ea9-a6c1-955ee88e493d"), Type = TextBlockType.Text, Text = "You learn two revelation spells at 1st level. The first is an initial revelation spell determined by your mystery. The second is an initial domain spell you select from one of the domains associated with your mystery, which you cast as a revelation spell, causing it to gain the cursebound trait." };
            yield return new TextBlock { Id = Guid.Parse("c7faa2b6-a473-48bf-899f-ea816db57de4"), Type = TextBlockType.Heading, Text = "Oracle Curse" };
            yield return new TextBlock { Id = Guid.Parse("bee56500-1ec5-471e-9ab7-1c1be74d0f10"), Type = TextBlockType.Text, Text = "Drawing on multiple disparate sources of power inevitably places an incredible stress on your body, manifesting as a supernatural curse. The more revelation spells you cast, the worse the effects of your curse, but these increasingly conflicting energies can also provide you with divine benefits." };
            yield return new TextBlock { Id = Guid.Parse("5f4be9d6-8c6a-4e66-9073-e8d572d64fac"), Type = TextBlockType.Text, Text = "The specific effects of your curse are tied to your mystery, but all curses follow the same progression. A curse continually gives you a mild but constant reminder that you carry otherworldly power. As you cast revelation spells, your curse intensifies, first to a minor effect and then to a moderate effect." };
            yield return new TextBlock { Id = Guid.Parse("39057672-bf09-4045-94f9-78c8577e19c4"), Type = TextBlockType.Text, Text = "Your curse progresses to its minor stage the first time you finish casting a revelation spell after your daily preparations. Once your minor curse has manifested, it remains in effect until you rest for 8 hours and again make your daily preparations. If you cast a revelation spell while your minor curse is in effect, you progress to the moderate curse effect immediately after you finish Casting the Spell. The minor effect continues to affect you, though some moderate curse effects might alter the specifics of your minor curse. At higher levels, you can cast more revelation spells, progressing your curse to its major stage and then an extreme stage; these stronger curses are cumulative with the effects of the lower stages and can alter them. When you Refocus while under the effects of your moderate or stronger curse, you reduce your curse's severity to minor in addition to regaining a Focus Point." };
            yield return new TextBlock { Id = Guid.Parse("f77d00d4-d074-47d7-835e-03bff08f126a"), Type = TextBlockType.Text, Text = "Drawing upon your mystery's power while your curse is at its worst causes an irreconcilable conflict between you and the sources of your power. Immediately after casting a revelation spell while under the moderate effect of your curse, you are overwhelmed. While overwhelmed, you can't Cast or Sustain any revelation spells� you effectively lose access to those spells. You can still Refocus to reduce the effects of your curse and regain a Focus Point, but doing so doesn't allow you to cast further revelation spells. These effects last until you rest for 8 hours and make your daily preparations, at which point your curse returns to its basic state. At higher levels, you can grow to withstand your curse's major and even extreme effects, enabling you to cast more revelation spells without becoming overwhelmed." };
            yield return new TextBlock { Id = Guid.Parse("f2f792ed-9513-4ab1-a285-2c8a7d94135f"), Type = TextBlockType.Text, Text = "Your curse has the curse, divine, and necromancy traits. You can't mitigate, reduce, or remove the effects of your oracular curse by any means other than Refocusing and resting for 8 hours. For example, if your curse makes creatures concealed from you, you can't negate that concealed condition through a magic item or spell, such as true strike (though you would still benefit from the other effects of that item or spell). Likewise, remove curse and similar spells don't affect your curse at all." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMystery(Guid.Parse("0e9d8445-a5d2-40fb-8a1b-14030aeeb81c"));
            builder.GainFocusPoolPoint(Guid.Parse("18234b3f-fef7-417b-b681-7a7d5be3f35d"));
            builder.GainFocusPoolPoint(Guid.Parse("2ae4a6c2-8efc-45bb-adbe-7dbbde7f8aa1"));
            builder.GainAnyTraitSpell(Guid.Parse("3b1085a2-010b-4c34-a502-d706542b711b"), Traits.Instances.Cursebound.ID, level: 1);
            builder.GainChosenMysteryDomainSpell(Guid.Parse("739c7073-10ba-43a1-bdbf-8fa1117308f8"), level: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1c7043d-30bb-4cc6-960a-8f7daf9d039e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 69
            };
        }
    }
}
