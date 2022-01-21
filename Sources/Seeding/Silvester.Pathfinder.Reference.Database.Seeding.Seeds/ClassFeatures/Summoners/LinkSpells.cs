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
        public static readonly Guid ID = Guid.Parse("840c74b4-293c-4a08-8fd5-38aecf5658c2");

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
            yield return new TextBlock { Id = Guid.Parse("28066be5-48b7-4ddb-ba93-cbcffa9c51f3"), Type = TextBlockType.Text, Text = "Your connection to your eidolon allows you to cast link spells, special spells that have been forged through your shared connection with your eidolon. Link spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to specifically connect with your eidolon, such as by having a heart-to-heart conversation, playing together, or meditating in unison on the nature of your bond." };
            yield return new TextBlock { Id = Guid.Parse("52a2338c-75b0-44cd-9e4f-6a01a8c9ea28"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up, much like cantrips. Focus spells don't require spell slots, and you can't cast them using spell slots. Taking feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points." };
            yield return new TextBlock { Id = Guid.Parse("4d2dfd48-d9bf-4981-a7b7-0cb880420f9b"), Type = TextBlockType.Text, Text = "You learn the evolution surge link spell, which allows you to grant your eidolon one of several useful benefits." };
            yield return new TextBlock { Id = Guid.Parse("6d8433cb-3c26-4f81-bab4-fb953f1cb357"), Type = TextBlockType.Heading, Text = "Link Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("b8c7a105-b8a3-41d9-a73c-41519882e967"), Type = TextBlockType.Text, Text = "Link cantrips are special link spells that don't cost Focus Points, so you can cast them as often as you like. Link cantrips are in addition to the cantrips you choose from your tradition's spell list. Generally, only feats can give you more link cantrips. Unlike other cantrips, you can't swap out link cantrips gained from summoner feats at a later level, unless you swap out the specific feat via retraining." };
            yield return new TextBlock { Id = Guid.Parse("2bec73c9-1dca-46b8-b379-fd9e1b38a6dd"), Type = TextBlockType.Text, Text = "You learn the boost eidolon link cantrip, which briefly improves your eidolon's capabilities, allowing it to attack with greater power." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFocusPoolPoint(Guid.Parse("77bf4bf4-6412-45e8-a8a6-77432b673f4f"));
            builder.GainSpecificSpell(Guid.Parse("bfbfa327-87b9-48b6-a33b-7d7b9811a149"), Spells.Instances.EvolutionSurge.ID);
            builder.GainSpecificSpell(Guid.Parse("4062001e-efaf-4cf3-9ce2-c657c5fd4123"), Spells.Instances.BoostEidolon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08872ff6-cfde-404d-8b78-437cf8c211ec"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 55
            };
        }
    }
}
