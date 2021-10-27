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
    public class LinkSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Link Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your connection to your eidolon allows you to cast link spells, special spells that have been forged through your shared connection with your eidolon. Link spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to specifically connect with your eidolon, such as by having a heart-to-heart conversation, playing together, or meditating in unison on the nature of your bond." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up, much like cantrips. Focus spells don't require spell slots, and you can't cast them using spell slots. Taking feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You learn the evolution surge link spell, which allows you to grant your eidolon one of several useful benefits." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Link Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Link cantrips are special link spells that don't cost Focus Points, so you can cast them as often as you like. Link cantrips are in addition to the cantrips you choose from your tradition's spell list. Generally, only feats can give you more link cantrips. Unlike other cantrips, you can't swap out link cantrips gained from summoner feats at a later level, unless you swap out the specific feat via retraining." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You learn the boost eidolon link cantrip, which briefly improves your eidolon's capabilities, allowing it to attack with greater power." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFocusPoolPoint(Guid.Parse(""));
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EvolutionSurge.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BoostEidolon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 55
            };
        }
    }
}
