using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class Familiar : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Familiar", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your patron has sent you a familiar, a mystical creature that teaches you and facilitates your spells. This familiar follows the rules here, though as it's a direct conduit between you and your patron, it's more powerful than other familiars. Your familiar gains an extra familiar ability, and gains another extra ability at 6th, 12th, and 18th levels." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your familiar is the source and repository of the spells your patron has bestowed upon you, and you must commune with your familiar to prepare your spells each day using your witch spellcasting. Your familiar starts off knowing 10 cantrips, five 1st-level spells, and one additional spell determined by your patron's theme. You choose these spells from the common spells of the tradition determined by your patron or from other spells of that tradition you gain access to." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each time you gain a level, your patron teaches your familiar two new spells of any level you can cast, chosen from common spells of your tradition or others you gain access to. Feats can also grant your familiar additional spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your familiar can learn new spells independently of your patron. It can learn any spell on your tradition's spell list by physically consuming a scroll of that spell in a process that takes 1 hour. You can use the Learn a Spell exploration activity to prepare a special written version of a spell, which your familiar can consume as if it were a scroll. You and your familiar can use the Learn a Spell activity to teach your familiar a spell from another witch's familiar. Both familiars must be present for the entirety of the activity, the spell must be on your spellcasting tradition's spell list, and you must pay the usual cost for that activity, typically in the form of an offering to the other familiar's patron. You can't prepare spells from another witch's familiar." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If your familiar dies, your patron replaces it during your next daily preparations. The new familiar might be a duplicate or reincarnation of your former familiar or a new entity altogether, but it knows the same spells your former familiar knew regardless. Your familiar's death doesn't affect any spells you have already prepared." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyFamiliar(Guid.Parse(""));
            builder.GainAnyFamiliarAbility(Guid.Parse(""));

            builder.GainAnyFamiliarAbility(Guid.Parse(""))
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 6);
                });

            builder.GainAnyFamiliarAbility(Guid.Parse(""))
               .AddPrerequisites(Guid.Parse(""), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 12);
               });

            builder.GainAnyFamiliarAbility(Guid.Parse(""))
               .AddPrerequisites(Guid.Parse(""), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 18);
               });

            builder.GainAnyFamiliarSpell(Guid.Parse(""), spellLevel: 0, amount: 10);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), spellLevel: 1, amount: 5);

            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, amount: 2, requiredLevel: 2);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, amount: 2, requiredLevel: 3);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, amount: 2, requiredLevel: 4);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, amount: 2, requiredLevel: 5);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, amount: 2, requiredLevel: 6);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, amount: 2, requiredLevel: 7);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, amount: 2, requiredLevel: 8);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, amount: 2, requiredLevel: 9);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 10, amount: 2, requiredLevel: 10);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 11, amount: 2, requiredLevel: 11);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 12, amount: 2, requiredLevel: 12);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 13, amount: 2, requiredLevel: 13);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 14, amount: 2, requiredLevel: 14);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 15, amount: 2, requiredLevel: 15);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 16, amount: 2, requiredLevel: 16);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 17, amount: 2, requiredLevel: 17);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 18, amount: 2, requiredLevel: 18);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 19, amount: 2, requiredLevel: 19);
            builder.GainAnyFamiliarSpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 20, amount: 2, requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 96
            };
        }
    }
}
